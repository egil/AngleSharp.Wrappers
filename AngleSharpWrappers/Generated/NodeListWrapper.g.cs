using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="INodeList"/> type.
    /// </summary>
    internal sealed class NodeListWrapper : Wrapper<INodeList>, INodeList, IWrapper<INodeList>
    {
        private Dictionary<Int32, INode> _int32Indexer = new Dictionary<Int32, INode>();

        /// <summary>
        /// Creates an instance of the <see cref="NodeListWrapper"/> type;
        /// </summary>
        internal NodeListWrapper(WrapperFactory factory, INodeList initialObject, Func<object?> query) : base(factory, initialObject, query) { }

        #region Properties and indexers

        public INode this[Int32 index]
        {
            get
            {
                INode? result;
                if (_int32Indexer.TryGetValue(index, out result) && ((IWrapper)result).IsRemoved)
                {
                    _int32Indexer.Remove(index);
                    result = null;
                }
                if (result is null)
                {
                    result = GetOrWrap(() => WrappedObject[index])!;
                    _int32Indexer.Add(index, result);
                }
                return result;
            }
        }
        public Int32 Length { get => WrappedObject.Length; }
        #endregion

        #region Methods
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedObject.ToHtml(writer, formatter);
        #endregion

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
