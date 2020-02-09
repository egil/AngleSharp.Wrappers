using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using AngleSharp.Svg.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="ISvgDescriptionElement"/> type.
    /// </summary>
    public partial class SvgDescriptionElementWrapper : Wrapper<ISvgDescriptionElement>, ISvgDescriptionElement, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="SvgDescriptionElementWrapper"/> type;
        /// </summary>
        internal SvgDescriptionElementWrapper(WrapperFactory factory, ISvgDescriptionElement initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public IElement AssignedSlot { get => GetOrWrap(() => WrappedObject.AssignedSlot); }

        /// <inheritdoc/>
        public INamedNodeMap Attributes { get => GetOrWrap(() => WrappedObject.Attributes); }

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
        public ITokenList ClassList { get => GetOrWrap(() => WrappedObject.ClassList); }

        /// <inheritdoc/>
        public String ClassName { get => WrappedObject.ClassName; set => WrappedObject.ClassName = value;}

        /// <inheritdoc/>
        public INode FirstChild { get => GetOrWrap(() => WrappedObject.FirstChild); }

        /// <inheritdoc/>
        public IElement FirstElementChild { get => GetOrWrap(() => WrappedObject.FirstElementChild); }

        /// <inheritdoc/>
        public NodeFlags Flags { get => WrappedObject.Flags; }

        /// <inheritdoc/>
        public Boolean HasChildNodes { get => WrappedObject.HasChildNodes; }

        /// <inheritdoc/>
        public String Id { get => WrappedObject.Id; set => WrappedObject.Id = value;}

        /// <inheritdoc/>
        public String InnerHtml { get => WrappedObject.InnerHtml; set => WrappedObject.InnerHtml = value;}

        /// <inheritdoc/>
        public Boolean IsFocused { get => WrappedObject.IsFocused; }

        /// <inheritdoc/>
        public INode LastChild { get => GetOrWrap(() => WrappedObject.LastChild); }

        /// <inheritdoc/>
        public IElement LastElementChild { get => GetOrWrap(() => WrappedObject.LastElementChild); }

        /// <inheritdoc/>
        public String LocalName { get => WrappedObject.LocalName; }

        /// <inheritdoc/>
        public String NamespaceUri { get => WrappedObject.NamespaceUri; }

        /// <inheritdoc/>
        public IElement NextElementSibling { get => GetOrWrap(() => WrappedObject.NextElementSibling); }

        /// <inheritdoc/>
        public INode NextSibling { get => GetOrWrap(() => WrappedObject.NextSibling); }

        /// <inheritdoc/>
        public String NodeName { get => WrappedObject.NodeName; }

        /// <inheritdoc/>
        public NodeType NodeType { get => WrappedObject.NodeType; }

        /// <inheritdoc/>
        public String NodeValue { get => WrappedObject.NodeValue; set => WrappedObject.NodeValue = value;}

        /// <inheritdoc/>
        public String OuterHtml { get => WrappedObject.OuterHtml; set => WrappedObject.OuterHtml = value;}

        /// <inheritdoc/>
        public IDocument Owner { get => GetOrWrap(() => WrappedObject.Owner); }

        /// <inheritdoc/>
        public INode Parent { get => GetOrWrap(() => WrappedObject.Parent); }

        /// <inheritdoc/>
        public IElement ParentElement { get => GetOrWrap(() => WrappedObject.ParentElement); }

        /// <inheritdoc/>
        public String Prefix { get => WrappedObject.Prefix; }

        /// <inheritdoc/>
        public IElement PreviousElementSibling { get => GetOrWrap(() => WrappedObject.PreviousElementSibling); }

        /// <inheritdoc/>
        public INode PreviousSibling { get => GetOrWrap(() => WrappedObject.PreviousSibling); }

        /// <inheritdoc/>
        public IShadowRoot ShadowRoot { get => GetOrWrap(() => WrappedObject.ShadowRoot); }

        /// <inheritdoc/>
        public String Slot { get => WrappedObject.Slot; set => WrappedObject.Slot = value;}

        /// <inheritdoc/>
        public ISourceReference SourceReference { get => WrappedObject.SourceReference; }

        /// <inheritdoc/>
        public String TagName { get => WrappedObject.TagName; }

        /// <inheritdoc/>
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}

        /// <inheritdoc/>
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture)
            => WrappedObject.AddEventListener(type, callback, capture);

        /// <inheritdoc/>
        public void After(INode[] nodes)
            => WrappedObject.After(nodes);

        /// <inheritdoc/>
        public void Append(INode[] nodes)
            => WrappedObject.Append(nodes);

        /// <inheritdoc/>
        public INode AppendChild(INode child)
            => GetOrWrap(() => WrappedObject.AppendChild(child));

        /// <inheritdoc/>
        public IShadowRoot AttachShadow(ShadowRootMode mode)
            => GetOrWrap(() => WrappedObject.AttachShadow(mode));

        /// <inheritdoc/>
        public void Before(INode[] nodes)
            => WrappedObject.Before(nodes);

        /// <inheritdoc/>
        public INode Clone(Boolean deep)
            => GetOrWrap(() => WrappedObject.Clone(deep));

        /// <inheritdoc/>
        public IElement Closest(String selectors)
            => GetOrWrap(() => WrappedObject.Closest(selectors));

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
        public String GetAttribute(String name)
            => WrappedObject.GetAttribute(name);

        /// <inheritdoc/>
        public String GetAttribute(String namespaceUri, String localName)
            => WrappedObject.GetAttribute(namespaceUri, localName);

        /// <inheritdoc/>
        public IHtmlCollection<IElement> GetElementsByClassName(String classNames)
            => GetOrWrap(() => WrappedObject.GetElementsByClassName(classNames));

        /// <inheritdoc/>
        public IHtmlCollection<IElement> GetElementsByTagName(String tagName)
            => GetOrWrap(() => WrappedObject.GetElementsByTagName(tagName));

        /// <inheritdoc/>
        public IHtmlCollection<IElement> GetElementsByTagNameNS(String namespaceUri, String tagName)
            => GetOrWrap(() => WrappedObject.GetElementsByTagNameNS(namespaceUri, tagName));

        /// <inheritdoc/>
        public Boolean HasAttribute(String name)
            => WrappedObject.HasAttribute(name);

        /// <inheritdoc/>
        public Boolean HasAttribute(String namespaceUri, String localName)
            => WrappedObject.HasAttribute(namespaceUri, localName);

        /// <inheritdoc/>
        public void Insert(AdjacentPosition position, String html)
            => WrappedObject.Insert(position, html);

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
        public Boolean Matches(String selectors)
            => WrappedObject.Matches(selectors);

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
        public void Remove()
            => WrappedObject.Remove();

        /// <inheritdoc/>
        public Boolean RemoveAttribute(String name)
            => WrappedObject.RemoveAttribute(name);

        /// <inheritdoc/>
        public Boolean RemoveAttribute(String namespaceUri, String localName)
            => WrappedObject.RemoveAttribute(namespaceUri, localName);

        /// <inheritdoc/>
        public INode RemoveChild(INode child)
            => GetOrWrap(() => WrappedObject.RemoveChild(child));

        /// <inheritdoc/>
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture)
            => WrappedObject.RemoveEventListener(type, callback, capture);

        /// <inheritdoc/>
        public void Replace(INode[] nodes)
            => WrappedObject.Replace(nodes);

        /// <inheritdoc/>
        public INode ReplaceChild(INode newChild, INode oldChild)
            => GetOrWrap(() => WrappedObject.ReplaceChild(newChild, oldChild));

        /// <inheritdoc/>
        public void SetAttribute(String name, String value)
            => WrappedObject.SetAttribute(name, value);

        /// <inheritdoc/>
        public void SetAttribute(String namespaceUri, String name, String value)
            => WrappedObject.SetAttribute(namespaceUri, name, value);

        /// <inheritdoc/>
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter)
            => WrappedObject.ToHtml(writer, formatter);
    }
}
