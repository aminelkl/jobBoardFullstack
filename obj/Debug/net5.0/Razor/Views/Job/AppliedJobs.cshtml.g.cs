#pragma checksum "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaec5bf9bb60998419ca826e535c7b7d68c3e81e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_AppliedJobs), @"mvc.1.0.view", @"/Views/Job/AppliedJobs.cshtml")]
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
#nullable restore
#line 1 "C:\Users\amine\Desktop\Job-Board\Views\_ViewImports.cshtml"
using Job_Board;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amine\Desktop\Job-Board\Views\_ViewImports.cshtml"
using Job_Board.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amine\Desktop\Job-Board\Views\_ViewImports.cshtml"
using Job_Board.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\Desktop\Job-Board\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaec5bf9bb60998419ca826e535c7b7d68c3e81e", @"/Views/Job/AppliedJobs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95767e69e0c191f7f4334aec69484a44172ad689", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Job_AppliedJobs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AppliedJobs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
  
    ViewData["Title"] = "Applied Jobs";
    ViewData["style"] = "background-color:rgba(0,29,56,0.8);";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- job_listing_area_start  -->
<div class=""job_listing_area plus_padding"" style=""margin-top:10%;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""job_lists m-0"">
                    <div class=""row"">

");
#nullable restore
#line 15 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                         foreach (var item in Model)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-lg-12 col-md-12"">
                                <div class=""single_jobs white-bg d-flex justify-content-between"">
                                    <div class=""jobs_left d-flex align-items-center"">
                                        <div class=""thumb"" style=""padding:0px;"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 862, "\"", 901, 1);
#nullable restore
#line 23 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
WriteAttributeValue("", 868, item.Job.Recruter.ProfilePicture, 868, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 902, "\"", 908, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 80px; height: 80px;\">\r\n                                        </div>\r\n                                        <div class=\"jobs_conetent\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1110, "\"", 1142, 2);
            WriteAttributeValue("", 1117, "/Job/Details/", 1117, 13, true);
#nullable restore
#line 26 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
WriteAttributeValue("", 1130, item.Job.Id, 1130, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4>");
#nullable restore
#line 26 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                               Write(item.Job.Title.Substring(0, (item.Job.Title.Length > 20 ? 20 : item.Job.Title.Length)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></a>
                                            <div class=""links_locat d-flex align-items-center"">
                                                <div class=""location"">
                                                    <p> <i class=""fa fa-map-marker""></i> ");
#nullable restore
#line 29 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                                    Write(item.Job.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                                <div class=\"location\">\r\n                                                    <p> <i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 32 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                                 Write(item.Job.JobNature == Job_Board.Models.enums.JobNature.FullTime? "Full TIme": "Part TIme");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                                <div class=\"location\">\r\n                                                    <p> <i class=\"fa fa-list-alt\"></i> ");
#nullable restore
#line 35 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                                        if (@item.Job.Category != null)

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                                                                  Write(item.Job.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                    <div class=""jobs_right"">
                                        <div class=""apply_now"">
                                            <a class=""heart_mark"" href=""#""> <i class=""fa fa-heart""></i> </a>
                                            <a");
            BeginWriteAttribute("href", " href=\"", 2600, "\"", 2632, 2);
            WriteAttributeValue("", 2607, "/Job/Details/", 2607, 13, true);
#nullable restore
#line 44 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
WriteAttributeValue("", 2620, item.Job.Id, 2620, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""genric-btn success"">Applied</a>
                                        </div>
                                        <div class=""date"" style=""color: #AAB1B7;"">
                                            <p><i class=""fa fa-calendar"" style=""margin-right:7px""></i> ");
#nullable restore
#line 47 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                                                  Write(item.Job.PublishedAt.ToString("dd/mm/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 52 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-12\">\r\n                            <div class=\"pagination_wrap\">\r\n                                <ul>\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaec5bf9bb60998419ca826e535c7b7d68c3e81e10555", async() => {
                WriteLiteral(" <i class=\"ti-angle-left\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                      WriteLiteral(ViewBag.Paginator.prevPage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaec5bf9bb60998419ca826e535c7b7d68c3e81e12809", async() => {
                WriteLiteral("<span>");
#nullable restore
#line 59 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                                                                 Write(ViewBag.Paginator.firstPage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                      WriteLiteral(ViewBag.Paginator.firstPage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 60 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                     for (int i = ViewBag.Paginator.firstPage + 1; i <= ViewBag.Paginator.totalPages; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaec5bf9bb60998419ca826e535c7b7d68c3e81e15713", async() => {
                WriteLiteral("<span>");
#nullable restore
#line 62 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                          WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 63 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaec5bf9bb60998419ca826e535c7b7d68c3e81e18423", async() => {
                WriteLiteral(" <i class=\"ti-angle-right\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\amine\Desktop\Job-Board\Views\Job\AppliedJobs.cshtml"
                                                                      WriteLiteral(ViewBag.Paginator.nextPage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591