using System;
using System.Collections.Generic;
using AngleSharp.Css.Dom;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Io.Dom;
using AngleSharp.Media.Dom;
using AngleSharp.Svg.Dom;
namespace AngleSharpWrappers
{
    #nullable enable
    public partial class WrapperFactory
    {
        /// <summary>
        /// Wraps an AngleSharp object in the wrapper specific to it.
        /// </summary>
        /// <typeparam name="T">The AngleSharp type.</typeparam>
        /// <param name="initialObject">The initial object to wrap.</param>
        /// <param name="objectQuery">A query method for refreshing the wrapped object.</param>
        /// <returns>The <see cref="IWrapper"/> wrapped object.</returns>
        internal IWrapper GetOrCreate<T>(T initialObject, Func<T?> objectQuery) where T : class
        {
            return initialObject switch
            {
                IAttr _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new AttrWrapper(this, (IAttr)io, oq), objectQuery),
                IAudioTrackList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new AudioTrackListWrapper(this, (IAudioTrackList)io, oq), objectQuery),
                IFileList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new FileListWrapper(this, (IFileList)io, oq), objectQuery),
                IHtmlAllCollection _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlAllCollectionWrapper(this, (IHtmlAllCollection)io, oq), objectQuery),
                IHtmlFormControlsCollection _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlFormControlsCollectionWrapper(this, (IHtmlFormControlsCollection)io, oq), objectQuery),
                IHtmlOptionsCollection _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlOptionsCollectionWrapper(this, (IHtmlOptionsCollection)io, oq), objectQuery),
                IMediaList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new MediaListWrapper(this, (IMediaList)io, oq), objectQuery),
                INamedNodeMap _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new NamedNodeMapWrapper(this, (INamedNodeMap)io, oq), objectQuery),
                INodeList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new NodeListWrapper(this, (INodeList)io, oq), objectQuery),
                ISettableTokenList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new SettableTokenListWrapper(this, (ISettableTokenList)io, oq), objectQuery),
                IStringList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new StringListWrapper(this, (IStringList)io, oq), objectQuery),
                IStringMap _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new StringMapWrapper(this, (IStringMap)io, oq), objectQuery),
                IStyleSheetList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new StyleSheetListWrapper(this, (IStyleSheetList)io, oq), objectQuery),
                ITextTrackCueList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new TextTrackCueListWrapper(this, (ITextTrackCueList)io, oq), objectQuery),
                ITextTrackList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new TextTrackListWrapper(this, (ITextTrackList)io, oq), objectQuery),
                ITokenList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new TokenListWrapper(this, (ITokenList)io, oq), objectQuery),
                IVideoTrackList _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new VideoTrackListWrapper(this, (IVideoTrackList)io, oq), objectQuery),
                INode node => GetOrCreateNode(node, objectQuery),
                _ => throw new InvalidOperationException($"Unknown type. Cannot create wrapper for {initialObject.GetType()}"),
            };
        }

        /// <summary>
        /// Wraps an <see cref="INode"/> in the wrapper specific to it.
        /// </summary>
        /// <typeparam name="T">The node type.</typeparam>
        /// <param name="initialObject">The initial node object to wrap</param>
        /// <param name="objectQuery">A query method for refreshing the wrapped node object.</param>
        /// <returns>The <see cref="IWrapper"/> wrapped node.</returns>
        internal IWrapper GetOrCreateNode(INode initialObject, Func<object?> objectQuery)
        {
            return initialObject switch
            {
                IComment _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new CommentWrapper(this, (IComment)io, oq), objectQuery),
                IDocumentType _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new DocumentTypeWrapper(this, (IDocumentType)io, oq), objectQuery),
                IHtmlAnchorElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlAnchorElementWrapper(this, (IHtmlAnchorElement)io, oq), objectQuery),
                IHtmlAreaElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlAreaElementWrapper(this, (IHtmlAreaElement)io, oq), objectQuery),
                IHtmlAudioElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlAudioElementWrapper(this, (IHtmlAudioElement)io, oq), objectQuery),
                IHtmlBaseElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlBaseElementWrapper(this, (IHtmlBaseElement)io, oq), objectQuery),
                IHtmlBodyElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlBodyElementWrapper(this, (IHtmlBodyElement)io, oq), objectQuery),
                IHtmlBreakRowElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlBreakRowElementWrapper(this, (IHtmlBreakRowElement)io, oq), objectQuery),
                IHtmlButtonElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlButtonElementWrapper(this, (IHtmlButtonElement)io, oq), objectQuery),
                IHtmlCanvasElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlCanvasElementWrapper(this, (IHtmlCanvasElement)io, oq), objectQuery),
                IHtmlCommandElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlCommandElementWrapper(this, (IHtmlCommandElement)io, oq), objectQuery),
                IHtmlDataElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlDataElementWrapper(this, (IHtmlDataElement)io, oq), objectQuery),
                IHtmlDataListElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlDataListElementWrapper(this, (IHtmlDataListElement)io, oq), objectQuery),
                IHtmlDetailsElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlDetailsElementWrapper(this, (IHtmlDetailsElement)io, oq), objectQuery),
                IHtmlDialogElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlDialogElementWrapper(this, (IHtmlDialogElement)io, oq), objectQuery),
                IHtmlDivElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlDivElementWrapper(this, (IHtmlDivElement)io, oq), objectQuery),
                IHtmlDocument _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlDocumentWrapper(this, (IHtmlDocument)io, oq), objectQuery),
                IHtmlEmbedElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlEmbedElementWrapper(this, (IHtmlEmbedElement)io, oq), objectQuery),
                IHtmlFieldSetElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlFieldSetElementWrapper(this, (IHtmlFieldSetElement)io, oq), objectQuery),
                IHtmlFormElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlFormElementWrapper(this, (IHtmlFormElement)io, oq), objectQuery),
                IHtmlHeadElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlHeadElementWrapper(this, (IHtmlHeadElement)io, oq), objectQuery),
                IHtmlHeadingElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlHeadingElementWrapper(this, (IHtmlHeadingElement)io, oq), objectQuery),
                IHtmlHrElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlHrElementWrapper(this, (IHtmlHrElement)io, oq), objectQuery),
                IHtmlHtmlElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlHtmlElementWrapper(this, (IHtmlHtmlElement)io, oq), objectQuery),
                IHtmlImageElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlImageElementWrapper(this, (IHtmlImageElement)io, oq), objectQuery),
                IHtmlInlineFrameElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlInlineFrameElementWrapper(this, (IHtmlInlineFrameElement)io, oq), objectQuery),
                IHtmlInputElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlInputElementWrapper(this, (IHtmlInputElement)io, oq), objectQuery),
                IHtmlKeygenElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlKeygenElementWrapper(this, (IHtmlKeygenElement)io, oq), objectQuery),
                IHtmlLabelElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlLabelElementWrapper(this, (IHtmlLabelElement)io, oq), objectQuery),
                IHtmlLegendElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlLegendElementWrapper(this, (IHtmlLegendElement)io, oq), objectQuery),
                IHtmlLinkElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlLinkElementWrapper(this, (IHtmlLinkElement)io, oq), objectQuery),
                IHtmlListItemElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlListItemElementWrapper(this, (IHtmlListItemElement)io, oq), objectQuery),
                IHtmlMapElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlMapElementWrapper(this, (IHtmlMapElement)io, oq), objectQuery),
                IHtmlMarqueeElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlMarqueeElementWrapper(this, (IHtmlMarqueeElement)io, oq), objectQuery),
                IHtmlMenuElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlMenuElementWrapper(this, (IHtmlMenuElement)io, oq), objectQuery),
                IHtmlMenuItemElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlMenuItemElementWrapper(this, (IHtmlMenuItemElement)io, oq), objectQuery),
                IHtmlMetaElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlMetaElementWrapper(this, (IHtmlMetaElement)io, oq), objectQuery),
                IHtmlMeterElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlMeterElementWrapper(this, (IHtmlMeterElement)io, oq), objectQuery),
                IHtmlModElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlModElementWrapper(this, (IHtmlModElement)io, oq), objectQuery),
                IHtmlObjectElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlObjectElementWrapper(this, (IHtmlObjectElement)io, oq), objectQuery),
                IHtmlOptionElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlOptionElementWrapper(this, (IHtmlOptionElement)io, oq), objectQuery),
                IHtmlOptionsGroupElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlOptionsGroupElementWrapper(this, (IHtmlOptionsGroupElement)io, oq), objectQuery),
                IHtmlOrderedListElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlOrderedListElementWrapper(this, (IHtmlOrderedListElement)io, oq), objectQuery),
                IHtmlOutputElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlOutputElementWrapper(this, (IHtmlOutputElement)io, oq), objectQuery),
                IHtmlParagraphElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlParagraphElementWrapper(this, (IHtmlParagraphElement)io, oq), objectQuery),
                IHtmlParamElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlParamElementWrapper(this, (IHtmlParamElement)io, oq), objectQuery),
                IHtmlPreElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlPreElementWrapper(this, (IHtmlPreElement)io, oq), objectQuery),
                IHtmlProgressElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlProgressElementWrapper(this, (IHtmlProgressElement)io, oq), objectQuery),
                IHtmlQuoteElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlQuoteElementWrapper(this, (IHtmlQuoteElement)io, oq), objectQuery),
                IHtmlScriptElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlScriptElementWrapper(this, (IHtmlScriptElement)io, oq), objectQuery),
                IHtmlSelectElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlSelectElementWrapper(this, (IHtmlSelectElement)io, oq), objectQuery),
                IHtmlSlotElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlSlotElementWrapper(this, (IHtmlSlotElement)io, oq), objectQuery),
                IHtmlSourceElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlSourceElementWrapper(this, (IHtmlSourceElement)io, oq), objectQuery),
                IHtmlSpanElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlSpanElementWrapper(this, (IHtmlSpanElement)io, oq), objectQuery),
                IHtmlStyleElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlStyleElementWrapper(this, (IHtmlStyleElement)io, oq), objectQuery),
                IHtmlTableCaptionElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTableCaptionElementWrapper(this, (IHtmlTableCaptionElement)io, oq), objectQuery),
                IHtmlTableColumnElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTableColumnElementWrapper(this, (IHtmlTableColumnElement)io, oq), objectQuery),
                IHtmlTableDataCellElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTableDataCellElementWrapper(this, (IHtmlTableDataCellElement)io, oq), objectQuery),
                IHtmlTableElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTableElementWrapper(this, (IHtmlTableElement)io, oq), objectQuery),
                IHtmlTableHeaderCellElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTableHeaderCellElementWrapper(this, (IHtmlTableHeaderCellElement)io, oq), objectQuery),
                IHtmlTableRowElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTableRowElementWrapper(this, (IHtmlTableRowElement)io, oq), objectQuery),
                IHtmlTableSectionElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTableSectionElementWrapper(this, (IHtmlTableSectionElement)io, oq), objectQuery),
                IHtmlTemplateElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTemplateElementWrapper(this, (IHtmlTemplateElement)io, oq), objectQuery),
                IHtmlTextAreaElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTextAreaElementWrapper(this, (IHtmlTextAreaElement)io, oq), objectQuery),
                IHtmlTimeElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTimeElementWrapper(this, (IHtmlTimeElement)io, oq), objectQuery),
                IHtmlTitleElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTitleElementWrapper(this, (IHtmlTitleElement)io, oq), objectQuery),
                IHtmlTrackElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTrackElementWrapper(this, (IHtmlTrackElement)io, oq), objectQuery),
                IHtmlUnknownElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlUnknownElementWrapper(this, (IHtmlUnknownElement)io, oq), objectQuery),
                IHtmlUnorderedListElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlUnorderedListElementWrapper(this, (IHtmlUnorderedListElement)io, oq), objectQuery),
                IHtmlVideoElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlVideoElementWrapper(this, (IHtmlVideoElement)io, oq), objectQuery),
                IProcessingInstruction _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new ProcessingInstructionWrapper(this, (IProcessingInstruction)io, oq), objectQuery),
                IPseudoElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new PseudoElementWrapper(this, (IPseudoElement)io, oq), objectQuery),
                IShadowRoot _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new ShadowRootWrapper(this, (IShadowRoot)io, oq), objectQuery),
                ISvgCircleElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new SvgCircleElementWrapper(this, (ISvgCircleElement)io, oq), objectQuery),
                ISvgDescriptionElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new SvgDescriptionElementWrapper(this, (ISvgDescriptionElement)io, oq), objectQuery),
                ISvgForeignObjectElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new SvgForeignObjectElementWrapper(this, (ISvgForeignObjectElement)io, oq), objectQuery),
                ISvgSvgElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new SvgSvgElementWrapper(this, (ISvgSvgElement)io, oq), objectQuery),
                ISvgTitleElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new SvgTitleElementWrapper(this, (ISvgTitleElement)io, oq), objectQuery),
                IText _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new TextWrapper(this, (IText)io, oq), objectQuery),
                IDocument _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new DocumentWrapper(this, (IDocument)io, oq), objectQuery),
                IDocumentFragment _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new DocumentFragmentWrapper(this, (IDocumentFragment)io, oq), objectQuery),
                IHtmlMediaElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlMediaElementWrapper(this, (IHtmlMediaElement)io, oq), objectQuery),
                IHtmlTableCellElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlTableCellElementWrapper(this, (IHtmlTableCellElement)io, oq), objectQuery),
                ICharacterData _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new CharacterDataWrapper(this, (ICharacterData)io, oq), objectQuery),
                ISvgElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new SvgElementWrapper(this, (ISvgElement)io, oq), objectQuery),
                IHtmlElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new HtmlElementWrapper(this, (IHtmlElement)io, oq), objectQuery),
                IElement _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new ElementWrapper(this, (IElement)io, oq), objectQuery),
                INode _ => WrapperCache.GetOrAdd(initialObject, (io, oq) => new NodeWrapper(this, (INode)io, oq), objectQuery),
                _ => throw new InvalidOperationException($"Unknown type. Cannot create wrapper for {initialObject.GetType()}"),
            };
        }
    }
}
