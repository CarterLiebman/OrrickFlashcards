#pragma checksum "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae6564a440e653f06fb05f9e0220fa8d54681b88"
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
#line 5 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
using Flashcardgenerator.Models.Localhost;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(FullWidthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-sentence/{sentenceId}")]
    public partial class EditSentence : Flashcardgenerator.Pages.EditSentenceComponent
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
                __builder2.AddAttribute(6, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
                __builder2.AddAttribute(8, "style", "font-weight: bold");
                __builder2.AddAttribute(9, "Text", "Item no longer available.");
                __builder2.AddAttribute(10, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                           !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\n      ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(14);
                __builder2.AddAttribute(15, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 16 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(17, "Text", "Close");
                __builder2.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                              !canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                                 CloseButtonClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-9");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(25);
                __builder2.AddAttribute(26, "style", "font-weight: bold");
                __builder2.AddAttribute(27, "Text", "Another user has made conflicting changes to one or more of the fields you have modified. Please reload.");
                __builder2.AddAttribute(28, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                                                                         hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n      ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-md-3");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(32);
                __builder2.AddAttribute(33, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 26 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                   ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Icon", "autorenew");
                __builder2.AddAttribute(35, "style", "margin-bottom: 20px");
                __builder2.AddAttribute(36, "Text", "Reload");
                __builder2.AddAttribute(37, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                               hasChanges

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                                                   Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "row");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<Flashcardgenerator.Models.Localhost.Sentence>>(44);
                __builder2.AddAttribute(45, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Flashcardgenerator.Models.Localhost.Sentence>(
#nullable restore
#line 32 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                   sentence

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "style", "height: 317.109375px");
                __builder2.AddAttribute(47, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                                          sentence != null && canEdit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Flashcardgenerator.Models.Localhost.Sentence>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Flashcardgenerator.Models.Localhost.Sentence>(this, 
#nullable restore
#line 32 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                                                                                 Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "row");
                    __builder3.OpenElement(52, "div");
                    __builder3.AddAttribute(53, "style", "margin-bottom: 1rem; margin-left: 0; margin-right: ");
                    __builder3.AddAttribute(54, "class", "row");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(57);
                    __builder3.AddAttribute(58, "Component", "briefId");
                    __builder3.AddAttribute(59, "style", "width: 100%");
                    __builder3.AddAttribute(60, "Text", "client");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\n                ");
                    __builder3.OpenElement(62, "div");
                    __builder3.AddAttribute(63, "class", "col-md-9");
                    __Blazor.Flashcardgenerator.Pages.EditSentence.TypeInference.CreateRadzenDropDownDataGrid_0(__builder3, 64, 65, 
#nullable restore
#line 41 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                 getBriefsForbriefIdResult

#line default
#line hidden
#nullable disable
                    , 66, 
#nullable restore
#line 41 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                      true

#line default
#line hidden
#nullable disable
                    , 67, "Client", 68, 
#nullable restore
#line 41 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                             false

#line default
#line hidden
#nullable disable
                    , 69, "display: block; width: 100%", 70, "Client.shortName", 71, "Client.clientId", 72, "ClientName", 73, 
#nullable restore
#line 41 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                                                                                                                       sentence.Brief.clientId

#line default
#line hidden
#nullable disable
                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sentence.Brief.clientId = __value, sentence.Brief.clientId)), 75, () => sentence.Brief.clientId);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(76, "\n            ");
                    __builder3.OpenElement(77, "div");
                    __builder3.AddAttribute(78, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(79, "class", "row");
                    __builder3.OpenElement(80, "div");
                    __builder3.AddAttribute(81, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(82);
                    __builder3.AddAttribute(83, "Component", "briefId");
                    __builder3.AddAttribute(84, "style", "width: 100%");
                    __builder3.AddAttribute(85, "Text", "Brief");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\n              ");
                    __builder3.OpenElement(87, "div");
                    __builder3.AddAttribute(88, "class", "col-md-9");
                    __Blazor.Flashcardgenerator.Pages.EditSentence.TypeInference.CreateRadzenDropDownDataGrid_1(__builder3, 89, 90, 
#nullable restore
#line 52 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                               getBriefsForbriefIdResult

#line default
#line hidden
#nullable disable
                    , 91, "Choose Brief", 92, 
#nullable restore
#line 52 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                 false

#line default
#line hidden
#nullable disable
                    , 93, "display: block; width: 100%", 94, "briefType", 95, "briefId", 96, "BriefId", 97, 
#nullable restore
#line 52 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                                                                                                                    sentence.briefId

#line default
#line hidden
#nullable disable
                    , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sentence.briefId = __value, sentence.briefId)), 99, () => sentence.briefId);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(100, "\n            ");
                    __builder3.OpenElement(101, "div");
                    __builder3.AddAttribute(102, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(103, "class", "row");
                    __builder3.OpenElement(104, "div");
                    __builder3.AddAttribute(105, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(106);
                    __builder3.AddAttribute(107, "Component", "content");
                    __builder3.AddAttribute(108, "style", "width: 100%");
                    __builder3.AddAttribute(109, "Text", "Content");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(110, "\n              ");
                    __builder3.OpenElement(111, "div");
                    __builder3.AddAttribute(112, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextArea>(113);
                    __builder3.AddAttribute(114, "style", "height: 125px; width: 100%");
                    __builder3.AddAttribute(115, "Name", "Content");
                    __builder3.AddAttribute(116, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                  sentence.content

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sentence.content = __value, sentence.content))));
                    __builder3.AddAttribute(118, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sentence.content));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(120);
                    __builder3.AddAttribute(121, "Component", "Content");
                    __builder3.AddAttribute(122, "style", "float: left; position: relative; width: 122.796875px");
                    __builder3.AddAttribute(123, "Text", "content is required");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(124, "\n            ");
                    __builder3.OpenElement(125, "div");
                    __builder3.AddAttribute(126, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(127, "class", "row");
                    __builder3.OpenElement(128, "div");
                    __builder3.AddAttribute(129, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(130);
                    __builder3.AddAttribute(131, "Component", "verified");
                    __builder3.AddAttribute(132, "style", "width: 100%");
                    __builder3.AddAttribute(133, "Text", "Verified");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(134, "\n              ");
                    __builder3.OpenElement(135, "div");
                    __builder3.AddAttribute(136, "class", "col-md-9");
                    __Blazor.Flashcardgenerator.Pages.EditSentence.TypeInference.CreateRadzenCheckBox_2(__builder3, 137, 138, "Verified", 139, 
#nullable restore
#line 74 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                               sentence.verified

#line default
#line hidden
#nullable disable
                    , 140, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sentence.verified = __value, sentence.verified)), 141, () => sentence.verified);
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(142, "\n            ");
                    __builder3.OpenElement(143, "div");
                    __builder3.AddAttribute(144, "class", "row");
                    __builder3.OpenElement(145, "div");
                    __builder3.AddAttribute(146, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(147);
                    __builder3.AddAttribute(148, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 80 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                           ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(149, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 80 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                            ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(150, "Icon", "save");
                    __builder3.AddAttribute(151, "Text", "Save");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(152, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(153);
                    __builder3.AddAttribute(154, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 82 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(155, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(156, "Text", "Cancel");
                    __builder3.AddAttribute(157, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "/Users/carter/Documents/GitHub/OrrickFlashcards/server/Pages/EditSentence.razor"
                                                                                                              Button4Click

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
namespace __Blazor.Flashcardgenerator.Pages.EditSentence
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDownDataGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, System.Object __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::System.Object __arg8, int __seq9, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg9, int __seq10, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg10)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Disabled", __arg1);
        __builder.AddAttribute(__seq2, "Placeholder", __arg2);
        __builder.AddAttribute(__seq3, "ShowSearch", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "TextProperty", __arg5);
        __builder.AddAttribute(__seq6, "ValueProperty", __arg6);
        __builder.AddAttribute(__seq7, "Name", __arg7);
        __builder.AddAttribute(__seq8, "Value", __arg8);
        __builder.AddAttribute(__seq9, "ValueChanged", __arg9);
        __builder.AddAttribute(__seq10, "ValueExpression", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDownDataGrid_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.IEnumerable __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, System.Object __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "ShowSearch", __arg2);
        __builder.AddAttribute(__seq3, "style", __arg3);
        __builder.AddAttribute(__seq4, "TextProperty", __arg4);
        __builder.AddAttribute(__seq5, "ValueProperty", __arg5);
        __builder.AddAttribute(__seq6, "Name", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
        public static void CreateRadzenCheckBox_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
