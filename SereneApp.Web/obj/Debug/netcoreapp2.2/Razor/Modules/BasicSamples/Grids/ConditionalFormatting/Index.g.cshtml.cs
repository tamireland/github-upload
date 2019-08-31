#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19e9180f109249e07f973dbb736573e15fab6fc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_ConditionalFormatting_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/ConditionalFormatting/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Grids/ConditionalFormatting/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Grids_ConditionalFormatting_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19e9180f109249e07f973dbb736573e15fab6fc7", @"/Modules/BasicSamples/Grids/ConditionalFormatting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_ConditionalFormatting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml"
  
    ViewData["Title"] = "Conditional Formatting In Grid Rows";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(97, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(108, 17, false);
#line 6 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(125, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(150, 796, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        This sample demonstrates how to style rows depending on data item values.
    </p>
    <p>
        Discontinued rows use grayed text. Rows with Units In Stock &lt; 0 shows with a red background.
        Rows with Units In Stock &lt; 20 shows with a orange background.
        Rows with Units In Stock &gt; 50 are in italic.
        Unit price is colored depending on the price level being higher than 50, or lower than 20.
    </p>
    <p>
        Coloring is done by adding CSS classes to row, by overriding <em>getItemCssClass</em> method.
    </p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
            EndContext();
            BeginContext(947, 34, false);
#line 25 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(981, 12, true);
            WriteLiteral(", \r\n        ");
            EndContext();
            BeginContext(994, 50, false);
#line 26 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml"
   Write(Html.AppSourceFile("ConditionalFormattingGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 268, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new SereneApp.BasicSamples.ConditionalFormattingGrid($('#GridDiv'), {}).init();

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
