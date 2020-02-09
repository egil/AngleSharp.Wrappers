using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using AngleSharp.Html.Dom;
using AngleSharp.Io.Dom;

namespace AngleSharpWrappers
{
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IHtmlInputElement"/> type.
    /// </summary>
    public partial class HtmlInputElementWrapper : Wrapper<IHtmlInputElement>, IHtmlInputElement, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="HtmlInputElementWrapper"/> type;
        /// </summary>
        internal HtmlInputElementWrapper(WrapperFactory factory, IHtmlInputElement initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

        /// <inheritdoc/>
        public event DomEventHandler Aborted { add => ((IGlobalEventHandlers)WrappedObject).Aborted += value; remove => ((IGlobalEventHandlers)WrappedObject).Aborted -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Blurred { add => ((IGlobalEventHandlers)WrappedObject).Blurred += value; remove => ((IGlobalEventHandlers)WrappedObject).Blurred -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Cancelled { add => ((IGlobalEventHandlers)WrappedObject).Cancelled += value; remove => ((IGlobalEventHandlers)WrappedObject).Cancelled -= value; }

        /// <inheritdoc/>
        public event DomEventHandler CanPlay { add => ((IGlobalEventHandlers)WrappedObject).CanPlay += value; remove => ((IGlobalEventHandlers)WrappedObject).CanPlay -= value; }

        /// <inheritdoc/>
        public event DomEventHandler CanPlayThrough { add => ((IGlobalEventHandlers)WrappedObject).CanPlayThrough += value; remove => ((IGlobalEventHandlers)WrappedObject).CanPlayThrough -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Changed { add => ((IGlobalEventHandlers)WrappedObject).Changed += value; remove => ((IGlobalEventHandlers)WrappedObject).Changed -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Clicked { add => ((IGlobalEventHandlers)WrappedObject).Clicked += value; remove => ((IGlobalEventHandlers)WrappedObject).Clicked -= value; }

        /// <inheritdoc/>
        public event DomEventHandler CueChanged { add => ((IGlobalEventHandlers)WrappedObject).CueChanged += value; remove => ((IGlobalEventHandlers)WrappedObject).CueChanged -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DoubleClick { add => ((IGlobalEventHandlers)WrappedObject).DoubleClick += value; remove => ((IGlobalEventHandlers)WrappedObject).DoubleClick -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Drag { add => ((IGlobalEventHandlers)WrappedObject).Drag += value; remove => ((IGlobalEventHandlers)WrappedObject).Drag -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragEnd { add => ((IGlobalEventHandlers)WrappedObject).DragEnd += value; remove => ((IGlobalEventHandlers)WrappedObject).DragEnd -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragEnter { add => ((IGlobalEventHandlers)WrappedObject).DragEnter += value; remove => ((IGlobalEventHandlers)WrappedObject).DragEnter -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragExit { add => ((IGlobalEventHandlers)WrappedObject).DragExit += value; remove => ((IGlobalEventHandlers)WrappedObject).DragExit -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragLeave { add => ((IGlobalEventHandlers)WrappedObject).DragLeave += value; remove => ((IGlobalEventHandlers)WrappedObject).DragLeave -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragOver { add => ((IGlobalEventHandlers)WrappedObject).DragOver += value; remove => ((IGlobalEventHandlers)WrappedObject).DragOver -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DragStart { add => ((IGlobalEventHandlers)WrappedObject).DragStart += value; remove => ((IGlobalEventHandlers)WrappedObject).DragStart -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Dropped { add => ((IGlobalEventHandlers)WrappedObject).Dropped += value; remove => ((IGlobalEventHandlers)WrappedObject).Dropped -= value; }

        /// <inheritdoc/>
        public event DomEventHandler DurationChanged { add => ((IGlobalEventHandlers)WrappedObject).DurationChanged += value; remove => ((IGlobalEventHandlers)WrappedObject).DurationChanged -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Emptied { add => ((IGlobalEventHandlers)WrappedObject).Emptied += value; remove => ((IGlobalEventHandlers)WrappedObject).Emptied -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Ended { add => ((IGlobalEventHandlers)WrappedObject).Ended += value; remove => ((IGlobalEventHandlers)WrappedObject).Ended -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Error { add => ((IGlobalEventHandlers)WrappedObject).Error += value; remove => ((IGlobalEventHandlers)WrappedObject).Error -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Focused { add => ((IGlobalEventHandlers)WrappedObject).Focused += value; remove => ((IGlobalEventHandlers)WrappedObject).Focused -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Input { add => ((IGlobalEventHandlers)WrappedObject).Input += value; remove => ((IGlobalEventHandlers)WrappedObject).Input -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Invalid { add => ((IGlobalEventHandlers)WrappedObject).Invalid += value; remove => ((IGlobalEventHandlers)WrappedObject).Invalid -= value; }

        /// <inheritdoc/>
        public event DomEventHandler KeyDown { add => ((IGlobalEventHandlers)WrappedObject).KeyDown += value; remove => ((IGlobalEventHandlers)WrappedObject).KeyDown -= value; }

        /// <inheritdoc/>
        public event DomEventHandler KeyPress { add => ((IGlobalEventHandlers)WrappedObject).KeyPress += value; remove => ((IGlobalEventHandlers)WrappedObject).KeyPress -= value; }

        /// <inheritdoc/>
        public event DomEventHandler KeyUp { add => ((IGlobalEventHandlers)WrappedObject).KeyUp += value; remove => ((IGlobalEventHandlers)WrappedObject).KeyUp -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Loaded { add => ((IGlobalEventHandlers)WrappedObject).Loaded += value; remove => ((IGlobalEventHandlers)WrappedObject).Loaded -= value; }

        /// <inheritdoc/>
        public event DomEventHandler LoadedData { add => ((IGlobalEventHandlers)WrappedObject).LoadedData += value; remove => ((IGlobalEventHandlers)WrappedObject).LoadedData -= value; }

        /// <inheritdoc/>
        public event DomEventHandler LoadedMetadata { add => ((IGlobalEventHandlers)WrappedObject).LoadedMetadata += value; remove => ((IGlobalEventHandlers)WrappedObject).LoadedMetadata -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Loading { add => ((IGlobalEventHandlers)WrappedObject).Loading += value; remove => ((IGlobalEventHandlers)WrappedObject).Loading -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseDown { add => ((IGlobalEventHandlers)WrappedObject).MouseDown += value; remove => ((IGlobalEventHandlers)WrappedObject).MouseDown -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseEnter { add => ((IGlobalEventHandlers)WrappedObject).MouseEnter += value; remove => ((IGlobalEventHandlers)WrappedObject).MouseEnter -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseLeave { add => ((IGlobalEventHandlers)WrappedObject).MouseLeave += value; remove => ((IGlobalEventHandlers)WrappedObject).MouseLeave -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseMove { add => ((IGlobalEventHandlers)WrappedObject).MouseMove += value; remove => ((IGlobalEventHandlers)WrappedObject).MouseMove -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseOut { add => ((IGlobalEventHandlers)WrappedObject).MouseOut += value; remove => ((IGlobalEventHandlers)WrappedObject).MouseOut -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseOver { add => ((IGlobalEventHandlers)WrappedObject).MouseOver += value; remove => ((IGlobalEventHandlers)WrappedObject).MouseOver -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseUp { add => ((IGlobalEventHandlers)WrappedObject).MouseUp += value; remove => ((IGlobalEventHandlers)WrappedObject).MouseUp -= value; }

        /// <inheritdoc/>
        public event DomEventHandler MouseWheel { add => ((IGlobalEventHandlers)WrappedObject).MouseWheel += value; remove => ((IGlobalEventHandlers)WrappedObject).MouseWheel -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Paused { add => ((IGlobalEventHandlers)WrappedObject).Paused += value; remove => ((IGlobalEventHandlers)WrappedObject).Paused -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Played { add => ((IGlobalEventHandlers)WrappedObject).Played += value; remove => ((IGlobalEventHandlers)WrappedObject).Played -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Playing { add => ((IGlobalEventHandlers)WrappedObject).Playing += value; remove => ((IGlobalEventHandlers)WrappedObject).Playing -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Progress { add => ((IGlobalEventHandlers)WrappedObject).Progress += value; remove => ((IGlobalEventHandlers)WrappedObject).Progress -= value; }

        /// <inheritdoc/>
        public event DomEventHandler RateChanged { add => ((IGlobalEventHandlers)WrappedObject).RateChanged += value; remove => ((IGlobalEventHandlers)WrappedObject).RateChanged -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Resetted { add => ((IGlobalEventHandlers)WrappedObject).Resetted += value; remove => ((IGlobalEventHandlers)WrappedObject).Resetted -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Resized { add => ((IGlobalEventHandlers)WrappedObject).Resized += value; remove => ((IGlobalEventHandlers)WrappedObject).Resized -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Scrolled { add => ((IGlobalEventHandlers)WrappedObject).Scrolled += value; remove => ((IGlobalEventHandlers)WrappedObject).Scrolled -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Seeked { add => ((IGlobalEventHandlers)WrappedObject).Seeked += value; remove => ((IGlobalEventHandlers)WrappedObject).Seeked -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Seeking { add => ((IGlobalEventHandlers)WrappedObject).Seeking += value; remove => ((IGlobalEventHandlers)WrappedObject).Seeking -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Selected { add => ((IGlobalEventHandlers)WrappedObject).Selected += value; remove => ((IGlobalEventHandlers)WrappedObject).Selected -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Shown { add => ((IGlobalEventHandlers)WrappedObject).Shown += value; remove => ((IGlobalEventHandlers)WrappedObject).Shown -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Stalled { add => ((IGlobalEventHandlers)WrappedObject).Stalled += value; remove => ((IGlobalEventHandlers)WrappedObject).Stalled -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Submitted { add => ((IGlobalEventHandlers)WrappedObject).Submitted += value; remove => ((IGlobalEventHandlers)WrappedObject).Submitted -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Suspended { add => ((IGlobalEventHandlers)WrappedObject).Suspended += value; remove => ((IGlobalEventHandlers)WrappedObject).Suspended -= value; }

        /// <inheritdoc/>
        public event DomEventHandler TimeUpdated { add => ((IGlobalEventHandlers)WrappedObject).TimeUpdated += value; remove => ((IGlobalEventHandlers)WrappedObject).TimeUpdated -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Toggled { add => ((IGlobalEventHandlers)WrappedObject).Toggled += value; remove => ((IGlobalEventHandlers)WrappedObject).Toggled -= value; }

        /// <inheritdoc/>
        public event DomEventHandler VolumeChanged { add => ((IGlobalEventHandlers)WrappedObject).VolumeChanged += value; remove => ((IGlobalEventHandlers)WrappedObject).VolumeChanged -= value; }

        /// <inheritdoc/>
        public event DomEventHandler Waiting { add => ((IGlobalEventHandlers)WrappedObject).Waiting += value; remove => ((IGlobalEventHandlers)WrappedObject).Waiting -= value; }

        /// <inheritdoc/>
        public String Accept { get => WrappedObject.Accept; set => WrappedObject.Accept = value;}

        /// <inheritdoc/>
        public String AccessKey { get => WrappedObject.AccessKey; set => WrappedObject.AccessKey = value;}

        /// <inheritdoc/>
        public String AccessKeyLabel { get => WrappedObject.AccessKeyLabel; }

        /// <inheritdoc/>
        public String AlternativeText { get => WrappedObject.AlternativeText; set => WrappedObject.AlternativeText = value;}

        /// <inheritdoc/>
        public IElement AssignedSlot { get => GetOrWrap(() => WrappedObject.AssignedSlot); }

        /// <inheritdoc/>
        public INamedNodeMap Attributes { get => GetOrWrap(() => WrappedObject.Attributes); }

        /// <inheritdoc/>
        public String Autocomplete { get => WrappedObject.Autocomplete; set => WrappedObject.Autocomplete = value;}

        /// <inheritdoc/>
        public Boolean Autofocus { get => WrappedObject.Autofocus; set => WrappedObject.Autofocus = value;}

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
        public String DefaultValue { get => WrappedObject.DefaultValue; set => WrappedObject.DefaultValue = value;}

        /// <inheritdoc/>
        public String Direction { get => WrappedObject.Direction; set => WrappedObject.Direction = value;}

        /// <inheritdoc/>
        public String DirectionName { get => WrappedObject.DirectionName; set => WrappedObject.DirectionName = value;}

        /// <inheritdoc/>
        public Int32 DisplayHeight { get => WrappedObject.DisplayHeight; set => WrappedObject.DisplayHeight = value;}

        /// <inheritdoc/>
        public Int32 DisplayWidth { get => WrappedObject.DisplayWidth; set => WrappedObject.DisplayWidth = value;}

        /// <inheritdoc/>
        public ISettableTokenList DropZone { get => GetOrWrap(() => WrappedObject.DropZone); }

        /// <inheritdoc/>
        public IFileList Files { get => GetOrWrap(() => WrappedObject.Files); }

        /// <inheritdoc/>
        public INode FirstChild { get => GetOrWrap(() => WrappedObject.FirstChild); }

        /// <inheritdoc/>
        public IElement FirstElementChild { get => GetOrWrap(() => WrappedObject.FirstElementChild); }

        /// <inheritdoc/>
        public NodeFlags Flags { get => WrappedObject.Flags; }

        /// <inheritdoc/>
        public IHtmlFormElement Form { get => GetOrWrap(() => WrappedObject.Form); }

        /// <inheritdoc/>
        public String FormAction { get => WrappedObject.FormAction; set => WrappedObject.FormAction = value;}

        /// <inheritdoc/>
        public String FormEncType { get => WrappedObject.FormEncType; set => WrappedObject.FormEncType = value;}

        /// <inheritdoc/>
        public String FormMethod { get => WrappedObject.FormMethod; set => WrappedObject.FormMethod = value;}

        /// <inheritdoc/>
        public Boolean FormNoValidate { get => WrappedObject.FormNoValidate; set => WrappedObject.FormNoValidate = value;}

        /// <inheritdoc/>
        public String FormTarget { get => WrappedObject.FormTarget; set => WrappedObject.FormTarget = value;}

        /// <inheritdoc/>
        public Boolean HasChildNodes { get => WrappedObject.HasChildNodes; }

        /// <inheritdoc/>
        public Boolean HasValue { get => WrappedObject.HasValue; }

        /// <inheritdoc/>
        public String Id { get => WrappedObject.Id; set => WrappedObject.Id = value;}

        /// <inheritdoc/>
        public String InnerHtml { get => WrappedObject.InnerHtml; set => WrappedObject.InnerHtml = value;}

        /// <inheritdoc/>
        public Boolean IsChecked { get => WrappedObject.IsChecked; set => WrappedObject.IsChecked = value;}

        /// <inheritdoc/>
        public Boolean IsContentEditable { get => WrappedObject.IsContentEditable; }

        /// <inheritdoc/>
        public Boolean IsDefaultChecked { get => WrappedObject.IsDefaultChecked; set => WrappedObject.IsDefaultChecked = value;}

        /// <inheritdoc/>
        public Boolean IsDisabled { get => WrappedObject.IsDisabled; set => WrappedObject.IsDisabled = value;}

        /// <inheritdoc/>
        public Boolean IsDraggable { get => WrappedObject.IsDraggable; set => WrappedObject.IsDraggable = value;}

        /// <inheritdoc/>
        public Boolean IsFocused { get => WrappedObject.IsFocused; }

        /// <inheritdoc/>
        public Boolean IsHidden { get => WrappedObject.IsHidden; set => WrappedObject.IsHidden = value;}

        /// <inheritdoc/>
        public Boolean IsIndeterminate { get => WrappedObject.IsIndeterminate; set => WrappedObject.IsIndeterminate = value;}

        /// <inheritdoc/>
        public Boolean IsMultiple { get => WrappedObject.IsMultiple; set => WrappedObject.IsMultiple = value;}

        /// <inheritdoc/>
        public Boolean IsReadOnly { get => WrappedObject.IsReadOnly; set => WrappedObject.IsReadOnly = value;}

        /// <inheritdoc/>
        public Boolean IsRequired { get => WrappedObject.IsRequired; set => WrappedObject.IsRequired = value;}

        /// <inheritdoc/>
        public Boolean IsSpellChecked { get => WrappedObject.IsSpellChecked; set => WrappedObject.IsSpellChecked = value;}

        /// <inheritdoc/>
        public Boolean IsTranslated { get => WrappedObject.IsTranslated; set => WrappedObject.IsTranslated = value;}

        /// <inheritdoc/>
        public INodeList Labels { get => GetOrWrap(() => WrappedObject.Labels); }

        /// <inheritdoc/>
        public String Language { get => WrappedObject.Language; set => WrappedObject.Language = value;}

        /// <inheritdoc/>
        public INode LastChild { get => GetOrWrap(() => WrappedObject.LastChild); }

        /// <inheritdoc/>
        public IElement LastElementChild { get => GetOrWrap(() => WrappedObject.LastElementChild); }

        /// <inheritdoc/>
        public IHtmlDataListElement List { get => GetOrWrap(() => WrappedObject.List); }

        /// <inheritdoc/>
        public String LocalName { get => WrappedObject.LocalName; }

        /// <inheritdoc/>
        public String Maximum { get => WrappedObject.Maximum; set => WrappedObject.Maximum = value;}

        /// <inheritdoc/>
        public Int32 MaxLength { get => WrappedObject.MaxLength; set => WrappedObject.MaxLength = value;}

        /// <inheritdoc/>
        public String Minimum { get => WrappedObject.Minimum; set => WrappedObject.Minimum = value;}

        /// <inheritdoc/>
        public Int32 MinLength { get => WrappedObject.MinLength; set => WrappedObject.MinLength = value;}

        /// <inheritdoc/>
        public String Name { get => WrappedObject.Name; set => WrappedObject.Name = value;}

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
        public String Pattern { get => WrappedObject.Pattern; set => WrappedObject.Pattern = value;}

        /// <inheritdoc/>
        public String Placeholder { get => WrappedObject.Placeholder; set => WrappedObject.Placeholder = value;}

        /// <inheritdoc/>
        public String Prefix { get => WrappedObject.Prefix; }

        /// <inheritdoc/>
        public IElement PreviousElementSibling { get => GetOrWrap(() => WrappedObject.PreviousElementSibling); }

        /// <inheritdoc/>
        public INode PreviousSibling { get => GetOrWrap(() => WrappedObject.PreviousSibling); }

        /// <inheritdoc/>
        public String SelectionDirection { get => WrappedObject.SelectionDirection; }

        /// <inheritdoc/>
        public Int32 SelectionEnd { get => WrappedObject.SelectionEnd; set => WrappedObject.SelectionEnd = value;}

        /// <inheritdoc/>
        public Int32 SelectionStart { get => WrappedObject.SelectionStart; set => WrappedObject.SelectionStart = value;}

        /// <inheritdoc/>
        public IShadowRoot ShadowRoot { get => GetOrWrap(() => WrappedObject.ShadowRoot); }

        /// <inheritdoc/>
        public Int32 Size { get => WrappedObject.Size; set => WrappedObject.Size = value;}

        /// <inheritdoc/>
        public String Slot { get => WrappedObject.Slot; set => WrappedObject.Slot = value;}

        /// <inheritdoc/>
        public String Source { get => WrappedObject.Source; set => WrappedObject.Source = value;}

        /// <inheritdoc/>
        public ISourceReference SourceReference { get => WrappedObject.SourceReference; }

        /// <inheritdoc/>
        public String Step { get => WrappedObject.Step; set => WrappedObject.Step = value;}

        /// <inheritdoc/>
        public Int32 TabIndex { get => WrappedObject.TabIndex; set => WrappedObject.TabIndex = value;}

        /// <inheritdoc/>
        public String TagName { get => WrappedObject.TagName; }

        /// <inheritdoc/>
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}

        /// <inheritdoc/>
        public String Title { get => WrappedObject.Title; set => WrappedObject.Title = value;}

        /// <inheritdoc/>
        public String Type { get => WrappedObject.Type; set => WrappedObject.Type = value;}

        /// <inheritdoc/>
        public String ValidationMessage { get => WrappedObject.ValidationMessage; }

        /// <inheritdoc/>
        public IValidityState Validity { get => WrappedObject.Validity; }

        /// <inheritdoc/>
        public String Value { get => WrappedObject.Value; set => WrappedObject.Value = value;}

        /// <inheritdoc/>
        public Nullable<DateTime> ValueAsDate { get => WrappedObject.ValueAsDate; set => WrappedObject.ValueAsDate = value;}

        /// <inheritdoc/>
        public Double ValueAsNumber { get => WrappedObject.ValueAsNumber; set => WrappedObject.ValueAsNumber = value;}

        /// <inheritdoc/>
        public Boolean WillValidate { get => WrappedObject.WillValidate; }

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
        public Boolean CheckValidity()
            => WrappedObject.CheckValidity();

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
        public void Select(Int32 selectionStart, Int32 selectionEnd, String selectionDirection)
            => WrappedObject.Select(selectionStart, selectionEnd, selectionDirection);

        /// <inheritdoc/>
        public void SelectAll()
            => WrappedObject.SelectAll();

        /// <inheritdoc/>
        public void SetAttribute(String name, String value)
            => WrappedObject.SetAttribute(name, value);

        /// <inheritdoc/>
        public void SetAttribute(String namespaceUri, String name, String value)
            => WrappedObject.SetAttribute(namespaceUri, name, value);

        /// <inheritdoc/>
        public void SetCustomValidity(String error)
            => WrappedObject.SetCustomValidity(error);

        /// <inheritdoc/>
        public void StepDown(Int32 n)
            => WrappedObject.StepDown(n);

        /// <inheritdoc/>
        public void StepUp(Int32 n)
            => WrappedObject.StepUp(n);

        /// <inheritdoc/>
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter)
            => WrappedObject.ToHtml(writer, formatter);
    }
}