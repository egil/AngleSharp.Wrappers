using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using AngleSharp.Html.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IHtmlElement"/> type.
    /// </summary>
    public partial class HtmlElementWrapper : Wrapper<IHtmlElement>, IHtmlElement, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="HtmlElementWrapper"/> type;
        /// </summary>
        internal HtmlElementWrapper(WrapperFactory factory, IHtmlElement initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public event DomEventHandler Aborted { add => WrappedObject.Aborted += value; remove => WrappedObject.Aborted -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Blurred { add => WrappedObject.Blurred += value; remove => WrappedObject.Blurred -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Cancelled { add => WrappedObject.Cancelled += value; remove => WrappedObject.Cancelled -= value; }

        /// <inheritdoc/>
        public event DomEventHandler CanPlay { add => WrappedObject.CanPlay += value; remove => WrappedObject.CanPlay -= value; }

        /// <inheritdoc/>
        public event DomEventHandler CanPlayThrough { add => WrappedObject.CanPlayThrough += value; remove => WrappedObject.CanPlayThrough -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Changed { add => WrappedObject.Changed += value; remove => WrappedObject.Changed -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Clicked { add => WrappedObject.Clicked += value; remove => WrappedObject.Clicked -= value; }

        /// <inheritdoc/>
        public event DomEventHandler CueChanged { add => WrappedObject.CueChanged += value; remove => WrappedObject.CueChanged -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DoubleClick { add => WrappedObject.DoubleClick += value; remove => WrappedObject.DoubleClick -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Drag { add => WrappedObject.Drag += value; remove => WrappedObject.Drag -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragEnd { add => WrappedObject.DragEnd += value; remove => WrappedObject.DragEnd -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragEnter { add => WrappedObject.DragEnter += value; remove => WrappedObject.DragEnter -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragExit { add => WrappedObject.DragExit += value; remove => WrappedObject.DragExit -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragLeave { add => WrappedObject.DragLeave += value; remove => WrappedObject.DragLeave -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragOver { add => WrappedObject.DragOver += value; remove => WrappedObject.DragOver -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragStart { add => WrappedObject.DragStart += value; remove => WrappedObject.DragStart -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Dropped { add => WrappedObject.Dropped += value; remove => WrappedObject.Dropped -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DurationChanged { add => WrappedObject.DurationChanged += value; remove => WrappedObject.DurationChanged -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Emptied { add => WrappedObject.Emptied += value; remove => WrappedObject.Emptied -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Ended { add => WrappedObject.Ended += value; remove => WrappedObject.Ended -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Error { add => WrappedObject.Error += value; remove => WrappedObject.Error -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Focused { add => WrappedObject.Focused += value; remove => WrappedObject.Focused -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Input { add => WrappedObject.Input += value; remove => WrappedObject.Input -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Invalid { add => WrappedObject.Invalid += value; remove => WrappedObject.Invalid -= value; }

        /// <inheritdoc/>
        public event DomEventHandler KeyDown { add => WrappedObject.KeyDown += value; remove => WrappedObject.KeyDown -= value; }

        /// <inheritdoc/>
        public event DomEventHandler KeyPress { add => WrappedObject.KeyPress += value; remove => WrappedObject.KeyPress -= value; }

        /// <inheritdoc/>
        public event DomEventHandler KeyUp { add => WrappedObject.KeyUp += value; remove => WrappedObject.KeyUp -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Loaded { add => WrappedObject.Loaded += value; remove => WrappedObject.Loaded -= value; }

        /// <inheritdoc/>
        public event DomEventHandler LoadedData { add => WrappedObject.LoadedData += value; remove => WrappedObject.LoadedData -= value; }

        /// <inheritdoc/>
        public event DomEventHandler LoadedMetadata { add => WrappedObject.LoadedMetadata += value; remove => WrappedObject.LoadedMetadata -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Loading { add => WrappedObject.Loading += value; remove => WrappedObject.Loading -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseDown { add => WrappedObject.MouseDown += value; remove => WrappedObject.MouseDown -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseEnter { add => WrappedObject.MouseEnter += value; remove => WrappedObject.MouseEnter -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseLeave { add => WrappedObject.MouseLeave += value; remove => WrappedObject.MouseLeave -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseMove { add => WrappedObject.MouseMove += value; remove => WrappedObject.MouseMove -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseOut { add => WrappedObject.MouseOut += value; remove => WrappedObject.MouseOut -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseOver { add => WrappedObject.MouseOver += value; remove => WrappedObject.MouseOver -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseUp { add => WrappedObject.MouseUp += value; remove => WrappedObject.MouseUp -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseWheel { add => WrappedObject.MouseWheel += value; remove => WrappedObject.MouseWheel -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Paused { add => WrappedObject.Paused += value; remove => WrappedObject.Paused -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Played { add => WrappedObject.Played += value; remove => WrappedObject.Played -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Playing { add => WrappedObject.Playing += value; remove => WrappedObject.Playing -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Progress { add => WrappedObject.Progress += value; remove => WrappedObject.Progress -= value; }

        /// <inheritdoc/>
        public event DomEventHandler RateChanged { add => WrappedObject.RateChanged += value; remove => WrappedObject.RateChanged -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Resetted { add => WrappedObject.Resetted += value; remove => WrappedObject.Resetted -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Resized { add => WrappedObject.Resized += value; remove => WrappedObject.Resized -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Scrolled { add => WrappedObject.Scrolled += value; remove => WrappedObject.Scrolled -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Seeked { add => WrappedObject.Seeked += value; remove => WrappedObject.Seeked -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Seeking { add => WrappedObject.Seeking += value; remove => WrappedObject.Seeking -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Selected { add => WrappedObject.Selected += value; remove => WrappedObject.Selected -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Shown { add => WrappedObject.Shown += value; remove => WrappedObject.Shown -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Stalled { add => WrappedObject.Stalled += value; remove => WrappedObject.Stalled -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Submitted { add => WrappedObject.Submitted += value; remove => WrappedObject.Submitted -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Suspended { add => WrappedObject.Suspended += value; remove => WrappedObject.Suspended -= value; }

        /// <inheritdoc/>
        public event DomEventHandler TimeUpdated { add => WrappedObject.TimeUpdated += value; remove => WrappedObject.TimeUpdated -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Toggled { add => WrappedObject.Toggled += value; remove => WrappedObject.Toggled -= value; }

        /// <inheritdoc/>
        public event DomEventHandler VolumeChanged { add => WrappedObject.VolumeChanged += value; remove => WrappedObject.VolumeChanged -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Waiting { add => WrappedObject.Waiting += value; remove => WrappedObject.Waiting -= value; }

        /// <inheritdoc/>
        public String AccessKey { get => WrappedObject.AccessKey; set => WrappedObject.AccessKey = value;}

        /// <inheritdoc/>
        public String AccessKeyLabel { get => WrappedObject.AccessKeyLabel; }

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
        public String ContentEditable { get => WrappedObject.ContentEditable; set => WrappedObject.ContentEditable = value;}

        /// <inheritdoc/>
        public IHtmlMenuElement ContextMenu { get => GetOrWrap(() => WrappedObject.ContextMenu); set => WrappedObject.ContextMenu = value;}

        /// <inheritdoc/>
        public IStringMap Dataset { get => GetOrWrap(() => WrappedObject.Dataset); }

        /// <inheritdoc/>
        public String Direction { get => WrappedObject.Direction; set => WrappedObject.Direction = value;}

        /// <inheritdoc/>
        public ISettableTokenList DropZone { get => GetOrWrap(() => WrappedObject.DropZone); }

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
        public Boolean IsContentEditable { get => WrappedObject.IsContentEditable; }

        /// <inheritdoc/>
        public Boolean IsDraggable { get => WrappedObject.IsDraggable; set => WrappedObject.IsDraggable = value;}

        /// <inheritdoc/>
        public Boolean IsFocused { get => WrappedObject.IsFocused; }

        /// <inheritdoc/>
        public Boolean IsHidden { get => WrappedObject.IsHidden; set => WrappedObject.IsHidden = value;}

        /// <inheritdoc/>
        public Boolean IsSpellChecked { get => WrappedObject.IsSpellChecked; set => WrappedObject.IsSpellChecked = value;}

        /// <inheritdoc/>
        public Boolean IsTranslated { get => WrappedObject.IsTranslated; set => WrappedObject.IsTranslated = value;}

        /// <inheritdoc/>
        public String Language { get => WrappedObject.Language; set => WrappedObject.Language = value;}

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
        public Int32 TabIndex { get => WrappedObject.TabIndex; set => WrappedObject.TabIndex = value;}

        /// <inheritdoc/>
        public String TagName { get => WrappedObject.TagName; }

        /// <inheritdoc/>
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}

        /// <inheritdoc/>
        public String Title { get => WrappedObject.Title; set => WrappedObject.Title = value;}

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
        public void DoBlur()
            => WrappedObject.DoBlur();

        /// <inheritdoc/>
        public void DoClick()
            => WrappedObject.DoClick();

        /// <inheritdoc/>
        public void DoFocus()
            => WrappedObject.DoFocus();

        /// <inheritdoc/>
        public void DoSpellCheck()
            => WrappedObject.DoSpellCheck();

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