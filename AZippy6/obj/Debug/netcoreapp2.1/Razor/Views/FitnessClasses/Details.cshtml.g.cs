#pragma checksum "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fd44a6df9c56c114956dcf94adea8d3be052b23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FitnessClasses_Details), @"mvc.1.0.view", @"/Views/FitnessClasses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FitnessClasses/Details.cshtml", typeof(AspNetCore.Views_FitnessClasses_Details))]
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
#line 1 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\_ViewImports.cshtml"
using AZippy6;

#line default
#line hidden
#line 2 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\_ViewImports.cshtml"
using AZippy6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd44a6df9c56c114956dcf94adea8d3be052b23", @"/Views/FitnessClasses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942884c1aed325809388dc966901ca1e08aa0b08", @"/Views/_ViewImports.cshtml")]
    public class Views_FitnessClasses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AZippy6.Models.FitnessClass>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>FitnessClass</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(208, 53, false);
#line 14 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fitnessclassTitle));

#line default
#line hidden
            EndContext();
            BeginContext(261, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 49, false);
#line 17 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayFor(model => model.fitnessclassTitle));

#line default
#line hidden
            EndContext();
            BeginContext(354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(398, 59, false);
#line 20 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fitnessclassDescription));

#line default
#line hidden
            EndContext();
            BeginContext(457, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(501, 55, false);
#line 23 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayFor(model => model.fitnessclassDescription));

#line default
#line hidden
            EndContext();
            BeginContext(556, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(600, 56, false);
#line 26 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fitnessclassDuration));

#line default
#line hidden
            EndContext();
            BeginContext(656, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(700, 52, false);
#line 29 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayFor(model => model.fitnessclassDuration));

#line default
#line hidden
            EndContext();
            BeginContext(752, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(796, 68, false);
#line 32 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fitnessclassCaloriesBurnedApprox));

#line default
#line hidden
            EndContext();
            BeginContext(864, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(908, 64, false);
#line 35 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayFor(model => model.fitnessclassCaloriesBurnedApprox));

#line default
#line hidden
            EndContext();
            BeginContext(972, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1016, 60, false);
#line 38 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fitnessclassMaxEnrollees));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1120, 56, false);
#line 41 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayFor(model => model.fitnessclassMaxEnrollees));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1220, 51, false);
#line 44 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fitnessclassFee));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1315, 47, false);
#line 47 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
       Write(Html.DisplayFor(model => model.fitnessclassFee));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1409, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1879ba1bb4648bb907f4f25591842cd", async() => {
                BeginContext(1467, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 52 "E:\Software Development\SD 733-01 Web Development Server-Side\Week 6\AZippy6\AZippy6\Views\FitnessClasses\Details.cshtml"
                           WriteLiteral(Model.fitnessclassId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1475, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1483, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd88e7c97f8e440f8f30c08628d75943", async() => {
                BeginContext(1505, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1521, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AZippy6.Models.FitnessClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
