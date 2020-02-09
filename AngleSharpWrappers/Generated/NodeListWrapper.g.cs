using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="INodeList"/> type.
    /// </summary>
    public partial class NodeListWrapper : Wrapper<INodeList>, INodeList, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="NodeListWrapper"/> type;
        /// </summary>
        internal NodeListWrapper(WrapperFactory factory, INodeList initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public INode this[Int32 index] { get => GetOrWrap(() => WrappedObject[index]); }

        /// <inheritdoc/>
        public Int32 Length { get => WrappedObject.Length; }

        /// <inheritdoc/>
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter)
            => WrappedObject.ToHtml(writer, formatter);

        /// <inheritdoc/>
        public IEnumerator<INode> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this[i];
            }
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
