#pragma checksum "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce6a2ae3e760e78253264d33c5f68be4ab308da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PendingPosts), @"mvc.1.0.view", @"/Views/Admin/PendingPosts.cshtml")]
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
#line 1 "C:\Users\amine\Desktop\jobBoardFullstack\Views\_ViewImports.cshtml"
using Job_Board;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amine\Desktop\jobBoardFullstack\Views\_ViewImports.cshtml"
using Job_Board.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\amine\Desktop\jobBoardFullstack\Views\_ViewImports.cshtml"
using Job_Board.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\amine\Desktop\jobBoardFullstack\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce6a2ae3e760e78253264d33c5f68be4ab308da", @"/Views/Admin/PendingPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95767e69e0c191f7f4334aec69484a44172ad689", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_PendingPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
  
    ViewData["Title"] = "Pending Posts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\" style=\"margin: 60px 0px;\">\r\n    <div class=\"job_listing_area col-lg-12\" style=\"padding: 0px;\">\r\n        <h3>Pending Posts</h3>\r\n        <div class=\"job_lists m-0\">\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 11 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-lg-12 col-md-12"">
                        <div class=""single_jobs white-bg d-flex justify-content-between"">
                            <div class=""jobs_left d-flex align-items-center"">
                                <div class=""thumb"" style=""padding:0px;"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 740, "\"", 775, 1);
#nullable restore
#line 18 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
WriteAttributeValue("", 746, item.Recruter.ProfilePicture, 746, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 776, "\"", 782, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 80px; height: 80px;\">\r\n                                </div>\r\n                                <div class=\"jobs_conetent\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 960, "\"", 988, 2);
            WriteAttributeValue("", 967, "/Job/Details/", 967, 13, true);
#nullable restore
#line 21 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
WriteAttributeValue("", 980, item.Id, 980, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4>");
#nullable restore
#line 21 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                                                                   Write(item.Title.Substring(0, (item.Title.Length > 40 ? 40 : item.Title.Length)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                                    <div class=\"links_locat d-flex align-items-center\">\r\n                                        <div class=\"location\">\r\n                                            <p> <i class=\"fa fa-map-marker\"></i> ");
#nullable restore
#line 24 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                                                                            Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"location\">\r\n                                            <p> <i class=\"fa fa-clock-o\"></i> ");
#nullable restore
#line 27 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                                                                          Write(item.JobNature == Job_Board.Models.enums.JobNature.FullTime? "Full TIme": "Part TIme");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                        <div class=\"location\">\r\n                                            <p> <i class=\"fa fa-list-alt\"></i> ");
#nullable restore
#line 30 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                                                                                if (@item.Category != null)

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                                                                                                      Write(item.Category.Name);

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
                                    <button class=""boxed-btn2 remove"" data-post-id=""");
#nullable restore
#line 37 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                                                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Remove</button>\r\n                                    <button class=\"boxed-btn4 accept\" data-post-id=\"");
#nullable restore
#line 38 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                                                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Accept</button>\r\n                                </div>\r\n                                <div class=\"date\">\r\n                                    <p><i class=\"fa fa-calendar\" style=\"margin-right:7px\"></i> ");
#nullable restore
#line 41 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                                                                                          Write(item.PublishedAt.ToString("dd/mm/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Admin\PendingPosts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""pagination_wrap"">
                        <ul>
                            <li><a href=""#""> <i class=""ti-angle-left""></i> </a></li>
                            <li><a href=""#""><span>01</span></a></li>
                            <li><a href=""#""> <i class=""ti-angle-right""></i> </a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".job_lists"").fadeIn(600);

            $("".remove"").on(""click"", function (e) {
                e.preventDefault();

                var link = $(e.target);
                var token = $(""input[name='__RequestVerificationToken'"").val();
                var id = link.attr(""data-post-id"");
                var parent = link.parents(""div.col-lg-12.col-md-12"").parent();

                console.log(token);
                console.log(id);

                bootbox.dialog({
                    title: 'Confirm',
                    message: '<p>Are you sure you want to remove this post?</p>',
                    size: 'large',
                    onEscape: true,
                    backdrop: false,
                    buttons: {
                        no: {
                            label: 'No',
                            className: 'btn-default',
                            callback: function () {
                     ");
                WriteLiteral(@"           bootbox.hideAll();
                            }
                        },
                        yes: {
                            label: 'Yes',
                            className: 'btn-danger',
                            callback: function () {
                                $.ajax({
                                    url: ""/Api/Job/Delete/"" + id,
                                    method: ""DELETE"",
                                    headers: { ""X-CSRF-TOKEN"": token }
                                })
                                    .done(function () {
                                        link.parents(""div.col-lg-12.col-md-12"").remove();
                                        if ($.trim(parent.html()) == '') {
                                            parent.append('<div class=""col-lg-12"" style=""text-align:center""> <h4>Pending Jobs Will Appear Here.</h4> </div>');
                                        }
                                    })
             ");
                WriteLiteral(@"                       .fail(function () {
                                        alert(""Something failed!"");
                                    });
                            }
                        }
                    }
                });
            });
            $("".accept"").on(""click"", function (e) {
                e.preventDefault();

                var link = $(e.target);
                var token = $(""input[name='__RequestVerificationToken'"").val();
                var id = link.attr(""data-post-id"");
                var parent = link.parents(""div.col-lg-12.col-md-12"").parent();

                console.log(token);
                console.log(id);

                bootbox.dialog({
                    title: 'Confirm',
                    message: '<p>Are you sure you want to Accept this post?</p>',
                    size: 'large',
                    onEscape: true,
                    backdrop: false,
                    buttons: {
                        no: {");
                WriteLiteral(@"
                            label: 'No',
                            className: 'btn-default',
                            callback: function () {
                                bootbox.hideAll();
                            }
                        },
                        yes: {
                            label: 'Yes',
                            className: 'btn-danger',
                            callback: function () {
                                $.ajax({
                                    url: ""/Api/Job/Accept/"" + id,
                                    method: ""PUT"",
                                    headers: { ""X-CSRF-TOKEN"": token }
                                })
                                    .done(function () {
                                        link.parents(""div.col-lg-12.col-md-12"").remove();
                                        if ($.trim(parent.html()) == '') {
                                            parent.append('<div class=""col-lg-12"" style");
                WriteLiteral(@"=""text-align:center""> <h4>Pending Jobs Will Appear Here.</h4> </div>');
                                        }
                                    })
                                    .fail(function () {
                                        alert(""Something failed!"");
                                    });
                            }
                        }
                    }
                });
            });
        })
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
