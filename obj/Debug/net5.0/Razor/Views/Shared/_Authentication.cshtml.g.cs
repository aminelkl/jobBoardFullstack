#pragma checksum "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9dd09231509c7b2e362245c29dbb134b447377a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Authentication), @"mvc.1.0.view", @"/Views/Shared/_Authentication.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9dd09231509c7b2e362245c29dbb134b447377a", @"/Views/Shared/_Authentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95767e69e0c191f7f4334aec69484a44172ad689", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Authentication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
 if (User.Identity.IsAuthenticated)
{




#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"main-menu  d-none d-lg-block\">\r\n            <ul id=\"navigation\">\r\n                <li>\r\n");
#nullable restore
#line 9 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
                     if (!User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/Profile\"> Profile <i class=\"ti-angle-down\"></i></a>\r\n                        <ul class=\"submenu\">\r\n");
#nullable restore
#line 13 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
                             if (User.IsInRole("Developer"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"/Job/AppliedJobs\">Applied Jobs</a></li>\r\n");
#nullable restore
#line 16 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"/Job/MyJobs\">Posted Jobs</a></li>\r\n");
#nullable restore
#line 20 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <hr style=""margin: 0px"">
                            <li><a href=""/Profile/Settings"">Settings </a></li>
                            <hr style=""margin: 0px"">
                            <li><a href=""/Account/Logout"">Log out</a></li>
                        </ul>
");
#nullable restore
#line 26 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
                }
                else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/Admin\"> Profile <i class=\"ti-angle-down\"></i></a>\r\n");
#nullable restore
#line 29 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"phone_num d-none d-xl-block\">\r\n        <a href=\"/Account/Login\">Log in</a>\r\n    </div>\r\n");
#nullable restore
#line 40 "C:\Users\amine\Desktop\jobBoardFullstack\Views\Shared\_Authentication.cshtml"
}

#line default
#line hidden
#nullable disable
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
