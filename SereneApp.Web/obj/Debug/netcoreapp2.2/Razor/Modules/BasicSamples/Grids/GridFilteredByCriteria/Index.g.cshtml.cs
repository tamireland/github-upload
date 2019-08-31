#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\GridFilteredByCriteria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f4891dc44c914c20f1029430c712b8391e8581"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_GridFilteredByCriteria_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/GridFilteredByCriteria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Grids/GridFilteredByCriteria/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Grids_GridFilteredByCriteria_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f4891dc44c914c20f1029430c712b8391e8581", @"/Modules/BasicSamples/Grids/GridFilteredByCriteria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_GridFilteredByCriteria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\GridFilteredByCriteria\Index.cshtml"
  
    ViewData["Title"] = "Grid Filtered By Criteria";

#line default
#line hidden
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(87, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(98, 17, false);
#line 6 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\GridFilteredByCriteria\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(115, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(140, 852, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        There are several ways to filter a grid in Serenity. Quick search box, quick filters
        and edit filter dialog etc. All of these filtering options are modifiable
        by end users. Even if you set an initial filter, end user might be able to clear it.
    </p>
    <p>
        Sometimes you may want to prefilter records that are shown in a particular page.
        ListRequest has a ""Criteria"" parameter to let you handle this from client
        side (this parameter is also used by edit filter dialog).
    </p>
    <p>
        Here we show only products that match criteria ""UnitsInStock > 10 and Category != Condiments and 
        Discountinued == false"". See ");
            EndContext();
            BeginContext(993, 47, false);
#line 23 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\GridFilteredByCriteria\Index.cshtml"
                                Write(Html.AppSourceFile("GridFilteredByCriteria.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 81, true);
            WriteLiteral(" to see how.\r\n    </p>\r\n\r\n    <p style=\"text-align: right;\"><b>Source Files:</b> ");
            EndContext();
            BeginContext(1122, 34, false);
#line 26 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\GridFilteredByCriteria\Index.cshtml"
                                                  Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1159, 47, false);
#line 26 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\GridFilteredByCriteria\Index.cshtml"
                                                                                       Write(Html.AppSourceFile("GridFilteredByCriteria.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 259, true);
            WriteLiteral(@"</p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new SereneApp.BasicSamples.GridFilteredByCriteria($('#GridDiv'), {}).init();

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
