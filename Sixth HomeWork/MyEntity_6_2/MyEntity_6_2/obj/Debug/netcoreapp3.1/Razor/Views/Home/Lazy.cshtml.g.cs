#pragma checksum "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\Home\Lazy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6a0d2f572377d04da8b8253cb92b19711f815f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lazy), @"mvc.1.0.view", @"/Views/Home/Lazy.cshtml")]
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
#line 1 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\_ViewImports.cshtml"
using MyEntity_6_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\_ViewImports.cshtml"
using MyEntity_6_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a0d2f572377d04da8b8253cb92b19711f815f7", @"/Views/Home/Lazy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4655470af9558bc044e51c887bc17c55ed648598", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lazy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\Home\Lazy.cshtml"
  
    ViewData["Title"] = "Theater";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Lazy loading</h2>\r\n\r\n<table width=\"100%\" class=\"table table-striped table-bordered table-hover\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Type</th>\r\n        <th>Tickets</th>\r\n        <th>Price</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\Home\Lazy.cshtml"
     foreach (var u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\Home\Lazy.cshtml"
       Write(u.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\Home\Lazy.cshtml"
       Write(u.St_type.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\Home\Lazy.cshtml"
       Write(u.Tickets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\Home\Lazy.cshtml"
       Write(u.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 23 "C:\Users\karpe\Desktop\web\Home-Work-Web\Sixth HomeWork\MyEntity_6_2\MyEntity_6_2\Views\Home\Lazy.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
