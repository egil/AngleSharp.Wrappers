using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IText"/> type.
    /// </summary>
    public partial class TextWrapper : Wrapper<IText>, IText, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="TextWrapper"/> type;
        /// </summary>
        internal TextWrapper(WrapperFactory factory, IText initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public IElement AssignedSlot { get => GetOrWrap(() => WrappedObject.AssignedSlot); }

        /// <inheritdoc/>
        public String BaseUri { get => WrappedObject.BaseUri; }

        /// <inheritdoc/>
        public Url BaseUrl { get => WrappedObject.BaseUrl; }

        /// <inheritdoc/>
        public INodeList ChildNodes { get => GetOrWrap(() => WrappedObject.ChildNodes); }

        /// <inheritdoc/>
        public String Data { get => WrappedObject.Data; set => WrappedObject.Data = value;}

        /// <inheritdoc/>
        public INode FirstChild { get => GetOrWrap(() => WrappedObject.FirstChild); }

        /// <inheritdoc/>
        public NodeFlags Flags { get => WrappedObject.Flags; }

        /// <inheritdoc/>
        public Boolean HasChildNodes { get => WrappedObject.HasChildNodes; }

        /// <inheritdoc/>
        public INode LastChild { get => GetOrWrap(() => WrappedObject.LastChild); }

        /// <inheritdoc/>
        public Int32 Length { get => WrappedObject.Length; }

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
        public IDocument Owner { get => GetOrWrap(() => WrappedObject.Owner); }

        /// <inheritdoc/>
        public INode Parent { get => GetOrWrap(() => WrappedObject.Parent); }

        /// <inheritdoc/>
        public IElement ParentElement { get => GetOrWrap(() => WrappedObject.ParentElement); }

        /// <inheritdoc/>
        public IElement PreviousElementSibling { get => GetOrWrap(() => WrappedObject.PreviousElementSibling); }

        /// <inheritdoc/>
        public INode PreviousSibling { get => GetOrWrap(() => WrappedObject.PreviousSibling); }

        /// <inheritdoc/>
        public String Text { get => WrappedObject.Text; }

        /// <inheritdoc/>
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}

        /// <inheritdoc/>
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture)
            => WrappedObject.AddEventListener(type, callback, capture);

        /// <inheritdoc/>
        public void After(INode[] nodes)
            => WrappedObject.After(nodes);

        /// <inheritdoc/>
        public void Append(String value)
            => WrappedObject.Append(value);

        /// <inheritdoc/>
        public INode AppendChild(INode child)
            => GetOrWrap(() => WrappedObject.AppendChild(child));

        /// <inheritdoc/>
        public void Before(INode[] nodes)
            => WrappedObject.Before(nodes);

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
        public void Delete(Int32 offset, Int32 count)
            => WrappedObject.Delete(offset, count);

        /// <inheritdoc/>
        public Boolean Dispatch(Event ev)
            => WrappedObject.Dispatch(ev);

        /// <inheritdoc/>
        public Boolean Equals(INode otherNode)
            => WrappedObject.Equals(otherNode);

        /// <inheritdoc/>
        public void Insert(Int32 offset, String value)
            => WrappedObject.Insert(offset, value);

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
        public void Remove()
            => WrappedObject.Remove();

        /// <inheritdoc/>
        public INode RemoveChild(INode child)
            => GetOrWrap(() => WrappedObject.RemoveChild(child));

        /// <inheritdoc/>
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture)
            => WrappedObject.RemoveEventListener(type, callback, capture);

        /// <inheritdoc/>
        public void Replace(Int32 offset, Int32 count, String value)
            => WrappedObject.Replace(offset, count, value);

        /// <inheritdoc/>
        public void Replace(INode[] nodes)
            => WrappedObject.Replace(nodes);

        /// <inheritdoc/>
        public INode ReplaceChild(INode newChild, INode oldChild)
            => GetOrWrap(() => WrappedObject.ReplaceChild(newChild, oldChild));

        /// <inheritdoc/>
        public IText Split(Int32 offset)
            => GetOrWrap(() => WrappedObject.Split(offset));

        /// <inheritdoc/>
        public String Substring(Int32 offset, Int32 count)
            => WrappedObject.Substring(offset, count);

        /// <inheritdoc/>
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter)
            => WrappedObject.ToHtml(writer, formatter);
    }
}
