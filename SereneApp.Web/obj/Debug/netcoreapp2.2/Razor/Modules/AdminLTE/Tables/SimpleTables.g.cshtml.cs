#pragma checksum "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\AdminLTE\Tables\SimpleTables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3dfd3aca43643e3437ab26b5fe6928a07144b8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_AdminLTE_Tables_SimpleTables), @"mvc.1.0.view", @"/Modules/AdminLTE/Tables/SimpleTables.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Modules/AdminLTE/Tables/SimpleTables.cshtml", typeof(AspNetCore.Modules_AdminLTE_Tables_SimpleTables))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3dfd3aca43643e3437ab26b5fe6928a07144b8f", @"/Modules/AdminLTE/Tables/SimpleTables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b55464e4a71a263d96b09945782f7a492ab71df", @"/Modules/_ViewImports.cshtml")]
    public class Modules_AdminLTE_Tables_SimpleTables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\AdminLTE\Tables\SimpleTables.cshtml"
  
    ViewData["Title"] = "Tables";

#line default
#line hidden
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Head", async() => {
                BeginContext(59, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(65, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3dfd3aca43643e3437ab26b5fe6928a07144b8f4478", async() => {
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
                BeginContext(115, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ContentHeader", async() => {
                BeginContext(146, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(157, 17, false);
#line 10 "D:\Users\tamir\Source\Repos\SereneApp\SereneApp.Web\Modules\AdminLTE\Tables\SimpleTables.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(174, 29, true);
                WriteLiteral("<small> simple</small></h1>\r\n");
                EndContext();
            }
            );
            BeginContext(206, 14044, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6"">
        <div class=""box"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Bordered Table</h3>
            </div><!-- /.box-header -->
            <div class=""box-body"">
                <table class=""table table-bordered"">
                    <tr>
                        <th style=""width: 10px"">#</th>
                        <th>Task</th>
                        <th>Progress</th>
                        <th style=""width: 40px"">Label</th>
                    </tr>
                    <tr>
                        <td>1.</td>
                        <td>Update software</td>
                        <td>
                            <div class=""progress progress-xs"">
                                <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-red"">55%</span></td>
      ");
            WriteLiteral(@"              </tr>
                    <tr>
                        <td>2.</td>
                        <td>Clean database</td>
                        <td>
                            <div class=""progress progress-xs"">
                                <div class=""progress-bar progress-bar-yellow"" style=""width: 70%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-yellow"">70%</span></td>
                    </tr>
                    <tr>
                        <td>3.</td>
                        <td>Cron job running</td>
                        <td>
                            <div class=""progress progress-xs progress-striped active"">
                                <div class=""progress-bar progress-bar-primary"" style=""width: 30%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-light-blue"">30%</span></td>
                    </tr>
            ");
            WriteLiteral(@"        <tr>
                        <td>4.</td>
                        <td>Fix and squish bugs</td>
                        <td>
                            <div class=""progress progress-xs progress-striped active"">
                                <div class=""progress-bar progress-bar-success"" style=""width: 90%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-green"">90%</span></td>
                    </tr>
                </table>
            </div><!-- /.box-body -->
            <div class=""box-footer clearfix"">
                <ul class=""pagination pagination-sm no-margin pull-right"">
                    <li><a href=""#"">&laquo;</a></li>
                    <li><a href=""#"">1</a></li>
                    <li><a href=""#"">2</a></li>
                    <li><a href=""#"">3</a></li>
                    <li><a href=""#"">&raquo;</a></li>
                </ul>
            </div>
        </div><!-- /.box -->
        <div c");
            WriteLiteral(@"lass=""box"">
            <div class=""box-header"">
                <h3 class=""box-title"">Condensed Full Width Table</h3>
            </div><!-- /.box-header -->
            <div class=""box-body no-padding"">
                <table class=""table table-condensed"">
                    <tr>
                        <th style=""width: 10px"">#</th>
                        <th>Task</th>
                        <th>Progress</th>
                        <th style=""width: 40px"">Label</th>
                    </tr>
                    <tr>
                        <td>1.</td>
                        <td>Update software</td>
                        <td>
                            <div class=""progress progress-xs"">
                                <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-red"">55%</span></td>
                    </tr>
                    <tr>
    ");
            WriteLiteral(@"                    <td>2.</td>
                        <td>Clean database</td>
                        <td>
                            <div class=""progress progress-xs"">
                                <div class=""progress-bar progress-bar-yellow"" style=""width: 70%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-yellow"">70%</span></td>
                    </tr>
                    <tr>
                        <td>3.</td>
                        <td>Cron job running</td>
                        <td>
                            <div class=""progress progress-xs progress-striped active"">
                                <div class=""progress-bar progress-bar-primary"" style=""width: 30%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-light-blue"">30%</span></td>
                    </tr>
                    <tr>
                        <td>4.</td>
");
            WriteLiteral(@"                        <td>Fix and squish bugs</td>
                        <td>
                            <div class=""progress progress-xs progress-striped active"">
                                <div class=""progress-bar progress-bar-success"" style=""width: 90%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-green"">90%</span></td>
                    </tr>
                </table>
            </div><!-- /.box-body -->
        </div><!-- /.box -->
    </div><!-- /.col -->
    <div class=""col-md-6"">
        <div class=""box"">
            <div class=""box-header"">
                <h3 class=""box-title"">Simple Full Width Table</h3>
                <div class=""box-tools"">
                    <ul class=""pagination pagination-sm no-margin pull-right"">
                        <li><a href=""#"">&laquo;</a></li>
                        <li><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
             ");
            WriteLiteral(@"           <li><a href=""#"">3</a></li>
                        <li><a href=""#"">&raquo;</a></li>
                    </ul>
                </div>
            </div><!-- /.box-header -->
            <div class=""box-body no-padding"">
                <table class=""table"">
                    <tr>
                        <th style=""width: 10px"">#</th>
                        <th>Task</th>
                        <th>Progress</th>
                        <th style=""width: 40px"">Label</th>
                    </tr>
                    <tr>
                        <td>1.</td>
                        <td>Update software</td>
                        <td>
                            <div class=""progress progress-xs"">
                                <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-red"">55%</span></td>
                    </tr>
                    ");
            WriteLiteral(@"<tr>
                        <td>2.</td>
                        <td>Clean database</td>
                        <td>
                            <div class=""progress progress-xs"">
                                <div class=""progress-bar progress-bar-yellow"" style=""width: 70%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-yellow"">70%</span></td>
                    </tr>
                    <tr>
                        <td>3.</td>
                        <td>Cron job running</td>
                        <td>
                            <div class=""progress progress-xs progress-striped active"">
                                <div class=""progress-bar progress-bar-primary"" style=""width: 30%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-light-blue"">30%</span></td>
                    </tr>
                    <tr>
                        <td");
            WriteLiteral(@">4.</td>
                        <td>Fix and squish bugs</td>
                        <td>
                            <div class=""progress progress-xs progress-striped active"">
                                <div class=""progress-bar progress-bar-success"" style=""width: 90%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-green"">90%</span></td>
                    </tr>
                </table>
            </div><!-- /.box-body -->
        </div><!-- /.box -->
        <div class=""box"">
            <div class=""box-header"">
                <h3 class=""box-title"">Striped Full Width Table</h3>
            </div><!-- /.box-header -->
            <div class=""box-body no-padding"">
                <table class=""table table-striped"">
                    <tr>
                        <th style=""width: 10px"">#</th>
                        <th>Task</th>
                        <th>Progress</th>
                        <th style=");
            WriteLiteral(@"""width: 40px"">Label</th>
                    </tr>
                    <tr>
                        <td>1.</td>
                        <td>Update software</td>
                        <td>
                            <div class=""progress progress-xs"">
                                <div class=""progress-bar progress-bar-danger"" style=""width: 55%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-red"">55%</span></td>
                    </tr>
                    <tr>
                        <td>2.</td>
                        <td>Clean database</td>
                        <td>
                            <div class=""progress progress-xs"">
                                <div class=""progress-bar progress-bar-yellow"" style=""width: 70%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-yellow"">70%</span></td>
                    </tr>
             ");
            WriteLiteral(@"       <tr>
                        <td>3.</td>
                        <td>Cron job running</td>
                        <td>
                            <div class=""progress progress-xs progress-striped active"">
                                <div class=""progress-bar progress-bar-primary"" style=""width: 30%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-light-blue"">30%</span></td>
                    </tr>
                    <tr>
                        <td>4.</td>
                        <td>Fix and squish bugs</td>
                        <td>
                            <div class=""progress progress-xs progress-striped active"">
                                <div class=""progress-bar progress-bar-success"" style=""width: 90%""></div>
                            </div>
                        </td>
                        <td><span class=""badge bg-green"">90%</span></td>
                    </tr>
                <");
            WriteLiteral(@"/table>
            </div><!-- /.box-body -->
        </div><!-- /.box -->
    </div><!-- /.col -->
</div><!-- /.row -->
<div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box"">
            <div class=""box-header"">
                <h3 class=""box-title"">Responsive Hover Table</h3>
                <div class=""box-tools"">
                    <div class=""input-group"" style=""width: 150px;"">
                        <input type=""text"" name=""table_search"" class=""form-control input-sm pull-right"" placeholder=""Search"">
                        <div class=""input-group-btn"">
                            <button class=""btn btn-sm btn-default""><i class=""fa fa-search""></i></button>
                        </div>
                    </div>
                </div>
            </div><!-- /.box-header -->
            <div class=""box-body table-responsive no-padding"">
                <table class=""table table-hover"">
                    <tr>
                        <th>ID</th>
                 ");
            WriteLiteral(@"       <th>User</th>
                        <th>Date</th>
                        <th>Status</th>
                        <th>Reason</th>
                    </tr>
                    <tr>
                        <td>183</td>
                        <td>John Doe</td>
                        <td>11-7-2014</td>
                        <td><span class=""label label-success"">Approved</span></td>
                        <td>Bacon ipsum dolor sit amet salami venison chicken flank fatback doner.</td>
                    </tr>
                    <tr>
                        <td>219</td>
                        <td>Alexander Pierce</td>
                        <td>11-7-2014</td>
                        <td><span class=""label label-warning"">Pending</span></td>
                        <td>Bacon ipsum dolor sit amet salami venison chicken flank fatback doner.</td>
                    </tr>
                    <tr>
                        <td>657</td>
                        <td>Bob Doe</td>
       ");
            WriteLiteral(@"                 <td>11-7-2014</td>
                        <td><span class=""label label-primary"">Approved</span></td>
                        <td>Bacon ipsum dolor sit amet salami venison chicken flank fatback doner.</td>
                    </tr>
                    <tr>
                        <td>175</td>
                        <td>Mike Doe</td>
                        <td>11-7-2014</td>
                        <td><span class=""label label-danger"">Denied</span></td>
                        <td>Bacon ipsum dolor sit amet salami venison chicken flank fatback doner.</td>
                    </tr>
                </table>
            </div><!-- /.box-body -->
        </div><!-- /.box -->
    </div>
</div>
");
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
