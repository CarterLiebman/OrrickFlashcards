#pragma checksum "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c0db7190f6b5068946c498a93243de37a9421b"
// <auto-generated/>
#pragma warning disable 1591
namespace Flashcardgenerator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using Flashcardgenerator.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using Aspose.Words;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using PragmaticSegmenterNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/_Imports.razor"
using BlazorDownloadFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
using Flashcardgenerator.Models.Localhost;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(FullWidthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-card/{briefId}")]
    public partial class AddCard : Flashcardgenerator.Pages.AddCardComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Flashcardgenerator.Models.Localhost.Card>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Flashcardgenerator.Models.Localhost.Card>(
#nullable restore
#line 12 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                   card

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                    card != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Flashcardgenerator.Models.Localhost.Card>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Flashcardgenerator.Models.Localhost.Card>(this, 
#nullable restore
#line 12 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                                             Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Answer");
                    __builder3.AddAttribute(19, "Component", "Answer");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 20 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                          480

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddAttribute(27, "Name", "Answer");
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                  card.Answer

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.Answer = __value, card.Answer))));
                    __builder3.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => card.Answer));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(34, "class", "row");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(37);
                    __builder3.AddAttribute(38, "Text", "Brief");
                    __builder3.AddAttribute(39, "Component", "briefId");
                    __builder3.AddAttribute(40, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\n              ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "class", "col-md-9");
                    __Blazor.Flashcardgenerator.Pages.AddCard.TypeInference.CreateRadzenDropDownDataGrid_0(__builder3, 44, 45, 
#nullable restore
#line 30 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                               getBriefsForbriefIdResult

#line default
#line hidden
#nullable disable
                    , 46, "briefType", 47, "briefId", 48, "Choose Brief", 49, 
#nullable restore
#line 30 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                                                                                  false

#line default
#line hidden
#nullable disable
                    , 50, "display: block; width: 100%", 51, "BriefId", 52, 
#nullable restore
#line 30 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                                                                                                                                            card.briefId

#line default
#line hidden
#nullable disable
                    , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.briefId = __value, card.briefId)), 54, () => card.briefId);
                    __builder3.AddMarkupContent(55, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(56);
                    __builder3.AddAttribute(57, "Component", "BriefId");
                    __builder3.AddAttribute(58, "Text", "briefId is required");
                    __builder3.AddAttribute(59, "style", "position: absolute");
                    __builder3.AddAttribute(60, "DefaultValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                                                 0

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\n            ");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(64, "class", "row");
                    __builder3.OpenElement(65, "div");
                    __builder3.AddAttribute(66, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(67);
                    __builder3.AddAttribute(68, "Text", "Card Id");
                    __builder3.AddAttribute(69, "Component", "cardId");
                    __builder3.AddAttribute(70, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\n              ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "col-md-9");
                    __Blazor.Flashcardgenerator.Pages.AddCard.TypeInference.CreateRadzenNumeric_1(__builder3, 74, 75, "display: block; width: 100%", 76, "CardId", 77, 
#nullable restore
#line 42 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                  card.cardId

#line default
#line hidden
#nullable disable
                    , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.cardId = __value, card.cardId)), 79, () => card.cardId);
                    __builder3.AddMarkupContent(80, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(81);
                    __builder3.AddAttribute(82, "Component", "CardId");
                    __builder3.AddAttribute(83, "Text", "cardId is required");
                    __builder3.AddAttribute(84, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(85, "\n            ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(88, "class", "row");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(91);
                    __builder3.AddAttribute(92, "Text", "Category");
                    __builder3.AddAttribute(93, "Component", "categoryId");
                    __builder3.AddAttribute(94, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\n              ");
                    __builder3.OpenElement(96, "div");
                    __builder3.AddAttribute(97, "class", "col-md-9");
                    __Blazor.Flashcardgenerator.Pages.AddCard.TypeInference.CreateRadzenDropDownDataGrid_2(__builder3, 98, 99, 
#nullable restore
#line 54 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                               getCategoriesForcategoryIdResult

#line default
#line hidden
#nullable disable
                    , 100, "name", 101, "categoryId", 102, "Choose Category", 103, 
#nullable restore
#line 54 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                                                                                          false

#line default
#line hidden
#nullable disable
                    , 104, "width: 100%", 105, "CategoryId", 106, 
#nullable restore
#line 54 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                                                                                                                                    card.categoryId

#line default
#line hidden
#nullable disable
                    , 107, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.categoryId = __value, card.categoryId)), 108, () => card.categoryId);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(109, "\n            ");
                    __builder3.OpenElement(110, "div");
                    __builder3.AddAttribute(111, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(112, "class", "row");
                    __builder3.OpenElement(113, "div");
                    __builder3.AddAttribute(114, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(115);
                    __builder3.AddAttribute(116, "Text", "Question");
                    __builder3.AddAttribute(117, "Component", "Question");
                    __builder3.AddAttribute(118, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n              ");
                    __builder3.OpenElement(120, "div");
                    __builder3.AddAttribute(121, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(122);
                    __builder3.AddAttribute(123, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 64 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                          480

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "style", "width: 100%");
                    __builder3.AddAttribute(125, "Name", "Question");
                    __builder3.AddAttribute(126, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                  card.Question

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(127, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.Question = __value, card.Question))));
                    __builder3.AddAttribute(128, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => card.Question));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(129, "\n            ");
                    __builder3.OpenElement(130, "div");
                    __builder3.AddAttribute(131, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(132, "class", "row");
                    __builder3.OpenElement(133, "div");
                    __builder3.AddAttribute(134, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(135);
                    __builder3.AddAttribute(136, "Text", "Sentence");
                    __builder3.AddAttribute(137, "Component", "sentenceId");
                    __builder3.AddAttribute(138, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(139, "\n              ");
                    __builder3.OpenElement(140, "div");
                    __builder3.AddAttribute(141, "class", "col-md-9");
                    __Blazor.Flashcardgenerator.Pages.AddCard.TypeInference.CreateRadzenDropDownDataGrid_3(__builder3, 142, 143, 
#nullable restore
#line 74 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                               getSentencesForsentenceIdResult

#line default
#line hidden
#nullable disable
                    , 144, "content", 145, "sentenceId", 146, "Choose Sentence", 147, 
#nullable restore
#line 74 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                                                                                            false

#line default
#line hidden
#nullable disable
                    , 148, "width: 100%", 149, "SentenceId", 150, 
#nullable restore
#line 74 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                                                                                                                                      card.sentenceId

#line default
#line hidden
#nullable disable
                    , 151, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.sentenceId = __value, card.sentenceId)), 152, () => card.sentenceId);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(153, "\n            ");
                    __builder3.OpenElement(154, "div");
                    __builder3.AddAttribute(155, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(156, "class", "row");
                    __builder3.OpenElement(157, "div");
                    __builder3.AddAttribute(158, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(159);
                    __builder3.AddAttribute(160, "Text", "Verified");
                    __builder3.AddAttribute(161, "Component", "Verified");
                    __builder3.AddAttribute(162, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(163, "\n              ");
                    __builder3.OpenElement(164, "div");
                    __builder3.AddAttribute(165, "class", "col-md-9");
                    __Blazor.Flashcardgenerator.Pages.AddCard.TypeInference.CreateRadzenCheckBox_4(__builder3, 166, 167, 
#nullable restore
#line 84 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                          true

#line default
#line hidden
#nullable disable
                    , 168, "Verified", 169, 
#nullable restore
#line 84 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                               card.Verified

#line default
#line hidden
#nullable disable
                    , 170, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.Verified = __value, card.Verified)), 171, () => card.Verified);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(172, "\n            ");
                    __builder3.OpenElement(173, "div");
                    __builder3.AddAttribute(174, "class", "row");
                    __builder3.OpenElement(175, "div");
                    __builder3.AddAttribute(176, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(177);
                    __builder3.AddAttribute(178, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 90 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(179, "Icon", "save");
                    __builder3.AddAttribute(180, "Text", "Save");
                    __builder3.AddAttribute(181, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 90 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(182, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(183);
                    __builder3.AddAttribute(184, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 92 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(185, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(186, "Text", "Cancel");
                    __builder3.AddAttribute(187, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/AddCard.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Flashcardgenerator.Pages.AddCard
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, System.Object __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "ShowSearch", __arg4);
        __builder.AddAttribute(__seq5, "style", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
        public static void CreateRadzenNumeric_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenNumeric<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDownDataGrid_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, System.Object __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "ShowSearch", __arg4);
        __builder.AddAttribute(__seq5, "style", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDownDataGrid_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, System.Object __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextProperty", __arg1);
        __builder.AddAttribute(__seq2, "ValueProperty", __arg2);
        __builder.AddAttribute(__seq3, "Placeholder", __arg3);
        __builder.AddAttribute(__seq4, "ShowSearch", __arg4);
        __builder.AddAttribute(__seq5, "style", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
        public static void CreateRadzenCheckBox_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "TriState", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591