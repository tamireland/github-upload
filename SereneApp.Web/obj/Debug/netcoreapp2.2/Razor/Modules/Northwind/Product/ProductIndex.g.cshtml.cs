#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Product\ProductIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6143351dd3cb2e1f0873258bd8d72586806c4097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Northwind_Product_ProductIndex), @"mvc.1.0.view", @"/Modules/Northwind/Product/ProductIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/Northwind/Product/ProductIndex.cshtml", typeof(AspNetCore.Modules_Northwind_Product_ProductIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6143351dd3cb2e1f0873258bd8d72586806c4097", @"/Modules/Northwind/Product/ProductIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Northwind_Product_ProductIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Product\ProductIndex.cshtml"
  
    ViewData["Title"] = Serenity.LocalText.Get("Db.Northwind.Product.EntityPlural");

#line default
#line hidden
            BeginContext(95, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Head", async() => {
                BeginContext(112, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(115, 50, false);
#line 7 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Product\ProductIndex.cshtml"
Write(Html.Script("dynamic://Lookup.Northwind.Category"));

#line default
#line hidden
                EndContext();
                BeginContext(165, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(168, 50, false);
#line 8 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Northwind\Product\ProductIndex.cshtml"
Write(Html.Script("dynamic://Lookup.Northwind.Supplier"));

#line default
#line hidden
                EndContext();
                BeginContext(218, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(223, 229, true);
            WriteLiteral("<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new SereneApp.Northwind.ProductGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
