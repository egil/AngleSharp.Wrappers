using System;
using AngleSharp.Dom;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Threading;
using AngleSharp;
using System.Linq;
using System.Linq.Expressions;

namespace AngleSharpWrappers
{
    class WrappedObjectEqualityComparer : EqualityComparer<object>
    {
        public override bool Equals(object x, object y) => ReferenceEquals(x, y);
        public override int GetHashCode(object obj) => obj.GetHashCode();
    }

    /// <summary>
    /// Represents a factory for wrapping and unwrapping <see cref="INode"/>s.
    /// </summary>
    public sealed partial class WrapperFactory
    {
        private readonly Dictionary<object, IWrapper> _wrappers = new Dictionary<object, IWrapper>(30, new WrappedObjectEqualityComparer());

        /// <summary>
        /// Wraps the provided AngleSharp object.
        /// </summary>
        public T Wrap<T>(Func<T?> query) where T : class
        {
            if (query is null) throw new ArgumentNullException(nameof(query));
            var initialObject = query();
            if (initialObject is null) throw new ArgumentException($"The initial object provided by the {nameof(query)} parameter must not return null initially.", nameof(query));

            return (T)GetOrCreate(initialObject, query);
        }

        internal void Refresh<T>(T oldTarget, T newTarget, IWrapper<T> wrapper) where T : class
        {
            _wrappers.Add(newTarget, wrapper);
            _wrappers.Remove(oldTarget);
        }

        internal void Remove<T>(T oldTarget) where T : class
        {
            _wrappers.Remove(oldTarget);
        }

        private IWrapper GetOrAdd<T>(T target, Func<object?> query, Func<WrapperFactory, T, Func<object?>, IWrapper<T>> wrapperFactory) where T : class
        {
            if (!_wrappers.TryGetValue(target, out var result))
            {
                result = wrapperFactory(this, target, query);
                _wrappers.Add(target, result);
            }
            return result;
        }
    }
}
