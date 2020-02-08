using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharpWrappers;

namespace AngleSharpWrappers
{
    internal static class Wrapper
    {
        public static readonly ConcurrentDictionary<object, IWrapper> WrapperCache = new ConcurrentDictionary<object, IWrapper>();
    }


    /// <summary>
    /// Represents a wrapper class.
    /// </summary>
    public abstract partial class Wrapper<TWrapped> : IWrapper where TWrapped : class
    {
        private readonly Func<object?> _getTargetObject;
        private TWrapped? _wrappedObject;

        private Dictionary<int, IWrapper> Wrappers { get; } = new Dictionary<int, IWrapper>();

        /// <summary>
        /// Gets the wrapped object.
        /// </summary>
        [SuppressMessage("Design", "CA1065:Do not raise exceptions in unexpected locations")]
        public TWrapped WrappedObject
        {
            get
            {
                if (_wrappedObject is null)
                {
                    var target = _getTargetObject();
                    if (target is null)
                        throw new NodeNoLongerAvailableException();

                    if (target is TWrapped wrappedObject)
                        _wrappedObject = wrappedObject;
                    else
                        throw new InvalidOperationException("The GetTargetObject func did not return the expected wrapped object type.");
                }
                return _wrappedObject!;
            }
        }

        /// <summary>
        /// Creates an instance of the <see cref="Wrapper{T}"/> class.
        /// </summary>
        /// <param name="initialTargetObject">The initial target object</param>
        /// <param name="getTargetObject">A function that can be used to retrieve a new instance of the wrapped type.</param>
        protected Wrapper(TWrapped initialTargetObject, Func<object?> getTargetObject)
        {
            if (initialTargetObject is null) throw new ArgumentNullException(nameof(initialTargetObject));
            if (getTargetObject is null) throw new ArgumentNullException(nameof(getTargetObject));

            _getTargetObject = getTargetObject;
            _wrappedObject = initialTargetObject;
            var added = Wrapper.WrapperCache.TryAdd(initialTargetObject, this);
            if(!added)
                throw new Exception("WRAPPER ADDED IN ANOTHER THREAD!");
        }

        /// <summary>
        /// Marks the wrapped object as stale, and forces the wrapper to retrieve it again.
        /// </summary>
        public void MarkAsStale()
        {
            if (_wrappedObject is { })
                Wrapper.WrapperCache.TryRemove(_wrappedObject, out var _);

            _wrappedObject = null;
            foreach (var wrapped in Wrappers.Values) wrapped.MarkAsStale();
        }

        protected T? GetOrWrap<T>(int key, Func<T?> objectQuery) where T : class, INode
        {
            if (objectQuery is null) throw new ArgumentNullException(nameof(objectQuery));

            if (!Wrappers.TryGetValue(key, out var result))
            {
                // If the query does not return anything, we return null to follow AngleSharps conventions
                var initialObject = objectQuery();
                if (initialObject is null) return default;

                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = WrapperFactory.NodeWrapperFactory(initialObject, objectQuery);
                }

                Wrappers.Add(key, result);
            }

            return (T)result;
        }
    }
}