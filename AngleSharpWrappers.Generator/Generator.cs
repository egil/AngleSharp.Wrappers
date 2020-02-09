using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using AngleSharp.Common;
using AngleSharp.Dom;
using AngleSharp.Svg.Dom;
using AngleSharp.Text;

namespace AngleSharpWrappers.Generator
{
    internal class Generator
    {
        private const char Space = ' ';
        private static readonly Type INodeType = typeof(INode);

        private Dictionary<string, Type> WrappedTypes { get; }

        public Generator()
        {
            var enumerableType = typeof(System.Collections.IEnumerable);
            var iattrType = typeof(IAttr);
            var allInterfaces = INodeType.Assembly.GetTypes().Where(x => x.IsInterface).ToList();

            WrappedTypes = allInterfaces.Where(x => INodeType.IsAssignableFrom(x) || enumerableType.IsAssignableFrom(x)).ToDictionary(x => GetTypeKey(x), x => x);

            WrappedTypes.Add(iattrType.FullName!, iattrType);

            foreach (var item in WrappedTypes.Values)
            {
                GenerateWrapper(item);
            }

            GenerateFactoryMethods(WrappedTypes.Values);
        }

        private void GenerateWrapper(Type type)
        {
            var usings = new List<Type>();
            var output = new StringBuilder();

            usings.AddRange(CreateClassStart(type, output));
            usings.AddRange(CreateEvents(type, output));
            usings.AddRange(CreatePropertiesAndIndexers(type, output));
            usings.AddRange(CreateMethods(type, output));
            usings.AddRange(CreateEnumerableMethods(type, output));
            CreateClassEnd(output);
            AddUsingStatements(usings, output);

            WriteClassToFile(type, output);
        }

        private static IEnumerable<Type> CreateClassStart(Type type, StringBuilder output)
        {
            var name = GetInterfaceTypeName(type);
            var wrapperName = GetWrapperClassName(type);
            var genericArgs = GetGenericArgsList(type);
            var genericConstraints = GetGenericTypeConstraints(type);

            output.AppendLine();
            output.AppendLine();
            output.AppendLine("namespace AngleSharpWrappers");
            output.AppendLine("{");
            output.AppendLine($"{Space,4}#nullable disable");

            output.AppendLine($"{Space,4}/// <summary>");
            output.AppendLine($"{Space,4}/// Represents a wrapper class around <see cref=\"{name}{genericArgs.Replace('<', '{').Replace('>', '}')}\"/> type.");
            output.AppendLine($"{Space,4}/// </summary>");
            output.AppendLine($"{Space,4}public partial class {wrapperName}{genericArgs} : Wrapper<{name}{genericArgs}>, {name}{genericArgs}, IWrapper");
            if (!string.IsNullOrEmpty(genericConstraints))
                output.AppendLine($"{Space,8}{genericConstraints}");
            output.AppendLine($"{Space,4}{{");

            output.AppendLine($"{Space,8}/// <summary>");
            output.AppendLine($"{Space,8}/// Creates an instance of the <see cref=\"{wrapperName}{genericArgs.Replace('<', '{').Replace('>', '}')}\"/> type;");
            output.AppendLine($"{Space,8}/// </summary>");
            if (INodeType.IsAssignableFrom(type))
                output.AppendLine($"{Space,8}internal {wrapperName}(WrapperFactory factory, {name}{genericArgs} initialObject, Func<object> getObject) : base(factory, initialObject, getObject) {{ }}");
            else
                output.AppendLine($"{Space,8}internal {wrapperName}(WrapperFactory factory, {name}{genericArgs} initialObject, Func<object> getObject) : base(factory, initialObject, getObject) {{ }}");

            yield return type;
            foreach (var t in type.GetGenericArguments()) yield return t;
            foreach (var t in type.GetGenericArguments().SelectMany(x => x.GetGenericParameterConstraints())) yield return t;
        }

        private static void CreateClassEnd(StringBuilder output)
        {
            output.AppendLine($"{Space,4}}}");
            output.AppendLine("}");
        }

        private static IEnumerable<Type> CreateEvents(Type type, StringBuilder output)
        {
            var events = GetEvents(type).GroupBy(x => x.Name).OrderBy(x => x.Key);
            foreach (var evtGroup in events)
            {
                var evt = evtGroup.First();
                output.AppendLine();
                var evtType = GetReturnType(evt.EventHandlerType);

                var castType = evtGroup.Count() > 1
                    ? $"(({evt.DeclaringType!.Name})WrappedObject)"
                    : "WrappedObject";

                output.AppendLine($"{Space,8}/// <inheritdoc/>");
                output.AppendLine($"{Space,8}public event {evtType} {evt.Name} {{ add => {castType}.{evt.Name} += value; remove => {castType}.{evt.Name} -= value; }}");

                if (evt.DeclaringType is { })
                    yield return evt.DeclaringType;
                if (evt.EventHandlerType is { })
                    yield return evt.EventHandlerType;
            }
        }

        private IEnumerable<Type> CreatePropertiesAndIndexers(Type type, StringBuilder output)
        {
            var properties = GetProperties(type);
            var indexerUsings = CreateIndexerProperties();
            var propUsings = CreateProperties();
            return indexerUsings.Concat(propUsings).ToList();

            IEnumerable<Type> CreateIndexerProperties()
            {
                foreach (var prop in properties.Where(x => x.GetIndexParameters().Length > 0).OrderBy(x => x.Name))
                {
                    output.AppendLine();
                    var indexParam = prop.GetIndexParameters().Single();
                    var genericReturnType = GetGenericArgsList(prop.PropertyType);
                    var paramType = prop.PropertyType.IsGenericParameter
                        ? prop.PropertyType.GetGenericParameterConstraints().Single()
                        : prop.PropertyType;

                    var getter = " ";
                    var setter = prop.CanWrite
                        ? $" set => WrappedObject[{indexParam.Name}] = value;"
                        : " ";

                    if (IsNonWrappedType(paramType) && prop.CanRead)
                    {
                        getter = $" get => WrappedObject[{indexParam.Name}];";
                    }
                    else if (prop.CanRead)
                    {
                        getter = $" get => GetOrWrap(() => WrappedObject[{indexParam.Name}]);";
                    }
                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}public {GetReturnType(prop.PropertyType)} this[{GetReturnType(indexParam.ParameterType)} {indexParam.Name}] {{{getter}{setter}}}");

                    yield return indexParam.ParameterType;
                }
            }

            IEnumerable<Type> CreateProperties()
            {
                foreach (var prop in properties.Where(x => x.GetIndexParameters().Length == 0).OrderBy(x => x.Name))
                {
                    output.AppendLine();
                    var propType = GetReturnType(prop.PropertyType);
                    var genericReturnType = prop.PropertyType.IsGenericType
                        ? $"<{string.Join(",", prop.PropertyType.GetGenericArguments().Select(x => x.Name))}>"
                        : string.Empty;

                    var paramType = prop.PropertyType.IsGenericType
                        ? prop.PropertyType.GetGenericArguments().Single()
                        : prop.PropertyType;

                    var getter = " ";
                    var setter = prop.CanWrite
                        ? $" set => WrappedObject.{prop.Name} = value;"
                        : " ";

                    if (IsNonWrappedType(paramType) && prop.CanRead)
                    {
                        getter = $" get => WrappedObject.{prop.Name};";
                    }
                    else if (prop.CanRead)
                    {
                        getter = $" get => GetOrWrap(() => WrappedObject.{prop.Name});";
                    }

                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}public {propType} {prop.Name} {{{getter}{setter}}}");

                    yield return prop.PropertyType;
                    foreach (var t in prop.PropertyType.GetGenericArguments()) yield return t;
                }
            }
        }

        private IEnumerable<Type> CreateMethods(Type type, StringBuilder output)
        {
            var methods = GetMethods(type);

            foreach (var method in methods.Where(x => !x.IsSpecialName && x.Name != "GetEnumerator").OrderBy(x => x.Name))
            {
                var parameters = method.GetParameters();
                var paramStr = string.Join(", ", parameters.Select(x => $"{GetParamterType(x.ParameterType)} {x.Name}"));
                var argsStr = string.Join(", ", parameters.Select(x => x.Name));
                var returnType = GetReturnType(method.ReturnType);

                output.AppendLine();

                if (IsNonWrappedType(method.ReturnType))
                {
                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}public {returnType} {method.Name}({paramStr})");
                    output.AppendLine($"{Space,12}=> WrappedObject.{method.Name}({argsStr});");
                }
                else
                {
                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}public {returnType} {method.Name}({paramStr})");
                    output.AppendLine($"{Space,12}=> GetOrWrap(() => WrappedObject.{method.Name}({argsStr}));");
                }

                yield return method.ReturnType;
                foreach (var t in method.ReturnType.GetGenericArguments()) yield return t;
                foreach (var t in parameters.Select(x => x.ParameterType)) yield return t;
                foreach (var t in parameters.SelectMany(x => x.ParameterType.GetGenericArguments())) yield return t;
            }
        }

        private IEnumerable<Type> CreateEnumerableMethods(Type type, StringBuilder output)
        {
            var enumerableType = type.GetInterfaces().FirstOrDefault(x => x.Name.StartsWith("IEnumerable", StringComparison.Ordinal));
            if (enumerableType is { })
            {
                output.AppendLine();
                var enumerableGeneric = enumerableType.GetGenericArguments().Single();
                var enumerableTargetType = enumerableGeneric;

                if (enumerableTargetType.IsGenericParameter)
                {
                    enumerableTargetType = enumerableTargetType.GetGenericParameterConstraints().Single();
                }

                if (IsNonWrappedType(enumerableTargetType))
                {
                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}public IEnumerator<{GetParamterType(enumerableGeneric)}> GetEnumerator() => WrappedObject.GetEnumerator();");
                    output.AppendLine();
                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}IEnumerator IEnumerable.GetEnumerator() => WrappedObject.GetEnumerator();");
                }
                else
                {
                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}public IEnumerator<{GetParamterType(enumerableGeneric)}> GetEnumerator()");
                    output.AppendLine($"{Space,8}{{");
                    output.AppendLine($"{Space,12}for (int i = 0; i < Length; i++)");
                    output.AppendLine($"{Space,12}{{");
                    output.AppendLine($"{Space,16}yield return this[i];");
                    output.AppendLine($"{Space,12}}}");
                    output.AppendLine($"{Space,8}}}");
                    output.AppendLine();
                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();");
                }
                yield return typeof(System.Collections.IEnumerable);
                yield return typeof(IEnumerable<>);
                yield return enumerableGeneric;
            }
        }
        
        private void GenerateFactoryMethods(IEnumerable<Type> wrappedTypes)
        {
            var output = new StringBuilder();
            var usings = new List<Type>(wrappedTypes) { typeof(Func<>), typeof(Dictionary<,>) };
            var getOrWrapTypes = wrappedTypes.Where(x => x.FullName is { }).OrderBy(x => x.Name).ToDictionary(x => x.FullName, x => x);
            var noneInodes = getOrWrapTypes.Values.Where(x => !x.IsGenericType).Where(x => !INodeType.IsAssignableFrom(x));
            var inodes = getOrWrapTypes.Values.Where(x => !x.IsGenericType).Where(x => INodeType.IsAssignableFrom(x)).ToDictionary(x => x.FullName!, x => x);

            var orderedINodes = CreateOrderedNodes(inodes);

            output.AppendLine();
            output.AppendLine("namespace AngleSharpWrappers");
            output.AppendLine("{");
            output.AppendLine($"{Space,4}#nullable enable");
            output.AppendLine($"{Space,4}public partial class WrapperFactory");
            output.AppendLine($"{Space,4}{{");

            output.AppendLine($"{Space,8}/// <summary>");
            output.AppendLine($"{Space,8}/// Wraps an AngleSharp object in the wrapper specific to it.");
            output.AppendLine($"{Space,8}/// </summary>");
            output.AppendLine($"{Space,8}/// <typeparam name=\"T\">The AngleSharp type.</typeparam>");
            output.AppendLine($"{Space,8}/// <param name=\"initialObject\">The initial object to wrap.</param>");
            output.AppendLine($"{Space,8}/// <param name=\"objectQuery\">A query method for refreshing the wrapped object.</param>");
            output.AppendLine($"{Space,8}/// <returns>The <see cref=\"IWrapper\"/> wrapped object.</returns>");
            output.AppendLine($"{Space,8}internal IWrapper GetOrCreate<T>(T initialObject, Func<T?> objectQuery) where T : class");
            output.AppendLine($"{Space,8}{{");
            output.AppendLine($"{Space,12}return initialObject switch");
            output.AppendLine($"{Space,12}{{");
            foreach (var type in noneInodes)
            {
                var wrapperName = $"{type.Name[1..]}Wrapper";
                var typeVarName = $"{char.ToLowerInvariant(type.Name[1])}{type.Name[2..]}";
                output.AppendLine($"{Space,16}{type.Name} _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new {wrapperName}(this, ({type.Name})io, oq), objectQuery),");
                usings.Add(type);
            }
            output.AppendLine($"{Space,16}INode node => GetOrCreateNode(node, objectQuery),");
            output.AppendLine($"{Space,16}_ => throw new InvalidOperationException($\"Unknown type. Cannot create wrapper for {{initialObject.GetType()}}\"),");
            output.AppendLine($"{Space,12}}};");
            output.AppendLine($"{Space,8}}}");
            output.AppendLine();

            output.AppendLine($"{Space,8}/// <summary>");
            output.AppendLine($"{Space,8}/// Wraps an <see cref=\"INode\"/> in the wrapper specific to it.");
            output.AppendLine($"{Space,8}/// </summary>");
            output.AppendLine($"{Space,8}/// <typeparam name=\"T\">The node type.</typeparam>");
            output.AppendLine($"{Space,8}/// <param name=\"initialObject\">The initial node object to wrap</param>");
            output.AppendLine($"{Space,8}/// <param name=\"objectQuery\">A query method for refreshing the wrapped node object.</param>");
            output.AppendLine($"{Space,8}/// <returns>The <see cref=\"IWrapper\"/> wrapped node.</returns>");
            output.AppendLine($"{Space,8}internal IWrapper GetOrCreateNode(INode initialObject, Func<object?> objectQuery)");
            output.AppendLine($"{Space,8}{{");
            output.AppendLine($"{Space,12}return initialObject switch");
            output.AppendLine($"{Space,12}{{");

            while (orderedINodes.Count > 0)
            {
                var typeName = orderedINodes.OrderBy(x => x.Value.Count).First().Key;
                var type = inodes[typeName];
                orderedINodes.Remove(typeName);

                var wrapperName = $"{type.Name[1..]}Wrapper";
                var typeVarName = $"{char.ToLowerInvariant(type.Name[1])}{type.Name[2..]}";
                output.AppendLine($"{Space,16}{type.Name} _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new {wrapperName}(this, ({type.Name})io, oq), objectQuery),");
                usings.Add(type);
            }

            output.AppendLine($"{Space,16}_ => throw new InvalidOperationException($\"Unknown type. Cannot create wrapper for {{initialObject.GetType()}}\"),");
            output.AppendLine($"{Space,12}}};");
            output.AppendLine($"{Space,8}}}");
           
            output.AppendLine($"{Space,4}}}");
            output.AppendLine("}");

            AddUsingStatements(usings, output);

            Console.WriteLine($"Writing WrapperFactory.g.cs");

            File.WriteAllText($"WrapperFactory.g.cs", output.ToString());
        }

        #region Helpers

        private static Dictionary<string, List<Type>> CreateOrderedNodes(Dictionary<string, Type> inodes)
        {
            var orderedINodes = inodes.ToDictionary(x => x.Key, x => new List<Type>());
            foreach (var typeName in orderedINodes.Keys)
            {
                var type = inodes[typeName];
                foreach (var parentType in type.GetInterfaces())
                {
                    if (orderedINodes.ContainsKey(parentType.FullName!) && typeName != parentType.FullName)
                        orderedINodes[parentType.FullName!].Add(parentType);
                }
            }
            return orderedINodes;
        }

        private static string GenerateUsings(List<Type> usings)
        {
            var uniqueUsings = usings.Select(x => x.Namespace).Distinct();
            var systemUsings = uniqueUsings.Where(x => x!.StartsWith("System", StringComparison.Ordinal)).OrderBy(x => x);
            var others = uniqueUsings.Where(x => !x!.StartsWith("System", StringComparison.Ordinal)).OrderBy(x => x);
            return string.Join(Environment.NewLine, systemUsings.Concat(others).Select(x => $"using {x};"));
        }

        private bool IsWrappedType(Type type)
        {
            return !IsNonWrappedType(type);
        }

        private bool IsNonWrappedType(Type type)
        {
            return type.IsPrimitive || type == VoidType || type.IsGenericParameter || !WrappedTypes.ContainsKey(GetTypeKey(type));
        }

        private static string GetTypeKey(Type type) => $"{type.Namespace}.{type.Name}";

        /// <summary>
        /// Gets all methods (and property methods) of an interface, and any interfaces it implements.
        /// </summary>
        public static HashSet<MethodInfo> GetMethods(Type type)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));

            var result = new HashSet<MethodInfo>();

            foreach (var mi in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy))
            {
                result.Add(mi);
            }

            foreach (var baseType in type.GetInterfaces())
            {
                result.AddRange(GetMethods(baseType));
            }

            return result;
        }

        public static List<EventInfo> GetEvents(Type type)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));

            var result = new List<EventInfo>();

            foreach (var mi in type.GetEvents(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy))
            {
                result.Add(mi);
            }

            foreach (var baseType in type.GetInterfaces())
            {
                result.AddRange(GetEvents(baseType));
            }

            return result;
        }

        public static HashSet<PropertyInfo> GetProperties(Type type)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));

            var result = new HashSet<PropertyInfo>();

            foreach (var mi in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy))
            {
                result.Add(mi);
            }

            foreach (var baseType in type.GetInterfaces())
            {
                result.AddRange(GetProperties(baseType));
            }

            return result;
        }

        public static PropertyInfo[] GetPublicProperties(Type type)
        {
            if (type.IsInterface)
            {
                var propertyInfos = new HashSet<PropertyInfo>();

                var considered = new List<Type>();
                var queue = new Queue<Type>();
                considered.Add(type);
                queue.Enqueue(type);
                while (queue.Count > 0)
                {
                    var subType = queue.Dequeue();
                    foreach (var subInterface in subType.GetInterfaces())
                    {
                        if (considered.Contains(subInterface)) continue;

                        considered.Add(subInterface);
                        queue.Enqueue(subInterface);
                    }

                    var typeProperties = subType.GetProperties(
                        BindingFlags.FlattenHierarchy
                        | BindingFlags.Public
                        | BindingFlags.Instance);

                    var newPropertyInfos = typeProperties
                        .Where(x => !propertyInfos.Contains(x));

                    propertyInfos.AddRange(newPropertyInfos);
                }

                return propertyInfos.ToArray();
            }

            return type.GetProperties(BindingFlags.FlattenHierarchy
                | BindingFlags.Public | BindingFlags.Instance);
        }

        public static readonly Type VoidType = typeof(void);

        public static string GetReturnType(Type? returnType)
        {
            if (returnType is null) throw new ArgumentNullException(nameof(returnType));
            if (returnType == VoidType) return "void";
            return GetParamterType(returnType);
        }

        private static string GetParamterType(Type parameterType)
        {
            var name = GetInterfaceTypeName(parameterType);
            var genericArgs = GetGenericArgsList(parameterType);
            return $"{name}{genericArgs}";
        }

        private static string GetGenericArgsList(Type type)
        {
            var genericArgs = type.GetGenericArguments();
            return genericArgs.Length > 0
                ? $"<{string.Join(",", type.GetGenericArguments().Select(x => x.Name))}>"
                : "";
        }

        private static string GetWrapperClassName(Type type) => $"{GetInterfaceTypeName(type)[1..]}Wrapper";

        private static string GetGenericClassArguments(Type type) => type.IsGenericType ? GetParamterType(type) : string.Empty;

        private static string GetGenericTypeConstraints(Type type)
        {
            return type.IsGenericType
                ? string.Join("", type.GetGenericArguments().SelectMany(x => x.GetGenericParameterConstraints().Select(y => $"where {x.Name} : class, {y.Name}")))
                : string.Empty;
        }

        private static string GetInterfaceTypeName(Type type)
        {
            return type.IsGenericType
                           ? $"{type.Name[0..type.Name.IndexOf('`', StringComparison.Ordinal)]}"
                           : $"{type.Name[0..]}";
        }

        private static void AddUsingStatements(List<Type> usings, StringBuilder output) => output.Insert(0, GenerateUsings(usings));

        private static void WriteClassToFile(Type type, StringBuilder output)
        {
            var wrapperName = GetWrapperClassName(type);
            Console.WriteLine($"Writing {wrapperName}.g.cs");
            File.WriteAllText($"{wrapperName}.g.cs", output.ToString());
        }

        #endregion
    }

    public static class Extensions
    {
        public static void AddRange<T>(this ISet<T> set, IEnumerable<T> items)
        {
            if (set is null) throw new ArgumentNullException(nameof(set));
            if (items is null) throw new ArgumentNullException(nameof(items));

            foreach (var item in items)
            {
                set.Add(item);
            }
        }
    }
}
