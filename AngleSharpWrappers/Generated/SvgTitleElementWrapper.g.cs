using System;
using System.Diagnostics;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using AngleSharp.Svg.Dom;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="ISvgTitleElement"/> type.
    /// </summary>
    [DebuggerDisplay("{OuterHtml,nq}")]
    public sealed class SvgTitleElementWrapper : Wrapper<ISvgTitleElement>, ISvgTitleElement
    {
        /// <summary>
        /// Creates an instance of the <see cref="SvgTitleElementWrapper"/> type;
        /// </summary>
        public SvgTitleElementWrapper(IElementFactory<ISvgTitleElement> elementFactory) : base(elementFactory) { }

        #region Properties and indexers
        [DebuggerHidden]
        public IElement AssignedSlot { get => WrappedElement.AssignedSlot; }
        [DebuggerHidden]
        public INamedNodeMap Attributes { get => WrappedElement.Attributes; }
        [DebuggerHidden]
        public String BaseUri { get => WrappedElement.BaseUri; }
        [DebuggerHidden]
        public Url BaseUrl { get => WrappedElement.BaseUrl; }
        [DebuggerHidden]
        public Int32 ChildElementCount { get => WrappedElement.ChildElementCount; }
        [DebuggerHidden]
        public INodeList ChildNodes { get => WrappedElement.ChildNodes; }
        [DebuggerHidden]
        public IHtmlCollection<IElement> Children { get => WrappedElement.Children; }
        [DebuggerHidden]
        public ITokenList ClassList { get => WrappedElement.ClassList; }
        [DebuggerHidden]
        public String ClassName { get => WrappedElement.ClassName; set => WrappedElement.ClassName = value;}
        [DebuggerHidden]
        public INode FirstChild { get => WrappedElement.FirstChild; }
        [DebuggerHidden]
        public IElement FirstElementChild { get => WrappedElement.FirstElementChild; }
        [DebuggerHidden]
        public NodeFlags Flags { get => WrappedElement.Flags; }
        [DebuggerHidden]
        public Boolean HasChildNodes { get => WrappedElement.HasChildNodes; }
        [DebuggerHidden]
        public String Id { get => WrappedElement.Id; set => WrappedElement.Id = value;}
        [DebuggerHidden]
        public String InnerHtml { get => WrappedElement.InnerHtml; set => WrappedElement.InnerHtml = value;}
        [DebuggerHidden]
        public Boolean IsFocused { get => WrappedElement.IsFocused; }
        [DebuggerHidden]
        public INode LastChild { get => WrappedElement.LastChild; }
        [DebuggerHidden]
        public IElement LastElementChild { get => WrappedElement.LastElementChild; }
        [DebuggerHidden]
        public String LocalName { get => WrappedElement.LocalName; }
        [DebuggerHidden]
        public String NamespaceUri { get => WrappedElement.NamespaceUri; }
        [DebuggerHidden]
        public IElement NextElementSibling { get => WrappedElement.NextElementSibling; }
        [DebuggerHidden]
        public INode NextSibling { get => WrappedElement.NextSibling; }
        [DebuggerHidden]
        public String NodeName { get => WrappedElement.NodeName; }
        [DebuggerHidden]
        public NodeType NodeType { get => WrappedElement.NodeType; }
        [DebuggerHidden]
        public String NodeValue { get => WrappedElement.NodeValue; set => WrappedElement.NodeValue = value;}
        [DebuggerHidden]
        public String OuterHtml { get => WrappedElement.OuterHtml; set => WrappedElement.OuterHtml = value;}
        [DebuggerHidden]
        public IDocument Owner { get => WrappedElement.Owner; }
        [DebuggerHidden]
        public INode Parent { get => WrappedElement.Parent; }
        [DebuggerHidden]
        public IElement ParentElement { get => WrappedElement.ParentElement; }
        [DebuggerHidden]
        public String Prefix { get => WrappedElement.Prefix; }
        [DebuggerHidden]
        public IElement PreviousElementSibling { get => WrappedElement.PreviousElementSibling; }
        [DebuggerHidden]
        public INode PreviousSibling { get => WrappedElement.PreviousSibling; }
        [DebuggerHidden]
        public IShadowRoot ShadowRoot { get => WrappedElement.ShadowRoot; }
        [DebuggerHidden]
        public String Slot { get => WrappedElement.Slot; set => WrappedElement.Slot = value;}
        [DebuggerHidden]
        public ISourceReference SourceReference { get => WrappedElement.SourceReference; }
        [DebuggerHidden]
        public String TagName { get => WrappedElement.TagName; }
        [DebuggerHidden]
        public String TextContent { get => WrappedElement.TextContent; set => WrappedElement.TextContent = value;}
        #endregion

        #region Methods
        [DebuggerHidden]
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedElement.AddEventListener(type, callback, capture);
        [DebuggerHidden]
        public void After(INode[] nodes) => WrappedElement.After(nodes);
        [DebuggerHidden]
        public void Append(INode[] nodes) => WrappedElement.Append(nodes);
        [DebuggerHidden]
        public INode AppendChild(INode child) => WrappedElement.AppendChild(child);
        [DebuggerHidden]
        public IShadowRoot AttachShadow(ShadowRootMode mode) => WrappedElement.AttachShadow(mode);
        [DebuggerHidden]
        public void Before(INode[] nodes) => WrappedElement.Before(nodes);
        [DebuggerHidden]
        public INode Clone(Boolean deep) => WrappedElement.Clone(deep);
        [DebuggerHidden]
        public IElement Closest(String selectors) => WrappedElement.Closest(selectors);
        [DebuggerHidden]
        public DocumentPositions CompareDocumentPosition(INode otherNode) => WrappedElement.CompareDocumentPosition(otherNode);
        [DebuggerHidden]
        public Boolean Contains(INode otherNode) => WrappedElement.Contains(otherNode);
        [DebuggerHidden]
        public Boolean Dispatch(Event ev) => WrappedElement.Dispatch(ev);
        [DebuggerHidden]
        public Boolean Equals(INode otherNode) => WrappedElement.Equals(otherNode);
        [DebuggerHidden]
        public String GetAttribute(String name) => WrappedElement.GetAttribute(name);
        [DebuggerHidden]
        public String GetAttribute(String namespaceUri, String localName) => WrappedElement.GetAttribute(namespaceUri, localName);
        [DebuggerHidden]
        public IHtmlCollection<IElement> GetElementsByClassName(String classNames) => WrappedElement.GetElementsByClassName(classNames);
        [DebuggerHidden]
        public IHtmlCollection<IElement> GetElementsByTagName(String tagName) => WrappedElement.GetElementsByTagName(tagName);
        [DebuggerHidden]
        public IHtmlCollection<IElement> GetElementsByTagNameNS(String namespaceUri, String tagName) => WrappedElement.GetElementsByTagNameNS(namespaceUri, tagName);
        [DebuggerHidden]
        public Boolean HasAttribute(String name) => WrappedElement.HasAttribute(name);
        [DebuggerHidden]
        public Boolean HasAttribute(String namespaceUri, String localName) => WrappedElement.HasAttribute(namespaceUri, localName);
        [DebuggerHidden]
        public void Insert(AdjacentPosition position, String html) => WrappedElement.Insert(position, html);
        [DebuggerHidden]
        public INode InsertBefore(INode newElement, INode referenceElement) => WrappedElement.InsertBefore(newElement, referenceElement);
        [DebuggerHidden]
        public void InvokeEventListener(Event ev) => WrappedElement.InvokeEventListener(ev);
        [DebuggerHidden]
        public Boolean IsDefaultNamespace(String namespaceUri) => WrappedElement.IsDefaultNamespace(namespaceUri);
        [DebuggerHidden]
        public String LookupNamespaceUri(String prefix) => WrappedElement.LookupNamespaceUri(prefix);
        [DebuggerHidden]
        public String LookupPrefix(String namespaceUri) => WrappedElement.LookupPrefix(namespaceUri);
        [DebuggerHidden]
        public Boolean Matches(String selectors) => WrappedElement.Matches(selectors);
        [DebuggerHidden]
        public void Normalize() => WrappedElement.Normalize();
        [DebuggerHidden]
        public void Prepend(INode[] nodes) => WrappedElement.Prepend(nodes);
        [DebuggerHidden]
        public IElement QuerySelector(String selectors) => WrappedElement.QuerySelector(selectors);
        [DebuggerHidden]
        public IHtmlCollection<IElement> QuerySelectorAll(String selectors) => WrappedElement.QuerySelectorAll(selectors);
        [DebuggerHidden]
        public void Remove() => WrappedElement.Remove();
        [DebuggerHidden]
        public Boolean RemoveAttribute(String name) => WrappedElement.RemoveAttribute(name);
        [DebuggerHidden]
        public Boolean RemoveAttribute(String namespaceUri, String localName) => WrappedElement.RemoveAttribute(namespaceUri, localName);
        [DebuggerHidden]
        public INode RemoveChild(INode child) => WrappedElement.RemoveChild(child);
        [DebuggerHidden]
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedElement.RemoveEventListener(type, callback, capture);
        [DebuggerHidden]
        public void Replace(INode[] nodes) => WrappedElement.Replace(nodes);
        [DebuggerHidden]
        public INode ReplaceChild(INode newChild, INode oldChild) => WrappedElement.ReplaceChild(newChild, oldChild);
        [DebuggerHidden]
        public void SetAttribute(String name, String value) => WrappedElement.SetAttribute(name, value);
        [DebuggerHidden]
        public void SetAttribute(String namespaceUri, String name, String value) => WrappedElement.SetAttribute(namespaceUri, name, value);
        [DebuggerHidden]
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedElement.ToHtml(writer, formatter);
        #endregion
    }
}
