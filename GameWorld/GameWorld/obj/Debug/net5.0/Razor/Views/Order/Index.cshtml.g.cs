#pragma checksum "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d779d149a02664c6ee3cc0e86c58f39bfe9090"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d779d149a02664c6ee3cc0e86c58f39bfe9090", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GameWorld.Models.Order.OrderIndexVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
#container-round-white
{
  background-color: #FFFFFF;
  border-radius:15px;
  padding: 20px;
  height:22vh;
}

#space{padding: 5px;}
</style>

<h1>Site Order History</h1>
<p id=""space""></p>

<table id=""container-round-white"" class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 25 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                Name of the Product\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Final Price\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 57 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 64 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 68 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src =\"", 1719, "\"", 1767, 1);
#nullable restore
#line 71 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
WriteAttributeValue("", 1726, Html.DisplayFor(modelItem => item.Image), 1726, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" width=\"100\" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 90 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GameWorld.Models.Order.OrderIndexVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
