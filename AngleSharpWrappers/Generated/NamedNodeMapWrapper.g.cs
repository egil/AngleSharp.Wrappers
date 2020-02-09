using System;
using System.Collections;
using System.Collections.Generic;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="INamedNodeMap"/> type.
    /// </summary>
    public partial class NamedNodeMapWrapper : Wrapper<INamedNodeMap>, INamedNodeMap, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="NamedNodeMapWrapper"/> type;
        /// </summary>
        internal NamedNodeMapWrapper(WrapperFactory factory, INamedNodeMap initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public IAttr this[Int32 index] { get => GetOrWrap(() => WrappedObject[index]); }

        /// <inheritdoc/>
        public IAttr this[String name] { get => GetOrWrap(() => WrappedObject[name]); }

        /// <inheritdoc/>
        public Int32 Length { get => WrappedObject.Length; }

        /// <inheritdoc/>
        public IAttr GetNamedItem(String name)
            => GetOrWrap(() => WrappedObject.GetNamedItem(name));

        /// <inheritdoc/>
        public IAttr GetNamedItem(String namespaceUri, String localName)
            => GetOrWrap(() => WrappedObject.GetNamedItem(namespaceUri, localName));

        /// <inheritdoc/>
        public IAttr RemoveNamedItem(String name)
            => GetOrWrap(() => WrappedObject.RemoveNamedItem(name));

        /// <inheritdoc/>
        public IAttr RemoveNamedItem(String namespaceUri, String localName)
            => GetOrWrap(() => WrappedObject.RemoveNamedItem(namespaceUri, localName));

        /// <inheritdoc/>
        public IAttr SetNamedItem(IAttr item)
            => GetOrWrap(() => WrappedObject.SetNamedItem(item));

        /// <inheritdoc/>
        public IAttr SetNamedItemWithNamespaceUri(IAttr item)
            => GetOrWrap(() => WrappedObject.SetNamedItemWithNamespaceUri(item));

        /// <inheritdoc/>
        public IEnumerator<IAttr> GetEnumerator()
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
