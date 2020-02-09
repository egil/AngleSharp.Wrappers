using System;
using System.Collections.Generic;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Extensions for <see cref="WrapperFactory"/>.
    /// </summary>
    public static class WrapperFactoryExtensions
    {
        /// <summary>
        /// Unwraps all AngleSharp objects in the enumerable, if they have been wrapped.
        /// </summary>
        public static IEnumerable<T> Unwrap<T>(this IEnumerable<T> nodes)
        {
            if (nodes is null) throw new ArgumentNullException(nameof(nodes));
            foreach (var node in nodes)
            {
                yield return node.Unwrap();
            }
        }

        /// <summary>
        /// Unwraps an AngleSharp object, if it has been wrapped.
        /// </summary>
        public static T Unwrap<T>(this T wrappedObject)
            => wrappedObject is IWrapper<T> wrapper ? wrapper.WrappedObject : wrappedObject;
    }
}
