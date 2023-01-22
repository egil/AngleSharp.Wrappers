using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using AngleSharp.Dom;

namespace AngleSharpWrappers.Generator
{
    internal class Generator
    {
        private const char Space = ' ';
        private static readonly Type WrapTargetType = typeof(IElement);
        private static readonly NullabilityInfoContext NullabilityInfoContext = new();

        private Dictionary<string, Type> WrappedTypes { get; }

        public Generator()
        {
            var enumerableType = typeof(System.Collections.IEnumerable);
            var iattrType = typeof(IAttr);
            var allInterfaces = WrapTargetType.Assembly.GetTypes().Where(x => x.IsInterface).ToList();

            WrappedTypes = allInterfaces.Where(x => WrapTargetType.IsAssignableFrom(x)).ToDictionary(x => GetTypeKey(x), x => x);

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

        private IEnumerable<Type> CreateClassStart(Type type, StringBuilder output)
        {
            var name = GetInterfaceTypeName(type);
            var wrapperName = GetWrapperClassName(type);
            var genericArgs = GetGenericArgsList(type);
            var genericConstraints = GetGenericTypeConstraints(type);

            output.AppendLine();
            output.AppendLine();
            output.AppendLine("namespace AngleSharpWrappers");
            output.AppendLine("{");
            output.AppendLine($"{Space,4}#nullable enable");

            output.AppendLine($"{Space,4}/// <summary>");
            output.AppendLine($"{Space,4}/// Represents a wrapper class around <see cref=\"{name}{genericArgs.Replace('<', '{').Replace('>', '}')}\"/> type.");
            output.AppendLine($"{Space,4}/// </summary>");
            output.AppendLine($"{Space,4}[DebuggerDisplay(\"{{OuterHtml,nq}}\")]");
            output.AppendLine($"{Space,4}public sealed class {wrapperName}{genericArgs} : Wrapper<{name}{genericArgs}>, {name}{genericArgs}");
            if (!string.IsNullOrEmpty(genericConstraints))
                output.AppendLine($"{Space,8}{genericConstraints}");
            output.AppendLine($"{Space,4}{{");

            output.AppendLine($"{Space,8}/// <summary>");
            output.AppendLine($"{Space,8}/// Creates an instance of the <see cref=\"{wrapperName}{genericArgs.Replace('<', '{').Replace('>', '}')}\"/> type;");
            output.AppendLine($"{Space,8}/// </summary>");
            output.AppendLine($"{Space,8}public {wrapperName}(IElementFactory<{name}{genericArgs}> elementFactory) : base(elementFactory) {{ }}");

            yield return type;
            yield return typeof(DebuggerHiddenAttribute);
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
            var events = GetEvents(type).GroupBy(x => x.Name).OrderBy(x => x.Key).ToList();
            if (events.Count > 0)
            {
                output.AppendLine();
                output.AppendLine($"{Space,8}#region Events");
            }

            foreach (var evtGroup in events)
            {
                var evt = evtGroup.Last();
                var evtType = GetReturnType(evt.EventHandlerType);

                var castType = evtGroup.Count() > 1 && evtGroup.Select(x => x.DeclaringType!.Name).Distinct().Count() > 1
                    ? $"(({evt.DeclaringType!.Name})WrappedElement)"
                    : "WrappedElement";

                output.AppendLine($"{Space,8}/// <inheritdoc/>");
                output.AppendLine($"{Space,8}public event {evtType} {evt.Name} {{ add => {castType}.{evt.Name} += value; remove => {castType}.{evt.Name} -= value; }}");

                if (evt.DeclaringType is { })
                    yield return evt.DeclaringType;
                if (evt.EventHandlerType is { })
                    yield return evt.EventHandlerType;
            }

            if (events.Count > 0)
                output.AppendLine($"{Space,8}#endregion");
        }

        private IEnumerable<Type> CreatePropertiesAndIndexers(Type type, StringBuilder output)
        {
            output.AppendLine();
            output.AppendLine($"{Space,8}#region Properties and indexers");
            var properties = GetProperties(type);
            var indexerUsings = CreateIndexerProperties();
            var propUsings = CreateProperties();
            var result = indexerUsings.Concat(propUsings).ToList();

            output.AppendLine($"{Space,8}#endregion");

            return result;

            IEnumerable<Type> CreateIndexerProperties()
            {
                foreach (var prop in properties.Where(x => x.GetIndexParameters().Length > 0).OrderBy(x => x.Name))
                {
                    output.AppendLine();
                    var indexParam = prop.GetIndexParameters().Single();

                    var getter = prop.CanRead ? $" get => WrappedElement[{indexParam.Name}];" : " ";
                    var setter = prop.CanWrite ? $" set => WrappedElement[{indexParam.Name}] = value;" : " ";
                    var idxTypeName = GetReturnType(indexParam.ParameterType);

                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}[DebuggerHidden]");
                    output.AppendLine($"{Space,8}public {GetReturnType(prop.PropertyType)} this[{idxTypeName} {indexParam.Name}] {{{getter}{setter}}}");

                    yield return indexParam.ParameterType;

                }
            }

            IEnumerable<Type> CreateProperties()
            {
                foreach (var prop in properties.Where(x => x.GetIndexParameters().Length == 0).OrderBy(x => x.Name))
                {
                    var nullableAnnotation = IsNullable(prop) ? "?" : "";
                    var propType = GetReturnType(prop.PropertyType);

                    var getter = prop.CanRead ? $" get => WrappedElement.{prop.Name};" : " ";
                    var setter = prop.CanWrite ? $" set => WrappedElement.{prop.Name} = value;" : " ";

                    output.AppendLine($"{Space,8}/// <inheritdoc/>");
                    output.AppendLine($"{Space,8}[DebuggerHidden]");
                    output.AppendLine($"{Space,8}public {propType}{nullableAnnotation} {prop.Name} {{{getter}{setter}}}");

                    yield return prop.PropertyType;
                    foreach (var t in prop.PropertyType.GetGenericArguments()) yield return t;
                }
            }
        }

        private IEnumerable<Type> CreateMethods(Type type, StringBuilder output)
        {
            var methods = GetMethods(type);

            output.AppendLine();
            output.AppendLine($"{Space,8}#region Methods");

            foreach (var method in methods.Where(x => !x.IsSpecialName && x.Name != "GetEnumerator").OrderBy(x => x.Name))
            {
                var parameters = method.GetParameters();
                var paramStr = string.Join(", ", parameters.Select(x =>
                {
                    var nullableAnnotation = IsNullable(x) ? "?" : "";
                    return $"{GetParamterType(x.ParameterType)}{nullableAnnotation} {x.Name}";
                }));
                var argsStr = string.Join(", ", parameters.Select(x => x.Name));
                var returnType = GetReturnType(method.ReturnType);
                var nullableAnnotation = IsNullable(method) ? "?" : "";

                output.AppendLine($"{Space,8}/// <inheritdoc/>");
                output.AppendLine($"{Space,8}[DebuggerHidden]");
                output.AppendLine($"{Space,8}public {returnType}{nullableAnnotation} {method.Name}({paramStr}) => WrappedElement.{method.Name}({argsStr});");

                yield return method.ReturnType;
                foreach (var t in method.ReturnType.GetGenericArguments()) yield return t;
                foreach (var t in parameters.Select(x => x.ParameterType)) yield return t;
                foreach (var t in parameters.SelectMany(x => x.ParameterType.GetGenericArguments())) yield return t;
            }

            output.AppendLine($"{Space,8}#endregion");
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

                output.AppendLine($"{Space,8}/// <inheritdoc/>");
                output.AppendLine($"{Space,8}public IEnumerator<{GetParamterType(enumerableGeneric)}> GetEnumerator() => WrappedElement.GetEnumerator();");
                output.AppendLine();
                output.AppendLine($"{Space,8}/// <inheritdoc/>");
                output.AppendLine($"{Space,8}IEnumerator IEnumerable.GetEnumerator() => WrappedElement.GetEnumerator();");

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
            var inodes = getOrWrapTypes.Values.ToDictionary(x => x.FullName!, x => x);

            var orderedINodes = CreateOrderedNodes(getOrWrapTypes);

            output.AppendLine();
            output.AppendLine("namespace AngleSharpWrappers");
            output.AppendLine("{");
            output.AppendLine($"{Space,4}#nullable enable");
            output.AppendLine($"{Space,4}/// <summary>");
            output.AppendLine($"{Space,4}/// A factory for creating element wrappers.");
            output.AppendLine($"{Space,4}/// </summary>");
            output.AppendLine($"{Space,4}public static class WrapperFactory");
            output.AppendLine($"{Space,4}{{");

            output.AppendLine($"{Space,8}/// <summary>");
            output.AppendLine($"{Space,8}/// Wraps an <see cref=\"IElement\"/> in the wrapper specific to it.");
            output.AppendLine($"{Space,8}/// </summary>");
            output.AppendLine($"{Space,8}/// <typeparam name=\"T\">The element type.</typeparam>");
            output.AppendLine($"{Space,8}/// <param name=\"factory\">The factory that provides the wrapped element.</param>");
            output.AppendLine($"{Space,8}/// <returns>The wrapped <see cref=\"IElement\"/>.</returns>");
            output.AppendLine($"{Space,8}public static T Create<T>(IElementFactory<T> factory) where T : class, INode");
            output.AppendLine($"{Space,8}{{");
            output.AppendLine($"{Space,12}IElement result = factory switch");
            output.AppendLine($"{Space,12}{{");

            while (orderedINodes.Count > 0)
            {
                var typeName = orderedINodes.OrderBy(x => x.Value.Count).First().Key;
                var type = inodes[typeName];
                orderedINodes.Remove(typeName);

                var wrapperName = $"{type.Name[1..]}Wrapper";
                var typeVarName = $"{char.ToLowerInvariant(type.Name[1])}{type.Name[2..]}";
                output.AppendLine($"{Space,16}IElementFactory<{type.Name}> {typeVarName}Factory => new {wrapperName}({typeVarName}Factory),");
                usings.Add(type);
            }

            output.AppendLine($"{Space,16}_ => throw new InvalidOperationException($\"Unknown type. Cannot create wrapper for {{typeof(T)}}\"),");
            output.AppendLine($"{Space,12}}};");
            output.AppendLine($"{Space,12}return (T)result;");
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
            var orderedINodes = inodes.ToDictionary(x => x.Key!, x => new List<Type>());
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
            if (parameterType.IsGenericType && parameterType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return GetInterfaceTypeName(parameterType.GetGenericArguments().First());
            }

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


        public static bool IsNullable(PropertyInfo property) =>
            IsNullableHelper(property.PropertyType, property.DeclaringType, property.CustomAttributes);

        public static bool IsNullable(FieldInfo field) =>
            IsNullableHelper(field.FieldType, field.DeclaringType, field.CustomAttributes);

        public static bool IsNullable(ParameterInfo parameter) =>
            IsNullableHelper(parameter.ParameterType, parameter.Member, parameter.CustomAttributes);

        public static bool IsNullable(MethodInfo method)
        {
            var breakHere = method.Name.Equals("GetAttribute");

            var nullabilityInfo = NullabilityInfoContext.Create(method.ReturnParameter);
            var nullabilityInfoWriteState = nullabilityInfo.WriteState;
            var nullable = nullabilityInfoWriteState is NullabilityState.Nullable;

            return nullable;
        }

        private static bool IsNullableHelper(Type memberType, MemberInfo? declaringType, IEnumerable<CustomAttributeData> customAttributes)
        {
            if (memberType.IsValueType)
                return Nullable.GetUnderlyingType(memberType) != null;

            var nullable = customAttributes
                .FirstOrDefault(x => x.AttributeType.FullName == "System.Runtime.CompilerServices.NullableAttribute");
            if (nullable != null && nullable.ConstructorArguments.Count == 1)
            {
                var attributeArgument = nullable.ConstructorArguments[0];
                if (attributeArgument.ArgumentType == typeof(byte[]))
                {
                    var args = (ReadOnlyCollection<CustomAttributeTypedArgument>)attributeArgument.Value!;
                    if (args.Count > 0 && args[0].ArgumentType == typeof(byte))
                    {
                        return (byte)args[0].Value! == 2;
                    }
                }
                else if (attributeArgument.ArgumentType == typeof(byte))
                {
                    return (byte)attributeArgument.Value! == 2;
                }
            }

            for (var type = declaringType; type != null; type = type.DeclaringType)
            {
                var context = type.CustomAttributes
                    .FirstOrDefault(x => x.AttributeType.FullName == "System.Runtime.CompilerServices.NullableContextAttribute");
                if (context != null &&
                    context.ConstructorArguments.Count == 1 &&
                    context.ConstructorArguments[0].ArgumentType == typeof(byte))
                {
                    return (byte)context.ConstructorArguments[0].Value! == 2;
                }
            }

            // Couldn't find a suitable attribute
            return false;
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
