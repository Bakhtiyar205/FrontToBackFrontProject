#pragma checksum "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c8ff7a8452ebd9eee82f989fd2c59fe263f122d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Default.cshtml")]
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
#line 1 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c8ff7a8452ebd9eee82f989fd2c59fe263f122d", @"/Views/Shared/Components/Category/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81052c4d0d671e0e46db3449fbc1cb187fb05a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
 foreach (var category in Model.Categories)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"li-1\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 106, "\"", 113, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i");
            BeginWriteAttribute("class", " class=\"", 131, "\"", 153, 1);
#nullable restore
#line 9 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
WriteAttributeValue("", 139, category.Icon, 139, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 9 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
                                      Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
             if (category.SubCategories.Count() > 0) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <i class=\"fas fa-chevron-circle-right\"></i>\r\n");
#nullable restore
#line 12 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </a>\r\n        <ul>\r\n");
#nullable restore
#line 17 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
             foreach (var subcategory in category.SubCategories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 448, "\"", 455, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 20 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
           Write(subcategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a></li>\r\n");
#nullable restore
#line 22 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </ul>\r\n    </li>\r\n");
#nullable restore
#line 27 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson7FrontToBackProject\HomeWork\FrontToBack\FrontToBack\Views\Shared\Components\Category\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
