#pragma checksum "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80f5d4db31b99f264f19155558a15a5d4e57d62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Line_Edit), @"mvc.1.0.view", @"/Views/Line/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80f5d4db31b99f264f19155558a15a5d4e57d62", @"/Views/Line/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d712202cac84fcadfa28734fbcefeb008b4eaa", @"/_ViewImports.cshtml")]
    public class Views_Line_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrainManager.ViewModels.Line.DetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Line/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section class=\"py-5\">\r\n    <div class=\"container\">\r\n        <h1 style=\"margin: 2%; text-align: center;\">Edit Line</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e80f5d4db31b99f264f19155558a15a5d4e57d624022", async() => {
                WriteLiteral("\r\n            <div>\r\n                <div class=\"form-group\" style=\"display: none\">\r\n                    <input type=\"text\" class=\"form-control\" id=\"id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 385, "\"", 402, 1);
#nullable restore
#line 8 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml"
WriteAttributeValue("", 393, Model.Id, 393, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"from\">From</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"from\" name=\"From\"");
                BeginWriteAttribute("value", " value=\"", 605, "\"", 624, 1);
#nullable restore
#line 12 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml"
WriteAttributeValue("", 613, Model.From, 613, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"to\">To</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"to\" name=\"To\"");
                BeginWriteAttribute("value", " value=\"", 819, "\"", 836, 1);
#nullable restore
#line 16 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml"
WriteAttributeValue("", 827, Model.To, 827, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"departureTime\">Departure Time</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"departureTime\" name=\"DepartureTime\"");
                BeginWriteAttribute("value", " value=\"", 1076, "\"", 1104, 1);
#nullable restore
#line 20 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml"
WriteAttributeValue("", 1084, Model.DepartureTime, 1084, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"arrivalTime\">Arrival Time</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"arrivalTime\" name=\"ArrivalTime\"");
                BeginWriteAttribute("value", " value=\"", 1336, "\"", 1362, 1);
#nullable restore
#line 24 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml"
WriteAttributeValue("", 1344, Model.ArrivalTime, 1344, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"arrivalTime\">Date</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"arrivalTime\" name=\"ArrivalTime\"");
                BeginWriteAttribute("value", " value=\"", 1586, "\"", 1605, 1);
#nullable restore
#line 28 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml"
WriteAttributeValue("", 1594, Model.Date, 1594, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group text-center\">\r\n");
#nullable restore
#line 31 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml"
                     if (User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\">Edit</button>\r\n");
#nullable restore
#line 34 "C:\Users\Bobi\Documents\GitHub\TrainManager\TrainManager\Views\Line\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrainManager.ViewModels.Line.DetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591