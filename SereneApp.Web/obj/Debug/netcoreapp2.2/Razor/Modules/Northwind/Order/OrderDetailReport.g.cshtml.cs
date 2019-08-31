#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0bda58eebf3c0f2e509a6adb9b1bab4f08d4a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Northwind_Order_OrderDetailReport), @"mvc.1.0.view", @"/Modules/Northwind/Order/OrderDetailReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/Northwind/Order/OrderDetailReport.cshtml", typeof(AspNetCore.Modules_Northwind_Order_OrderDetailReport))]
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
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#line 2 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#line 3 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\_ViewImports.cshtml"
using SereneApp;

#line default
#line hidden
#line 4 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0bda58eebf3c0f2e509a6adb9b1bab4f08d4a0", @"/Modules/Northwind/Order/OrderDetailReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Northwind_Order_OrderDetailReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SereneApp.Northwind.OrderDetailReportData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
 if ((bool?)ViewData["Printing"] == true)
{
    Layout = MVC.Views.Shared._LayoutNoNavigation;
}

#line default
#line hidden
            BeginContext(153, 196, true);
            WriteLiteral("\r\n<section class=\"invoice\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <h2 class=\"page-header\">\r\n                Invoice\r\n                <small class=\"pull-right\">Date: ");
            EndContext();
            BeginContext(350, 32, false);
#line 13 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                                           Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(382, 605, true);
            WriteLiteral(@"</small>
            </h2>
        </div>
    </div>
    <!-- info row -->
    <div class=""row invoice-info"">
        <div class=""col-sm-4 invoice-col"">
            From
            <address>
                <strong>Northwind, Inc.</strong><br>
                1357 Serenity Road<br>
                Visual Studio Gallery, VS 97653<br>
                Phone: (804) 123-5432<br>
                Email: info@northwind.net
            </address>
        </div>
        <!-- /.col -->
        <div class=""col-sm-4 invoice-col"">
            To
            <address>
                <strong>");
            EndContext();
            BeginContext(988, 26, false);
#line 33 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                   Write(Model.Customer.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 31, true);
            WriteLiteral("</strong><br>\r\n                ");
            EndContext();
            BeginContext(1046, 22, false);
#line 34 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
           Write(Model.Customer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1068, 25, true);
            WriteLiteral("\r\n                Phone: ");
            EndContext();
            BeginContext(1094, 20, false);
#line 35 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                  Write(Model.Customer.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 27, true);
            WriteLiteral("<br>\r\n                Fax: ");
            EndContext();
            BeginContext(1142, 18, false);
#line 36 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                Write(Model.Customer.Fax);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 136, true);
            WriteLiteral("\r\n            </address>\r\n        </div>\r\n        <!-- /.col -->\r\n        <div class=\"col-sm-4 invoice-col\">\r\n            <b>Invoice #IX");
            EndContext();
            BeginContext(1298, 19, false);
#line 41 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                      Write(Model.Order.OrderID);

#line default
#line hidden
            EndContext();
            BeginContext(1318, 57, true);
            WriteLiteral("</b><br>\r\n            <br>\r\n            <b>Order ID:</b> ");
            EndContext();
            BeginContext(1376, 19, false);
#line 43 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                        Write(Model.Order.OrderID);

#line default
#line hidden
            EndContext();
            BeginContext(1395, 38, true);
            WriteLiteral("<br>\r\n            <b>Payment Due:</b> ");
            EndContext();
            BeginContext(1434, 47, false);
#line 44 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                           Write(Model.Order.OrderDate.Value.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1481, 571, true);
            WriteLiteral(@"<br>
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
    <!-- Table row -->
    <div class=""row"">
        <div class=""col-xs-12 table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Product</th>
                        <th>Unit Price</th>
                        <th>Quantity</th>
                        <th>Discount</th>
                        <th>Line Total</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 63 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                     foreach (var d in Model.Details)
                    {

#line default
#line hidden
            BeginContext(2130, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2193, 13, false);
#line 66 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                           Write(d.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2206, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2247, 39, false);
#line 67 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                            Write(d.UnitPrice.ToStringDefault("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2328, 28, false);
#line 68 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                            Write(d.Quantity.ToStringDefault());

#line default
#line hidden
            EndContext();
            BeginContext(2357, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2398, 38, false);
#line 69 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                            Write(d.Discount.ToStringDefault("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(2437, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2478, 39, false);
#line 70 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                            Write(d.LineTotal.ToStringDefault("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(2518, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 72 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                    }

#line default
#line hidden
            BeginContext(2579, 270, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <!-- /.col -->
    </div>

    <div class=""row"">
        <div class=""col-xs-6"">

        </div>
        <!-- /.col -->
        <div class=""col-xs-6"">
            <p class=""lead"">Amount Due ");
            EndContext();
            BeginContext(2851, 59, false);
#line 85 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                                   Write(Model.Order.OrderDate.Value.AddDays(10).ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2911, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 87 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
              
                var subTotal = Model.Details.Sum(x => x.LineTotal ?? 0);
            

#line default
#line hidden
            BeginContext(3024, 202, true);
            WriteLiteral("\r\n            <div class=\"table-responsive\">\r\n                <table class=\"table\">\r\n                    <tr>\r\n                        <th style=\"width:50%\">Subtotal:</th>\r\n                        <td>$");
            EndContext();
            BeginContext(3227, 29, false);
#line 95 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                        Write(subTotal.ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3256, 134, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Tax (9.3%)</th>\r\n                        <td>$");
            EndContext();
            BeginContext(3392, 40, false);
#line 99 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                         Write((subTotal * 0.093m).ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3433, 267, true);
            WriteLiteral(@"</td>
                    </tr>
                    <tr>
                        <th>Shipping:</th>
                        <td>$5.80</td>
                    </tr>
                    <tr>
                        <th>Total:</th>
                        <td>$");
            EndContext();
            BeginContext(3702, 40, false);
#line 107 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Order\OrderDetailReport.cshtml"
                         Write((subTotal * 1.093m).ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3743, 118, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SereneApp.Northwind.OrderDetailReportData> Html { get; private set; }
    }
}
#pragma warning restore 1591