#pragma checksum "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45508215f1dce6319d58efd444b047ab0919bbab"
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
#line 2 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
using GameWorld.Models.Statistics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45508215f1dce6319d58efd444b047ab0919bbab", @"/Views/Statistics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StatisticsVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
  ViewData["Title"] = "Statistics"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4 class=""text-center"">Statistics</h4>
<div class=""text-center"">
    <div class=""col-x1-8"">
        <div class=""card-group pb-0"">
            <div class=""card-columns text-center"">
            </div>
        </div>
        <table class=""table table-striped"" style=""width:100%"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 17 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CountClients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CountProducts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.CountOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.SumOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountClients));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountProducts));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
                   Write(Html.DisplayFor(model => model.CountOrders));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "D:\coding stuff\marti parti diplomen\DiplomenProekt\GameWorld\GameWorld\Views\Statistics\Index.cshtml"
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
