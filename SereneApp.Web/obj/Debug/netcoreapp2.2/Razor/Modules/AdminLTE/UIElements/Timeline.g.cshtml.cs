#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\AdminLTE\UIElements\Timeline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "455c5d28fc212905890afb8252a53904acaf9d08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_AdminLTE_UIElements_Timeline), @"mvc.1.0.view", @"/Modules/AdminLTE/UIElements/Timeline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/AdminLTE/UIElements/Timeline.cshtml", typeof(AspNetCore.Modules_AdminLTE_UIElements_Timeline))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"455c5d28fc212905890afb8252a53904acaf9d08", @"/Modules/AdminLTE/UIElements/Timeline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_AdminLTE_UIElements_Timeline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/adminlte/demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\AdminLTE\UIElements\Timeline.cshtml"
  
    ViewData["Title"] = "Timeline";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Head", async() => {
                BeginContext(61, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(67, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455c5d28fc212905890afb8252a53904acaf9d084480", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(117, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(148, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(159, 17, false);
#line 10 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\AdminLTE\UIElements\Timeline.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(176, 22, true);
                WriteLiteral("<small></small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(201, 6309, true);
            WriteLiteral(@"
<!-- row -->
<div class=""row"">
    <div class=""col-md-12"">
        <!-- The time line -->
        <ul class=""timeline"">
            <!-- timeline time label -->
            <li class=""time-label"">
                <span class=""bg-red"">
                    10 Feb. 2014
                </span>
            </li>
            <!-- /.timeline-label -->
            <!-- timeline item -->
            <li>
                <i class=""fa fa-envelope bg-blue""></i>
                <div class=""timeline-item"">
                    <span class=""time""><i class=""fa fa-clock-o""></i> 12:05</span>
                    <h3 class=""timeline-header""><a href=""#"">Support Team</a> sent you an email</h3>
                    <div class=""timeline-body"">
                        Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles,
                        weebly ning heekya handango imeem plugg dopplr jibjab, movity
                        jajah plickers sifteo edmodo ifttt zimbra. Babblely odeo kaboodle
       ");
            WriteLiteral(@"                 quora plaxo ideeli hulu weebly balihoo...
                    </div>
                    <div class=""timeline-footer"">
                        <a class=""btn btn-primary btn-xs"">Read more</a>
                        <a class=""btn btn-danger btn-xs"">Delete</a>
                    </div>
                </div>
            </li>
            <!-- END timeline item -->
            <!-- timeline item -->
            <li>
                <i class=""fa fa-user bg-aqua""></i>
                <div class=""timeline-item"">
                    <span class=""time""><i class=""fa fa-clock-o""></i> 5 mins ago</span>
                    <h3 class=""timeline-header no-border""><a href=""#"">Sarah Young</a> accepted your friend request</h3>
                </div>
            </li>
            <!-- END timeline item -->
            <!-- timeline item -->
            <li>
                <i class=""fa fa-comments bg-yellow""></i>
                <div class=""timeline-item"">
                    <span class=");
            WriteLiteral(@"""time""><i class=""fa fa-clock-o""></i> 27 mins ago</span>
                    <h3 class=""timeline-header""><a href=""#"">Jay White</a> commented on your post</h3>
                    <div class=""timeline-body"">
                        Take me to your leader!
                        Switzerland is small and neutral!
                        We are more like Germany, ambitious and misunderstood!
                    </div>
                    <div class=""timeline-footer"">
                        <a class=""btn btn-warning btn-flat btn-xs"">View comment</a>
                    </div>
                </div>
            </li>
            <!-- END timeline item -->
            <!-- timeline time label -->
            <li class=""time-label"">
                <span class=""bg-green"">
                    3 Jan. 2014
                </span>
            </li>
            <!-- /.timeline-label -->
            <!-- timeline item -->
            <li>
                <i class=""fa fa-camera bg-purple""></i>
      ");
            WriteLiteral(@"          <div class=""timeline-item"">
                    <span class=""time""><i class=""fa fa-clock-o""></i> 2 days ago</span>
                    <h3 class=""timeline-header""><a href=""#"">Mina Lee</a> uploaded new photos</h3>
                    <div class=""timeline-body"">
                        <img src=""http://placehold.it/150x100"" alt=""..."" class=""margin"">
                        <img src=""http://placehold.it/150x100"" alt=""..."" class=""margin"">
                        <img src=""http://placehold.it/150x100"" alt=""..."" class=""margin"">
                        <img src=""http://placehold.it/150x100"" alt=""..."" class=""margin"">
                    </div>
                </div>
            </li>
            <!-- END timeline item -->
            <!-- timeline item -->
            <li>
                <i class=""fa fa-video-camera bg-maroon""></i>
                <div class=""timeline-item"">
                    <span class=""time""><i class=""fa fa-clock-o""></i> 5 days ago</span>
                    <h3 class");
            WriteLiteral(@"=""timeline-header""><a href=""#"">Mr. Doe</a> shared a video</h3>
                    <div class=""timeline-body"">
                        <div class=""embed-responsive embed-responsive-16by9"">
                            <iframe class=""embed-responsive-item"" src=""https://www.youtube.com/embed/tMWkeBIohBs"" frameborder=""0"" allowfullscreen></iframe>
                        </div>
                    </div>
                    <div class=""timeline-footer"">
                        <a href=""#"" class=""btn btn-xs bg-maroon"">See comments</a>
                    </div>
                </div>
            </li>
            <!-- END timeline item -->
            <li>
                <i class=""fa fa-clock-o bg-gray""></i>
            </li>
        </ul>
    </div><!-- /.col -->
</div><!-- /.row -->
<div class=""row"" style=""margin-top: 10px;"">
    <div class=""col-md-12"">
        <div class=""box box-primary"">
            <div class=""box-header"">
                <h3 class=""box-title""><i class=""fa fa-code""></i>");
            WriteLiteral(@" Timeline Markup</h3>
            </div>
            <div class=""box-body"">
                <pre style=""font-weight: 600;"">
&lt;ul class=""timeline"">
    &lt;!-- timeline time label -->
    &lt;li class=""time-label"">
        &lt;span class=""bg-red"">
            10 Feb. 2014
        &lt;/span>
    &lt;/li>
    &lt;!-- /.timeline-label -->
    &lt;!-- timeline item -->
    &lt;li>
        &lt;!-- timeline icon -->
        &lt;i class=""fa fa-envelope bg-blue"">&lt;/i>
        &lt;div class=""timeline-item"">
            &lt;span class=""time"">&lt;i class=""fa fa-clock-o"">&lt;/i> 12:05&lt;/span>
            &lt;h3 class=""timeline-header"">&lt;a href=""#"">Support Team&lt;/a> ...&lt;/h3>
            &lt;div class=""timeline-body"">
                ...
                Content goes here
            &lt;/div>
            &lt;div class=""timeline-footer"">
                &lt;a class=""btn btn-primary btn-xs"">...&lt;/a>
            &lt;/div>
        &lt;/div>
    &lt;/li>
    &lt;!-- END timeline item --");
            WriteLiteral(">\r\n    ...\r\n&lt;/ul>\r\n                  </pre>\r\n            </div><!-- /.box-body -->\r\n        </div><!-- /.box -->\r\n    </div><!-- /.col -->\r\n</div><!-- /.row -->\r\n");
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