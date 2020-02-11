using System;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Represents a type that can wrap another type.
    /// </summary>
    public interface IWrapper
    {
        bool IsRemoved { get; }
    }

    /// <inheritdoc/>
    public interface IWrapper<out T> : IWrapper where T : class
    {
        /// <summary>
        /// Gets the wrapped object.
        /// </summary>
        T WrappedObject { get; }
    }
}
