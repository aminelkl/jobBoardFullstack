#pragma checksum "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d713070c2a6edd9d9b5a3f24050d014ec10ff905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d713070c2a6edd9d9b5a3f24050d014ec10ff905", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95767e69e0c191f7f4334aec69484a44172ad689", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml"
  
    ViewData["Title"] = "Profile";
    ViewData["style"] = "background-color:rgba(0,29,56,0.8);";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""featured_candidates_area candidate_page_padding"" style=""margin-top:6%;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-3""></div>
            <div class=""col-md-6 col-lg-6"">
                <div class=""single_candidates text-center"" style=""box-shadow:0px 15px 12px 0px #cacaca;"">
                    <div class=""thumb"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 545, "\"", 572, 1);
#nullable restore
#line 16 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml"
WriteAttributeValue("", 551, Model.ProfilePicture, 551, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 573, "\"", 579, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height:110px;\">\r\n                    </div>\r\n                    <a href=\"#\"><h4 style=\"margin-top:16px;\">");
#nullable restore
#line 18 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml"
                                                        Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml"
                                                                         Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                    <p>");
#nullable restore
#line 19 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml"
                  Write(Model.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <hr style=\"border: 2px solid #F5F7FA;\">\r\n                    <p style=\"text-align:left\"><span><i class=\"fa fa-envelope\"></i></span> ");
#nullable restore
#line 22 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml"
                                                                                      Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p style=\"text-align:left\"><span><i class=\"fa fa-linkedin\"></i></span> <a");
            BeginWriteAttribute("href", " href=\"", 1046, "\"", 1071, 1);
#nullable restore
#line 23 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1053, Model.LinkedInUrl, 1053, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Profile\Index.cshtml"
                                                                                                                   Write(Model.LinkedInUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
