#pragma checksum "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e225bb02fcbc05ffa406d6028395c012242344e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\_ViewImports.cshtml"
using TrainManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\_ViewImports.cshtml"
using TrainManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e225bb02fcbc05ffa406d6028395c012242344e0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d712202cac84fcadfa28734fbcefeb008b4eaa", @"/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"py-5\">\r\n    <div class=\"container\">\r\n        <h1>Bulgarian State Railways</h1>\r\n        <div>\r\n            <a href=\"/Line/GetAll?page=1\" class=\"btn btn-primary text-center mb-2\">View All Lines</a>\r\n\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Home\Index.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <a href=\"/User/All?page=1&showBy=10&orderBy=usernameAsc\" class=\"btn btn-primary text-center mb-2\">View All Users</a>\r\n            </div>\r\n");
#nullable restore
#line 17 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Home\Index.cshtml"
         if (User.IsInRole("Admin") || User.IsInRole("User"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <a href=\"/Train/All?page=1\" class=\"btn btn-primary text-center mb-2\">View All Trains</a>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</section>

<a>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
    Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
    Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
    Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</a>");
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
