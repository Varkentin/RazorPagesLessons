#pragma checksum "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Shared\Components\HeadCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c50d087f65eafdb20d2c49eeecfa5f5b772aea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesGeneral.Pages.Shared.Components.HeadCount.Pages_Shared_Components_HeadCount_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/HeadCount/Default.cshtml")]
namespace RazorPagesGeneral.Pages.Shared.Components.HeadCount
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c50d087f65eafdb20d2c49eeecfa5f5b772aea", @"/Pages/Shared/Components/HeadCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c378b30c823e37bfbbd7ec868bd0d5623981ea7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_HeadCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeptHeadCount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-hover rounded-pill\">\r\n    <thead class=\"thead-light\">\r\n        <tr>\r\n            <th>Department</th>\r\n            <th>Head Count</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 11 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Shared\Components\HeadCount\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 14 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Shared\Components\HeadCount\Default.cshtml"
               Write(item.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 15 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Shared\Components\HeadCount\Default.cshtml"
               Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 17 "W:\Work_C#\RazorPagesLessons\RazorPagesLessons\RazorPagesGeneral\Pages\Shared\Components\HeadCount\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeptHeadCount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
