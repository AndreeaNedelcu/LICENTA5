#pragma checksum "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\YourReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7397e26ce29ffa168e61466d2e9033af55bd645b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LICENTA5.Pages.Home.Views_Home_YourReservations), @"mvc.1.0.view", @"/Views/Home/YourReservations.cshtml")]
namespace LICENTA5.Pages.Home
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7397e26ce29ffa168e61466d2e9033af55bd645b", @"/Views/Home/YourReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba38fbbd23055c2cc0a1c49740cd6f57f9e0b640", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_YourReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("min-width: 18rem; max-width:30.5%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ReservationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\YourReservations.cshtml"
   
    var currentHour = ViewBag.CurrentHour;
    DateTime currentDate = ViewBag.CurrentDate;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"containerRest row\">\r\n\r\n\r\n\r\n    <h3 class=\"col-md-6\" style=\"color:white\">Thank you for choosing us! You can se all your reservations here...</h3>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\YourReservations.cshtml"
     if (signInManager.IsSignedIn(User) && User.IsInRole("Premium-User"))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container d-flex justify-content-center col-md-6"">
            <div class=""row"">
                <div class=""col-md-6""> <button type=""button"" class=""btn btn-lg btn-warning"" data-toggle=""modal"" data-target=""#myModal""><i class=""fa-solid fa-crown fa-2xl""></i></button> </div>
            </div>
        </div>
        <div class=""modal fade"" id=""myModal"" role=""dialog"">
            <div class=""modal-dialog"">
                <div class=""card"">
                    <div class=""text-right cross""> <i class=""fa fa-times""></i> </div>
                    <div class=""card-body text-center"">
                        <img src=""https://img.icons8.com/external-microdots-premium-microdot-graphic/100/000000/external-crown-business-finance-vol4-microdots-premium-microdot-graphic.png"" />

                        <h4 style=""color:black"">CONGRATULATIONS!</h4>
                        <hr />
                        <p style=""color:black"">You have reached 10 reservation through us! Your account has been ");
            WriteLiteral("upgraded to Premium.</p> <button class=\"btn btn-out btn-square continue\">CONTINUE</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\YourReservations.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\YourReservations.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7397e26ce29ffa168e61466d2e9033af55bd645b7601", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 40 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\YourReservations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = p;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\YourReservations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = new ViewDataDictionary(ViewData) { { "CurrentHourForPartial", currentHour }
                                             , {"CurrentDateForPartial", currentDate } };

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\YourReservations.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n}");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591