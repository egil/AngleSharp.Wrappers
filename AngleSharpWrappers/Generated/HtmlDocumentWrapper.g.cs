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
    /// Represents a wrapper class around <see cref="IHtmlDocument"/> type.
    /// </summary>
    public partial class HtmlDocumentWrapper : Wrapper<IHtmlDocument>, IHtmlDocument, IWrapper
    {
        /// <summary>
        /// Creates an instance of the <see cref="HtmlDocumentWrapper"/> type;
        /// </summary>
        internal HtmlDocumentWrapper(WrapperFactory factory, IHtmlDocument initialObject, Func<object> getObject) : base(factory, initialObject, getObject) { }

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
        public event DomEventHandler ReadyStateChanged { add => WrappedObject.ReadyStateChanged += value; remove => WrappedObject.ReadyStateChanged -= value; }

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
