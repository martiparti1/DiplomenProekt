#pragma checksum "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d969aa3636cf9e178541dde8502211f9232b021"
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
#line 1 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\_ViewImports.cshtml"
using GameWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\_ViewImports.cshtml"
using GameWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d969aa3636cf9e178541dde8502211f9232b021", @"/Views/Product/Details.cshtml")]
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
  
    ViewData["Title"] = @Model.ProductName;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
    background-color: #f5f5f5
}

.hedding {
    font-size: 20px;
    color: #ab8181;
}
.container{
    border-radius: 15px;
}
.main-section {
    position: absolute;
    left: 50%;
    right: 50%;
    transform: translate(-50%, 5%);
}

.left-side-product-box img {
    width: 100%;
}

.left-side-product-box .sub-img img {
    margin-top: 5px;
    width: 83px;
    height: 100px;
}

.right-side-pro-detail span {
    font-size: 15px;
}

.right-side-pro-detail p {
    font-size: 25px;
    color: #a1a1a1;
}

.right-side-pro-detail .price-pro {
    color: #E45641;
}

.right-side-pro-detail .tag-section {
    font-size: 18px;
    color: #5D4C46;
}

.pro-box-section .pro-box img {
    width: 100%;
    height: 200px;
}
</style>

    <div class=""col-lg-8 border p-3 main-section bg-white container"">
        <div class=""row hedding m-0 pl-3 pt-0 pb-3"">
            <h1 style=""color: black"">");
#nullable restore
#line 61 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"row m-0\">\r\n            <div class=\"col-lg-4 left-side-product-box pb-3\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1248, "\"", 1292, 1);
#nullable restore
#line 65 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
WriteAttributeValue("", 1254, Html.DisplayFor(model => model.Image), 1254, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"border p-3\">\r\n");
#nullable restore
#line 66 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                 if((this.User.Identity.IsAuthenticated) && (this.User.IsInRole("Administrator")))
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d969aa3636cf9e178541dde8502211f9232b0218126", async() => {
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
#line 69 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
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
            WriteLiteral("\r\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d969aa3636cf9e178541dde8502211f9232b02110711", async() => {
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
#line 70 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
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
#line 71 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                    
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
#line 79 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                                                                            Write(Html.DisplayFor(model => model.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <p class=\"m-0 p-0 price-pro\">");
#nullable restore
#line 82 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("€</p>\r\n                            <hr class=\"p-0 m-0\">\r\n                        </div>\r\n                        <div class=\"col-lg-12 pt-2\">\r\n                            <h5>Description</h5>\r\n                            <span>");
#nullable restore
#line 87 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                             Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <hr class=\"m-0 pt-2 mt-2\">\r\n                        </div>\r\n                        <div class=\"col-lg-12\">\r\n                            <p class=\"tag-section\"><strong>Category: </strong><a");
            BeginWriteAttribute("href", " href=\"", 2781, "\"", 2788, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                                                                                    Write(Html.DisplayFor(model=>model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                        </div>\r\n");
#nullable restore
#line 93 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                        if (this.User.Identity.IsAuthenticated)
                           {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d969aa3636cf9e178541dde8502211f9232b02116075", async() => {
                WriteLiteral("\r\n                             <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 3133, "\"", 3150, 1);
#nullable restore
#line 97 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
WriteAttributeValue("", 3141, Model.Id, 3141, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                             <input type=\"number\" name=\"quantity\" value=\"1\" />\r\n                             <button class=\"btn btn-success\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3296, "\"", 3355, 3);
                WriteAttributeValue("", 3306, "location.href=\'", 3306, 15, true);
#nullable restore
#line 99 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
WriteAttributeValue("", 3321, Url.Action("AddToCart" , "Cart"), 3321, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3354, "\'", 3354, 1, true);
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
#line 101 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\Details.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 text-center pt-3"">
                <h4>More Product</h4>
            </div>
        </div>
        <div class=""row mt-3 p-0 text-center pro-box-section"">
            <div class=""col-lg-3 pb-2"">
                <div class=""pro-box border p-0 m-0"">
                    <img src=""http://nicesnippets.com/demo/pd-b-image1.jpg"">
                </div>
            </div>
            <div class=""col-lg-3 pb-2"">
                <div class=""pro-box border p-0 m-0"">
                    <img src=""http://nicesnippets.com/demo/pd-b-images2.jpg"">
                </div>
            </div>
            <div class=""col-lg-3 pb-2"">
                <div class=""pro-box border p-0 m-0"">
                    <img src=""http://nicesnippets.com/demo/pd-b-images3.jpg"">
                </div>
            </div>
            <div class=""col-lg-3 pb-2"">
                <div c");
            WriteLiteral("lass=\"pro-box border p-0 m-0\">\r\n                    <img src=\"http://nicesnippets.com/demo/pd-b-images4.jpg\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
