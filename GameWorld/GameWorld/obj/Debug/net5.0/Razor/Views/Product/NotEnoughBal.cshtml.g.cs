#pragma checksum "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\NotEnoughBal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa6aa258a651c5293fa91d2f9a7eb2d2de2993fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_NotEnoughBal), @"mvc.1.0.view", @"/Views/Product/NotEnoughBal.cshtml")]
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
#nullable restore
#line 1 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\NotEnoughBal.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\NotEnoughBal.cshtml"
using GameWorld.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa6aa258a651c5293fa91d2f9a7eb2d2de2993fa", @"/Views/Product/NotEnoughBal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_NotEnoughBal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\NotEnoughBal.cshtml"
   
    ViewData["Title"] = "Not enough balance";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Your balance isn\'t enough to place this order.</h1>\r\n<div>\r\n    <button type=\"button\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 281, "\"", 343, 3);
            WriteAttributeValue("", 291, "location.href=\'", 291, 15, true);
#nullable restore
#line 9 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Product\NotEnoughBal.cshtml"
WriteAttributeValue("", 306, Url.Action("AddBalance", "Balance"), 306, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 342, "\'", 342, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add more balance</button>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
