using System;
using System.Collections;
using System.Collections.Generic;
using AngleSharp.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="ITokenList"/> type.
    /// </summary>
    public partial class TokenListWrapper : Wrapper<ITokenList>, ITokenList, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="TokenListWrapper"/> type;
        /// </summary>
        internal TokenListWrapper(WrapperFactory factory, ITokenList initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public String this[Int32 index] { get => WrappedObject[index]; }

        /// <inheritdoc/>
        public Int32 Length { get => WrappedObject.Length; }

        /// <inheritdoc/>
        public void Add(String[] tokens)
            => WrappedObject.Add(tokens);

        /// <inheritdoc/>
        public Boolean Contains(String token)
            => WrappedObject.Contains(token);

        /// <inheritdoc/>
        public void Remove(String[] tokens)
            => WrappedObject.Remove(tokens);

        /// <inheritdoc/>
        public Boolean Toggle(String token, Boolean force)
            => WrappedObject.Toggle(token, force);

        /// <inheritdoc/>
        public IEnumerator<String> GetEnumerator() => WrappedObject.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => WrappedObject.GetEnumerator();
    }
}
