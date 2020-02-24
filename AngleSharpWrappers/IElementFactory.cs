using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    /// <summary>
    /// Represents an <see cref="IElement"/> factory, used by a <see cref="Wrapper{TElement}"/>.
    /// </summary>
    public interface IElementFactory<out TElement> where TElement : class, INode
    {
        /// <summary>
        /// A method that returns the <see cref="TElement"/> to wrap.
        /// </summary>
        /// <returns></returns>
        TElement GetElement();
    }
}
