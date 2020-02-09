using System;
using System.Collections;
using System.Collections.Generic;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IStringMap"/> type.
    /// </summary>
    public partial class StringMapWrapper : Wrapper<IStringMap>, IStringMap, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="StringMapWrapper"/> type;
        /// </summary>
        internal StringMapWrapper(WrapperFactory factory, IStringMap initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public String this[String name] { get => WrappedObject[name]; set => WrappedObject[name] = value;}

        /// <inheritdoc/>
        public void Remove(String name)
            => WrappedObject.Remove(name);

        /// <inheritdoc/>
        public IEnumerator<KeyValuePair<String,String>> GetEnumerator() => WrappedObject.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => WrappedObject.GetEnumerator();
    }
}
