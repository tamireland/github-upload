#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\InlineImageInGrid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "168dc396f7451c37676bcb1335b80460e1762c66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_InlineImageInGrid_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/InlineImageInGrid/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Grids/InlineImageInGrid/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Grids_InlineImageInGrid_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"168dc396f7451c37676bcb1335b80460e1762c66", @"/Modules/BasicSamples/Grids/InlineImageInGrid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_InlineImageInGrid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\InlineImageInGrid\Index.cshtml"
  
    ViewData["Title"] = "Inline Image in Grid";

#line default
#line hidden
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Head", async() => {
                BeginContext(73, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(104, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(115, 17, false);
#line 9 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\InlineImageInGrid\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(132, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(157, 371, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>Here is how to show a product image inline in grid.</p>
    <p>If you didn't yet, please upload an image for a product for this demonstration to work.</p>

    <p style=""text-align: right;""><b>Source Files:</b> ");
            EndContext();
            BeginContext(529, 34, false);
#line 17 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\InlineImageInGrid\Index.cshtml"
                                                  Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(563, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(566, 42, false);
#line 17 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\InlineImageInGrid\Index.cshtml"
                                                                                       Write(Html.AppSourceFile("InlineImageInGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(608, 269, true);
            WriteLiteral(@"</p>
</div>

<div id=""GridDiv""></div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new SereneApp.BasicSamples.InlineImageInGrid($('#GridDiv'));
        Q.initFullHeightGridPage($('#GridDiv'));
    });
</script>");
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