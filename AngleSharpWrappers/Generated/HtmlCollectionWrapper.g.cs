using System;
using System.Collections;
using System.Collections.Generic;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IHtmlCollection{T}"/> type.
    /// </summary>
    public partial class HtmlCollectionWrapper<T> : Wrapper<IHtmlCollection<T>>, IHtmlCollection<T>, IWrapper
        where T : class, IElement
    {
        /// <summary>
        /// Creates an instance of the <see cref="HtmlCollectionWrapper{T}"/> type;
        /// </summary>
        /// <param name="getObject">A function that can be used to retrieve a new instance of the wrapped type.</param>
        public HtmlCollectionWrapper(IHtmlCollection<T> initialObject, Func<IHtmlCollection<T>> getObject) : base(initialObject, getObject) { }

        /// <inheritdoc/>
        public T this[Int32 index] { get => GetOrWrap<T>(HashCode.Combine("this+System.Int32", index), () => WrappedObject[index]); }

        /// <inheritdoc/>
        public T this[String id] { get => GetOrWrap<T>(HashCode.Combine("this+System.String", id), () => WrappedObject[id]); }

        /// <inheritdoc/>
        public Int32 Length { get => WrappedObject.Length; }

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator()
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
