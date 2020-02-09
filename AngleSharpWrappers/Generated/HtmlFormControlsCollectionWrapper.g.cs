using System;
using System.Collections;
using System.Collections.Generic;
using AngleSharp.Html.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IHtmlFormControlsCollection"/> type.
    /// </summary>
    public partial class HtmlFormControlsCollectionWrapper : Wrapper<IHtmlFormControlsCollection>, IHtmlFormControlsCollection, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="HtmlFormControlsCollectionWrapper"/> type;
        /// </summary>
        internal HtmlFormControlsCollectionWrapper(WrapperFactory factory, IHtmlFormControlsCollection initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public IHtmlElement this[Int32 index] { get => GetOrWrap(() => WrappedObject[index]); }

        /// <inheritdoc/>
        public IHtmlElement this[String id] { get => GetOrWrap(() => WrappedObject[id]); }

        /// <inheritdoc/>
        public Int32 Length { get => WrappedObject.Length; }

        /// <inheritdoc/>
        public IEnumerator<IHtmlElement> GetEnumerator()
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
