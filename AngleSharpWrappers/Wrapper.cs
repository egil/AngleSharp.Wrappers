using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Represents a wrapper <see cref="IElement"/>.
    /// </summary>
    public abstract class Wrapper<TElement> : IWrapper<TElement> where TElement : class, INode
    {
        private readonly IElementFactory<TElement> _elementFactory;

        /// <summary>
        /// Gets the wrapped element.
        /// </summary>
        /// <exception cref="ElementRemovedException">If the element is no longer available</exception>
        [SuppressMessage("Design", "CA1065:Do not raise exceptions in unexpected locations", Justification = "<Pending>")]
        [DebuggerHidden]
        public TElement WrappedElement => _elementFactory.GetElement();

        /// <summary>
        /// Creates an instance of the <see cref="Wrapper{T}"/> class.
        /// </summary>
        protected Wrapper(IElementFactory<TElement> elementFactory)
        {
            if (elementFactory is null) throw new ArgumentNullException(nameof(elementFactory));

            _elementFactory = elementFactory;
        }

        public override bool Equals(object obj) => WrappedElement.Equals(obj);

        public override int GetHashCode() => WrappedElement.GetHashCode();

        public static bool operator ==(Wrapper<TElement> x, TElement y)
        {
            if (x is null) return y is null;
            return x.WrappedElement == y;
        }

        public static bool operator !=(Wrapper<TElement> x, TElement y)
        {
            return !(x == y);
        }

        public static bool operator ==(TElement x, Wrapper<TElement> y)
        {
            if (y is null) return x is null;
            return x == y.WrappedElement;
        }

        public static bool operator !=(TElement x, Wrapper<TElement> y)
        {
            return !(x == y);
        }
    }
}