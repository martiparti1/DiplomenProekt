#pragma checksum "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2bdf216546365ee22249fca69ea02f300434e03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_Index), @"mvc.1.0.view", @"/Views/Statistics/Index.cshtml")]
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
#nullable restore
#line 2 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
using GameWorld.Models.Statistics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2bdf216546365ee22249fca69ea02f300434e03", @"/Views/Statistics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StatisticsVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
  ViewData["Title"] = "Statistics"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #container-round-white
{
  background-color: #FFFFFF;
  border-radius:15px;
  padding: 20px;
  height:100%;
}
</style>
<h4 class=""text-center"">Statistics</h4>
<div id=""container-round-white"" class=""text-center"">
    <div class=""col-x1-8"">
        <div class=""card-group pb-0"">
            <div class=""card-columns text-center"">
            </div>
        </div>
        <table class=""table table-striped"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                       Number of Clients
                    </th>
                    <th>
                        Number of Products
                    </th>
                    <th>
                        Number of Orders
                    </th>
                    <th>
                        Total Sum of all Orders
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        ");
#nullable restore
#line 41 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountClients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountProducts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "D:\na marti diplomata(school version\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.SumOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StatisticsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
