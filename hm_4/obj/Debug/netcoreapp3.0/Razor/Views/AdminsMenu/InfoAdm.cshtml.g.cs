#pragma checksum "C:\Users\user\source\repos\hm_4\Views\AdminsMenu\InfoAdm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9edd4a9173261dff2a4b0dd9aad87e5744e77ab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminsMenu_InfoAdm), @"mvc.1.0.view", @"/Views/AdminsMenu/InfoAdm.cshtml")]
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
#line 1 "C:\Users\user\source\repos\hm_4\Views\_ViewImports.cshtml"
using hm_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\hm_4\Views\_ViewImports.cshtml"
using hm_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9edd4a9173261dff2a4b0dd9aad87e5744e77ab5", @"/Views/AdminsMenu/InfoAdm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d2eada4066ad4f28abb6fa2ca94a50889f9c84", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminsMenu_InfoAdm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<hm_4.Models.Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\hm_4\Views\AdminsMenu\InfoAdm.cshtml"
  
    ViewData["Title"] = "Админы";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Админ ");
#nullable restore
#line 5 "C:\Users\user\source\repos\hm_4\Views\AdminsMenu\InfoAdm.cshtml"
     Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\user\source\repos\hm_4\Views\AdminsMenu\InfoAdm.cshtml"
                      Write(Model.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<table class=\"table-condensed\" cellpadding=\"8\">\r\n    <tr>\r\n        <td>Имя</td>\r\n        <td>Фамилия</td>\r\n        <td>Возраст</td>\r\n        <td>Город проживания</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\user\source\repos\hm_4\Views\AdminsMenu\InfoAdm.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\user\source\repos\hm_4\Views\AdminsMenu\InfoAdm.cshtml"
       Write(Model.SecondName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\user\source\repos\hm_4\Views\AdminsMenu\InfoAdm.cshtml"
       Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\user\source\repos\hm_4\Views\AdminsMenu\InfoAdm.cshtml"
       Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<hm_4.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
