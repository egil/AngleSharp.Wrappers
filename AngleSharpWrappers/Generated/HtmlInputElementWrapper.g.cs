using System;
using System.Diagnostics;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using AngleSharp.Html.Dom;
using AngleSharp.Io.Dom;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="IHtmlInputElement"/> type.
    /// </summary>
    [DebuggerDisplay("{OuterHtml,nq}")]
    public sealed class HtmlInputElementWrapper : Wrapper<IHtmlInputElement>, IHtmlInputElement
    {
        /// <summary>
        /// Creates an instance of the <see cref="HtmlInputElementWrapper"/> type;
        /// </summary>
        public HtmlInputElementWrapper(IElementFactory<IHtmlInputElement> elementFactory) : base(elementFactory) { }

        #region Events
        public event DomEventHandler Aborted { add => WrappedElement.Aborted += value; remove => WrappedElement.Aborted -= value; }
        public event DomEventHandler Blurred { add => WrappedElement.Blurred += value; remove => WrappedElement.Blurred -= value; }
        public event DomEventHandler Cancelled { add => WrappedElement.Cancelled += value; remove => WrappedElement.Cancelled -= value; }
        public event DomEventHandler CanPlay { add => WrappedElement.CanPlay += value; remove => WrappedElement.CanPlay -= value; }
        public event DomEventHandler CanPlayThrough { add => WrappedElement.CanPlayThrough += value; remove => WrappedElement.CanPlayThrough -= value; }
        public event DomEventHandler Changed { add => WrappedElement.Changed += value; remove => WrappedElement.Changed -= value; }
        public event DomEventHandler Clicked { add => WrappedElement.Clicked += value; remove => WrappedElement.Clicked -= value; }
        public event DomEventHandler CueChanged { add => WrappedElement.CueChanged += value; remove => WrappedElement.CueChanged -= value; }
        public event DomEventHandler DoubleClick { add => WrappedElement.DoubleClick += value; remove => WrappedElement.DoubleClick -= value; }
        public event DomEventHandler Drag { add => WrappedElement.Drag += value; remove => WrappedElement.Drag -= value; }
        public event DomEventHandler DragEnd { add => WrappedElement.DragEnd += value; remove => WrappedElement.DragEnd -= value; }
        public event DomEventHandler DragEnter { add => WrappedElement.DragEnter += value; remove => WrappedElement.DragEnter -= value; }
        public event DomEventHandler DragExit { add => WrappedElement.DragExit += value; remove => WrappedElement.DragExit -= value; }
        public event DomEventHandler DragLeave { add => WrappedElement.DragLeave += value; remove => WrappedElement.DragLeave -= value; }
        public event DomEventHandler DragOver { add => WrappedElement.DragOver += value; remove => WrappedElement.DragOver -= value; }
        public event DomEventHandler DragStart { add => WrappedElement.DragStart += value; remove => WrappedElement.DragStart -= value; }
        public event DomEventHandler Dropped { add => WrappedElement.Dropped += value; remove => WrappedElement.Dropped -= value; }
        public event DomEventHandler DurationChanged { add => WrappedElement.DurationChanged += value; remove => WrappedElement.DurationChanged -= value; }
        public event DomEventHandler Emptied { add => WrappedElement.Emptied += value; remove => WrappedElement.Emptied -= value; }
        public event DomEventHandler Ended { add => WrappedElement.Ended += value; remove => WrappedElement.Ended -= value; }
        public event DomEventHandler Error { add => WrappedElement.Error += value; remove => WrappedElement.Error -= value; }
        public event DomEventHandler Focused { add => WrappedElement.Focused += value; remove => WrappedElement.Focused -= value; }
        public event DomEventHandler Input { add => WrappedElement.Input += value; remove => WrappedElement.Input -= value; }
        public event DomEventHandler Invalid { add => WrappedElement.Invalid += value; remove => WrappedElement.Invalid -= value; }
        public event DomEventHandler KeyDown { add => WrappedElement.KeyDown += value; remove => WrappedElement.KeyDown -= value; }
        public event DomEventHandler KeyPress { add => WrappedElement.KeyPress += value; remove => WrappedElement.KeyPress -= value; }
        public event DomEventHandler KeyUp { add => WrappedElement.KeyUp += value; remove => WrappedElement.KeyUp -= value; }
        public event DomEventHandler Loaded { add => WrappedElement.Loaded += value; remove => WrappedElement.Loaded -= value; }
        public event DomEventHandler LoadedData { add => WrappedElement.LoadedData += value; remove => WrappedElement.LoadedData -= value; }
        public event DomEventHandler LoadedMetadata { add => WrappedElement.LoadedMetadata += value; remove => WrappedElement.LoadedMetadata -= value; }
        public event DomEventHandler Loading { add => WrappedElement.Loading += value; remove => WrappedElement.Loading -= value; }
        public event DomEventHandler MouseDown { add => WrappedElement.MouseDown += value; remove => WrappedElement.MouseDown -= value; }
        public event DomEventHandler MouseEnter { add => WrappedElement.MouseEnter += value; remove => WrappedElement.MouseEnter -= value; }
        public event DomEventHandler MouseLeave { add => WrappedElement.MouseLeave += value; remove => WrappedElement.MouseLeave -= value; }
        public event DomEventHandler MouseMove { add => WrappedElement.MouseMove += value; remove => WrappedElement.MouseMove -= value; }
        public event DomEventHandler MouseOut { add => WrappedElement.MouseOut += value; remove => WrappedElement.MouseOut -= value; }
        public event DomEventHandler MouseOver { add => WrappedElement.MouseOver += value; remove => WrappedElement.MouseOver -= value; }
        public event DomEventHandler MouseUp { add => WrappedElement.MouseUp += value; remove => WrappedElement.MouseUp -= value; }
        public event DomEventHandler MouseWheel { add => WrappedElement.MouseWheel += value; remove => WrappedElement.MouseWheel -= value; }
        public event DomEventHandler Paused { add => WrappedElement.Paused += value; remove => WrappedElement.Paused -= value; }
        public event DomEventHandler Played { add => WrappedElement.Played += value; remove => WrappedElement.Played -= value; }
        public event DomEventHandler Playing { add => WrappedElement.Playing += value; remove => WrappedElement.Playing -= value; }
        public event DomEventHandler Progress { add => WrappedElement.Progress += value; remove => WrappedElement.Progress -= value; }
        public event DomEventHandler RateChanged { add => WrappedElement.RateChanged += value; remove => WrappedElement.RateChanged -= value; }
        public event DomEventHandler Resetted { add => WrappedElement.Resetted += value; remove => WrappedElement.Resetted -= value; }
        public event DomEventHandler Resized { add => WrappedElement.Resized += value; remove => WrappedElement.Resized -= value; }
        public event DomEventHandler Scrolled { add => WrappedElement.Scrolled += value; remove => WrappedElement.Scrolled -= value; }
        public event DomEventHandler Seeked { add => WrappedElement.Seeked += value; remove => WrappedElement.Seeked -= value; }
        public event DomEventHandler Seeking { add => WrappedElement.Seeking += value; remove => WrappedElement.Seeking -= value; }
        public event DomEventHandler Selected { add => WrappedElement.Selected += value; remove => WrappedElement.Selected -= value; }
        public event DomEventHandler Shown { add => WrappedElement.Shown += value; remove => WrappedElement.Shown -= value; }
        public event DomEventHandler Stalled { add => WrappedElement.Stalled += value; remove => WrappedElement.Stalled -= value; }
        public event DomEventHandler Submitted { add => WrappedElement.Submitted += value; remove => WrappedElement.Submitted -= value; }
        public event DomEventHandler Suspended { add => WrappedElement.Suspended += value; remove => WrappedElement.Suspended -= value; }
        public event DomEventHandler TimeUpdated { add => WrappedElement.TimeUpdated += value; remove => WrappedElement.TimeUpdated -= value; }
        public event DomEventHandler Toggled { add => WrappedElement.Toggled += value; remove => WrappedElement.Toggled -= value; }
        public event DomEventHandler VolumeChanged { add => WrappedElement.VolumeChanged += value; remove => WrappedElement.VolumeChanged -= value; }
        public event DomEventHandler Waiting { add => WrappedElement.Waiting += value; remove => WrappedElement.Waiting -= value; }
        #endregion

        #region Properties and indexers
        [DebuggerHidden]
        public String? Accept { get => WrappedElement.Accept; set => WrappedElement.Accept = value;}
        [DebuggerHidden]
        public String? AccessKey { get => WrappedElement.AccessKey; set => WrappedElement.AccessKey = value;}
        [DebuggerHidden]
        public String? AccessKeyLabel { get => WrappedElement.AccessKeyLabel; }
        [DebuggerHidden]
        public String? AlternativeText { get => WrappedElement.AlternativeText; set => WrappedElement.AlternativeText = value;}
        [DebuggerHidden]
        public IElement? AssignedSlot { get => WrappedElement.AssignedSlot; }
        [DebuggerHidden]
        public INamedNodeMap Attributes { get => WrappedElement.Attributes; }
        [DebuggerHidden]
        public String? Autocomplete { get => WrappedElement.Autocomplete; set => WrappedElement.Autocomplete = value;}
        [DebuggerHidden]
        public Boolean Autofocus { get => WrappedElement.Autofocus; set => WrappedElement.Autofocus = value;}
        [DebuggerHidden]
        public String BaseUri { get => WrappedElement.BaseUri; }
        [DebuggerHidden]
        public Url? BaseUrl { get => WrappedElement.BaseUrl; }
        [DebuggerHidden]
        public Int32 ChildElementCount { get => WrappedElement.ChildElementCount; }
        [DebuggerHidden]
        public INodeList ChildNodes { get => WrappedElement.ChildNodes; }
        [DebuggerHidden]
        public IHtmlCollection<IElement> Children { get => WrappedElement.Children; }
        [DebuggerHidden]
        public ITokenList ClassList { get => WrappedElement.ClassList; }
        [DebuggerHidden]
        public String? ClassName { get => WrappedElement.ClassName; set => WrappedElement.ClassName = value;}
        [DebuggerHidden]
        public String? ContentEditable { get => WrappedElement.ContentEditable; set => WrappedElement.ContentEditable = value;}
        [DebuggerHidden]
        public IHtmlMenuElement? ContextMenu { get => WrappedElement.ContextMenu; set => WrappedElement.ContextMenu = value;}
        [DebuggerHidden]
        public IStringMap Dataset { get => WrappedElement.Dataset; }
        [DebuggerHidden]
        public String DefaultValue { get => WrappedElement.DefaultValue; set => WrappedElement.DefaultValue = value;}
        [DebuggerHidden]
        public String? Direction { get => WrappedElement.Direction; set => WrappedElement.Direction = value;}
        [DebuggerHidden]
        public String? DirectionName { get => WrappedElement.DirectionName; set => WrappedElement.DirectionName = value;}
        [DebuggerHidden]
        public Int32 DisplayHeight { get => WrappedElement.DisplayHeight; set => WrappedElement.DisplayHeight = value;}
        [DebuggerHidden]
        public Int32 DisplayWidth { get => WrappedElement.DisplayWidth; set => WrappedElement.DisplayWidth = value;}
        [DebuggerHidden]
        public ISettableTokenList DropZone { get => WrappedElement.DropZone; }
        [DebuggerHidden]
        public IFileList? Files { get => WrappedElement.Files; }
        [DebuggerHidden]
        public INode? FirstChild { get => WrappedElement.FirstChild; }
        [DebuggerHidden]
        public IElement? FirstElementChild { get => WrappedElement.FirstElementChild; }
        [DebuggerHidden]
        public NodeFlags Flags { get => WrappedElement.Flags; }
        [DebuggerHidden]
        public IHtmlFormElement? Form { get => WrappedElement.Form; }
        [DebuggerHidden]
        public String? FormAction { get => WrappedElement.FormAction; set => WrappedElement.FormAction = value;}
        [DebuggerHidden]
        public String FormEncType { get => WrappedElement.FormEncType; set => WrappedElement.FormEncType = value;}
        [DebuggerHidden]
        public String FormMethod { get => WrappedElement.FormMethod; set => WrappedElement.FormMethod = value;}
        [DebuggerHidden]
        public Boolean FormNoValidate { get => WrappedElement.FormNoValidate; set => WrappedElement.FormNoValidate = value;}
        [DebuggerHidden]
        public String? FormTarget { get => WrappedElement.FormTarget; set => WrappedElement.FormTarget = value;}
        [DebuggerHidden]
        public Boolean HasChildNodes { get => WrappedElement.HasChildNodes; }
        [DebuggerHidden]
        public Boolean HasValue { get => WrappedElement.HasValue; }
        [DebuggerHidden]
        public String? Id { get => WrappedElement.Id; set => WrappedElement.Id = value;}
        [DebuggerHidden]
        public String InnerHtml { get => WrappedElement.InnerHtml; set => WrappedElement.InnerHtml = value;}
        [DebuggerHidden]
        public Boolean IsChecked { get => WrappedElement.IsChecked; set => WrappedElement.IsChecked = value;}
        [DebuggerHidden]
        public Boolean IsContentEditable { get => WrappedElement.IsContentEditable; }
        [DebuggerHidden]
        public Boolean IsDefaultChecked { get => WrappedElement.IsDefaultChecked; set => WrappedElement.IsDefaultChecked = value;}
        [DebuggerHidden]
        public Boolean IsDisabled { get => WrappedElement.IsDisabled; set => WrappedElement.IsDisabled = value;}
        [DebuggerHidden]
        public Boolean IsDraggable { get => WrappedElement.IsDraggable; set => WrappedElement.IsDraggable = value;}
        [DebuggerHidden]
        public Boolean IsFocused { get => WrappedElement.IsFocused; }
        [DebuggerHidden]
        public Boolean IsHidden { get => WrappedElement.IsHidden; set => WrappedElement.IsHidden = value;}
        [DebuggerHidden]
        public Boolean IsIndeterminate { get => WrappedElement.IsIndeterminate; set => WrappedElement.IsIndeterminate = value;}
        [DebuggerHidden]
        public Boolean IsMultiple { get => WrappedElement.IsMultiple; set => WrappedElement.IsMultiple = value;}
        [DebuggerHidden]
        public Boolean IsReadOnly { get => WrappedElement.IsReadOnly; set => WrappedElement.IsReadOnly = value;}
        [DebuggerHidden]
        public Boolean IsRequired { get => WrappedElement.IsRequired; set => WrappedElement.IsRequired = value;}
        [DebuggerHidden]
        public Boolean IsSpellChecked { get => WrappedElement.IsSpellChecked; set => WrappedElement.IsSpellChecked = value;}
        [DebuggerHidden]
        public Boolean IsTranslated { get => WrappedElement.IsTranslated; set => WrappedElement.IsTranslated = value;}
        [DebuggerHidden]
        public INodeList Labels { get => WrappedElement.Labels; }
        [DebuggerHidden]
        public String? Language { get => WrappedElement.Language; set => WrappedElement.Language = value;}
        [DebuggerHidden]
        public INode? LastChild { get => WrappedElement.LastChild; }
        [DebuggerHidden]
        public IElement? LastElementChild { get => WrappedElement.LastElementChild; }
        [DebuggerHidden]
        public IHtmlDataListElement? List { get => WrappedElement.List; }
        [DebuggerHidden]
        public String LocalName { get => WrappedElement.LocalName; }
        [DebuggerHidden]
        public String? Maximum { get => WrappedElement.Maximum; set => WrappedElement.Maximum = value;}
        [DebuggerHidden]
        public Int32 MaxLength { get => WrappedElement.MaxLength; set => WrappedElement.MaxLength = value;}
        [DebuggerHidden]
        public String? Minimum { get => WrappedElement.Minimum; set => WrappedElement.Minimum = value;}
        [DebuggerHidden]
        public Int32 MinLength { get => WrappedElement.MinLength; set => WrappedElement.MinLength = value;}
        [DebuggerHidden]
        public String? Name { get => WrappedElement.Name; set => WrappedElement.Name = value;}
        [DebuggerHidden]
        public String? NamespaceUri { get => WrappedElement.NamespaceUri; }
        [DebuggerHidden]
        public IElement? NextElementSibling { get => WrappedElement.NextElementSibling; }
        [DebuggerHidden]
        public INode? NextSibling { get => WrappedElement.NextSibling; }
        [DebuggerHidden]
        public String NodeName { get => WrappedElement.NodeName; }
        [DebuggerHidden]
        public NodeType NodeType { get => WrappedElement.NodeType; }
        [DebuggerHidden]
        public String NodeValue { get => WrappedElement.NodeValue; set => WrappedElement.NodeValue = value;}
        [DebuggerHidden]
        public String OuterHtml { get => WrappedElement.OuterHtml; set => WrappedElement.OuterHtml = value;}
        [DebuggerHidden]
        public IDocument? Owner { get => WrappedElement.Owner; }
        [DebuggerHidden]
        public INode? Parent { get => WrappedElement.Parent; }
        [DebuggerHidden]
        public IElement? ParentElement { get => WrappedElement.ParentElement; }
        [DebuggerHidden]
        public String? Pattern { get => WrappedElement.Pattern; set => WrappedElement.Pattern = value;}
        [DebuggerHidden]
        public String? Placeholder { get => WrappedElement.Placeholder; set => WrappedElement.Placeholder = value;}
        [DebuggerHidden]
        public String? Prefix { get => WrappedElement.Prefix; }
        [DebuggerHidden]
        public IElement? PreviousElementSibling { get => WrappedElement.PreviousElementSibling; }
        [DebuggerHidden]
        public INode? PreviousSibling { get => WrappedElement.PreviousSibling; }
        [DebuggerHidden]
        public String? SelectionDirection { get => WrappedElement.SelectionDirection; }
        [DebuggerHidden]
        public Int32 SelectionEnd { get => WrappedElement.SelectionEnd; set => WrappedElement.SelectionEnd = value;}
        [DebuggerHidden]
        public Int32 SelectionStart { get => WrappedElement.SelectionStart; set => WrappedElement.SelectionStart = value;}
        [DebuggerHidden]
        public IShadowRoot? ShadowRoot { get => WrappedElement.ShadowRoot; }
        [DebuggerHidden]
        public Int32 Size { get => WrappedElement.Size; set => WrappedElement.Size = value;}
        [DebuggerHidden]
        public String? Slot { get => WrappedElement.Slot; set => WrappedElement.Slot = value;}
        [DebuggerHidden]
        public String? Source { get => WrappedElement.Source; set => WrappedElement.Source = value;}
        [DebuggerHidden]
        public ISourceReference? SourceReference { get => WrappedElement.SourceReference; }
        [DebuggerHidden]
        public String? Step { get => WrappedElement.Step; set => WrappedElement.Step = value;}
        [DebuggerHidden]
        public Int32 TabIndex { get => WrappedElement.TabIndex; set => WrappedElement.TabIndex = value;}
        [DebuggerHidden]
        public String TagName { get => WrappedElement.TagName; }
        [DebuggerHidden]
        public String TextContent { get => WrappedElement.TextContent; set => WrappedElement.TextContent = value;}
        [DebuggerHidden]
        public String? Title { get => WrappedElement.Title; set => WrappedElement.Title = value;}
        [DebuggerHidden]
        public String Type { get => WrappedElement.Type; set => WrappedElement.Type = value;}
        [DebuggerHidden]
        public String? ValidationMessage { get => WrappedElement.ValidationMessage; }
        [DebuggerHidden]
        public IValidityState Validity { get => WrappedElement.Validity; }
        [DebuggerHidden]
        public String Value { get => WrappedElement.Value; set => WrappedElement.Value = value;}
        [DebuggerHidden]
        public DateTime? ValueAsDate { get => WrappedElement.ValueAsDate; set => WrappedElement.ValueAsDate = value;}
        [DebuggerHidden]
        public Double ValueAsNumber { get => WrappedElement.ValueAsNumber; set => WrappedElement.ValueAsNumber = value;}
        [DebuggerHidden]
        public Boolean WillValidate { get => WrappedElement.WillValidate; }
        #endregion

        #region Methods
        [DebuggerHidden]
        public void AddEventListener(String type, DomEventHandler? callback, Boolean capture) => WrappedElement.AddEventListener(type, callback, capture);
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
        public Boolean CheckValidity() => WrappedElement.CheckValidity();
        [DebuggerHidden]
        public INode Clone(Boolean deep) => WrappedElement.Clone(deep);
        [DebuggerHidden]
        public IElement? Closest(String selectors) => WrappedElement.Closest(selectors);
        [DebuggerHidden]
        public DocumentPositions CompareDocumentPosition(INode otherNode) => WrappedElement.CompareDocumentPosition(otherNode);
        [DebuggerHidden]
        public Boolean Contains(INode otherNode) => WrappedElement.Contains(otherNode);
        [DebuggerHidden]
        public Boolean Dispatch(Event ev) => WrappedElement.Dispatch(ev);
        [DebuggerHidden]
        public void DoBlur() => WrappedElement.DoBlur();
        [DebuggerHidden]
        public void DoClick() => WrappedElement.DoClick();
        [DebuggerHidden]
        public void DoFocus() => WrappedElement.DoFocus();
        [DebuggerHidden]
        public void DoSpellCheck() => WrappedElement.DoSpellCheck();
        [DebuggerHidden]
        public Boolean Equals(INode otherNode) => WrappedElement.Equals(otherNode);
        [DebuggerHidden]
        public String? GetAttribute(String name) => WrappedElement.GetAttribute(name);
        [DebuggerHidden]
        public String? GetAttribute(String? namespaceUri, String localName) => WrappedElement.GetAttribute(namespaceUri, localName);
        [DebuggerHidden]
        public IHtmlCollection<IElement> GetElementsByClassName(String classNames) => WrappedElement.GetElementsByClassName(classNames);
        [DebuggerHidden]
        public IHtmlCollection<IElement> GetElementsByTagName(String tagName) => WrappedElement.GetElementsByTagName(tagName);
        [DebuggerHidden]
        public IHtmlCollection<IElement> GetElementsByTagNameNS(String namespaceUri, String tagName) => WrappedElement.GetElementsByTagNameNS(namespaceUri, tagName);
        [DebuggerHidden]
        public Boolean HasAttribute(String name) => WrappedElement.HasAttribute(name);
        [DebuggerHidden]
        public Boolean HasAttribute(String? namespaceUri, String localName) => WrappedElement.HasAttribute(namespaceUri, localName);
        [DebuggerHidden]
        public void Insert(AdjacentPosition position, String html) => WrappedElement.Insert(position, html);
        [DebuggerHidden]
        public INode InsertBefore(INode newElement, INode? referenceElement) => WrappedElement.InsertBefore(newElement, referenceElement);
        [DebuggerHidden]
        public void InvokeEventListener(Event ev) => WrappedElement.InvokeEventListener(ev);
        [DebuggerHidden]
        public Boolean IsDefaultNamespace(String namespaceUri) => WrappedElement.IsDefaultNamespace(namespaceUri);
        [DebuggerHidden]
        public String? LookupNamespaceUri(String prefix) => WrappedElement.LookupNamespaceUri(prefix);
        [DebuggerHidden]
        public String? LookupPrefix(String namespaceUri) => WrappedElement.LookupPrefix(namespaceUri);
        [DebuggerHidden]
        public Boolean Matches(String selectors) => WrappedElement.Matches(selectors);
        [DebuggerHidden]
        public void Normalize() => WrappedElement.Normalize();
        [DebuggerHidden]
        public void Prepend(INode[] nodes) => WrappedElement.Prepend(nodes);
        [DebuggerHidden]
        public IElement? QuerySelector(String selectors) => WrappedElement.QuerySelector(selectors);
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
        public void RemoveEventListener(String type, DomEventHandler? callback, Boolean capture) => WrappedElement.RemoveEventListener(type, callback, capture);
        [DebuggerHidden]
        public void Replace(INode[] nodes) => WrappedElement.Replace(nodes);
        [DebuggerHidden]
        public INode ReplaceChild(INode newChild, INode oldChild) => WrappedElement.ReplaceChild(newChild, oldChild);
        [DebuggerHidden]
        public void Select(Int32 selectionStart, Int32 selectionEnd, String? selectionDirection) => WrappedElement.Select(selectionStart, selectionEnd, selectionDirection);
        [DebuggerHidden]
        public void SelectAll() => WrappedElement.SelectAll();
        [DebuggerHidden]
        public void SetAttribute(String name, String value) => WrappedElement.SetAttribute(name, value);
        [DebuggerHidden]
        public void SetAttribute(String namespaceUri, String name, String value) => WrappedElement.SetAttribute(namespaceUri, name, value);
        [DebuggerHidden]
        public void SetCustomValidity(String error) => WrappedElement.SetCustomValidity(error);
        [DebuggerHidden]
        public void StepDown(Int32 n) => WrappedElement.StepDown(n);
        [DebuggerHidden]
        public void StepUp(Int32 n) => WrappedElement.StepUp(n);
        [DebuggerHidden]
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedElement.ToHtml(writer, formatter);
        #endregion
    }
}
