#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\OtherFormInTabOneBar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cf908f67af69d7289978025930bef97dc8ac632"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Dialogs_OtherFormInTabOneBar_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Dialogs/OtherFormInTabOneBar/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/BasicSamples/Dialogs/OtherFormInTabOneBar/Index.cshtml", typeof(AspNetCore.Modules_BasicSamples_Dialogs_OtherFormInTabOneBar_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf908f67af69d7289978025930bef97dc8ac632", @"/Modules/BasicSamples/Dialogs/OtherFormInTabOneBar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Dialogs_OtherFormInTabOneBar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\OtherFormInTabOneBar\Index.cshtml"
  
    ViewData["Title"] = "Another Form In Tab With One Toolbar";

#line default
#line hidden
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(98, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(109, 17, false);
#line 6 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\OtherFormInTabOneBar\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(126, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(151, 565, true);
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>Sometimes you may want to display / edit details of a related entity in a tab.</p>
    <p>Here we show customer details in a tab under order dialog.</p>
    <p>Note that, customer details are loaded separately from the order itself.</p>
    <p>In this example Order and Customer entities are saved with same toolbar button.</p>

    <p style=""text-align: right;"">
        <b>Source Files:</b>
        ");
            EndContext();
            BeginContext(717, 34, false);
#line 18 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\OtherFormInTabOneBar\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(751, 11, true);
            WriteLiteral(",\r\n        ");
            EndContext();
            BeginContext(763, 46, false);
#line 19 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\OtherFormInTabOneBar\Index.cshtml"
   Write(Html.AppSourceFile("OtherFormOneBarDialog.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(809, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(820, 44, false);
#line 20 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\OtherFormInTabOneBar\Index.cshtml"
   Write(Html.AppSourceFile("OtherFormOneBarGrid.ts"));

#line default
#line hidden
            EndContext();
            BeginContext(864, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(875, 57, false);
#line 21 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\BasicSamples\Dialogs\OtherFormInTabOneBar\Index.cshtml"
   Write(Html.AppSourceFile("OtherFormOneBarDialog.Template.html"));

#line default
#line hidden
            EndContext();
            BeginContext(932, 267, true);
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new SereneApp.BasicSamples.OtherFormInTabOneBarGrid($('#GridDiv'), {}).init();

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
