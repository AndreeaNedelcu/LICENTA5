#pragma checksum "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca1a9dbfe3cc81093735976bcdeaa9aece486cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LICENTA5.Pages.Shared.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
namespace LICENTA5.Pages.Shared
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
#line 2 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using LICENTA5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using LICENTA5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using LICENTA5.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using LICENTA5.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using LICENTA5.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using LICENTA5.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using LICENTA5.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca1a9dbfe3cc81093735976bcdeaa9aece486cb", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba38fbbd23055c2cc0a1c49740cd6f57f9e0b640", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Shared\Error.cshtml"
 if (ViewBag.ErrorTitle == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-danger\">Error.</h1>\r\n    <h2 class=\"text-danger\">An error occurred while processing your request. We are working on the fix.</h2>\r\n");
#nullable restore
#line 10 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Shared\Error.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-danger\">");
#nullable restore
#line 14 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h6 class=\"text-danger\">");
#nullable restore
#line 15 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Shared\Error.cshtml"
                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 16 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Shared\Error.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591