using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Represents a wrapper around an <typeparamref name="TElement"/>.
    /// </summary>
    public interface IWrapper<out TElement> where TElement : class, INode
    {
        /// <summary>
        /// Gets the wrapped element.
        /// </summary>
        TElement WrappedElement { get; }
    }
}
