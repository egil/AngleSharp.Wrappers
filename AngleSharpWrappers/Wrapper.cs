using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharpWrappers;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Represents a wrapper class.
    /// </summary>
    public abstract partial class Wrapper<TWrapped> : IWrapper<TWrapped>
        where TWrapped : class
    {
        private readonly Func<object?> _getTargetObject;
        private TWrapped? _wrappedObject;
        private WrapperFactory Factory { get; }

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
                    if (target is null) throw new NodeNoLongerAvailableException();

                    if (target is TWrapped wrappedObject)
                    {
                        _wrappedObject = wrappedObject;
                        Factory.AddWrapper(target, this);
                    }
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
        protected Wrapper(WrapperFactory factory, TWrapped initialTargetObject, Func<object?> getTargetObject)
        {
            if (initialTargetObject is null) throw new ArgumentNullException(nameof(initialTargetObject));
            if (getTargetObject is null) throw new ArgumentNullException(nameof(getTargetObject));

            _getTargetObject = getTargetObject;
            Factory = factory;
            _wrappedObject = initialTargetObject;
        }

        /// <inheritdoc/>
        public void MarkAsStale()
        {
            if (_wrappedObject is { })
            {
                _wrappedObject = null;
            }
        }

        /// <summary>
        /// Gets or Wraps the type returned by the <paramref name="objectQuery"/>.
        /// </summary>
        protected IHtmlCollection<T>? GetOrWrap<T>(Func<IHtmlCollection<T>?> objectQuery) where T : class, IElement
        {
            if (objectQuery is null) throw new ArgumentNullException(nameof(objectQuery));
            IHtmlCollection<T>? result = default;

            var initialObject = objectQuery();
            if (initialObject is { })
            {
                var wrapper = Factory.GetOrCreate(initialObject, objectQuery);
                result = (IHtmlCollection<T>)wrapper;
            }

            return result;
        }

        /// <summary>
        /// Gets or Wraps the type returned by the <paramref name="objectQuery"/>.
        /// </summary>
        protected T? GetOrWrap<T>(Func<T?> objectQuery) where T : class
        {
            if (objectQuery is null) throw new ArgumentNullException(nameof(objectQuery));
            T? result = default;

            var initialObject = objectQuery();
            if (initialObject is { })
            {
                var wrapper = Factory.GetOrCreate(initialObject, objectQuery);
                result = (T)wrapper;
            }

            return result;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => WrappedObject.Equals(obj);

        /// <inheritdoc/>
        public override int GetHashCode() => WrappedObject.GetHashCode();

        /// <inheritdoc/>
        public override string ToString() => WrappedObject.ToString();
    }
}