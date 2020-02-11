using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="INode"/> type.
    /// </summary>
    internal sealed class NodeWrapper : Wrapper<INode>, INode, IWrapper<INode>
    {
        private INodeList? _childNodes;
        private INode? _firstChild;
        private INode? _lastChild;
        private INode? _nextSibling;
        private IDocument? _owner;
        private INode? _parent;
        private IElement? _parentElement;
        private INode? _previousSibling;

        /// <summary>
        /// Creates an instance of the <see cref="NodeWrapper"/> type;
        /// </summary>
        internal NodeWrapper(WrapperFactory factory, INode initialObject, Func<object?> query) : base(factory, initialObject, query) { }

        #region Properties and indexers
        public String BaseUri { get => WrappedObject.BaseUri; }
        public Url BaseUrl { get => WrappedObject.BaseUrl; }
        public INodeList? ChildNodes
        {
            get
            {
                if (_childNodes is null || ((IWrapper)_childNodes).IsRemoved) _childNodes = GetOrWrap(() => WrappedObject.ChildNodes);
                return _childNodes;
            }
        }
        public INode? FirstChild
        {
            get
            {
                if (_firstChild is null || ((IWrapper)_firstChild).IsRemoved) _firstChild = GetOrWrap(() => WrappedObject.FirstChild);
                return _firstChild;
            }
        }
        public NodeFlags Flags { get => WrappedObject.Flags; }
        public Boolean HasChildNodes { get => WrappedObject.HasChildNodes; }
        public INode? LastChild
        {
            get
            {
                if (_lastChild is null || ((IWrapper)_lastChild).IsRemoved) _lastChild = GetOrWrap(() => WrappedObject.LastChild);
                return _lastChild;
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
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}
        #endregion

        #region Methods
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.AddEventListener(type, callback, capture);
        public INode AppendChild(INode child) => WrappedObject.AppendChild(child);
        public INode Clone(Boolean deep) => WrappedObject.Clone(deep);
        public DocumentPositions CompareDocumentPosition(INode otherNode) => WrappedObject.CompareDocumentPosition(otherNode);
        public Boolean Contains(INode otherNode) => WrappedObject.Contains(otherNode);
        public Boolean Dispatch(Event ev) => WrappedObject.Dispatch(ev);
        public Boolean Equals(INode otherNode) => WrappedObject.Equals(otherNode);
        public INode InsertBefore(INode newElement, INode referenceElement) => WrappedObject.InsertBefore(newElement, referenceElement);
        public void InvokeEventListener(Event ev) => WrappedObject.InvokeEventListener(ev);
        public Boolean IsDefaultNamespace(String namespaceUri) => WrappedObject.IsDefaultNamespace(namespaceUri);
        public String LookupNamespaceUri(String prefix) => WrappedObject.LookupNamespaceUri(prefix);
        public String LookupPrefix(String namespaceUri) => WrappedObject.LookupPrefix(namespaceUri);
        public void Normalize() => WrappedObject.Normalize();
        public INode RemoveChild(INode child) => WrappedObject.RemoveChild(child);
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.RemoveEventListener(type, callback, capture);
        public INode ReplaceChild(INode newChild, INode oldChild) => WrappedObject.ReplaceChild(newChild, oldChild);
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedObject.ToHtml(writer, formatter);
        #endregion
    }
}
