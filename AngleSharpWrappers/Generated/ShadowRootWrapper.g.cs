using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IShadowRoot"/> type.
    /// </summary>
    public partial class ShadowRootWrapper : Wrapper<IShadowRoot>, IShadowRoot, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="ShadowRootWrapper"/> type;
        /// </summary>
        internal ShadowRootWrapper(WrapperFactory factory, IShadowRoot initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public IElement ActiveElement { get => GetOrWrap(() => WrappedObject.ActiveElement); }

        /// <inheritdoc/>
        public String BaseUri { get => WrappedObject.BaseUri; }

        /// <inheritdoc/>
        public Url BaseUrl { get => WrappedObject.BaseUrl; }

        /// <inheritdoc/>
        public Int32 ChildElementCount { get => WrappedObject.ChildElementCount; }

        /// <inheritdoc/>
        public INodeList ChildNodes { get => GetOrWrap(() => WrappedObject.ChildNodes); }

        /// <inheritdoc/>
        public IHtmlCollection<IElement> Children { get => GetOrWrap(() => WrappedObject.Children); }

        /// <inheritdoc/>
        public INode FirstChild { get => GetOrWrap(() => WrappedObject.FirstChild); }

        /// <inheritdoc/>
        public IElement FirstElementChild { get => GetOrWrap(() => WrappedObject.FirstElementChild); }

        /// <inheritdoc/>
        public NodeFlags Flags { get => WrappedObject.Flags; }

        /// <inheritdoc/>
        public Boolean HasChildNodes { get => WrappedObject.HasChildNodes; }

        /// <inheritdoc/>
        public IElement Host { get => GetOrWrap(() => WrappedObject.Host); }

        /// <inheritdoc/>
        public String InnerHtml { get => WrappedObject.InnerHtml; set => WrappedObject.InnerHtml = value;}

        /// <inheritdoc/>
        public INode LastChild { get => GetOrWrap(() => WrappedObject.LastChild); }

        /// <inheritdoc/>
        public IElement LastElementChild { get => GetOrWrap(() => WrappedObject.LastElementChild); }

        /// <inheritdoc/>
        public INode NextSibling { get => GetOrWrap(() => WrappedObject.NextSibling); }

        /// <inheritdoc/>
        public String NodeName { get => WrappedObject.NodeName; }

        /// <inheritdoc/>
        public NodeType NodeType { get => WrappedObject.NodeType; }

        /// <inheritdoc/>
        public String NodeValue { get => WrappedObject.NodeValue; set => WrappedObject.NodeValue = value;}

        /// <inheritdoc/>
        public IDocument Owner { get => GetOrWrap(() => WrappedObject.Owner); }

        /// <inheritdoc/>
        public INode Parent { get => GetOrWrap(() => WrappedObject.Parent); }

        /// <inheritdoc/>
        public IElement ParentElement { get => GetOrWrap(() => WrappedObject.ParentElement); }

        /// <inheritdoc/>
        public INode PreviousSibling { get => GetOrWrap(() => WrappedObject.PreviousSibling); }

        /// <inheritdoc/>
        public IStyleSheetList StyleSheets { get => GetOrWrap(() => WrappedObject.StyleSheets); }

        /// <inheritdoc/>
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}

        /// <inheritdoc/>
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture)
            => WrappedObject.AddEventListener(type, callback, capture);

        /// <inheritdoc/>
        public void Append(INode[] nodes)
            => WrappedObject.Append(nodes);

        /// <inheritdoc/>
        public INode AppendChild(INode child)
            => GetOrWrap(() => WrappedObject.AppendChild(child));

        /// <inheritdoc/>
        public INode Clone(Boolean deep)
            => GetOrWrap(() => WrappedObject.Clone(deep));

        /// <inheritdoc/>
        public DocumentPositions CompareDocumentPosition(INode otherNode)
            => WrappedObject.CompareDocumentPosition(otherNode);

        /// <inheritdoc/>
        public Boolean Contains(INode otherNode)
            => WrappedObject.Contains(otherNode);

        /// <inheritdoc/>
        public Boolean Dispatch(Event ev)
            => WrappedObject.Dispatch(ev);

        /// <inheritdoc/>
        public Boolean Equals(INode otherNode)
            => WrappedObject.Equals(otherNode);

        /// <inheritdoc/>
        public IElement GetElementById(String elementId)
            => GetOrWrap(() => WrappedObject.GetElementById(elementId));

        /// <inheritdoc/>
        public INode InsertBefore(INode newElement, INode referenceElement)
            => GetOrWrap(() => WrappedObject.InsertBefore(newElement, referenceElement));

        /// <inheritdoc/>
        public void InvokeEventListener(Event ev)
            => WrappedObject.InvokeEventListener(ev);

        /// <inheritdoc/>
        public Boolean IsDefaultNamespace(String namespaceUri)
            => WrappedObject.IsDefaultNamespace(namespaceUri);

        /// <inheritdoc/>
        public String LookupNamespaceUri(String prefix)
            => WrappedObject.LookupNamespaceUri(prefix);

        /// <inheritdoc/>
        public String LookupPrefix(String namespaceUri)
            => WrappedObject.LookupPrefix(namespaceUri);

        /// <inheritdoc/>
        public void Normalize()
            => WrappedObject.Normalize();

        /// <inheritdoc/>
        public void Prepend(INode[] nodes)
            => WrappedObject.Prepend(nodes);

        /// <inheritdoc/>
        public IElement QuerySelector(String selectors)
            => GetOrWrap(() => WrappedObject.QuerySelector(selectors));

        /// <inheritdoc/>
        public IHtmlCollection<IElement> QuerySelectorAll(String selectors)
            => GetOrWrap(() => WrappedObject.QuerySelectorAll(selectors));

        /// <inheritdoc/>
        public INode RemoveChild(INode child)
            => GetOrWrap(() => WrappedObject.RemoveChild(child));

        /// <inheritdoc/>
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture)
            => WrappedObject.RemoveEventListener(type, callback, capture);

        /// <inheritdoc/>
        public INode ReplaceChild(INode newChild, INode oldChild)
            => GetOrWrap(() => WrappedObject.ReplaceChild(newChild, oldChild));

        /// <inheritdoc/>
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter)
            => WrappedObject.ToHtml(writer, formatter);
    }
}
