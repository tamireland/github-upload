#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Membership\Account\SignUp\AccountActivateEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d727c20340b9cb3c3069cd5b09a27a92dce34f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_SignUp_AccountActivateEmail), @"mvc.1.0.view", @"/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml", typeof(AspNetCore.Modules_Membership_Account_SignUp_AccountActivateEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d727c20340b9cb3c3069cd5b09a27a92dce34f0b", @"/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_SignUp_AccountActivateEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SereneApp.Membership.ActivateEmailModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d727c20340b9cb3c3069cd5b09a27a92dce34f0b4054", async() => {
                BeginContext(64, 54, true);
                WriteLiteral("\r\n    <title>Activate your SereneApp account</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(127, 394, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d727c20340b9cb3c3069cd5b09a27a92dce34f0b5289", async() => {
                BeginContext(133, 9, true);
                WriteLiteral("\r\n    <p>");
                EndContext();
                BeginContext(143, 17, false);
#line 8 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Membership\Account\SignUp\AccountActivateEmail.cshtml"
  Write(Model.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(160, 178, true);
                WriteLiteral(",</p>\r\n\r\n    <p>We received a request to create a new account on SereneApp with your e-mail address.</p>\r\n\r\n    <p>Click the link below to activate your account:</p>\r\n\r\n    <p><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 338, "\"", 364, 1);
#line 14 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Membership\Account\SignUp\AccountActivateEmail.cshtml"
WriteAttributeValue("", 345, Model.ActivateLink, 345, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(365, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(367, 18, false);
#line 14 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\Membership\Account\SignUp\AccountActivateEmail.cshtml"
                                Write(Model.ActivateLink);

#line default
#line hidden
                EndContext();
                BeginContext(385, 129, true);
                WriteLiteral("</a></p>\r\n\r\n    <p>If it wasn\'t you who requested this, you can ignore this email.</p>\r\n\r\n    Thanks,\r\n    The \"SereneApp\" Team\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(521, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SereneApp.Membership.ActivateEmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591