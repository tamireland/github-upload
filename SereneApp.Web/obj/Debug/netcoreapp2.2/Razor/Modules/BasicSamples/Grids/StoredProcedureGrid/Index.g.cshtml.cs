#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "315ab7328c4caea6d650fce158153818ce16c035"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_StoredProcedureGrid_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/StoredProcedureGrid/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Grids/StoredProcedureGrid/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Grids_StoredProcedureGrid_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"315ab7328c4caea6d650fce158153818ce16c035", @"/Modules/BasicSamples/Grids/StoredProcedureGrid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_StoredProcedureGrid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml"
  
    ViewBag.Title = "Stored Procedure Grid";

#line default
#line hidden
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(79, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(90, 13, false);
#line 6 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(103, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(128, 287, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>How to use a stored procedure as a data source.</p>

    <p style=""text-align: right;"">
        <b>Source Files:</b> 
        ");
            EndContext();
            BeginContext(416, 34, false);
#line 15 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(450, 12, true);
            WriteLiteral(", \r\n        ");
            EndContext();
            BeginContext(463, 47, false);
#line 16 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml"
   Write(Html.AppSourceFile("CustomerGrossSalesGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(510, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(521, 51, false);
#line 17 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml"
   Write(Html.AppSourceFile("CustomerGrossSalesEndpoint.cs"));

#line default
#line hidden
            EndContext();
            BeginContext(572, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(583, 53, false);
#line 18 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml"
   Write(Html.AppSourceFile("CustomerGrossSalesRepository.cs"));

#line default
#line hidden
            EndContext();
            BeginContext(636, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(647, 54, false);
#line 19 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml"
   Write(Html.AppSourceFile("CustomerGrossSalesListRequest.cs"));

#line default
#line hidden
            EndContext();
            BeginContext(701, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(712, 50, false);
#line 20 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\StoredProcedureGrid\Index.cshtml"
   Write(Html.AppSourceFile("CustomerGrossSalesColumns.cs"));

#line default
#line hidden
            EndContext();
            BeginContext(762, 265, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new SereneApp.BasicSamples.CustomerGrossSalesGrid($('#GridDiv'), {}).init();

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
