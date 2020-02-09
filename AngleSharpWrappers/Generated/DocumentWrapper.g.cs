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
    #nullable disable
    /// <summary>
    /// Represents a wrapper class around <see cref="IDocument"/> type.
    /// </summary>
    public partial class DocumentWrapper : Wrapper<IDocument>, IDocument, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="DocumentWrapper"/> type;
        /// </summary>
        internal DocumentWrapper(WrapperFactory factory, IDocument initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

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
        public event DomEventHandler ReadyStateChanged { add => WrappedObject.ReadyStateChanged += value; remove => WrappedObject.ReadyStateChanged -= value; }

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
        public IElement ActiveElement { get => GetOrWrap(() => WrappedObject.ActiveElement); }

        /// <inheritdoc/>
        public IHtmlAllCollection All { get => GetOrWrap(() => WrappedObject.All); }

        /// <inheritdoc/>
        public IHtmlCollection<IHtmlAnchorElement> Anchors { get => GetOrWrap(() => WrappedObject.Anchors); }

        /// <inheritdoc/>
        public String BaseUri { get => WrappedObject.BaseUri; }

        /// <inheritdoc/>
        public Url BaseUrl { get => WrappedObject.BaseUrl; }

        /// <inheritdoc/>
        public IHtmlElement Body { get => GetOrWrap(() => WrappedObject.Body); set => WrappedObject.Body = value;}

        /// <inheritdoc/>
        public String CharacterSet { get => WrappedObject.CharacterSet; }

        /// <inheritdoc/>
        public Int32 ChildElementCount { get => WrappedObject.ChildElementCount; }

        /// <inheritdoc/>
        public INodeList ChildNodes { get => GetOrWrap(() => WrappedObject.ChildNodes); }

        /// <inheritdoc/>
        public IHtmlCollection<IElement> Children { get => GetOrWrap(() => WrappedObject.Children); }

        /// <inheritdoc/>
        public IHtmlCollection<IElement> Commands { get => GetOrWrap(() => WrappedObject.Commands); }

        /// <inheritdoc/>
        public String CompatMode { get => WrappedObject.CompatMode; }

        /// <inheritdoc/>
        public String ContentType { get => WrappedObject.ContentType; }

        /// <inheritdoc/>
        public IBrowsingContext Context { get => WrappedObject.Context; }

        /// <inheritdoc/>
        public String Cookie { get => WrappedObject.Cookie; set => WrappedObject.Cookie = value;}

        /// <inheritdoc/>
        public IHtmlScriptElement CurrentScript { get => GetOrWrap(() => WrappedObject.CurrentScript); }

        /// <inheritdoc/>
        public IWindow DefaultView { get => WrappedObject.DefaultView; }

        /// <inheritdoc/>
        public String DesignMode { get => WrappedObject.DesignMode; set => WrappedObject.DesignMode = value;}

        /// <inheritdoc/>
        public String Direction { get => WrappedObject.Direction; set => WrappedObject.Direction = value;}

        /// <inheritdoc/>
        public IDocumentType Doctype { get => GetOrWrap(() => WrappedObject.Doctype); }

        /// <inheritdoc/>
        public IElement DocumentElement { get => GetOrWrap(() => WrappedObject.DocumentElement); }

        /// <inheritdoc/>
        public String DocumentUri { get => WrappedObject.DocumentUri; }

        /// <inheritdoc/>
        public String Domain { get => WrappedObject.Domain; set => WrappedObject.Domain = value;}

        /// <inheritdoc/>
        public IEntityProvider Entities { get => WrappedObject.Entities; }

        /// <inheritdoc/>
        public INode FirstChild { get => GetOrWrap(() => WrappedObject.FirstChild); }

        /// <inheritdoc/>
        public IElement FirstElementChild { get => GetOrWrap(() => WrappedObject.FirstElementChild); }

        /// <inheritdoc/>
        public NodeFlags Flags { get => WrappedObject.Flags; }

        /// <inheritdoc/>
        public IHtmlCollection<IHtmlFormElement> Forms { get => GetOrWrap(() => WrappedObject.Forms); }

        /// <inheritdoc/>
        public Boolean HasChildNodes { get => WrappedObject.HasChildNodes; }

        /// <inheritdoc/>
        public IHtmlHeadElement Head { get => GetOrWrap(() => WrappedObject.Head); }

        /// <inheritdoc/>
        public IHtmlCollection<IHtmlImageElement> Images { get => GetOrWrap(() => WrappedObject.Images); }

        /// <inheritdoc/>
        public IImplementation Implementation { get => WrappedObject.Implementation; }

        /// <inheritdoc/>
        public IDocument ImportAncestor { get => GetOrWrap(() => WrappedObject.ImportAncestor); }

        /// <inheritdoc/>
        public INode LastChild { get => GetOrWrap(() => WrappedObject.LastChild); }

        /// <inheritdoc/>
        public IElement LastElementChild { get => GetOrWrap(() => WrappedObject.LastElementChild); }

        /// <inheritdoc/>
        public String LastModified { get => WrappedObject.LastModified; }

        /// <inheritdoc/>
        public String LastStyleSheetSet { get => WrappedObject.LastStyleSheetSet; }

        /// <inheritdoc/>
        public IHtmlCollection<IElement> Links { get => GetOrWrap(() => WrappedObject.Links); }

        /// <inheritdoc/>
        public ILocation Location { get => WrappedObject.Location; }

        /// <inheritdoc/>
        public INode NextSibling { get => GetOrWrap(() => WrappedObject.NextSibling); }

        /// <inheritdoc/>
        public String NodeName { get => WrappedObject.NodeName; }

        /// <inheritdoc/>
        public NodeType NodeType { get => WrappedObject.NodeType; }

        /// <inheritdoc/>
        public String NodeValue { get => WrappedObject.NodeValue; set => WrappedObject.NodeValue = value;}

        /// <inheritdoc/>
        public String Origin { get => WrappedObject.Origin; }

        /// <inheritdoc/>
        public IDocument Owner { get => GetOrWrap(() => WrappedObject.Owner); }

        /// <inheritdoc/>
        public INode Parent { get => GetOrWrap(() => WrappedObject.Parent); }

        /// <inheritdoc/>
        public IElement ParentElement { get => GetOrWrap(() => WrappedObject.ParentElement); }

        /// <inheritdoc/>
        public IHtmlCollection<IHtmlEmbedElement> Plugins { get => GetOrWrap(() => WrappedObject.Plugins); }

        /// <inheritdoc/>
        public String PreferredStyleSheetSet { get => WrappedObject.PreferredStyleSheetSet; }

        /// <inheritdoc/>
        public INode PreviousSibling { get => GetOrWrap(() => WrappedObject.PreviousSibling); }

        /// <inheritdoc/>
        public DocumentReadyState ReadyState { get => WrappedObject.ReadyState; }

        /// <inheritdoc/>
        public String Referrer { get => WrappedObject.Referrer; }

        /// <inheritdoc/>
        public IHtmlCollection<IHtmlScriptElement> Scripts { get => GetOrWrap(() => WrappedObject.Scripts); }

        /// <inheritdoc/>
        public String SelectedStyleSheetSet { get => WrappedObject.SelectedStyleSheetSet; set => WrappedObject.SelectedStyleSheetSet = value;}

        /// <inheritdoc/>
        public TextSource Source { get => WrappedObject.Source; }

        /// <inheritdoc/>
        public HttpStatusCode StatusCode { get => WrappedObject.StatusCode; }

        /// <inheritdoc/>
        public IStyleSheetList StyleSheets { get => GetOrWrap(() => WrappedObject.StyleSheets); }

        /// <inheritdoc/>
        public IStringList StyleSheetSets { get => GetOrWrap(() => WrappedObject.StyleSheetSets); }

        /// <inheritdoc/>
        public String TextContent { get => WrappedObject.TextContent; set => WrappedObject.TextContent = value;}

        /// <inheritdoc/>
        public String Title { get => WrappedObject.Title; set => WrappedObject.Title = value;}

        /// <inheritdoc/>
        public String Url { get => WrappedObject.Url; }

        /// <inheritdoc/>
        public void AddEventListener(String type, DomEventHandler callback, Boolean capture)
            => WrappedObject.AddEventListener(type, callback, capture);

        /// <inheritdoc/>
        public INode Adopt(INode externalNode)
            => GetOrWrap(() => WrappedObject.Adopt(externalNode));

        /// <inheritdoc/>
        public void Append(INode[] nodes)
            => WrappedObject.Append(nodes);

        /// <inheritdoc/>
        public INode AppendChild(INode child)
            => GetOrWrap(() => WrappedObject.AppendChild(child));

        /// <inheritdoc/>
        public INode Clone(Boolean deep)
            => GetOrWrap(() => WrappedObject.Clone(deep));

        /// <inheritdoc/>
        public void Close()
            => WrappedObject.Close();

        /// <inheritdoc/>
        public DocumentPositions CompareDocumentPosition(INode otherNode)
            => WrappedObject.CompareDocumentPosition(otherNode);

        /// <inheritdoc/>
        public Boolean Contains(INode otherNode)
            => WrappedObject.Contains(otherNode);

        /// <inheritdoc/>
        public IAttr CreateAttribute(String name)
            => GetOrWrap(() => WrappedObject.CreateAttribute(name));

        /// <inheritdoc/>
        public IAttr CreateAttribute(String namespaceUri, String name)
            => GetOrWrap(() => WrappedObject.CreateAttribute(namespaceUri, name));

        /// <inheritdoc/>
        public IComment CreateComment(String data)
            => GetOrWrap(() => WrappedObject.CreateComment(data));

        /// <inheritdoc/>
        public IDocumentFragment CreateDocumentFragment()
            => GetOrWrap(() => WrappedObject.CreateDocumentFragment());

        /// <inheritdoc/>
        public IElement CreateElement(String name)
            => GetOrWrap(() => WrappedObject.CreateElement(name));

        /// <inheritdoc/>
        public IElement CreateElement(String namespaceUri, String name)
            => GetOrWrap(() => WrappedObject.CreateElement(namespaceUri, name));

        /// <inheritdoc/>
        public Event CreateEvent(String type)
            => WrappedObject.CreateEvent(type);

        /// <inheritdoc/>
        public INodeIterator CreateNodeIterator(INode root, FilterSettings settings, NodeFilter filter)
            => WrappedObject.CreateNodeIterator(root, settings, filter);

        /// <inheritdoc/>
        public IProcessingInstruction CreateProcessingInstruction(String target, String data)
            => GetOrWrap(() => WrappedObject.CreateProcessingInstruction(target, data));

        /// <inheritdoc/>
        public IRange CreateRange()
            => WrappedObject.CreateRange();

        /// <inheritdoc/>
        public IText CreateTextNode(String data)
            => GetOrWrap(() => WrappedObject.CreateTextNode(data));

        /// <inheritdoc/>
        public ITreeWalker CreateTreeWalker(INode root, FilterSettings settings, NodeFilter filter)
            => WrappedObject.CreateTreeWalker(root, settings, filter);

        /// <inheritdoc/>
        public Boolean Dispatch(Event ev)
            => WrappedObject.Dispatch(ev);

        /// <inheritdoc/>
        public void Dispose()
            => WrappedObject.Dispose();

        /// <inheritdoc/>
        public void EnableStyleSheetsForSet(String name)
            => WrappedObject.EnableStyleSheetsForSet(name);

        /// <inheritdoc/>
        public Boolean Equals(INode otherNode)
            => WrappedObject.Equals(otherNode);

        /// <inheritdoc/>
        public Boolean ExecuteCommand(String commandId, Boolean showUserInterface, String value)
            => WrappedObject.ExecuteCommand(commandId, showUserInterface, value);

        /// <inheritdoc/>
        public String GetCommandValue(String commandId)
            => WrappedObject.GetCommandValue(commandId);

        /// <inheritdoc/>
        public IElement GetElementById(String elementId)
            => GetOrWrap(() => WrappedObject.GetElementById(elementId));

        /// <inheritdoc/>
        public IHtmlCollection<IElement> GetElementsByClassName(String classNames)
            => GetOrWrap(() => WrappedObject.GetElementsByClassName(classNames));

        /// <inheritdoc/>
        public IHtmlCollection<IElement> GetElementsByName(String name)
            => GetOrWrap(() => WrappedObject.GetElementsByName(name));

        /// <inheritdoc/>
        public IHtmlCollection<IElement> GetElementsByTagName(String tagName)
            => GetOrWrap(() => WrappedObject.GetElementsByTagName(tagName));

        /// <inheritdoc/>
        public IHtmlCollection<IElement> GetElementsByTagName(String namespaceUri, String tagName)
            => GetOrWrap(() => WrappedObject.GetElementsByTagName(namespaceUri, tagName));

        /// <inheritdoc/>
        public Boolean HasFocus()
            => WrappedObject.HasFocus();

        /// <inheritdoc/>
        public INode Import(INode externalNode, Boolean deep)
            => GetOrWrap(() => WrappedObject.Import(externalNode, deep));

        /// <inheritdoc/>
        public INode InsertBefore(INode newElement, INode referenceElement)
            => GetOrWrap(() => WrappedObject.InsertBefore(newElement, referenceElement));

        /// <inheritdoc/>
        public void InvokeEventListener(Event ev)
            => WrappedObject.InvokeEventListener(ev);

        /// <inheritdoc/>
        public Boolean IsCommandEnabled(String commandId)
            => WrappedObject.IsCommandEnabled(commandId);

        /// <inheritdoc/>
        public Boolean IsCommandExecuted(String commandId)
            => WrappedObject.IsCommandExecuted(commandId);

        /// <inheritdoc/>
        public Boolean IsCommandIndeterminate(String commandId)
            => WrappedObject.IsCommandIndeterminate(commandId);

        /// <inheritdoc/>
        public Boolean IsCommandSupported(String commandId)
            => WrappedObject.IsCommandSupported(commandId);

        /// <inheritdoc/>
        public Boolean IsDefaultNamespace(String namespaceUri)
            => WrappedObject.IsDefaultNamespace(namespaceUri);

        /// <inheritdoc/>
        public void Load(String url)
            => WrappedObject.Load(url);

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
        public IDocument Open(String type, String replace)
            => GetOrWrap(() => WrappedObject.Open(type, replace));

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
        public INode RemoveChild(INode child)
            => GetOrWrap(() => WrappedObject.RemoveChild(child));

        /// <inheritdoc/>
        public void RemoveEventListener(String type, DomEventHandler callback, Boolean capture)
            => WrappedObject.RemoveEventListener(type, callback, capture);

        /// <inheritdoc/>
        public INode ReplaceChild(INode newChild, INode oldChild)
            => GetOrWrap(() => WrappedObject.ReplaceChild(newChild, oldChild));

        /// <inheritdoc/>
        public void ToHtml(TextWriter writer, IMarkupFormatter formatter)
            => WrappedObject.ToHtml(writer, formatter);

        /// <inheritdoc/>
        public void Write(String content)
            => WrappedObject.Write(content);

        /// <inheritdoc/>
        public void WriteLine(String content)
            => WrappedObject.WriteLine(content);
    }
}
