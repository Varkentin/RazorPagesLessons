#pragma checksum "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3226c737bb2075161a39e4e8a408bef45f402a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesGeneral.Pages.Employees.Pages_Employees_Employees), @"mvc.1.0.razor-page", @"/Pages/Employees/Employees.cshtml")]
namespace RazorPagesGeneral.Pages.Employees
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
#line 1 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\_ViewImports.cshtml"
using RazorPagesGeneral;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\_ViewImports.cshtml"
using RazorPagesLessons.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3226c737bb2075161a39e4e8a408bef45f402a", @"/Pages/Employees/Employees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2220f812cf1109be5ca68f407f01a4689dd3e4aa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Employees : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DisplayEmployeePartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml"
  
    ViewData["Title"] = "Employees";
    ViewData["ShowButtons"] = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml"
 if (TempData["SuccessMessage"]!= null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-success text-center\">");
#nullable restore
#line 10 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml"
                                        Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Employees</h1>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 16 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml"
     foreach (var item in Model.Employees)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 col-sm-6 col-lg-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6b3226c737bb2075161a39e4e8a408bef45f402a4953", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 19 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 21 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Employees\Employees.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesGeneral.Pages.Employees.EmployeesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesGeneral.Pages.Employees.EmployeesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesGeneral.Pages.Employees.EmployeesModel>)PageContext?.ViewData;
        public RazorPagesGeneral.Pages.Employees.EmployeesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
