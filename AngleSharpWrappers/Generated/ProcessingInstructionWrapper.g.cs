using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="IProcessingInstruction"/> type.
    /// </summary>
    internal sealed class ProcessingInstructionWrapper : Wrapper<IProcessingInstruction>, IProcessingInstruction, IWrapper<IProcessingInstruction>
    {
        private INodeList? _childNodes;
        private INode? _firstChild;
        private INode? _lastChild;
        private IElement? _nextElementSibling;
        private INode? _nextSibling;
        private IDocument? _owner;
        private INode? _parent;
        private IElement? _parentElement;
        private IElement? _previousElementSibling;
        private INode? _previousSibling;

        /// <summary>
        /// Creates an instance of the <see cref="ProcessingInstructionWrapper"/> type;
        /// </summary>
        internal ProcessingInstructionWrapper(WrapperFactory factory, IProcessingInstruction initialObject, Func<object?> query) : base(factory, initialObject, query) { }

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
        public String Data { get => WrappedObject.Data; set => WrappedObject.Data = value;}
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
        public Int32 Length { get => WrappedObject.Length; }
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
        public String Target { get => WrappedObject.Target; }
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}
        #endregion

        #region Methods
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.AddEventListener(type, callback, capture);
        public void After(INode[] nodes) => WrappedObject.After(nodes);
        public void Append(String value) => WrappedObject.Append(value);
        public INode AppendChild(INode child) => WrappedObject.AppendChild(child);
        public void Before(INode[] nodes) => WrappedObject.Before(nodes);
        public INode Clone(Boolean deep) => WrappedObject.Clone(deep);
        public DocumentPositions CompareDocumentPosition(INode otherNode) => WrappedObject.CompareDocumentPosition(otherNode);
        public Boolean Contains(INode otherNode) => WrappedObject.Contains(otherNode);
        public void Delete(Int32 offset, Int32 count) => WrappedObject.Delete(offset, count);
        public Boolean Dispatch(Event ev) => WrappedObject.Dispatch(ev);
        public Boolean Equals(INode otherNode) => WrappedObject.Equals(otherNode);
        public void Insert(Int32 offset, String value) => WrappedObject.Insert(offset, value);
        public INode InsertBefore(INode newElement, INode referenceElement) => WrappedObject.InsertBefore(newElement, referenceElement);
        public void InvokeEventListener(Event ev) => WrappedObject.InvokeEventListener(ev);
        public Boolean IsDefaultNamespace(String namespaceUri) => WrappedObject.IsDefaultNamespace(namespaceUri);
        public String LookupNamespaceUri(String prefix) => WrappedObject.LookupNamespaceUri(prefix);
        public String LookupPrefix(String namespaceUri) => WrappedObject.LookupPrefix(namespaceUri);
        public void Normalize() => WrappedObject.Normalize();
        public void Remove() => WrappedObject.Remove();
        public INode RemoveChild(INode child) => WrappedObject.RemoveChild(child);
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.RemoveEventListener(type, callback, capture);
        public void Replace(Int32 offset, Int32 count, String value) => WrappedObject.Replace(offset, count, value);
        public void Replace(INode[] nodes) => WrappedObject.Replace(nodes);
        public INode ReplaceChild(INode newChild, INode oldChild) => WrappedObject.ReplaceChild(newChild, oldChild);
        public String Substring(Int32 offset, Int32 count) => WrappedObject.Substring(offset, count);
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedObject.ToHtml(writer, formatter);
        #endregion
    }
}
