#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73bc3d58e9fd5889bee879ae756040b6b9b91ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ChangePassword_AccountChangePassword), @"mvc.1.0.view", @"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml", typeof(AspNetCore.Modules_Membership_Account_ChangePassword_AccountChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73bc3d58e9fd5889bee879ae756040b6b9b91ea", @"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ChangePassword_AccountChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ChangePassword.FormTitle;
    ViewData["PageId"] = "ChangePassword";

#line default
#line hidden
            BeginContext(125, 112, true);
            WriteLiteral("\r\n<script id=\"Template_Membership_ChangePasswordPanel\" type=\"text/template\">\r\n<div>\r\n    <h3 class=\"page-title\">");
            EndContext();
            BeginContext(238, 47, false);
#line 8 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
                      Write(Texts.Forms.Membership.ChangePassword.FormTitle);

#line default
#line hidden
            EndContext();
            BeginContext(285, 400, true);
            WriteLiteral(@"</h3>
    <form id=""~_Form"" action="""">
        <div class=""s-Form"">
            <div class=""fieldset ui-widget ui-widget-content ui-corner-all"">
                <div id=""~_PropertyGrid""></div>
                <div class=""clear""></div>
            </div>
            <div class=""buttons"">
                <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary"">
                    ");
            EndContext();
            BeginContext(686, 50, false);
#line 17 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
               Write(Texts.Forms.Membership.ChangePassword.SubmitButton);

#line default
#line hidden
            EndContext();
            BeginContext(736, 333, true);
            WriteLiteral(@"
                </button>
            </div>
        </div>
    </form>
</div>
</script>

<div class=""page-content"">
    <div id=""ChangePasswordPanel"">
    </div>
</div>

<script type=""text/javascript"">
$(function() {
    new SereneApp.Membership.ChangePasswordPanel($('#ChangePasswordPanel')).init();
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
