using System;
using System.Collections;
using System.Collections.Generic;
using AngleSharp.Html.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IHtmlOptionsCollection"/> type.
    /// </summary>
    public partial class HtmlOptionsCollectionWrapper : Wrapper<IHtmlOptionsCollection>, IHtmlOptionsCollection, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="HtmlOptionsCollectionWrapper"/> type;
        /// </summary>
        internal HtmlOptionsCollectionWrapper(WrapperFactory factory, IHtmlOptionsCollection initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public IHtmlOptionElement this[Int32 index] { get => GetOrWrap(() => WrappedObject[index]); }

        /// <inheritdoc/>
        public IHtmlOptionElement this[String id] { get => GetOrWrap(() => WrappedObject[id]); }

        /// <inheritdoc/>
        public Int32 Length { get => WrappedObject.Length; }

        /// <inheritdoc/>
        public Int32 SelectedIndex { get => WrappedObject.SelectedIndex; set => WrappedObject.SelectedIndex = value;}

        /// <inheritdoc/>
        public void Add(IHtmlOptionElement element, IHtmlElement before)
            => WrappedObject.Add(element, before);

        /// <inheritdoc/>
        public void Add(IHtmlOptionsGroupElement element, IHtmlElement before)
            => WrappedObject.Add(element, before);

        /// <inheritdoc/>
        public IHtmlOptionElement GetOptionAt(Int32 index)
            => GetOrWrap(() => WrappedObject.GetOptionAt(index));

        /// <inheritdoc/>
        public void Remove(Int32 index)
            => WrappedObject.Remove(index);

        /// <inheritdoc/>
        public void SetOptionAt(Int32 index, IHtmlOptionElement option)
            => WrappedObject.SetOptionAt(index, option);

        /// <inheritdoc/>
        public IEnumerator<IHtmlOptionElement> GetEnumerator()
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
