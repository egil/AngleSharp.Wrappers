using System;
using System.Collections.Generic;
using AngleSharp.Dom;
using System.Collections.Concurrent;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Represents a factory for wrapping and unwrapping <see cref="INode"/>s.
    /// </summary>
    public static partial class WrapperFactory
    {
        public static readonly ConcurrentDictionary<object, IWrapper> WrapperCache = new ConcurrentDictionary<object, IWrapper>();

        public static IEnumerable<INode> Unwrap(this IEnumerable<INode> nodes)
        {
            if (nodes is null) throw new ArgumentNullException(nameof(nodes));
            foreach (var node in nodes)
            {
                yield return node.Unwrap();
            }
        }

    }
}
