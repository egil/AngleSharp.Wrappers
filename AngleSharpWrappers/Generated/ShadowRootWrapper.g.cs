using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="IShadowRoot"/> type.
    /// </summary>
    internal sealed class ShadowRootWrapper : Wrapper<IShadowRoot>, IShadowRoot, IWrapper<IShadowRoot>
    {
        private IElement? _activeElement;
        private INodeList? _childNodes;
        private INode? _firstChild;
        private IElement? _firstElementChild;
        private IElement? _host;
        private INode? _lastChild;
        private IElement? _lastElementChild;
        private INode? _nextSibling;
        private IDocument? _owner;
        private INode? _parent;
        private IElement? _parentElement;
        private INode? _previousSibling;

        /// <summary>
        /// Creates an instance of the <see cref="ShadowRootWrapper"/> type;
        /// </summary>
        internal ShadowRootWrapper(WrapperFactory factory, IShadowRoot initialObject, Func<object?> query) : base(factory, initialObject, query) { }

        #region Properties and indexers
        public IElement? ActiveElement
        {
            get
            {
                if (_activeElement is null || ((IWrapper)_activeElement).IsRemoved) _activeElement = GetOrWrap(() => WrappedObject.ActiveElement);
                return _activeElement;
            }
        }
        public String BaseUri { get => WrappedObject.BaseUri; }
        public Url BaseUrl { get => WrappedObject.BaseUrl; }
        public Int32 ChildElementCount { get => WrappedObject.ChildElementCount; }
        public INodeList? ChildNodes
        {
            get
            {
                if (_childNodes is null || ((IWrapper)_childNodes).IsRemoved) _childNodes = GetOrWrap(() => WrappedObject.ChildNodes);
                return _childNodes;
            }
        }
        public IHtmlCollection<IElement> Children { get => WrappedObject.Children; }
        public INode? FirstChild
        {
            get
            {
                if (_firstChild is null || ((IWrapper)_firstChild).IsRemoved) _firstChild = GetOrWrap(() => WrappedObject.FirstChild);
                return _firstChild;
            }
        }
        public IElement? FirstElementChild
        {
            get
            {
                if (_firstElementChild is null || ((IWrapper)_firstElementChild).IsRemoved) _firstElementChild = GetOrWrap(() => WrappedObject.FirstElementChild);
                return _firstElementChild;
            }
        }
        public NodeFlags Flags { get => WrappedObject.Flags; }
        public Boolean HasChildNodes { get => WrappedObject.HasChildNodes; }
        public IElement? Host
        {
            get
            {
                if (_host is null || ((IWrapper)_host).IsRemoved) _host = GetOrWrap(() => WrappedObject.Host);
                return _host;
            }
        }
        public String InnerHtml { get => WrappedObject.InnerHtml; set => WrappedObject.InnerHtml = value;}
        public INode? LastChild
        {
            get
            {
                if (_lastChild is null || ((IWrapper)_lastChild).IsRemoved) _lastChild = GetOrWrap(() => WrappedObject.LastChild);
                return _lastChild;
            }
        }
        public IElement? LastElementChild
        {
            get
            {
                if (_lastElementChild is null || ((IWrapper)_lastElementChild).IsRemoved) _lastElementChild = GetOrWrap(() => WrappedObject.LastElementChild);
                return _lastElementChild;
            }
        }
        public INode? NextSibling
        {
            get
            {
                if (_nextSibling is null || ((IWrapper)_nextSibling).IsRemoved) _nextSibling = GetOrWrap(() => WrappedObject.NextSibling);
                return _nextSibling;
            }
        }
        public String NodeName { get => WrappedObject.NodeName; }
        public NodeType NodeType { get => WrappedObject.NodeType; }
        public String NodeValue { get => WrappedObject.NodeValue; set => WrappedObject.NodeValue = value;}
        public IDocument? Owner
        {
            get
            {
                if (_owner is null || ((IWrapper)_owner).IsRemoved) _owner = GetOrWrap(() => WrappedObject.Owner);
                return _owner;
            }
        }
        public INode? Parent
        {
            get
            {
                if (_parent is null || ((IWrapper)_parent).IsRemoved) _parent = GetOrWrap(() => WrappedObject.Parent);
                return _parent;
            }
        }
        public IElement? ParentElement
        {
            get
            {
                if (_parentElement is null || ((IWrapper)_parentElement).IsRemoved) _parentElement = GetOrWrap(() => WrappedObject.ParentElement);
                return _parentElement;
            }
        }
        public INode? PreviousSibling
        {
            get
            {
                if (_previousSibling is null || ((IWrapper)_previousSibling).IsRemoved) _previousSibling = GetOrWrap(() => WrappedObject.PreviousSibling);
                return _previousSibling;
            }
        }
        public IStyleSheetList StyleSheets { get => WrappedObject.StyleSheets; }
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}
        #endregion

        #region Methods
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.AddEventListener(type, callback, capture);
        public void Append(INode[] nodes) => WrappedObject.Append(nodes);
        public INode AppendChild(INode child) => WrappedObject.AppendChild(child);
        public INode Clone(Boolean deep) => WrappedObject.Clone(deep);
        public DocumentPositions CompareDocumentPosition(INode otherNode) => WrappedObject.CompareDocumentPosition(otherNode);
        public Boolean Contains(INode otherNode) => WrappedObject.Contains(otherNode);
        public Boolean Dispatch(Event ev) => WrappedObject.Dispatch(ev);
        public Boolean Equals(INode otherNode) => WrappedObject.Equals(otherNode);
        public IElement GetElementById(String elementId) => WrappedObject.GetElementById(elementId);
        public INode InsertBefore(INode newElement, INode referenceElement) => WrappedObject.InsertBefore(newElement, referenceElement);
        public void InvokeEventListener(Event ev) => WrappedObject.InvokeEventListener(ev);
        public Boolean IsDefaultNamespace(String namespaceUri) => WrappedObject.IsDefaultNamespace(namespaceUri);
        public String LookupNamespaceUri(String prefix) => WrappedObject.LookupNamespaceUri(prefix);
        public String LookupPrefix(String namespaceUri) => WrappedObject.LookupPrefix(namespaceUri);
        public void Normalize() => WrappedObject.Normalize();
        public void Prepend(INode[] nodes) => WrappedObject.Prepend(nodes);
        public IElement QuerySelector(String selectors) => WrappedObject.QuerySelector(selectors);
        public IHtmlCollection<IElement> QuerySelectorAll(String selectors) => WrappedObject.QuerySelectorAll(selectors);
        public INode RemoveChild(INode child) => WrappedObject.RemoveChild(child);
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.RemoveEventListener(type, callback, capture);
        public INode ReplaceChild(INode newChild, INode oldChild) => WrappedObject.ReplaceChild(newChild, oldChild);
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedObject.ToHtml(writer, formatter);
        #endregion
    }
}
