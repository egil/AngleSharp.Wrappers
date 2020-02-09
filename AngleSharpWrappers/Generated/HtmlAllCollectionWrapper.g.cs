using System;
using System.Collections;
using System.Collections.Generic;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IHtmlAllCollection"/> type.
    /// </summary>
    public partial class HtmlAllCollectionWrapper : Wrapper<IHtmlAllCollection>, IHtmlAllCollection, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="HtmlAllCollectionWrapper"/> type;
        /// </summary>
        internal HtmlAllCollectionWrapper(WrapperFactory factory, IHtmlAllCollection initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public IElement this[Int32 index] { get => GetOrWrap(() => WrappedObject[index]); }

        /// <inheritdoc/>
        public IElement this[String id] { get => GetOrWrap(() => WrappedObject[id]); }

        /// <inheritdoc/>
        public Int32 Length { get => WrappedObject.Length; }

        /// <inheritdoc/>
        public IEnumerator<IElement> GetEnumerator()
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
