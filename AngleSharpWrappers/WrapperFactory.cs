using System;
using AngleSharp.Dom;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Represents a factory for wrapping and unwrapping <see cref="INode"/>s.
    /// </summary>
    public partial class WrapperFactory
    {
        private ConcurrentDictionary<object, IWrapper> WrapperCache { get; } = new ConcurrentDictionary<object, IWrapper>();
        
        /// <summary>
        /// Wraps the provided AngleSharp object.
        /// </summary>
        public T Wrap<T>(Func<T?> objectQuery) where T : class
        {
            if (objectQuery is null) throw new ArgumentNullException(nameof(objectQuery));
            var initialObject = objectQuery();
            if (initialObject is null) throw new ArgumentException($"The initial object provided by the {nameof(objectQuery)} parameter must not return null initially.", nameof(objectQuery));

            return (T)GetOrCreate(initialObject, objectQuery);
        }

        /// <summary>
        /// Wraps the provided <see cref="IHtmlCollection{T}"/> object.
        /// </summary>
        public IHtmlCollection<T> Wrap<T>(Func<IHtmlCollection<T>?> objectQuery) where T : class, IElement
        {
            if (objectQuery is null) throw new ArgumentNullException(nameof(objectQuery));
            var initialObject = objectQuery();
            if (initialObject is null) throw new ArgumentException($"The initial object provided by the {nameof(objectQuery)} parameter must not return null initially.", nameof(objectQuery));

            return (IHtmlCollection<T>)GetOrCreate(initialObject, objectQuery);
        }

        /// <summary>
        /// Marks all created wrappers as stale.
        /// </summary>
        public void MarkAsStale()
        {
            foreach (var wrapper in WrapperCache.Values)
            {
                wrapper.MarkAsStale();
            }
            WrapperCache.Clear();
        }

        internal IWrapper GetOrCreate<T>(IHtmlCollection<T> initialObject, Func<IHtmlCollection<T>?> objectQuery) where T : class, IElement
        {
            return WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlCollectionWrapper<T>(this, (IHtmlCollection<T>)io, oq), objectQuery);
        }

        internal void AddWrapper(object wrappedObject, IWrapper wrapper) => WrapperCache.TryAdd(wrappedObject, wrapper);

        internal void RemoveWrapper(object wrappedObject) => WrapperCache.TryRemove(wrappedObject, out var _);
    }
}
