#pragma checksum "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99dd24310adf0f7a5579cf65f1043800a454e1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\_ViewImports.cshtml"
using GameWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\_ViewImports.cshtml"
using GameWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99dd24310adf0f7a5579cf65f1043800a454e1d0", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameWorld.Models.Product.ProductDetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
  
    ViewData["Title"] = @Model.ProductName;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        background-color: #f5f5f5;
        font-size: 16px;
        line-height: 1.5;
    }

    .heading {
        font-size: 20px;
        color: #ab8181;
    }

    .container {
        border-radius: 15px;
        max-width: 1200px;
        margin: auto;
        padding: 0 15px;
    }

    .left-side-product-box img {
        max-width: 100%;
        height: auto;
    }

    ");
            WriteLiteral("@media screen and (min-width: 768px) {\r\n        .left-side-product-box {\r\n            text-align: center;\r\n        }\r\n    }\r\n\r\n    .right-side-pro-detail {\r\n        margin-top: 20px;\r\n    }\r\n\r\n    ");
            WriteLiteral("@media screen and (min-width: 992px) {\r\n        .right-side-pro-detail {\r\n            margin-top: 0;\r\n        }\r\n    }\r\n</style>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99dd24310adf0f7a5579cf65f1043800a454e1d06888", async() => {
                WriteLiteral("\r\n    <div class=\" border p-3 main-section bg-white container\">\r\n        <div class=\"row hedding m-0 pl-3 pt-0 pb-3\">\r\n            <h1 style=\"color: black\">");
#nullable restore
#line 51 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row m-0\">\r\n            <div class=\"col-lg-4 left-side-product-box pb-3\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 1205, "\"", 1249, 1);
#nullable restore
#line 55 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
WriteAttributeValue("", 1211, Html.DisplayFor(model => model.Image), 1211, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"border p-3\">\r\n");
#nullable restore
#line 56 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                 if ((this.User.Identity.IsAuthenticated) && (this.User.IsInRole("Administrator")))
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99dd24310adf0f7a5579cf65f1043800a454e1d08566", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute(")\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99dd24310adf0f7a5579cf65f1043800a454e1d011260", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
            <div class=""col-lg-8"">
                <div class=""right-side-pro-detail border p-3 m-0"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <h3>Platform</h3>
                            <h4 class=""m-0 p-0"" style=""color: black; text-transform: uppercase;"">");
#nullable restore
#line 69 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                                                                            Write(Html.DisplayFor(model => model.Platform));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <p class=\"m-0 p-0 price-pro\">");
#nullable restore
#line 72 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("€</p>\r\n                            <hr class=\"p-0 m-0\">\r\n                        </div>\r\n                        <div class=\"col-lg-12 pt-2\">\r\n                            <h5>Description</h5>\r\n                            <span>");
#nullable restore
#line 77 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                             Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <hr class=\"m-0 pt-2 mt-2\">\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <p class=\"tag-section\"><strong>Category: </strong><a");
                BeginWriteAttribute("href", " href=\"", 2698, "\"", 2705, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 81 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                                                                    Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></p>\r\n                        </div>\r\n");
#nullable restore
#line 83 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                         if (this.User.Identity.IsAuthenticated)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99dd24310adf0f7a5579cf65f1043800a454e1d016732", async() => {
                    WriteLiteral("\r\n                                <input type=\"hidden\" name=\"productId\"");
                    BeginWriteAttribute("value", " value=\"", 3053, "\"", 3070, 1);
#nullable restore
#line 87 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
WriteAttributeValue("", 3061, Model.Id, 3061, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                <input type=\"number\" name=\"quantity\" value=\"1\" />\r\n                                <button class=\"btn btn-success\"");
                    BeginWriteAttribute("onclick", " onclick=\"", 3222, "\"", 3281, 3);
                    WriteAttributeValue("", 3232, "location.href=\'", 3232, 15, true);
#nullable restore
#line 89 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
WriteAttributeValue("", 3247, Url.Action("AddToCart" , "Cart"), 3247, 33, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 3280, "\'", 3280, 1, true);
                    EndWriteAttribute();
                    WriteLiteral(">Add to Cart</button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameWorld.Models.Product.ProductDetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
