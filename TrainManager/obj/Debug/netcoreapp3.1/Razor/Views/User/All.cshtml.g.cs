#pragma checksum "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45fd4e3010504ce0df850d9aa671284441aef621"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_All), @"mvc.1.0.view", @"/Views/User/All.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45fd4e3010504ce0df850d9aa671284441aef621", @"/Views/User/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d712202cac84fcadfa28734fbcefeb008b4eaa", @"/_ViewImports.cshtml")]
    public class Views_User_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrainManager.ViewModels.User.ListingPageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<section class=""py-5 col-md-12"">
    <div class=""container col-md-12"">
        <h1 style=""margin: 2%; text-align: center;"">All Users</h1>
        <div style=""padding: 5%;"">
            <div>
                <h2>Show By: </h2>
                <div class=""mb-4"">
                    <a class=""btn btn-primary mx-2""");
            BeginWriteAttribute("href", " href=\"", 379, "\"", 430, 2);
            WriteAttributeValue("", 386, "/User/All?page=1&showBy=10&", 386, 27, true);
#nullable restore
#line 10 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 413, Model.OrderParam, 413, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">10</a>\r\n                    <a class=\"btn btn-primary mx-2\"");
            BeginWriteAttribute("href", " href=\"", 491, "\"", 542, 2);
            WriteAttributeValue("", 498, "/User/All?page=1&showBy=25&", 498, 27, true);
#nullable restore
#line 11 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 525, Model.OrderParam, 525, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">25</a>\r\n                    <a class=\"btn btn-primary mx-2\"");
            BeginWriteAttribute("href", " href=\"", 603, "\"", 654, 2);
            WriteAttributeValue("", 610, "/User/All?page=1&showBy=50&", 610, 27, true);
#nullable restore
#line 12 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 637, Model.OrderParam, 637, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">50</a>\r\n                </div>\r\n            </div>\r\n            <div>\r\n                <h2>Order By: </h2>\r\n                <div class=\"mb-4\">\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 856, "\"", 926, 3);
            WriteAttributeValue("", 863, "/User/All?page=1&showBy=", 863, 24, true);
#nullable restore
#line 18 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 887, Model.UsersPerPage, 887, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 906, "&orderBy=usernameAsc", 906, 20, true);
            EndWriteAttribute();
            WriteLiteral(">Username Asc</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1002, "\"", 1073, 3);
            WriteAttributeValue("", 1009, "/User/All?page=1&showBy=", 1009, 24, true);
#nullable restore
#line 19 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 1033, Model.UsersPerPage, 1033, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1052, "&orderBy=usernameDesc", 1052, 21, true);
            EndWriteAttribute();
            WriteLiteral(">Username Desc</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1150, "\"", 1217, 3);
            WriteAttributeValue("", 1157, "/User/All?page=1&showBy=", 1157, 24, true);
#nullable restore
#line 20 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 1181, Model.UsersPerPage, 1181, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1200, "&orderBy=emailAsc", 1200, 17, true);
            EndWriteAttribute();
            WriteLiteral(">Email Asc</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1290, "\"", 1358, 3);
            WriteAttributeValue("", 1297, "/User/All?page=1&showBy=", 1297, 24, true);
#nullable restore
#line 21 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 1321, Model.UsersPerPage, 1321, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1340, "&orderBy=emailDesc", 1340, 18, true);
            EndWriteAttribute();
            WriteLiteral(">Email Desc</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1432, "\"", 1499, 3);
            WriteAttributeValue("", 1439, "/User/All?page=1&showBy=", 1439, 24, true);
#nullable restore
#line 22 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 1463, Model.UsersPerPage, 1463, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1482, "&orderBy=fNameAsc", 1482, 17, true);
            EndWriteAttribute();
            WriteLiteral(">FirstName Asc</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1576, "\"", 1644, 3);
            WriteAttributeValue("", 1583, "/User/All?page=1&showBy=", 1583, 24, true);
#nullable restore
#line 23 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 1607, Model.UsersPerPage, 1607, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1626, "&orderBy=fNameDesc", 1626, 18, true);
            EndWriteAttribute();
            WriteLiteral(">FirstName Desc</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1722, "\"", 1789, 3);
            WriteAttributeValue("", 1729, "/User/All?page=1&showBy=", 1729, 24, true);
#nullable restore
#line 24 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 1753, Model.UsersPerPage, 1753, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1772, "&orderBy=lNameAsc", 1772, 17, true);
            EndWriteAttribute();
            WriteLiteral(">LastName Asc</a>\r\n                    <a class=\"btn btn-primary mx-2 mb-1\"");
            BeginWriteAttribute("href", " href=\"", 1865, "\"", 1933, 3);
            WriteAttributeValue("", 1872, "/User/All?page=1&showBy=", 1872, 24, true);
#nullable restore
#line 25 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 1896, Model.UsersPerPage, 1896, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1915, "&orderBy=lNameDesc", 1915, 18, true);
            EndWriteAttribute();
            WriteLiteral(@">LastName Desc</a>
                </div>
            </div>

            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">Username</th>
                        <th scope=""col"">First Name</th>
                        <th scope=""col"">Last Name</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">SSN</th>
                        <th scope=""col"">Address</th>
                        <th scope=""col"">Phone Number</th>
                        <th scope=""col"">Edit</th>
                        <th scope=""col"">Delete</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 44 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                     for (var i = 0; i < Model.Users.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 47 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                                       Write(Model.Users[i].Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                           Write(Model.Users[i].FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                           Write(Model.Users[i].LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                           Write(Model.Users[i].Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                           Write(Model.Users[i].SSN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                           Write(Model.Users[i].Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                           Write(Model.Users[i].PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <div class=\"button-holder\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3370, "\"", 3409, 2);
            WriteAttributeValue("", 3377, "/User/Edit?id=", 3377, 14, true);
#nullable restore
#line 56 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 3391, Model.Users[i].Id, 3391, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-uppercase\">Edit</a>\r\n                                </div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"button-holder\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3665, "\"", 3706, 2);
            WriteAttributeValue("", 3672, "/User/Delete?id=", 3672, 16, true);
#nullable restore
#line 61 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 3688, Model.Users[i].Id, 3688, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger text-uppercase\">Delete</a>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n\r\n            </table>\r\n            <div class=\"d-flex flex-wrap align-items-center\">\r\n                <div class=\"pagination mx-auto\">\r\n");
#nullable restore
#line 72 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                      
                        var prevPage = Model.CurrentPage - 1;
                        var nextPage = Model.CurrentPage + 1;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                     if (Model.CurrentPage != 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 4324, "\"", 4400, 6);
            WriteAttributeValue("", 4331, "/User/All?page=", 4331, 15, true);
#nullable restore
#line 78 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 4346, prevPage, 4346, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4355, "&showBy=", 4355, 8, true);
#nullable restore
#line 78 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 4363, Model.UsersPerPage, 4363, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4382, "&", 4382, 1, true);
#nullable restore
#line 78 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 4383, Model.OrderParam, 4383, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary prev-arrow mx-1\"><i class=\"fas fa-arrow-left\"></i></a>\r\n");
#nullable restore
#line 79 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 81 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                     for (var j = 1; j <= (Model.TotalUsersCount / Model.UsersPerPage) + 1; j++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                         if (j == Model.CurrentPage)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-primary active mx-1\"");
            BeginWriteAttribute("href", " href=\"", 4774, "\"", 4843, 6);
            WriteAttributeValue("", 4781, "/User/All?page=", 4781, 15, true);
#nullable restore
#line 85 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 4796, j, 4796, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4798, "&showBy=", 4798, 8, true);
#nullable restore
#line 85 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 4806, Model.UsersPerPage, 4806, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4825, "&", 4825, 1, true);
#nullable restore
#line 85 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 4826, Model.OrderParam, 4826, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 85 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                                                                                                                                    Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 86 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                        }
                        else if (j >= Model.CurrentPage - 4 && (j <= Model.CurrentPage + 4 && j <= Model.LastPage))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 5054, "\"", 5123, 6);
            WriteAttributeValue("", 5061, "/User/All?page=", 5061, 15, true);
#nullable restore
#line 89 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 5076, j, 5076, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5078, "&showBy=", 5078, 8, true);
#nullable restore
#line 89 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 5086, Model.UsersPerPage, 5086, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5105, "&", 5105, 1, true);
#nullable restore
#line 89 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 5106, Model.OrderParam, 5106, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mx-1\">");
#nullable restore
#line 89 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                                                                                                                 Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 90 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                     if (Model.CurrentPage != Model.LastPage)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 5314, "\"", 5390, 6);
            WriteAttributeValue("", 5321, "/User/All?page=", 5321, 15, true);
#nullable restore
#line 95 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 5336, nextPage, 5336, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5345, "&showBy=", 5345, 8, true);
#nullable restore
#line 95 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 5353, Model.UsersPerPage, 5353, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5372, "&", 5372, 1, true);
#nullable restore
#line 95 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
WriteAttributeValue("", 5373, Model.OrderParam, 5373, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary next-arrow mx-1\"><i class=\"fas fa-arrow-right\"></i></a>\r\n");
#nullable restore
#line 96 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\User\All.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrainManager.ViewModels.User.ListingPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
