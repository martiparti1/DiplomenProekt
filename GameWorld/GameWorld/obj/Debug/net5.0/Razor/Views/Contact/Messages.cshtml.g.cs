#pragma checksum "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf130d844f9d26edfa8eff2d9fc88b2af44d7329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Messages), @"mvc.1.0.view", @"/Views/Contact/Messages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf130d844f9d26edfa8eff2d9fc88b2af44d7329", @"/Views/Contact/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GameWorld.Domain.Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml"
  
    ViewBag.Title = "Messages";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #container-round-white
{
  background-color: #FFFFFF;
  border-radius:15px;
  padding: 20px;
  height:17vh;
}
#space{padding: 5px;}
</style>
<h2>Messages</h2>
<p id=""space"" ></p>

<table id=""container-round-white"" class=""table  table-hover"">
    <thead>
        <tr>
            <th>Name</th>
            <th>Email</th>
            <th>Subject</th>
            <th>Message</th>
            <th>Submitted At</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml"
         foreach (var message in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml"
               Write(message.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml"
               Write(message.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml"
               Write(message.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml"
               Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml"
               Write(message.SubmittedAt.ToString("g"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Contact\Messages.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GameWorld.Domain.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
