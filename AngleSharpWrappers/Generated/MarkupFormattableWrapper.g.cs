using System;
using System.IO;
using AngleSharp;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="IMarkupFormattable"/> type.
    /// </summary>
    internal sealed class MarkupFormattableWrapper : Wrapper<IMarkupFormattable>, IMarkupFormattable, IWrapper<IMarkupFormattable>
    {

        /// <summary>
        /// Creates an instance of the <see cref="MarkupFormattableWrapper"/> type;
        /// </summary>
        internal MarkupFormattableWrapper(WrapperFactory factory, IMarkupFormattable initialObject, Func<object?> query) : base(factory, initialObject, query) { }

        #region Properties and indexers
        #endregion

        #region Methods
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedObject.ToHtml(writer, formatter);
        #endregion
    }
}
