#pragma checksum "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb5c29f9339019dfeb392ad6e10ce3d4111d69b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\_ViewImports.cshtml"
using GameWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\_ViewImports.cshtml"
using GameWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
using GameWorld.Models.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5c29f9339019dfeb392ad6e10ce3d4111d69b9", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GameWorld.Models.Product.ProductIndexVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n.text-center.container.py-5 {\r\n  background-color: #E0E0E0;\r\n  border-radius:20px;\r\n}\r\n\r\n\r\n#card-round-borders{\r\n    border-radius: 10px;\r\n}\r\n\r\n\r\n\r\n</style>\r\n\r\n");
#nullable restore
#line 18 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
 if ((this.User.Identity.IsAuthenticated) && (this.User.IsInRole("Administrator")))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb5c29f9339019dfeb392ad6e10ce3d4111d69b96185", async() => {
                WriteLiteral("Add a Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 23 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb5c29f9339019dfeb392ad6e10ce3d4111d69b97625", async() => {
                WriteLiteral("\r\n <section style=\"background-color: #eee;\">\r\n        <div class=\"text-center container py-5\">\r\n            \r\n\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 30 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                 <div class=""col-lg-4 col-md-12 mb-4"">
                    <div id=""card-round-borders"" class=""card"">
                        <div class=""bg-image hover-zoom ripple ripple-surface ripple-surface-light"" data-mdb-ripple-color=""light"">
                         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb5c29f9339019dfeb392ad6e10ce3d4111d69b98608", async() => {
                    WriteLiteral(" <img");
                    BeginWriteAttribute("src", " src=\"", 997, "\"", 1014, 1);
#nullable restore
#line 35 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
WriteAttributeValue("", 1003, item.Image, 1003, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"card-round-borders\" class=\"w-100 img-thumbnail\" /> ");
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
#line 35 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("   \r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                          <a");
                BeginWriteAttribute("href", " href=\"", 1189, "\"", 1196, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"text-reset\">\r\n                            <h5 class=\"card-title mb-3\">");
#nullable restore
#line 39 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
                                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                          </a>\r\n                          <a");
                BeginWriteAttribute("href", " href=\"", 1359, "\"", 1366, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"text-reset\">\r\n                            <p>");
#nullable restore
#line 42 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
                          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                          </a>\r\n                            <h6 class=\"mb-3\">");
#nullable restore
#line 44 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n");
#nullable restore
#line 45 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
                            if (this.User.Identity.IsAuthenticated)
                           {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb5c29f9339019dfeb392ad6e10ce3d4111d69b913256", async() => {
                    WriteLiteral("\r\n                             <input type=\"hidden\" name=\"productId\"");
                    BeginWriteAttribute("value", " value=\"", 1801, "\"", 1817, 1);
#nullable restore
#line 49 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
WriteAttributeValue("", 1809, item.Id, 1809, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                             <input type=\"number\" name=\"quantity\" value=\"1\" />\r\n                             <button type=\"submit\">Add to Cart</button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
                           }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                     </div>\r\n                     </div>\r\n                 </div>\r\n");
#nullable restore
#line 58 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n        </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GameWorld.Models.Product.ProductIndexVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
