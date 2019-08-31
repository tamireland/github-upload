#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c49ebc4633bee80dba9e046c3332ddb139cb664e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_ViewWithoutID_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/ViewWithoutID/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Grids/ViewWithoutID/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Grids_ViewWithoutID_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49ebc4633bee80dba9e046c3332ddb139cb664e", @"/Modules/BasicSamples/Grids/ViewWithoutID/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_ViewWithoutID_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
  
    ViewData["Title"] = "View Without ID";

#line default
#line hidden
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(77, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(88, 17, false);
#line 6 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(105, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(130, 677, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>One of the frequently asked questions about Serenity is how to work views, and especially with ones without an ID column.</p>
    <p>Actually this is a requirement of SlickGrid, as it needs a unique ID for items.</p>
    <p>It could be possible to use an expression field (doesn't have to be in view) by concatting view fields to get a composite ID.</p>
    <p>Anyway in this sample we are using a view from Northwind (Sales By Category) that doesn't have an ID, and we are not using a composite key.</p>
    <p>See ");
            EndContext();
            BeginContext(808, 42, false);
#line 15 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
      Write(Html.AppSourceFile("ViewWithoutIDGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(850, 163, true);
            WriteLiteral(" for how to set a fake autoincrementing ID client side by intercepting OnViewProcessData method.</p>\r\n    \r\n    <p style=\"text-align: right;\"><b>Source Files:</b> ");
            EndContext();
            BeginContext(1014, 34, false);
#line 17 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
                                                  Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1051, 42, false);
#line 17 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Grids\ViewWithoutID\Index.cshtml"
                                                                                       Write(Html.AppSourceFile("ViewWithoutIDGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 254, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new SereneApp.BasicSamples.ViewWithoutIDGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
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
