using System;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="IAttr"/> type.
    /// </summary>
    internal sealed class AttrWrapper : Wrapper<IAttr>, IAttr, IWrapper<IAttr>
    {

        /// <summary>
        /// Creates an instance of the <see cref="AttrWrapper"/> type;
        /// </summary>
        internal AttrWrapper(WrapperFactory factory, IAttr initialObject, Func<object?> query) : base(factory, initialObject, query) { }

        #region Properties and indexers
        public String LocalName { get => WrappedObject.LocalName; }
        public String Name { get => WrappedObject.Name; }
        public String NamespaceUri { get => WrappedObject.NamespaceUri; }
        public String Prefix { get => WrappedObject.Prefix; }
        public String Value { get => WrappedObject.Value; set => WrappedObject.Value = value;}
        #endregion

        #region Methods
        public Boolean Equals(IAttr other) => WrappedObject.Equals(other);
        #endregion
    }
}
