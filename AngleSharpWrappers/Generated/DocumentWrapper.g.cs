using System;
using System.IO;
using System.Net;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using AngleSharp.Html.Dom;
using AngleSharp.Text;

namespace AngleSharpWrappers
{
    #nullable enable
    /// <summary>
    /// Represents a wrapper class around <see cref="IDocument"/> type.
    /// </summary>
    internal sealed class DocumentWrapper : Wrapper<IDocument>, IDocument, IWrapper<IDocument>
    {
        private IElement? _activeElement;
        private IHtmlElement? _body;
        private INodeList? _childNodes;
        private IHtmlScriptElement? _currentScript;
        private IDocumentType? _doctype;
        private IElement? _documentElement;
        private INode? _firstChild;
        private IElement? _firstElementChild;
        private IHtmlHeadElement? _head;
        private IDocument? _importAncestor;
        private INode? _lastChild;
        private IElement? _lastElementChild;
        private INode? _nextSibling;
        private IDocument? _owner;
        private INode? _parent;
        private IElement? _parentElement;
        private INode? _previousSibling;

        /// <summary>
        /// Creates an instance of the <see cref="DocumentWrapper"/> type;
        /// </summary>
        internal DocumentWrapper(WrapperFactory factory, IDocument initialObject, Func<object?> query) : base(factory, initialObject, query) { }

        #region Events
        public event DomEventHandler Aborted { add => WrappedObject.Aborted += value; remove => WrappedObject.Aborted -= value; }
        public event DomEventHandler Blurred { add => WrappedObject.Blurred += value; remove => WrappedObject.Blurred -= value; }
        public event DomEventHandler Cancelled { add => WrappedObject.Cancelled += value; remove => WrappedObject.Cancelled -= value; }
        public event DomEventHandler CanPlay { add => WrappedObject.CanPlay += value; remove => WrappedObject.CanPlay -= value; }
        public event DomEventHandler CanPlayThrough { add => WrappedObject.CanPlayThrough += value; remove => WrappedObject.CanPlayThrough -= value; }
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
        public event DomEventHandler DurationChanged { add => WrappedObject.DurationChanged += value; remove => WrappedObject.DurationChanged -= value; }
        public event DomEventHandler Emptied { add => WrappedObject.Emptied += value; remove => WrappedObject.Emptied -= value; }
        public event DomEventHandler Ended { add => WrappedObject.Ended += value; remove => WrappedObject.Ended -= value; }
        public event DomEventHandler Error { add => WrappedObject.Error += value; remove => WrappedObject.Error -= value; }
        public event DomEventHandler Focused { add => WrappedObject.Focused += value; remove => WrappedObject.Focused -= value; }
        public event DomEventHandler Input { add => WrappedObject.Input += value; remove => WrappedObject.Input -= value; }
        public event DomEventHandler Invalid { add => WrappedObject.Invalid += value; remove => WrappedObject.Invalid -= value; }
        public event DomEventHandler KeyDown { add => WrappedObject.KeyDown += value; remove => WrappedObject.KeyDown -= value; }
        public event DomEventHandler KeyPress { add => WrappedObject.KeyPress += value; remove => WrappedObject.KeyPress -= value; }
        public event DomEventHandler KeyUp { add => WrappedObject.KeyUp += value; remove => WrappedObject.KeyUp -= value; }
        public event DomEventHandler Loaded { add => WrappedObject.Loaded += value; remove => WrappedObject.Loaded -= value; }
        public event DomEventHandler LoadedData { add => WrappedObject.LoadedData += value; remove => WrappedObject.LoadedData -= value; }
        public event DomEventHandler LoadedMetadata { add => WrappedObject.LoadedMetadata += value; remove => WrappedObject.LoadedMetadata -= value; }
        public event DomEventHandler Loading { add => WrappedObject.Loading += value; remove => WrappedObject.Loading -= value; }
        public event DomEventHandler MouseDown { add => WrappedObject.MouseDown += value; remove => WrappedObject.MouseDown -= value; }
        public event DomEventHandler MouseEnter { add => WrappedObject.MouseEnter += value; remove => WrappedObject.MouseEnter -= value; }
        public event DomEventHandler MouseLeave { add => WrappedObject.MouseLeave += value; remove => WrappedObject.MouseLeave -= value; }
        public event DomEventHandler MouseMove { add => WrappedObject.MouseMove += value; remove => WrappedObject.MouseMove -= value; }
        public event DomEventHandler MouseOut { add => WrappedObject.MouseOut += value; remove => WrappedObject.MouseOut -= value; }
        public event DomEventHandler MouseOver { add => WrappedObject.MouseOver += value; remove => WrappedObject.MouseOver -= value; }
        public event DomEventHandler MouseUp { add => WrappedObject.MouseUp += value; remove => WrappedObject.MouseUp -= value; }
        public event DomEventHandler MouseWheel { add => WrappedObject.MouseWheel += value; remove => WrappedObject.MouseWheel -= value; }
        public event DomEventHandler Paused { add => WrappedObject.Paused += value; remove => WrappedObject.Paused -= value; }
        public event DomEventHandler Played { add => WrappedObject.Played += value; remove => WrappedObject.Played -= value; }
        public event DomEventHandler Playing { add => WrappedObject.Playing += value; remove => WrappedObject.Playing -= value; }
        public event DomEventHandler Progress { add => WrappedObject.Progress += value; remove => WrappedObject.Progress -= value; }
        public event DomEventHandler RateChanged { add => WrappedObject.RateChanged += value; remove => WrappedObject.RateChanged -= value; }
        public event DomEventHandler ReadyStateChanged { add => WrappedObject.ReadyStateChanged += value; remove => WrappedObject.ReadyStateChanged -= value; }
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
        public event DomEventHandler TimeUpdated { add => WrappedObject.TimeUpdated += value; remove => WrappedObject.TimeUpdated -= value; }
        public event DomEventHandler Toggled { add => WrappedObject.Toggled += value; remove => WrappedObject.Toggled -= value; }
        public event DomEventHandler VolumeChanged { add => WrappedObject.VolumeChanged += value; remove => WrappedObject.VolumeChanged -= value; }
        public event DomEventHandler Waiting { add => WrappedObject.Waiting += value; remove => WrappedObject.Waiting -= value; }
        #endregion

        #region Properties and indexers
        public IElement? ActiveElement
        {
            get
            {
                if (_activeElement is null || ((IWrapper)_activeElement).IsRemoved) _activeElement = GetOrWrap(() => WrappedObject.ActiveElement);
                return _activeElement;
            }
        }
        public IHtmlAllCollection All { get => WrappedObject.All; }
        public IHtmlCollection<IHtmlAnchorElement> Anchors { get => WrappedObject.Anchors; }
        public String BaseUri { get => WrappedObject.BaseUri; }
        public Url BaseUrl { get => WrappedObject.BaseUrl; }
        public IHtmlElement? Body
        {
            get
            {
                if (_body is null || ((IWrapper)_body).IsRemoved) _body = GetOrWrap(() => WrappedObject.Body);
                return _body;
            }
            set => WrappedObject.Body = value;
        }
        public String CharacterSet { get => WrappedObject.CharacterSet; }
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
        public IHtmlCollection<IElement> Commands { get => WrappedObject.Commands; }
        public String CompatMode { get => WrappedObject.CompatMode; }
        public String ContentType { get => WrappedObject.ContentType; }
        public IBrowsingContext Context { get => WrappedObject.Context; }
        public String Cookie { get => WrappedObject.Cookie; set => WrappedObject.Cookie = value;}
        public IHtmlScriptElement? CurrentScript
        {
            get
            {
                if (_currentScript is null || ((IWrapper)_currentScript).IsRemoved) _currentScript = GetOrWrap(() => WrappedObject.CurrentScript);
                return _currentScript;
            }
        }
        public IWindow DefaultView { get => WrappedObject.DefaultView; }
        public String DesignMode { get => WrappedObject.DesignMode; set => WrappedObject.DesignMode = value;}
        public String Direction { get => WrappedObject.Direction; set => WrappedObject.Direction = value;}
        public IDocumentType? Doctype
        {
            get
            {
                if (_doctype is null || ((IWrapper)_doctype).IsRemoved) _doctype = GetOrWrap(() => WrappedObject.Doctype);
                return _doctype;
            }
        }
        public IElement? DocumentElement
        {
            get
            {
                if (_documentElement is null || ((IWrapper)_documentElement).IsRemoved) _documentElement = GetOrWrap(() => WrappedObject.DocumentElement);
                return _documentElement;
            }
        }
        public String DocumentUri { get => WrappedObject.DocumentUri; }
        public String Domain { get => WrappedObject.Domain; set => WrappedObject.Domain = value;}
        public IEntityProvider Entities { get => WrappedObject.Entities; }
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
        public IHtmlCollection<IHtmlFormElement> Forms { get => WrappedObject.Forms; }
        public Boolean HasChildNodes { get => WrappedObject.HasChildNodes; }
        public IHtmlHeadElement? Head
        {
            get
            {
                if (_head is null || ((IWrapper)_head).IsRemoved) _head = GetOrWrap(() => WrappedObject.Head);
                return _head;
            }
        }
        public IHtmlCollection<IHtmlImageElement> Images { get => WrappedObject.Images; }
        public IImplementation Implementation { get => WrappedObject.Implementation; }
        public IDocument? ImportAncestor
        {
            get
            {
                if (_importAncestor is null || ((IWrapper)_importAncestor).IsRemoved) _importAncestor = GetOrWrap(() => WrappedObject.ImportAncestor);
                return _importAncestor;
            }
        }
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
        public String LastModified { get => WrappedObject.LastModified; }
        public String LastStyleSheetSet { get => WrappedObject.LastStyleSheetSet; }
        public IHtmlCollection<IElement> Links { get => WrappedObject.Links; }
        public ILocation Location { get => WrappedObject.Location; }
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
        public String Origin { get => WrappedObject.Origin; }
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
        public IHtmlCollection<IHtmlEmbedElement> Plugins { get => WrappedObject.Plugins; }
        public String PreferredStyleSheetSet { get => WrappedObject.PreferredStyleSheetSet; }
        public INode? PreviousSibling
        {
            get
            {
                if (_previousSibling is null || ((IWrapper)_previousSibling).IsRemoved) _previousSibling = GetOrWrap(() => WrappedObject.PreviousSibling);
                return _previousSibling;
            }
        }
        public DocumentReadyState ReadyState { get => WrappedObject.ReadyState; }
        public String Referrer { get => WrappedObject.Referrer; }
        public IHtmlCollection<IHtmlScriptElement> Scripts { get => WrappedObject.Scripts; }
        public String SelectedStyleSheetSet { get => WrappedObject.SelectedStyleSheetSet; set => WrappedObject.SelectedStyleSheetSet = value;}
        public TextSource Source { get => WrappedObject.Source; }
        public HttpStatusCode StatusCode { get => WrappedObject.StatusCode; }
        public IStyleSheetList StyleSheets { get => WrappedObject.StyleSheets; }
        public IStringList StyleSheetSets { get => WrappedObject.StyleSheetSets; }
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}
        public String Title { get => WrappedObject.Title; set => WrappedObject.Title = value;}
        public String Url { get => WrappedObject.Url; }
        #endregion

        #region Methods
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.AddEventListener(type, callback, capture);
        public INode Adopt(INode externalNode) => WrappedObject.Adopt(externalNode);
        public void Append(INode[] nodes) => WrappedObject.Append(nodes);
        public INode AppendChild(INode child) => WrappedObject.AppendChild(child);
        public INode Clone(Boolean deep) => WrappedObject.Clone(deep);
        public void Close() => WrappedObject.Close();
        public DocumentPositions CompareDocumentPosition(INode otherNode) => WrappedObject.CompareDocumentPosition(otherNode);
        public Boolean Contains(INode otherNode) => WrappedObject.Contains(otherNode);
        public IAttr CreateAttribute(String name) => WrappedObject.CreateAttribute(name);
        public IAttr CreateAttribute(String namespaceUri, String name) => WrappedObject.CreateAttribute(namespaceUri, name);
        public IComment CreateComment(String data) => WrappedObject.CreateComment(data);
        public IDocumentFragment CreateDocumentFragment() => WrappedObject.CreateDocumentFragment();
        public IElement CreateElement(String name) => WrappedObject.CreateElement(name);
        public IElement CreateElement(String namespaceUri, String name) => WrappedObject.CreateElement(namespaceUri, name);
        public Event CreateEvent(String type) => WrappedObject.CreateEvent(type);
        public INodeIterator CreateNodeIterator(INode root, FilterSettings settings, NodeFilter filter) => WrappedObject.CreateNodeIterator(root, settings, filter);
        public IProcessingInstruction CreateProcessingInstruction(String target, String data) => WrappedObject.CreateProcessingInstruction(target, data);
        public IRange CreateRange() => WrappedObject.CreateRange();
        public IText CreateTextNode(String data) => WrappedObject.CreateTextNode(data);
        public ITreeWalker CreateTreeWalker(INode root, FilterSettings settings, NodeFilter filter) => WrappedObject.CreateTreeWalker(root, settings, filter);
        public Boolean Dispatch(Event ev) => WrappedObject.Dispatch(ev);
        public void Dispose() => WrappedObject.Dispose();
        public void EnableStyleSheetsForSet(String name) => WrappedObject.EnableStyleSheetsForSet(name);
        public Boolean Equals(INode otherNode) => WrappedObject.Equals(otherNode);
        public Boolean ExecuteCommand(String commandId, Boolean showUserInterface, String value) => WrappedObject.ExecuteCommand(commandId, showUserInterface, value);
        public String GetCommandValue(String commandId) => WrappedObject.GetCommandValue(commandId);
        public IElement GetElementById(String elementId) => WrappedObject.GetElementById(elementId);
        public IHtmlCollection<IElement> GetElementsByClassName(String classNames) => WrappedObject.GetElementsByClassName(classNames);
        public IHtmlCollection<IElement> GetElementsByName(String name) => WrappedObject.GetElementsByName(name);
        public IHtmlCollection<IElement> GetElementsByTagName(String tagName) => WrappedObject.GetElementsByTagName(tagName);
        public IHtmlCollection<IElement> GetElementsByTagName(String namespaceUri, String tagName) => WrappedObject.GetElementsByTagName(namespaceUri, tagName);
        public Boolean HasFocus() => WrappedObject.HasFocus();
        public INode Import(INode externalNode, Boolean deep) => WrappedObject.Import(externalNode, deep);
        public INode InsertBefore(INode newElement, INode referenceElement) => WrappedObject.InsertBefore(newElement, referenceElement);
        public void InvokeEventListener(Event ev) => WrappedObject.InvokeEventListener(ev);
        public Boolean IsCommandEnabled(String commandId) => WrappedObject.IsCommandEnabled(commandId);
        public Boolean IsCommandExecuted(String commandId) => WrappedObject.IsCommandExecuted(commandId);
        public Boolean IsCommandIndeterminate(String commandId) => WrappedObject.IsCommandIndeterminate(commandId);
        public Boolean IsCommandSupported(String commandId) => WrappedObject.IsCommandSupported(commandId);
        public Boolean IsDefaultNamespace(String namespaceUri) => WrappedObject.IsDefaultNamespace(namespaceUri);
        public void Load(String url) => WrappedObject.Load(url);
        public String LookupNamespaceUri(String prefix) => WrappedObject.LookupNamespaceUri(prefix);
        public String LookupPrefix(String namespaceUri) => WrappedObject.LookupPrefix(namespaceUri);
        public void Normalize() => WrappedObject.Normalize();
        public IDocument Open(String type, String replace) => WrappedObject.Open(type, replace);
        public void Prepend(INode[] nodes) => WrappedObject.Prepend(nodes);
        public IElement QuerySelector(String selectors) => WrappedObject.QuerySelector(selectors);
        public IHtmlCollection<IElement> QuerySelectorAll(String selectors) => WrappedObject.QuerySelectorAll(selectors);
        public INode RemoveChild(INode child) => WrappedObject.RemoveChild(child);
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture) => WrappedObject.RemoveEventListener(type, callback, capture);
        public INode ReplaceChild(INode newChild, INode oldChild) => WrappedObject.ReplaceChild(newChild, oldChild);
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter) => WrappedObject.ToHtml(writer, formatter);
        public void Write(String content) => WrappedObject.Write(content);
        public void WriteLine(String content) => WrappedObject.WriteLine(content);
        #endregion
    }
}
