using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharpWrappers;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Represents a wrapper class.
    /// </summary>
    internal abstract class Wrapper<TWrapped> : IWrapper<TWrapped> where TWrapped : class
    {
        private TWrapped? _wrappedObject;

        private WrapperFactory Factory { get; }

        /// <inheritdoc/>
        public Func<object?> TargetObjectQuery { get; }

        /// <inheritdoc/>
        [SuppressMessage("Design", "CA1065:Do not raise exceptions in unexpected locations")]
        public TWrapped WrappedObject
        {
            get
            {
                EnsureWrappedObject();
                if (_wrappedObject is null)
                    throw new NodeRemovedException();
                return _wrappedObject!;
            }
        }

        public bool IsRemoved
        {
            get
            {
                if (_wrappedObject is null) return true;
                EnsureWrappedObject();
                return _wrappedObject is null;
            }
        }

        /// <summary>
        /// Creates an instance of the <see cref="Wrapper{T}"/> class.
        /// </summary>
        protected Wrapper(WrapperFactory factory, TWrapped initialTargetObject, Func<object?> query)
        {
            if (factory is null) throw new ArgumentNullException(nameof(factory));
            if (initialTargetObject is null) throw new ArgumentNullException(nameof(initialTargetObject));
            if (query is null) throw new ArgumentNullException(nameof(query));

            Factory = factory;
            TargetObjectQuery = query;
            _wrappedObject = initialTargetObject;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => WrappedObject.Equals(obj);

        /// <inheritdoc/>
        public override int GetHashCode() => WrappedObject.GetHashCode();

        /// <inheritdoc/>
        public override string ToString() => WrappedObject.ToString();

        /// <summary>
        /// Gets or Wraps the type returned by the <paramref name="query"/>.
        /// </summary>
        protected T? GetOrWrap<T>(Func<T?> query) where T : class
        {
            if (query is null) throw new ArgumentNullException(nameof(query));
            T? result = default;

            var initialObject = query();
            if (initialObject is { })
            {
                var wrapper = Factory.GetOrCreate(initialObject, query);
                result = (T)wrapper;
            }

            return result;
        }

        private void EnsureWrappedObject()
        {
            if (_wrappedObject is null) return;

            object? target = null;
            try { target = TargetObjectQuery(); } catch(Exception) { }

            if (target is TWrapped wrapped)
            {
                if (!ReferenceEquals(_wrappedObject, wrapped))
                {
                    _wrappedObject = wrapped;
                    Factory.Refresh(_wrappedObject, wrapped, this);
                }
            }
            else
            {
                Factory.Remove(_wrappedObject);
                _wrappedObject = null;
            }
        }
    }
}