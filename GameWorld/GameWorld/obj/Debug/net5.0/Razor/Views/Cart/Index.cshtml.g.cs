#pragma checksum "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ba2ee8bfa98da0d8025aac73ff649b08d400430"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ba2ee8bfa98da0d8025aac73ff649b08d400430", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"764080dd2c2806edcb15dc09a44cc56a4898ed19", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameWorld.Domain.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>
.h-custom {
height: 100vh !important;
}


.card-registration .select-input.form-control[readonly]:not([disabled]) {
font-size: 1rem;
line-height: 2.15;
padding-left: .75em;
padding-right: .75em;
}

.card-registration .select-arrow {
top: 13px;
}

.bg-grey {
background-color: #eae8e8;
}


.card-registration-2 .bg-grey {
border-top-right-radius: 16px;
border-bottom-right-radius: 16px;
}



.card-registration-2 .bg-grey {
border-bottom-left-radius: 16px;
border-bottom-right-radius: 16px;
}

#pt-5-right {
  text-align: right;
}
#pt-5-left {
  text-align: left;
}

#pt-5-a-red {
  color: red;
  text-decoration: underline;
}
</style>



<div class=""container py-5 h-100"">
    <div class=""row d-flex justify-content-center align-items-center h-100"">
      <div class=""col-12"">
        <div class=""card card-registration card-registration-2"" style=""border-radius: 15px;"">
          <div class=""card-body p-0"">
            <div class=""row g-0"">
              <d");
            WriteLiteral(@"iv class=""col-lg-8"">
                <div class=""p-5"">
                  <div class=""d-flex justify-content-between align-items-center mb-5"">
                    <h1 class=""fw-bold mb-0 text-black"">Your Cart</h1>
                    <h6 class=""mb-0 text-muted"">");
#nullable restore
#line 161 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                                           Write(Model.Items.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Items</h6>\r\n                  </div>\r\n");
#nullable restore
#line 163 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                   if(Model.Items.Count == 0)
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <h2>Your cart is empty</h2>\r\n                      <hr class=\"my-4\">\r\n");
#nullable restore
#line 167 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                  }
                  
                  else
                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <hr class=\"my-4\">\r\n");
#nullable restore
#line 172 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                   foreach(var item in Model.Items)
                  {
    


#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"row mb-4 d-flex justify-content-between align-items-center\">\r\n                    <div class=\"col-md-2 col-lg-2 col-xl-2\">\r\n                      <img");
            BeginWriteAttribute("src", "\r\n                        src=\"", 4464, "\"", 4514, 1);
#nullable restore
#line 179 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
WriteAttributeValue("", 4495, item.Product.Image, 4495, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"img-fluid rounded-3\" alt=\"img\">\r\n                    </div>\r\n                    <div class=\"col-md-3 col-lg-3 col-xl-3\">\r\n                      <h6 class=\"text-muted\">");
#nullable restore
#line 183 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                                        Write(item.Product.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                      <h6 class=\"text-black mb-0\">");
#nullable restore
#line 184 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                                             Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 184 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                                                                        Write(item.Product.Platform.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h6>\r\n                    </div>\r\n                    <div class=\"col-md-3 col-lg-3 col-xl-2 d-flex\">\r\n                     \r\n                      <input id=\"form1\" min=\"0\"");
            BeginWriteAttribute("value", " value=\"", 5042, "\"", 5064, 1);
#nullable restore
#line 188 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5050, item.Quantity, 5050, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""number""
                        class=""form-control form-control-sm"" onkeypress=""return handleEnterKey(event);"" />
                       
                    
                    </div>
                    <div class=""col-md-3 col-lg-2 col-xl-2 offset-lg-1"">
                      <h6 class=""mb-0"">");
#nullable restore
#line 194 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                                  Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</h6>\r\n                    </div>\r\n\r\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ba2ee8bfa98da0d8025aac73ff649b08d4004309349", async() => {
                WriteLiteral("\r\n                     <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 5583, "\"", 5607, 1);
#nullable restore
#line 198 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5591, item.Product.Id, 5591, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                     <button type=\"submit\" class=\"close\"><span aria-hidden=\"true\">&times;</span></button>\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 197 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 5470, Url.Action("RemoveFromCart", "Cart"), 5470, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n");
            WriteLiteral("                  <hr class=\"my-4\">\r\n");
#nullable restore
#line 204 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"

                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                   
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  <div>\r\n                      <button class=\"btn btn-light\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5937, "\"", 5994, 3);
            WriteAttributeValue("", 5947, "location.href=\'", 5947, 15, true);
#nullable restore
#line 209 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5962, Url.Action("Index", "Product"), 5962, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5993, "\'", 5993, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</button>\r\n                      <button class=\"btn btn-danger\" style=\"float: right; text-decoration: underline;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6126, "\"", 6184, 3);
            WriteAttributeValue("", 6136, "location.href=\'", 6136, 15, true);
#nullable restore
#line 210 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
WriteAttributeValue("", 6151, Url.Action("ClearCart", "Cart"), 6151, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6183, "\'", 6183, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Clear Cart</button> 
                  </div> 

                </div>
              </div>
              <div class=""col-lg-4 bg-grey"">
                <div class=""p-5"">
                  <h3 class=""fw-bold mb-5 mt-2 pt-1"">Summary</h3>
                  <hr class=""my-4"">

                  <div class=""d-flex justify-content-between mb-4"">
                    <h5>");
#nullable restore
#line 221 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                   Write(Model.Items.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Items</h5>\r\n                  </div>\r\n\r\n                  <div class=\"mb-5\">\r\n                  </div>\r\n\r\n\r\n                  <div class=\"d-flex justify-content-between mb-4\">\r\n");
#nullable restore
#line 229 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                     if(true)
                    {
                        decimal finalPrice = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 232 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                     foreach(var item in Model.Items)
                    {
                        
                        decimal productFinalPrice = item.Product.Price * item.Quantity;
                        finalPrice += productFinalPrice;

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5 class=\"align-text-right\"> Price before discounts : ");
#nullable restore
#line 239 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                                                                      Write(String.Format("{0:0.00}",finalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</h5>\r\n");
#nullable restore
#line 240 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  </div>
                 

                  <div class=""mb-5"">
                  </div>

                  <hr class=""my-4"">

                  <div class=""d-flex justify-content-between mb-5"">
                    <h5>Final price</h5>
");
#nullable restore
#line 251 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                     if(true)
                    {
                        decimal finalPrice = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 254 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                     foreach(var item in Model.Items)
                    {
                        
                        decimal productFinalPrice = item.Product.Price * item.Quantity - item.Product.Price*item.Quantity*item.Product.Discount/100;
                        finalPrice += productFinalPrice;

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h5>");
#nullable restore
#line 261 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                   Write(String.Format("{0:0.00}",finalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</h5>\r\n");
#nullable restore
#line 262 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                  </div>\r\n                    <button class=\"btn btn-success btn-lg btn-block\"");
            BeginWriteAttribute("onclick", " onclick=\"", 8194, "\"", 8251, 3);
            WriteAttributeValue("", 8204, "location.href=\'", 8204, 15, true);
#nullable restore
#line 265 "D:\coding stuff\MARTI PARTI GAMEWORLD\DiplomenProekt\GameWorld\GameWorld\Views\Cart\Index.cshtml"
WriteAttributeValue("", 8219, Url.Action("Checkout", "Cart"), 8219, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8250, "\'", 8250, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Checkout</button>\r\n\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n\r\n");
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
