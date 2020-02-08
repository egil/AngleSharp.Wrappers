using System;
using AngleSharp.Css.Dom;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Io.Dom;
using AngleSharp.Media.Dom;
namespace AngleSharpWrappers
{
    #nullable disable
    public abstract partial class Wrapper<TWrapped> : IWrapper where TWrapped : class
    {
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IAttr GetOrWrap(int key, Func<IAttr> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new AttrWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IAttr)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IAudioTrackList GetOrWrap(int key, Func<IAudioTrackList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new AudioTrackListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IAudioTrackList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IFileList GetOrWrap(int key, Func<IFileList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new FileListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IFileList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IHtmlAllCollection GetOrWrap(int key, Func<IHtmlAllCollection> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new HtmlAllCollectionWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IHtmlAllCollection)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IHtmlFormControlsCollection GetOrWrap(int key, Func<IHtmlFormControlsCollection> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new HtmlFormControlsCollectionWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IHtmlFormControlsCollection)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IHtmlOptionsCollection GetOrWrap(int key, Func<IHtmlOptionsCollection> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new HtmlOptionsCollectionWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IHtmlOptionsCollection)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IMediaList GetOrWrap(int key, Func<IMediaList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new MediaListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IMediaList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected INamedNodeMap GetOrWrap(int key, Func<INamedNodeMap> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new NamedNodeMapWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (INamedNodeMap)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected INodeList GetOrWrap(int key, Func<INodeList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new NodeListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (INodeList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected ISettableTokenList GetOrWrap(int key, Func<ISettableTokenList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new SettableTokenListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (ISettableTokenList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IStringList GetOrWrap(int key, Func<IStringList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new StringListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IStringList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IStringMap GetOrWrap(int key, Func<IStringMap> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new StringMapWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IStringMap)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IStyleSheetList GetOrWrap(int key, Func<IStyleSheetList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new StyleSheetListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IStyleSheetList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected ITextTrackCueList GetOrWrap(int key, Func<ITextTrackCueList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new TextTrackCueListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (ITextTrackCueList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected ITextTrackList GetOrWrap(int key, Func<ITextTrackList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new TextTrackListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (ITextTrackList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected ITokenList GetOrWrap(int key, Func<ITokenList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new TokenListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (ITokenList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IVideoTrackList GetOrWrap(int key, Func<IVideoTrackList> objectQuery)
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new VideoTrackListWrapper(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IVideoTrackList)result;
        }
        /// <summary>
        /// Gets (or wraps) the requested nested object.
        /// </summary>
        /// <param name="key">Key to look up the requested wrapped object.</param>
        /// <param name="objectQuery">A function that can be used to retrieve a new instance of the wrapped type.</param>
        /// <returns>The object wrapped in a wrapper.</returns>
        protected IHtmlCollection<T> GetOrWrap<T>(int key, Func<IHtmlCollection<T>> objectQuery) where T : class, IElement
        {
            if (!Wrappers.TryGetValue(key, out var result))
            {
                var initialObject = objectQuery();
                if (initialObject is null) return default;
                if (!Wrapper.WrapperCache.TryGetValue(initialObject, out result))
                {
                    result = new HtmlCollectionWrapper<T>(initialObject, objectQuery);
                }
                Wrappers.Add(key, result);
            }
            return (IHtmlCollection<T>)result;
        }
    }
}
