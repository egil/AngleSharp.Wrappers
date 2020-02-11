using System;
using System.IO;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using AngleSharp.Html.Dom;
using AngleSharp.Io;
using AngleSharp.Media.Dom;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="IHtmlVideoElement"/> type.
    /// </summary>
    internal sealed class HtmlVideoElementWrapper : Wrapper<IHtmlVideoElement>, IHtmlVideoElement, IWrapper<IHtmlVideoElement>
    {
        private IElement? _assignedSlot;
        private INodeList? _childNodes;
        private IHtmlMenuElement? _contextMenu;
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
        /// Creates an instance of the <see cref="HtmlVideoElementWrapper"/> type;
        /// </summary>
        internal HtmlVideoElementWrapper(WrapperFactory factory, IHtmlVideoElement initialObject, Func<object?> query) : base(factory, initialObject, query) { }

        #region Events
        public event DomEventHandler Aborted { add => WrappedObject.Aborted += value; remove => WrappedObject.Aborted -= value; }
        public event DomEventHandler Blurred { add => WrappedObject.Blurred += value; remove => WrappedObject.Blurred -= value; }
        public event DomEventHandler Cancelled { add => WrappedObject.Cancelled += value; remove => WrappedObject.Cancelled -= value; }
        public event DomEventHandler CanPlay { add => ((IMediaController)WrappedObject).CanPlay += value; remove => ((IMediaController)WrappedObject).CanPlay -= value; }
        public event DomEventHandler CanPlayThrough { add => ((IMediaController)WrappedObject).CanPlayThrough += value; remove => ((IMediaController)WrappedObject).CanPlayThrough -= value; }
        public event DomEventHandler Changed { add => WrappedObject.Changed += value; remove => WrappedObject.Changed -= value; }
        public event DomEventHandler Clicked { add => WrappedObject.Clicked += value; remove => WrappedObject.Clicked -= value; }
        public event DomEventHandler CueChanged { add => WrappedObject.CueChanged += value; remove => WrappedObject.CueChanged -= value; }
        public event DomEventHandler DoubleClick { add => WrappedObject.DoubleClick += value; remove => WrappedObject.DoubleClick -= value; }
        public event DomEventHandler Drag { add => WrappedObject.Drag += value; remove => WrappedObject.Drag -= value; }
        public event DomEventHandler DragEnd { add => WrappedObject.DragEnd += value; remove => WrappedObject.DragEnd -= value; }
        public event DomEventHandler DragEnter { add => WrappedObject.DragEnter += value; remove => WrappedObject.DragEnter -= value; }
        public event DomEventHandler DragExit { add => WrappedObject.DragExit += value; remove => WrappedObject.DragExit -= value; }
        public event DomEventHandler DragLeave { add => WrappedObject.DragLeave += value; remove => WrappedObject.DragLeave -= value; }
        public event DomEventHandler DragOver { add => WrappedObject.DragOver += value; remove => WrappedObject.DragOver -= value; }
        public event DomEventHandler DragStart { add => WrappedObject.DragStart += value; remove => WrappedObject.DragStart -= value; }
        public event DomEventHandler Dropped { add => WrappedObject.Dropped += value; remove => WrappedObject.Dropped -= value; }
        public event DomEventHandler DurationChanged { add => ((IMediaController)WrappedObject).DurationChanged += value; remove => ((IMediaController)WrappedObject).DurationChanged -= value; }
        public event DomEventHandler Emptied { add => ((IMediaController)WrappedObject).Emptied += value; remove => ((IMediaController)WrappedObject).Emptied -= value; }
        public event DomEventHandler Ended { add => ((IMediaController)WrappedObject).Ended += value; remove => ((IMediaController)WrappedObject).Ended -= value; }
        public event DomEventHandler Error { add => WrappedObject.Error += value; remove => WrappedObject.Error -= value; }
        public event DomEventHandler Focused { add => WrappedObject.Focused += value; remove => WrappedObject.Focused -= value; }
        public event DomEventHandler Input { add => WrappedObject.Input += value; remove => WrappedObject.Input -= value; }
        public event DomEventHandler Invalid { add => WrappedObject.Invalid += value; remove => WrappedObject.Invalid -= value; }
        public event DomEventHandler KeyDown { add => WrappedObject.KeyDown += value; remove => WrappedObject.KeyDown -= value; }
        public event DomEventHandler KeyPress { add => WrappedObject.KeyPress += value; remove => WrappedObject.KeyPress -= value; }
        public event DomEventHandler KeyUp { add => WrappedObject.KeyUp += value; remove => WrappedObject.KeyUp -= value; }
        public event DomEventHandler Loaded { add => WrappedObject.Loaded += value; remove => WrappedObject.Loaded -= value; }
        public event DomEventHandler LoadedData { add => ((IMediaController)WrappedObject).LoadedData += value; remove => ((IMediaController)WrappedObject).LoadedData -= value; }
        public event DomEventHandler LoadedMetadata { add => ((IMediaController)WrappedObject).LoadedMetadata += value; remove => ((IMediaController)WrappedObject).LoadedMetadata -= value; }
        public event DomEventHandler Loading { add => WrappedObject.Loading += value; remove => WrappedObject.Loading -= value; }
        public event DomEventHandler MouseDown { add => WrappedObject.MouseDown += value; remove => WrappedObject.MouseDown -= value; }
        public event DomEventHandler MouseEnter { add => WrappedObject.MouseEnter += value; remove => WrappedObject.MouseEnter -= value; }
        public event DomEventHandler MouseLeave { add => WrappedObject.MouseLeave += value; remove => WrappedObject.MouseLeave -= value; }
        public event DomEventHandler MouseMove { add => WrappedObject.MouseMove += value; remove => WrappedObject.MouseMove -= value; }
        public event DomEventHandler MouseOut { add => WrappedObject.MouseOut += value; remove => WrappedObject.MouseOut -= value; }
        public event DomEventHandler MouseOver { add => WrappedObject.MouseOver += value; remove => WrappedObject.MouseOver -= value; }
        public event DomEventHandler MouseUp { add => WrappedObject.MouseUp += value; remove => WrappedObject.MouseUp -= value; }
        public event DomEventHandler MouseWheel { add => WrappedObject.MouseWheel += value; remove => WrappedObject.MouseWheel -= value; }
        public event DomEventHandler Paused { add => ((IMediaController)WrappedObject).Paused += value; remove => ((IMediaController)WrappedObject).Paused -= value; }
        public event DomEventHandler Played { add => ((IMediaController)WrappedObject).Played += value; remove => ((IMediaController)WrappedObject).Played -= value; }
        public event DomEventHandler Playing { add => ((IMediaController)WrappedObject).Playing += value; remove => ((IMediaController)WrappedObject).Playing -= value; }
        public event DomEventHandler Progress { add => WrappedObject.Progress += value; remove => WrappedObject.Progress -= value; }
        public event DomEventHandler RateChanged { add => ((IMediaController)WrappedObject).RateChanged += value; remove => ((IMediaController)WrappedObject).RateChanged -= value; }
        public event DomEventHandler Resetted { add => WrappedObject.Resetted += value; remove => WrappedObject.Resetted -= value; }
        public event DomEventHandler Resized { add => WrappedObject.Resized += value; remove => WrappedObject.Resized -= value; }
        public event DomEventHandler Scrolled { add => WrappedObject.Scrolled += value; remove => WrappedObject.Scrolled -= value; }
        public event DomEventHandler Seeked { add => WrappedObject.Seeked += value; remove => WrappedObject.Seeked -= value; }
        public event DomEventHandler Seeking { add => WrappedObject.Seeking += value; remove => WrappedObject.Seeking -= value; }
        public event DomEventHandler Selected { add => WrappedObject.Selected += value; remove => WrappedObject.Selected -= value; }
        public event DomEventHandler Shown { add => WrappedObject.Shown += value; remove => WrappedObject.Shown -= value; }
        public event DomEventHandler Stalled { add => WrappedObject.Stalled += value; remove => WrappedObject.Stalled -= value; }
        public event DomEventHandler Submitted { add => WrappedObject.Submitted += value; remove => WrappedObject.Submitted -= value; }
        public event DomEventHandler Suspended { add => WrappedObject.Suspended += value; remove => WrappedObject.Suspended -= value; }
        public event DomEventHandler TimeUpdated { add => ((IMediaController)WrappedObject).TimeUpdated += value; remove => ((IMediaController)WrappedObject).TimeUpdated -= value; }
        public event DomEventHandler Toggled { add => WrappedObject.Toggled += value; remove => WrappedObject.Toggled -= value; }
        public event DomEventHandler VolumeChanged { add => ((IMediaController)WrappedObject).VolumeChanged += value; remove => ((IMediaController)WrappedObject).VolumeChanged -= value; }
        public event DomEventHandler Waiting { add => ((IMediaController)WrappedObject).Waiting += value; remove => ((IMediaController)WrappedObject).Waiting -= value; }
        #endregion

        #region Properties and indexers
        public String AccessKey { get => WrappedObject.AccessKey; set => WrappedObject.AccessKey = value;}
        public String AccessKeyLabel { get => WrappedObject.AccessKeyLabel; }
        public IElement? AssignedSlot
        {
            get
            {
                if (_assignedSlot is null || ((IWrapper)_assignedSlot).IsRemoved) _assignedSlot = GetOrWrap(() => WrappedObject.AssignedSlot);
                return _assignedSlot;
            }
        }
        public INamedNodeMap Attributes { get => WrappedObject.Attributes; }
        public IAudioTrackList AudioTracks { get => WrappedObject.AudioTracks; }
        public String BaseUri { get => WrappedObject.BaseUri; }
        public Url BaseUrl { get => WrappedObject.BaseUrl; }
        public ITimeRanges BufferedTime { get => WrappedObject.BufferedTime; }
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
        public String ContentEditable { get => WrappedObject.ContentEditable; set => WrappedObject.ContentEditable = value;}
        public IHtmlMenuElement? ContextMenu
        {
            get
            {
                if (_contextMenu is null || ((IWrapper)_contextMenu).IsRemoved) _contextMenu = GetOrWrap(() => WrappedObject.ContextMenu);
                return _contextMenu;
            }
            set => WrappedObject.ContextMenu = value;
        }
        public IMediaController Controller { get => WrappedObject.Controller; }
        public String CrossOrigin { get => WrappedObject.CrossOrigin; set => WrappedObject.CrossOrigin = value;}
        public IDownload CurrentDownload { get => WrappedObject.CurrentDownload; }
        public String CurrentSource { get => WrappedObject.CurrentSource; }
        public Double CurrentTime { get => WrappedObject.CurrentTime; set => WrappedObject.CurrentTime = value;}
        public IStringMap Dataset { get => WrappedObject.Dataset; }
        public Double DefaultPlaybackRate { get => WrappedObject.DefaultPlaybackRate; set => WrappedObject.DefaultPlaybackRate = value;}
        public String Direction { get => WrappedObject.Direction; set => WrappedObject.Direction = value;}
        public Int32 DisplayHeight { get => WrappedObject.DisplayHeight; set => WrappedObject.DisplayHeight = value;}
        public Int32 DisplayWidth { get => WrappedObject.DisplayWidth; set => WrappedObject.DisplayWidth = value;}
        public ISettableTokenList DropZone { get => WrappedObject.DropZone; }
        public Double Duration { get => WrappedObject.Duration; }
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
        public Boolean IsAutoplay { get => WrappedObject.IsAutoplay; set => WrappedObject.IsAutoplay = value;}
        public Boolean IsContentEditable { get => WrappedObject.IsContentEditable; }
        public Boolean IsDefaultMuted { get => WrappedObject.IsDefaultMuted; set => WrappedObject.IsDefaultMuted = value;}
        public Boolean IsDraggable { get => WrappedObject.IsDraggable; set => WrappedObject.IsDraggable = value;}
        public Boolean IsEnded { get => WrappedObject.IsEnded; }
        public Boolean IsFocused { get => WrappedObject.IsFocused; }
        public Boolean IsHidden { get => WrappedObject.IsHidden; set => WrappedObject.IsHidden = value;}
        public Boolean IsLoop { get => WrappedObject.IsLoop; set => WrappedObject.IsLoop = value;}
        public Boolean IsMuted { get => WrappedObject.IsMuted; set => WrappedObject.IsMuted = value;}
        public Boolean IsPaused { get => WrappedObject.IsPaused; }
        public Boolean IsSeeking { get => WrappedObject.IsSeeking; }
        public Boolean IsShowingControls { get => WrappedObject.IsShowingControls; set => WrappedObject.IsShowingControls = value;}
        public Boolean IsSpellChecked { get => WrappedObject.IsSpellChecked; set => WrappedObject.IsSpellChecked = value;}
        public Boolean IsTranslated { get => WrappedObject.IsTranslated; set => WrappedObject.IsTranslated = value;}
        public String Language { get => WrappedObject.Language; set => WrappedObject.Language = value;}
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
        public IMediaError MediaError { get => WrappedObject.MediaError; }
        public String MediaGroup { get => WrappedObject.MediaGroup; set => WrappedObject.MediaGroup = value;}
        public String NamespaceUri { get => WrappedObject.NamespaceUri; }
        public MediaNetworkState NetworkState { get => WrappedObject.NetworkState; }
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
        public Int32 OriginalHeight { get => WrappedObject.OriginalHeight; }
        public Int32 OriginalWidth { get => WrappedObject.OriginalWidth; }
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
        public Double PlaybackRate { get => WrappedObject.PlaybackRate; set => WrappedObject.PlaybackRate = value;}
        public MediaControllerPlaybackState PlaybackState { get => WrappedObject.PlaybackState; }
        public ITimeRanges PlayedTime { get => WrappedObject.PlayedTime; }
        public String Poster { get => WrappedObject.Poster; set => WrappedObject.Poster = value;}
        public String Prefix { get => WrappedObject.Prefix; }
        public String Preload { get => WrappedObject.Preload; set => WrappedObject.Preload = value;}
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
        public MediaReadyState ReadyState { get => WrappedObject.ReadyState; }
        public ITimeRanges SeekableTime { get => WrappedObject.SeekableTime; }
        public IShadowRoot? ShadowRoot
        {
            get
            {
                if (_shadowRoot is null || ((IWrapper)_shadowRoot).IsRemoved) _shadowRoot = GetOrWrap(() => WrappedObject.ShadowRoot);
                return _shadowRoot;
            }
        }
        public String Slot { get => WrappedObject.Slot; set => WrappedObject.Slot = value;}
        public String Source { get => WrappedObject.Source; set => WrappedObject.Source = value;}
        public ISourceReference SourceReference { get => WrappedObject.SourceReference; }
        public DateTime StartDate { get => WrappedObject.StartDate; }
        public Int32 TabIndex { get => WrappedObject.TabIndex; set => WrappedObject.TabIndex = value;}
        public String TagName { get => WrappedObject.TagName; }
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}
        public ITextTrackList TextTracks { get => WrappedObject.TextTracks; }
        public String Title { get => WrappedObject.Title; set => WrappedObject.Title = value;}
        public IVideoTrackList VideoTracks { get => WrappedObject.VideoTracks; }
        public Double Volume { get => WrappedObject.Volume; set => WrappedObject.Volume = value;}
        #endregion

        #region Methods
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.AddEventListener(type, callback, capture);
        public ITextTrack AddTextTrack(String kind, String label, String language) => WrappedObject.AddTextTrack(kind, label, language);
        public void After(INode[] nodes) => WrappedObject.After(nodes);
        public void Append(INode[] nodes) => WrappedObject.Append(nodes);
        public INode AppendChild(INode child) => WrappedObject.AppendChild(child);
        public IShadowRoot AttachShadow(ShadowRootMode mode) => WrappedObject.AttachShadow(mode);
        public void Before(INode[] nodes) => WrappedObject.Before(nodes);
        public String CanPlayType(String type) => WrappedObject.CanPlayType(type);
        public INode Clone(Boolean deep) => WrappedObject.Clone(deep);
        public IElement Closest(String selectors) => WrappedObject.Closest(selectors);
        public DocumentPositions CompareDocumentPosition(INode otherNode) => WrappedObject.CompareDocumentPosition(otherNode);
        public Boolean Contains(INode otherNode) => WrappedObject.Contains(otherNode);
        public Boolean Dispatch(Event ev) => WrappedObject.Dispatch(ev);
        public void DoBlur() => WrappedObject.DoBlur();
        public void DoClick() => WrappedObject.DoClick();
        public void DoFocus() => WrappedObject.DoFocus();
        public void DoSpellCheck() => WrappedObject.DoSpellCheck();
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
        public void Load() => WrappedObject.Load();
        public String LookupNamespaceUri(String prefix) => WrappedObject.LookupNamespaceUri(prefix);
        public String LookupPrefix(String namespaceUri) => WrappedObject.LookupPrefix(namespaceUri);
        public Boolean Matches(String selectors) => WrappedObject.Matches(selectors);
        public void Normalize() => WrappedObject.Normalize();
        public void Pause() => WrappedObject.Pause();
        public void Play() => WrappedObject.Play();
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
