using System;
using System.Collections.Generic;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Svg.Dom;
namespace AngleSharpWrappers
{
    #nullable enable
    public sealed partial class WrapperFactory
    {
        /// <summary>
        /// Wraps an <see cref="INode"/> in the wrapper specific to it.
        /// </summary>
        /// <typeparam name="T">The node type.</typeparam>
        /// <param name="initialObject">The initial node object to wrap</param>
        /// <param name="objectQuery">A query method for refreshing the wrapped node object.</param>
        /// <returns>The <see cref="IWrapper"/> wrapped node.</returns>
        internal IWrapper GetOrCreate<T>(T initialObject, Func<object?> query) where T : class
        {
            return initialObject switch
            {
                IAttr attr => GetOrAdd<IAttr>(attr, query, (f, o, q) => new AttrWrapper(f, o, q)),
                IComment comment => GetOrAdd<IComment>(comment, query, (f, o, q) => new CommentWrapper(f, o, q)),
                IDocumentType documentType => GetOrAdd<IDocumentType>(documentType, query, (f, o, q) => new DocumentTypeWrapper(f, o, q)),
                IHtmlAnchorElement htmlAnchorElement => GetOrAdd<IHtmlAnchorElement>(htmlAnchorElement, query, (f, o, q) => new HtmlAnchorElementWrapper(f, o, q)),
                IHtmlAreaElement htmlAreaElement => GetOrAdd<IHtmlAreaElement>(htmlAreaElement, query, (f, o, q) => new HtmlAreaElementWrapper(f, o, q)),
                IHtmlAudioElement htmlAudioElement => GetOrAdd<IHtmlAudioElement>(htmlAudioElement, query, (f, o, q) => new HtmlAudioElementWrapper(f, o, q)),
                IHtmlBaseElement htmlBaseElement => GetOrAdd<IHtmlBaseElement>(htmlBaseElement, query, (f, o, q) => new HtmlBaseElementWrapper(f, o, q)),
                IHtmlBodyElement htmlBodyElement => GetOrAdd<IHtmlBodyElement>(htmlBodyElement, query, (f, o, q) => new HtmlBodyElementWrapper(f, o, q)),
                IHtmlBreakRowElement htmlBreakRowElement => GetOrAdd<IHtmlBreakRowElement>(htmlBreakRowElement, query, (f, o, q) => new HtmlBreakRowElementWrapper(f, o, q)),
                IHtmlButtonElement htmlButtonElement => GetOrAdd<IHtmlButtonElement>(htmlButtonElement, query, (f, o, q) => new HtmlButtonElementWrapper(f, o, q)),
                IHtmlCanvasElement htmlCanvasElement => GetOrAdd<IHtmlCanvasElement>(htmlCanvasElement, query, (f, o, q) => new HtmlCanvasElementWrapper(f, o, q)),
                IHtmlCommandElement htmlCommandElement => GetOrAdd<IHtmlCommandElement>(htmlCommandElement, query, (f, o, q) => new HtmlCommandElementWrapper(f, o, q)),
                IHtmlDataElement htmlDataElement => GetOrAdd<IHtmlDataElement>(htmlDataElement, query, (f, o, q) => new HtmlDataElementWrapper(f, o, q)),
                IHtmlDataListElement htmlDataListElement => GetOrAdd<IHtmlDataListElement>(htmlDataListElement, query, (f, o, q) => new HtmlDataListElementWrapper(f, o, q)),
                IHtmlDetailsElement htmlDetailsElement => GetOrAdd<IHtmlDetailsElement>(htmlDetailsElement, query, (f, o, q) => new HtmlDetailsElementWrapper(f, o, q)),
                IHtmlDialogElement htmlDialogElement => GetOrAdd<IHtmlDialogElement>(htmlDialogElement, query, (f, o, q) => new HtmlDialogElementWrapper(f, o, q)),
                IHtmlDivElement htmlDivElement => GetOrAdd<IHtmlDivElement>(htmlDivElement, query, (f, o, q) => new HtmlDivElementWrapper(f, o, q)),
                IHtmlDocument htmlDocument => GetOrAdd<IHtmlDocument>(htmlDocument, query, (f, o, q) => new HtmlDocumentWrapper(f, o, q)),
                IHtmlEmbedElement htmlEmbedElement => GetOrAdd<IHtmlEmbedElement>(htmlEmbedElement, query, (f, o, q) => new HtmlEmbedElementWrapper(f, o, q)),
                IHtmlFieldSetElement htmlFieldSetElement => GetOrAdd<IHtmlFieldSetElement>(htmlFieldSetElement, query, (f, o, q) => new HtmlFieldSetElementWrapper(f, o, q)),
                IHtmlFormElement htmlFormElement => GetOrAdd<IHtmlFormElement>(htmlFormElement, query, (f, o, q) => new HtmlFormElementWrapper(f, o, q)),
                IHtmlHeadElement htmlHeadElement => GetOrAdd<IHtmlHeadElement>(htmlHeadElement, query, (f, o, q) => new HtmlHeadElementWrapper(f, o, q)),
                IHtmlHeadingElement htmlHeadingElement => GetOrAdd<IHtmlHeadingElement>(htmlHeadingElement, query, (f, o, q) => new HtmlHeadingElementWrapper(f, o, q)),
                IHtmlHrElement htmlHrElement => GetOrAdd<IHtmlHrElement>(htmlHrElement, query, (f, o, q) => new HtmlHrElementWrapper(f, o, q)),
                IHtmlHtmlElement htmlHtmlElement => GetOrAdd<IHtmlHtmlElement>(htmlHtmlElement, query, (f, o, q) => new HtmlHtmlElementWrapper(f, o, q)),
                IHtmlImageElement htmlImageElement => GetOrAdd<IHtmlImageElement>(htmlImageElement, query, (f, o, q) => new HtmlImageElementWrapper(f, o, q)),
                IHtmlInlineFrameElement htmlInlineFrameElement => GetOrAdd<IHtmlInlineFrameElement>(htmlInlineFrameElement, query, (f, o, q) => new HtmlInlineFrameElementWrapper(f, o, q)),
                IHtmlInputElement htmlInputElement => GetOrAdd<IHtmlInputElement>(htmlInputElement, query, (f, o, q) => new HtmlInputElementWrapper(f, o, q)),
                IHtmlKeygenElement htmlKeygenElement => GetOrAdd<IHtmlKeygenElement>(htmlKeygenElement, query, (f, o, q) => new HtmlKeygenElementWrapper(f, o, q)),
                IHtmlLabelElement htmlLabelElement => GetOrAdd<IHtmlLabelElement>(htmlLabelElement, query, (f, o, q) => new HtmlLabelElementWrapper(f, o, q)),
                IHtmlLegendElement htmlLegendElement => GetOrAdd<IHtmlLegendElement>(htmlLegendElement, query, (f, o, q) => new HtmlLegendElementWrapper(f, o, q)),
                IHtmlLinkElement htmlLinkElement => GetOrAdd<IHtmlLinkElement>(htmlLinkElement, query, (f, o, q) => new HtmlLinkElementWrapper(f, o, q)),
                IHtmlListItemElement htmlListItemElement => GetOrAdd<IHtmlListItemElement>(htmlListItemElement, query, (f, o, q) => new HtmlListItemElementWrapper(f, o, q)),
                IHtmlMapElement htmlMapElement => GetOrAdd<IHtmlMapElement>(htmlMapElement, query, (f, o, q) => new HtmlMapElementWrapper(f, o, q)),
                IHtmlMarqueeElement htmlMarqueeElement => GetOrAdd<IHtmlMarqueeElement>(htmlMarqueeElement, query, (f, o, q) => new HtmlMarqueeElementWrapper(f, o, q)),
                IHtmlMenuElement htmlMenuElement => GetOrAdd<IHtmlMenuElement>(htmlMenuElement, query, (f, o, q) => new HtmlMenuElementWrapper(f, o, q)),
                IHtmlMenuItemElement htmlMenuItemElement => GetOrAdd<IHtmlMenuItemElement>(htmlMenuItemElement, query, (f, o, q) => new HtmlMenuItemElementWrapper(f, o, q)),
                IHtmlMetaElement htmlMetaElement => GetOrAdd<IHtmlMetaElement>(htmlMetaElement, query, (f, o, q) => new HtmlMetaElementWrapper(f, o, q)),
                IHtmlMeterElement htmlMeterElement => GetOrAdd<IHtmlMeterElement>(htmlMeterElement, query, (f, o, q) => new HtmlMeterElementWrapper(f, o, q)),
                IHtmlModElement htmlModElement => GetOrAdd<IHtmlModElement>(htmlModElement, query, (f, o, q) => new HtmlModElementWrapper(f, o, q)),
                IHtmlObjectElement htmlObjectElement => GetOrAdd<IHtmlObjectElement>(htmlObjectElement, query, (f, o, q) => new HtmlObjectElementWrapper(f, o, q)),
                IHtmlOptionElement htmlOptionElement => GetOrAdd<IHtmlOptionElement>(htmlOptionElement, query, (f, o, q) => new HtmlOptionElementWrapper(f, o, q)),
                IHtmlOptionsGroupElement htmlOptionsGroupElement => GetOrAdd<IHtmlOptionsGroupElement>(htmlOptionsGroupElement, query, (f, o, q) => new HtmlOptionsGroupElementWrapper(f, o, q)),
                IHtmlOrderedListElement htmlOrderedListElement => GetOrAdd<IHtmlOrderedListElement>(htmlOrderedListElement, query, (f, o, q) => new HtmlOrderedListElementWrapper(f, o, q)),
                IHtmlOutputElement htmlOutputElement => GetOrAdd<IHtmlOutputElement>(htmlOutputElement, query, (f, o, q) => new HtmlOutputElementWrapper(f, o, q)),
                IHtmlParagraphElement htmlParagraphElement => GetOrAdd<IHtmlParagraphElement>(htmlParagraphElement, query, (f, o, q) => new HtmlParagraphElementWrapper(f, o, q)),
                IHtmlParamElement htmlParamElement => GetOrAdd<IHtmlParamElement>(htmlParamElement, query, (f, o, q) => new HtmlParamElementWrapper(f, o, q)),
                IHtmlPreElement htmlPreElement => GetOrAdd<IHtmlPreElement>(htmlPreElement, query, (f, o, q) => new HtmlPreElementWrapper(f, o, q)),
                IHtmlProgressElement htmlProgressElement => GetOrAdd<IHtmlProgressElement>(htmlProgressElement, query, (f, o, q) => new HtmlProgressElementWrapper(f, o, q)),
                IHtmlQuoteElement htmlQuoteElement => GetOrAdd<IHtmlQuoteElement>(htmlQuoteElement, query, (f, o, q) => new HtmlQuoteElementWrapper(f, o, q)),
                IHtmlScriptElement htmlScriptElement => GetOrAdd<IHtmlScriptElement>(htmlScriptElement, query, (f, o, q) => new HtmlScriptElementWrapper(f, o, q)),
                IHtmlSelectElement htmlSelectElement => GetOrAdd<IHtmlSelectElement>(htmlSelectElement, query, (f, o, q) => new HtmlSelectElementWrapper(f, o, q)),
                IHtmlSlotElement htmlSlotElement => GetOrAdd<IHtmlSlotElement>(htmlSlotElement, query, (f, o, q) => new HtmlSlotElementWrapper(f, o, q)),
                IHtmlSourceElement htmlSourceElement => GetOrAdd<IHtmlSourceElement>(htmlSourceElement, query, (f, o, q) => new HtmlSourceElementWrapper(f, o, q)),
                IHtmlSpanElement htmlSpanElement => GetOrAdd<IHtmlSpanElement>(htmlSpanElement, query, (f, o, q) => new HtmlSpanElementWrapper(f, o, q)),
                IHtmlStyleElement htmlStyleElement => GetOrAdd<IHtmlStyleElement>(htmlStyleElement, query, (f, o, q) => new HtmlStyleElementWrapper(f, o, q)),
                IHtmlTableCaptionElement htmlTableCaptionElement => GetOrAdd<IHtmlTableCaptionElement>(htmlTableCaptionElement, query, (f, o, q) => new HtmlTableCaptionElementWrapper(f, o, q)),
                IHtmlTableColumnElement htmlTableColumnElement => GetOrAdd<IHtmlTableColumnElement>(htmlTableColumnElement, query, (f, o, q) => new HtmlTableColumnElementWrapper(f, o, q)),
                IHtmlTableDataCellElement htmlTableDataCellElement => GetOrAdd<IHtmlTableDataCellElement>(htmlTableDataCellElement, query, (f, o, q) => new HtmlTableDataCellElementWrapper(f, o, q)),
                IHtmlTableElement htmlTableElement => GetOrAdd<IHtmlTableElement>(htmlTableElement, query, (f, o, q) => new HtmlTableElementWrapper(f, o, q)),
                IHtmlTableHeaderCellElement htmlTableHeaderCellElement => GetOrAdd<IHtmlTableHeaderCellElement>(htmlTableHeaderCellElement, query, (f, o, q) => new HtmlTableHeaderCellElementWrapper(f, o, q)),
                IHtmlTableRowElement htmlTableRowElement => GetOrAdd<IHtmlTableRowElement>(htmlTableRowElement, query, (f, o, q) => new HtmlTableRowElementWrapper(f, o, q)),
                IHtmlTableSectionElement htmlTableSectionElement => GetOrAdd<IHtmlTableSectionElement>(htmlTableSectionElement, query, (f, o, q) => new HtmlTableSectionElementWrapper(f, o, q)),
                IHtmlTemplateElement htmlTemplateElement => GetOrAdd<IHtmlTemplateElement>(htmlTemplateElement, query, (f, o, q) => new HtmlTemplateElementWrapper(f, o, q)),
                IHtmlTextAreaElement htmlTextAreaElement => GetOrAdd<IHtmlTextAreaElement>(htmlTextAreaElement, query, (f, o, q) => new HtmlTextAreaElementWrapper(f, o, q)),
                IHtmlTimeElement htmlTimeElement => GetOrAdd<IHtmlTimeElement>(htmlTimeElement, query, (f, o, q) => new HtmlTimeElementWrapper(f, o, q)),
                IHtmlTitleElement htmlTitleElement => GetOrAdd<IHtmlTitleElement>(htmlTitleElement, query, (f, o, q) => new HtmlTitleElementWrapper(f, o, q)),
                IHtmlTrackElement htmlTrackElement => GetOrAdd<IHtmlTrackElement>(htmlTrackElement, query, (f, o, q) => new HtmlTrackElementWrapper(f, o, q)),
                IHtmlUnknownElement htmlUnknownElement => GetOrAdd<IHtmlUnknownElement>(htmlUnknownElement, query, (f, o, q) => new HtmlUnknownElementWrapper(f, o, q)),
                IHtmlUnorderedListElement htmlUnorderedListElement => GetOrAdd<IHtmlUnorderedListElement>(htmlUnorderedListElement, query, (f, o, q) => new HtmlUnorderedListElementWrapper(f, o, q)),
                IHtmlVideoElement htmlVideoElement => GetOrAdd<IHtmlVideoElement>(htmlVideoElement, query, (f, o, q) => new HtmlVideoElementWrapper(f, o, q)),
                INodeList nodeList => GetOrAdd<INodeList>(nodeList, query, (f, o, q) => new NodeListWrapper(f, o, q)),
                IProcessingInstruction processingInstruction => GetOrAdd<IProcessingInstruction>(processingInstruction, query, (f, o, q) => new ProcessingInstructionWrapper(f, o, q)),
                IPseudoElement pseudoElement => GetOrAdd<IPseudoElement>(pseudoElement, query, (f, o, q) => new PseudoElementWrapper(f, o, q)),
                IShadowRoot shadowRoot => GetOrAdd<IShadowRoot>(shadowRoot, query, (f, o, q) => new ShadowRootWrapper(f, o, q)),
                ISvgCircleElement svgCircleElement => GetOrAdd<ISvgCircleElement>(svgCircleElement, query, (f, o, q) => new SvgCircleElementWrapper(f, o, q)),
                ISvgDescriptionElement svgDescriptionElement => GetOrAdd<ISvgDescriptionElement>(svgDescriptionElement, query, (f, o, q) => new SvgDescriptionElementWrapper(f, o, q)),
                ISvgForeignObjectElement svgForeignObjectElement => GetOrAdd<ISvgForeignObjectElement>(svgForeignObjectElement, query, (f, o, q) => new SvgForeignObjectElementWrapper(f, o, q)),
                ISvgSvgElement svgSvgElement => GetOrAdd<ISvgSvgElement>(svgSvgElement, query, (f, o, q) => new SvgSvgElementWrapper(f, o, q)),
                ISvgTitleElement svgTitleElement => GetOrAdd<ISvgTitleElement>(svgTitleElement, query, (f, o, q) => new SvgTitleElementWrapper(f, o, q)),
                IText text => GetOrAdd<IText>(text, query, (f, o, q) => new TextWrapper(f, o, q)),
                IDocument document => GetOrAdd<IDocument>(document, query, (f, o, q) => new DocumentWrapper(f, o, q)),
                IDocumentFragment documentFragment => GetOrAdd<IDocumentFragment>(documentFragment, query, (f, o, q) => new DocumentFragmentWrapper(f, o, q)),
                IHtmlMediaElement htmlMediaElement => GetOrAdd<IHtmlMediaElement>(htmlMediaElement, query, (f, o, q) => new HtmlMediaElementWrapper(f, o, q)),
                IHtmlTableCellElement htmlTableCellElement => GetOrAdd<IHtmlTableCellElement>(htmlTableCellElement, query, (f, o, q) => new HtmlTableCellElementWrapper(f, o, q)),
                ICharacterData characterData => GetOrAdd<ICharacterData>(characterData, query, (f, o, q) => new CharacterDataWrapper(f, o, q)),
                ISvgElement svgElement => GetOrAdd<ISvgElement>(svgElement, query, (f, o, q) => new SvgElementWrapper(f, o, q)),
                IHtmlElement htmlElement => GetOrAdd<IHtmlElement>(htmlElement, query, (f, o, q) => new HtmlElementWrapper(f, o, q)),
                IElement element => GetOrAdd<IElement>(element, query, (f, o, q) => new ElementWrapper(f, o, q)),
                INode node => GetOrAdd<INode>(node, query, (f, o, q) => new NodeWrapper(f, o, q)),
                IMarkupFormattable markupFormattable => GetOrAdd<IMarkupFormattable>(markupFormattable, query, (f, o, q) => new MarkupFormattableWrapper(f, o, q)),
                _ => throw new InvalidOperationException($"Unknown type. Cannot create wrapper for {initialObject.GetType()}"),
            };
        }
    }
}
