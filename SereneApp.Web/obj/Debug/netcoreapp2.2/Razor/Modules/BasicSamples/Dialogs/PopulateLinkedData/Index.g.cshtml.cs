#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\PopulateLinkedData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f7e47f6be195d878ebe498d98efc2879e891b47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Dialogs_PopulateLinkedData_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Dialogs/PopulateLinkedData/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Dialogs/PopulateLinkedData/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Dialogs_PopulateLinkedData_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7e47f6be195d878ebe498d98efc2879e891b47", @"/Modules/BasicSamples/Dialogs/PopulateLinkedData/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Dialogs_PopulateLinkedData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\PopulateLinkedData\Index.cshtml"
  
    ViewData["Title"] = "Populate Linked Data";

#line default
#line hidden
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(82, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(93, 17, false);
#line 6 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\PopulateLinkedData\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(110, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(135, 506, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>This sample demonstrates how to refresh related fields when a joined field value changes.</p>
    <p>Open an order record, and change the Customer. Dialog will re-populate its customer details.</p>
    <p>This is performed with a call to Retrieve method of Customer service.</p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
            EndContext();
            BeginContext(642, 34, false);
#line 16 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\PopulateLinkedData\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(676, 12, true);
            WriteLiteral(", \r\n        ");
            EndContext();
            BeginContext(689, 49, false);
#line 17 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\PopulateLinkedData\Index.cshtml"
   Write(Html.AppSourceFile("PopulateLinkedDataDialog.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(738, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(749, 47, false);
#line 18 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\PopulateLinkedData\Index.cshtml"
   Write(Html.AppSourceFile("PopulateLinkedDataGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(796, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(807, 47, false);
#line 19 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\PopulateLinkedData\Index.cshtml"
   Write(Html.AppSourceFile("PopulateLinkedDataForm.cs"));

#line default
#line hidden
            EndContext();
            BeginContext(854, 265, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new SereneApp.BasicSamples.PopulateLinkedDataGrid($('#GridDiv'), {}).init();

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