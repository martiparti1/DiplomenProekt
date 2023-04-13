#pragma checksum "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eacdebe3d6b37d575743910d75ce21912767d073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eacdebe3d6b37d575743910d75ce21912767d073", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameWorld.Domain.Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Your Shopping Cart</h2>\r\n\r\n");
#nullable restore
#line 5 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
 if (Model.Items.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Your cart is empty.</p>\r\n");
#nullable restore
#line 8 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Product Name</th>\r\n                <th>Price</th>\r\n                <th>Quantity</th>\r\n                <th>Total</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n           \r\n");
#nullable restore
#line 22 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                   Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                   Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                    Write(item.Quantity * item.Product.Price - item.Quantity*item.Product.Price*item.Product.Discount / 100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 31 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                \r\n                <td colspan=\"3\">Total:</td>\r\n                <td id=\"cart-total\"></td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 1003, "\"", 1042, 1);
#nullable restore
#line 40 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1010, Url.Action("ClearCart", "Cart"), 1010, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Clear Cart</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1104, 1);
#nullable restore
#line 41 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1073, Url.Action("Checkout", "Cart"), 1073, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Checkout</a>\r\n");
#nullable restore
#line 42 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    $(document).ready(function () {\r\n        var total = 0;\r\n        $(\".item-total\").each(function () {\r\n            total += parseFloat($(this).text());\r\n        });\r\n        $(\"#cart-total\").text(total);\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameWorld.Domain.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591