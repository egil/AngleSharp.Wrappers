using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using AngleSharp.Svg.Dom;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="ISvgCircleElement"/> type.
    /// </summary>
    internal sealed class SvgCircleElementWrapper : Wrapper<ISvgCircleElement>, ISvgCircleElement, IWrapper<ISvgCircleElement>
    {
        private IElement? _assignedSlot;
        private INodeList? _childNodes;
        private INode? _firstChild;
        private IElement? _firstElementChild;
        private INode? _lastChild;
        private IElement? _lastElementChild;
        private IElement? _nextElementSibling;
        private INode? _nextSibling;
        private IDocument? _owner;
        private INode? _parent;
        private IElement? _parentElement;
        private IElement? _previousElementSibling;
        private INode? _previousSibling;
        private IShadowRoot? _shadowRoot;

        /// <summary>
        /// Creates an instance of the <see cref="SvgCircleElementWrapper"/> type;
        /// </summary>
        internal SvgCircleElementWrapper(WrapperFactory factory, ISvgCircleElement initialObject, Func<object?> query) : base(factory, initialObject, query) { }

        #region Properties and indexers
        public IElement? AssignedSlot
        {
            get
            {
                if (_assignedSlot is null || ((IWrapper)_assignedSlot).IsRemoved) _assignedSlot = GetOrWrap(() => WrappedObject.AssignedSlot);
                return _assignedSlot;
            }
        }
        public INamedNodeMap Attributes { get => WrappedObject.Attributes; }
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
        public ITokenList ClassList { get => WrappedObject.ClassList; }
        public String ClassName { get => WrappedObject.ClassName; set => WrappedObject.ClassName = value;}
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
        public String Id { get => WrappedObject.Id; set => WrappedObject.Id = value;}
        public String InnerHtml { get => WrappedObject.InnerHtml; set => WrappedObject.InnerHtml = value;}
        public Boolean IsFocused { get => WrappedObject.IsFocused; }
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
        public String LocalName { get => WrappedObject.LocalName; }
        public String NamespaceUri { get => WrappedObject.NamespaceUri; }
        public IElement? NextElementSibling
        {
            get
            {
                if (_nextElementSibling is null || ((IWrapper)_nextElementSibling).IsRemoved) _nextElementSibling = GetOrWrap(() => WrappedObject.NextElementSibling);
                return _nextElementSibling;
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
        public String OuterHtml { get => WrappedObject.OuterHtml; set => WrappedObject.OuterHtml = value;}
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
        public String Prefix { get => WrappedObject.Prefix; }
        public IElement? PreviousElementSibling
        {
            get
            {
                if (_previousElementSibling is null || ((IWrapper)_previousElementSibling).IsRemoved) _previousElementSibling = GetOrWrap(() => WrappedObject.PreviousElementSibling);
                return _previousElementSibling;
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
        public IShadowRoot? ShadowRoot
        {
            get
            {
                if (_shadowRoot is null || ((IWrapper)_shadowRoot).IsRemoved) _shadowRoot = GetOrWrap(() => WrappedObject.ShadowRoot);
                return _shadowRoot;
            }
        }
        public String Slot { get => WrappedObject.Slot; set => WrappedObject.Slot = value;}
        public ISourceReference SourceReference { get => WrappedObject.SourceReference; }
        public String TagName { get => WrappedObject.TagName; }
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}
        #endregion

        #region Methods
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.AddEventListener(type, callback, capture);
        public void After(INode[] nodes) => WrappedObject.After(nodes);
        public void Append(INode[] nodes) => WrappedObject.Append(nodes);
        public INode AppendChild(INode child) => WrappedObject.AppendChild(child);
        public IShadowRoot AttachShadow(ShadowRootMode mode) => WrappedObject.AttachShadow(mode);
        public void Before(INode[] nodes) => WrappedObject.Before(nodes);
        public INode Clone(Boolean deep) => WrappedObject.Clone(deep);
        public IElement Closest(String selectors) => WrappedObject.Closest(selectors);
        public DocumentPositions CompareDocumentPosition(INode otherNode) => WrappedObject.CompareDocumentPosition(otherNode);
        public Boolean Contains(INode otherNode) => WrappedObject.Contains(otherNode);
        public Boolean Dispatch(Event ev) => WrappedObject.Dispatch(ev);
        public Boolean Equals(INode otherNode) => WrappedObject.Equals(otherNode);
        public String GetAttribute(String name) => WrappedObject.GetAttribute(name);
        public String GetAttribute(String namespaceUri, String localName) => WrappedObject.GetAttribute(namespaceUri, localName);
        public IHtmlCollection<IElement> GetElementsByClassName(String classNames) => WrappedObject.GetElementsByClassName(classNames);
        public IHtmlCollection<IElement> GetElementsByTagName(String tagName) => WrappedObject.GetElementsByTagName(tagName);
        public IHtmlCollection<IElement> GetElementsByTagNameNS(String namespaceUri, String tagName) => WrappedObject.GetElementsByTagNameNS(namespaceUri, tagName);
        public Boolean HasAttribute(String name) => WrappedObject.HasAttribute(name);
        public Boolean HasAttribute(String namespaceUri, String localName) => WrappedObject.HasAttribute(namespaceUri, localName);
        public void Insert(AdjacentPosition position, String html) => WrappedObject.Insert(position, html);
        public INode InsertBefore(INode newElement, INode referenceElement) => WrappedObject.InsertBefore(newElement, referenceElement);
        public void InvokeEventListener(Event ev) => WrappedObject.InvokeEventListener(ev);
        public Boolean IsDefaultNamespace(String namespaceUri) => WrappedObject.IsDefaultNamespace(namespaceUri);
        public String LookupNamespaceUri(String prefix) => WrappedObject.LookupNamespaceUri(prefix);
        public String LookupPrefix(String namespaceUri) => WrappedObject.LookupPrefix(namespaceUri);
        public Boolean Matches(String selectors) => WrappedObject.Matches(selectors);
        public void Normalize() => WrappedObject.Normalize();
        public void Prepend(INode[] nodes) => WrappedObject.Prepend(nodes);
        public IElement QuerySelector(String selectors) => WrappedObject.QuerySelector(selectors);
        public IHtmlCollection<IElement> QuerySelectorAll(String selectors) => WrappedObject.QuerySelectorAll(selectors);
        public void Remove() => WrappedObject.Remove();
        public Boolean RemoveAttribute(String name) => WrappedObject.RemoveAttribute(name);
        public Boolean RemoveAttribute(String namespaceUri, String localName) => WrappedObject.RemoveAttribute(namespaceUri, localName);
        public INode RemoveChild(INode child) => WrappedObject.RemoveChild(child);
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.RemoveEventListener(type, callback, capture);
        public void Replace(INode[] nodes) => WrappedObject.Replace(nodes);
        public INode ReplaceChild(INode newChild, INode oldChild) => WrappedObject.ReplaceChild(newChild, oldChild);
        public void SetAttribute(String name, String value) => WrappedObject.SetAttribute(name, value);
        public void SetAttribute(String namespaceUri, String name, String value) => WrappedObject.SetAttribute(namespaceUri, name, value);
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedObject.ToHtml(writer, formatter);
        #endregion
    }
}
