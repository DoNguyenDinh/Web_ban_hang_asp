#pragma checksum "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\Home\checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc79cd5c9d67843f3b0ced9dcbb72e298176d080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_checkout), @"mvc.1.0.view", @"/Views/Home/checkout.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\_ViewImports.cshtml"
using Ecommerces_asp.net.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc79cd5c9d67843f3b0ced9dcbb72e298176d080", @"/Views/Home/checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a5411045041dc6a6ddbe5d973ae24bc5a7d3064", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\Home\checkout.cshtml"
   
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""breadcrumbs"">
    <div class=""container"">
        <ol class=""breadcrumb breadcrumb1"">
            <li><a href=""index.html""><span class=""glyphicon glyphicon-home"" aria-hidden=""true""></span>Home</a></li>
            <li class=""active"">Checkout Page</li>
        </ol>
    </div>
</div>
<!-- //breadcrumbs -->
<!-- checkout -->
<div class=""checkout"">
    <div class=""container"">
        <h2>Your shopping cart contains: <span>3 Products</span></h2>
        <div class=""checkout-right"">
            <table class=""timetable_sub"">
                <thead>
                    <tr>
                        <th>SL No.</th>
                        <th>Product</th>
                        <th>Quality</th>
                        <th>Product Name</th>

                        <th>Price</th>
                        <th>Remove</th>
                    </tr>
                </thead>
");
#nullable restore
#line 30 "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\Home\checkout.cshtml"
                 foreach (var item in ViewBag.cart)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"rem1\">\r\n                    <td class=\"invert\">1</td>\r\n                    <td class=\"invert-image\"><a href=\"single.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc79cd5c9d67843f3b0ced9dcbb72e298176d0805239", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1179, "~/template/images/", 1179, 18, true);
#nullable restore
#line 36 "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\Home\checkout.cshtml"
AddHtmlAttributeValue("", 1197, item.Product.Image, 1197, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a></td>
                    <td class=""invert"">
                        <div class=""quantity"">
                            <div class=""quantity-select"">
                                <div class=""entry value-minus"">&nbsp;</div>
                                <div class=""entry value""><span>");
#nullable restore
#line 41 "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\Home\checkout.cshtml"
                                                          Write(item.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                                <div class=\"entry value-plus active\">&nbsp;</div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td class=\"invert\">");
#nullable restore
#line 46 "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\Home\checkout.cshtml"
                                  Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"invert\">$");
#nullable restore
#line 48 "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\Home\checkout.cshtml"
                                   Write(item.Product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td class=""invert"">
                        <div class=""rem"">
                            <div class=""close1""> </div>
                        </div>
                        <script>
$(document).ready(function(c) {
								$('.close1').on('click', function(c){
									$('.rem1').fadeOut('slow', function(c){
										$('.rem1').remove();
									});
									});
								});
                        </script>
                    </td>
                </tr>
");
#nullable restore
#line 64 "C:\Users\hp\Desktop\tai\Tan Tai\-n-ASP.NET-CORE\Ecommerces_asp.net\Views\Home\checkout.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!--quantity-->\r\n");
            WriteLiteral(@"                <!--quantity-->
            </table>
        </div>
        <div class=""checkout-left"">
            <div class=""checkout-left-basket"">
                <h4>Continue to basket</h4>
                <ul>
                    <li>Product1 <i>-</i> <span>$15.00 </span></li>
                    <li>Product2 <i>-</i> <span>$25.00 </span></li>
                    <li>Product3 <i>-</i> <span>$29.00 </span></li>
                    <li>Total Service Charges <i>-</i> <span>$15.00</span></li>
                    <li>Total <i>-</i> <span>$84.00</span></li>
                </ul>
            </div>
            <div class=""checkout-right-basket"">
                <a href=""single.html""><span class=""glyphicon glyphicon-menu-left"" aria-hidden=""true""></span>Continue Shopping</a>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
