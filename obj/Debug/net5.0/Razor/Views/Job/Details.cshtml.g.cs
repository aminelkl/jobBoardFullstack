#pragma checksum "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72de2c4c7621fb5b35b7763c22913e911b8c54e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Details), @"mvc.1.0.view", @"/Views/Job/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72de2c4c7621fb5b35b7763c22913e911b8c54e3", @"/Views/Job/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95767e69e0c191f7f4334aec69484a44172ad689", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Job_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Job_Board.Models.JobModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Apply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("js-apply-job"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- bradcam_area  -->
<div class=""bradcam_area bradcam_bg_1"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-12"">
                <div class=""bradcam_text"" style=""word-break: break-all;"">
                    <h3>");
#nullable restore
#line 20 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
            </div>
        </div>
    </div>
</div>
<!--/ bradcam_area  -->

<div class=""job_details_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""job_details_header"">
                    <div class=""single_jobs white-bg d-flex justify-content-between"">
                        <div class=""jobs_left d-flex align-items-center"">
                            <div class=""thumb"" style=""padding:0px;"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 1103, "\"", 1139, 1);
#nullable restore
#line 36 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
WriteAttributeValue("", 1109, Model.Recruter.ProfilePicture, 1109, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1140, "\"", 1146, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 80px; height: 80px;\">\r\n                            </div>\r\n                            <div class=\"jobs_conetent\" style=\"word-break: break-all;\">\r\n                                <a href=\"#\"><h4>");
#nullable restore
#line 39 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                                <div class=\"links_locat d-flex align-items-center\">\r\n                                    <div class=\"location\">\r\n                                        <p> <i class=\"fa fa-map-marker\"></i> ");
#nullable restore
#line 42 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                                                        Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"location\">\r\n                                        <p> <i class=\"fa fa-clock-o\"></i> ");
#nullable restore
#line 45 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                                                      Write(Model.JobNature == Job_Board.Models.enums.JobNature.FullTime? "Full TIme": "Part TIme");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"location\">\r\n                                        <p> <i class=\"fa fa-list-alt\"></i> ");
#nullable restore
#line 48 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                                                            if (Model.Category != null)

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                                                                                  Write(Model.Category.Name);

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
");
#nullable restore
#line 55 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                 if (User.IsInRole("Developer"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"heart_mark\" href=\"#\"> <i class=\"ti-heart\"></i> </a>\r\n");
#nullable restore
#line 58 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
                <div class=""descript_wrap white-bg"">
                    <div class=""single_wrap"" style=""word-break: break-all;"">
                        <h4>Job description</h4>
                        <p>
                            ");
#nullable restore
#line 67 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n                \r\n                <div class=\"apply_job_form white-bg\" id=\"apply\">\r\n                    <h4>Apply for the job</h4>\r\n");
#nullable restore
#line 76 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                     if (User.IsInRole("Developer"))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                         if (ViewBag.IsApplied != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p style=\"color:#2c9266;\"> <i class=\"fa fa-check\" aria-hidden=\"true\"></i> Already applied</p>\r\n");
#nullable restore
#line 81 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72de2c4c7621fb5b35b7763c22913e911b8c54e310772", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""submit_btn"">
                                            <button type=""submit"" class=""boxed-btn3 w-100"" type=""submit"">Apply Now</button>
                                        </div>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                                                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-post-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                         
                    }
                    else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"/Account/Login\" style=\"color: blue;text-decoration: underline;\"> Sign in to apply</a>\r\n");
#nullable restore
#line 97 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    

                </div>

            </div>
            <div class=""col-lg-4"">
                <div class=""job_sumary"">
                    <div class=""summery_header"">
                        <h3>Job Summery</h3>
                    </div>
                    <div class=""job_content"">
                        <ul>
                            <li>Published on: <span>");
#nullable restore
#line 110 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                               Write(Model.PublishedAt.ToString("dd/mm/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></li>\r\n                            <li>Vacancy: <span>");
#nullable restore
#line 111 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                          Write(Model.Vacancy);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Position</span></li>\r\n                            <li>Salary: <span>");
#nullable restore
#line 112 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                         Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            <li>Location: <span>");
#nullable restore
#line 113 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                           Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            <li>Job Nature: <span> ");
#nullable restore
#line 114 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
                                               Write(Model.JobNature == Job_Board.Models.enums.JobNature.FullTime? "Full TIme": "Part TIme");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".js-apply-job"").on(""submit"", function (e) {
                e.preventDefault();

                var link = $(e.target);
                var token = link.find(""input[name='__RequestVerificationToken'"").val();
                var id = link.attr(""data-post-id"");
                var parent = link.parent();

                console.log(token);
                console.log(id);

                $.ajax({
                    url: ""/Api/Job/Apply"",
                    method: ""POST"",
                    headers: { ""X-CSRF-TOKEN"": token },
                    data: { ""JobId"": id },
                    success: function (data, status) {
                        console.log(status);
                        link.empty(500);
                        parent.append('<p style=""color:#2c9266;""> <i class=""fa fa-check"" aria-hidden=""true""></i>Applied</p>')
                    },
                    error: function (data, status, fx) {
    ");
                WriteLiteral("                    console.log(link);\r\n                        alert(\"Failed to apply\");\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\amine\Desktop\Job-Board\Views\Job\Details.cshtml"
           
    public string GetAntiXsrfRequestToken()
    {
        return Xsrf.GetAndStoreTokens(Context).RequestToken;
    }

#line default
#line hidden
#nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery Xsrf { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Job_Board.Models.JobModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591