#pragma checksum "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2951df9bf553c73f6373e10bed7bef3d72f9146d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LICENTA5.Pages.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2951df9bf553c73f6373e10bed7bef3d72f9146d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba38fbbd23055c2cc0a1c49740cd6f57f9e0b640", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "RestaurantSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/HomeSlides/fun&friends2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/HomeSlides/date2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/HomeSlides//quiet&fancy2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Third slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuyGiftCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-common"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/giftcard/qrcode.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Restaurants", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("opacity:0.7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
  
    var clicked = 0;

    Random rand = new Random();
    int toSkip = rand.Next(1, repository.Restaurants.Count());
    Restaurant res = null;

    res = repository.Restaurants.Skip(toSkip).Take(1).FirstOrDefault();
    Layout = "~/Views/Shared/_HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<section class=\"top-main\">\r\n        <div class=\"top-site-images\">\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"page-title-wrapper\">\r\n            <div class=\"container\">\r\n                <div class=\"banner-wrapper\" style=\"width:60%\">\r\n\r\n");
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n<div style=\"padding-top:30px\">\r\n\r\n    <!--<partial name=\"RestaurantSummary\" model=\"");
#nullable restore
#line 42 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
                                            Write(Model.RandomRestaurant);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n    </div>-->\r\n");
#nullable restore
#line 44 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
     if (Model.SearchTerm != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
         foreach (var v in Model.RestaurantsList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2951df9bf553c73f6373e10bed7bef3d72f9146d12674", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 48 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = v;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




    <div class=""container-buttons"" style=""z-index:1"">
        <div class=""about-us"">
            <div class=""who-we-are"">


            </div>
            <div class=""cards"" style=""display:flex; justify-content: center; align-items: center;
    margin: 10px;
    flex-wrap: wrap;
    padding: 20px;
    padding-bottom: 0px;
    "">

                <div class=""card"" style=""width:250px; margin-right: 20px; background-color:transparent; color:white"">

                    <div class=""card-body"">

                        <a");
            BeginWriteAttribute("href", " href=\"", 2168, "\"", 2258, 2);
            WriteAttributeValue("", 2175, "https://localhost:44354/home/RestaurantDetails/", 2175, 47, true);
#nullable restore
#line 73 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
WriteAttributeValue("", 2222, Model.RandomRestaurant.RestaurantID, 2222, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-common"" style=""padding:10px;width:64px;height:64px""><i class=""fa-solid fa-lightbulb fa-3x"" onclick=""help()""></i></a>
                        <span style=""color:white""><b>RANDOM</b></span>
                        <p style=""color:white"">Trying new things is important! Let us choose a random restaurant for you.</p>
                    </div>
                </div>




                <div class=""card"" style=""width:250px;margin: 20px; background-color:transparent;color:white"">

                    <card class=""card-body"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 2837, "\"", 2928, 2);
            WriteAttributeValue("", 2844, "https://localhost:44354/home/RestaurantDetails/", 2844, 47, true);
#nullable restore
#line 85 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
WriteAttributeValue("", 2891, Model.NearestRestaurant.RestaurantID, 2891, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-common"" style=""padding:10px""><i class=""fa-solid fa-location-crosshairs fa-3x""></i></a>
                        <span style=""color:white""><b>AT HAND</b> </span>
                        <p style=""color:white"">You do not always need to go too far for good food. Let's see the nearest restaurant for you.</p>
                    </card>
                </div>

                <div class=""card"" style=""width:250px;margin: 20px; background-color:transparent;color:white"">

                    <card class=""card-body"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 3493, "\"", 3588, 2);
            WriteAttributeValue("", 3500, "https://localhost:44354/home/RestaurantDetails/", 3500, 47, true);
#nullable restore
#line 94 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
WriteAttributeValue("", 3547, Model.MostPopularRestaurant.RestaurantID, 3547, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-common"" style=""padding:10px; width:64px;height:64px""><i class=""fa-solid fa-fire fa-3x""></i></a>
                        <span style=""color:white""><b>POPULAR</b></span>
                        <p style=""color:white"">Have the best client exeprience at one of our most popular restaurant amoung users</p>
                    </card>
                </div>




            </div>
        </div>
    </div>


    <div class=""page-container"" style=""margin-top:30px"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 col-sm-6 col-xs-12 "">
                    <div class=""images"">
                        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                            <ol class=""carousel-indicators"">
                                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                                <li data-target=""#carouselExampleIndicators"" data");
            WriteLiteral(@"-slide-to=""1""></li>
                                <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                            </ol>
                            <div class=""carousel-inner"">
                                <div class=""carousel-item active"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2951df9bf553c73f6373e10bed7bef3d72f9146d19243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""carousel-caption d-none d-md-block"">
                                        <h5>Have fun with your friends</h5>
                                        <p style=""color:white"">We are sure that we can help you find a place for all of you</p>
                                    </div>
                                </div>
                                <div class=""carousel-item"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2951df9bf553c73f6373e10bed7bef3d72f9146d20919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""carousel-caption d-none d-md-block"">
                                        <h5>Date night</h5>
                                        <p style=""color:white"">Some time for just the two of you wold be nice. Hurry up and book a table!</p>
                                    </div>
                                </div>
                                <div class=""carousel-item"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2951df9bf553c73f6373e10bed7bef3d72f9146d22593", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    <div class=""carousel-caption d-none d-md-block"">
                                        <h5>Chill day</h5>
                                        <p style=""color:white"">Maybe you need a quiet, yet fancy place for today</p>
                                    </div>
                                </div>
                            </div>
                            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                <span class=""sr-only"">Previous</span>
                            </a>
                            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                <span class=""sr-only"">Next</span>
      ");
            WriteLiteral(@"                      </a>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-sm-6 col-xs-12"">

                    <div style=""color:white"">
                        <h1>What can you find here?</h1>
                        <br />
                        <p style=""color:white"">
                            If you enjoy eating out, spending time with your friends or just want to make a surprise dinner for someone, this is the app for you. Flash Table gives you full control over your booking experience.
                        </p>
                        <p style=""color:white"">
                          Planning a night out has never been easier. Flash Table is here for you! We have over 50 partner restaurants that are waiting for you. Just go through them and pick your favourite. Use your time wisely and choose Flash Table for any reservation.
                        </p>

                    </div>
                </div>
 ");
            WriteLiteral(@"           </div>
        </div>


        <div class=""row"">
            <div class=""col-md-12 col-xs-6 justify-content-center "" style=""color:white"">

                <h1 style=""color:white;text-align:center;margin-top:100px"" >
                    Offer a gift card!
                    <img src=""https://img.icons8.com/external-flaticons-flat-flat-icons/64/000000/external-gift-card-black-friday-cyber-monday-flaticons-flat-flat-icons.png"" />

                </h1>
                <section class=""accordion_two_section ptb-100"">
                    <div class=""container"">
                        <div class=""row "">
                            <div class=""col-md-6 col-sm-6 accordionTwo"">
                                <div class=""panel-group"" id=""accordionTwoLeft"">
                                    <div class=""panel panel-default"">
                                        <div class=""panel-heading"">
                                            <h4 class=""panel-title""> <a data-toggle=""collapse"" d");
            WriteLiteral(@"ata-parent=""#accordionTwoLeft"" href=""#collapseTwoLeftone"" aria-expanded=""false"" class=""collapsed""> How to use the gift card? </a> </h4>
                                        </div>
                                        <div id=""collapseTwoLeftone"" class=""panel-collapse collapse"" aria-expanded=""false"" role=""tablist"" style=""height: 0px;"">
                                            <div class=""panel-body"">
                                                <ul>
                                                    <li>
                                                        -> After you buy a credit card for a friend they will receive an email with the generated QR code, the value and the valability period.
                                                        The card can be used at any of the partner restaurants.
                                                    </li>
                                                    <li>
                                                        -> A reservation ");
            WriteLiteral(@"must be made through Flash Table and the card can be used by presenting the QR code at the restaurant.
                                                    </li>
                                                </ul>

                                            </div>
                                        </div>
                                    </div>
                                    <div class=""panel panel-default"">
                                        <div class=""panel-heading"">
                                            <h4 class=""panel-title""> <a class=""collapsed"" data-toggle=""collapse"" data-parent=""#accordionTwoLeft"" href=""#collapseTwoLeftTwo"" aria-expanded=""false""> Availability</a> </h4>
                                        </div>
                                        <div id=""collapseTwoLeftTwo"" class=""panel-collapse collapse"" aria-expanded=""false"" role=""tablist"">
                                            <div class=""panel-body""> The gift card is availabale for 6 month afte");
            WriteLiteral(@"r it was issues. The email that we'll send will contain the unique QR code together with the period it can be used. </div>
                                        </div>
                                    </div>
                                    <div class=""panel panel-default"">
                                        <div class=""panel-heading"">
                                            <h4 class=""panel-title""> <a class=""collapsed"" data-toggle=""collapse"" data-parent=""#accordionTwoLeft"" href=""#collapseTwoLeftThree"" aria-expanded=""false""> How to buy? </a> </h4>
                                        </div>
                                        <div id=""collapseTwoLeftThree"" class=""panel-collapse collapse"" aria-expanded=""false"" role=""tablist"">
                                            <div class=""panel-body"">Click on the button bellow, choose a value for the gift card and make sure you enter a correct email account. You can also write your friend a message that it will be also emailed.</div>
 ");
            WriteLiteral("                                           <div class=\" row justify-content-center\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2951df9bf553c73f6373e10bed7bef3d72f9146d30352", async() => {
                WriteLiteral("<b>Buy</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-6 col-sm-6"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2951df9bf553c73f6373e10bed7bef3d72f9146d32155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </section>




            </div>
        </div>




    </div>
    <div class=""instructions"" style=""color:white"">
        <h1>Need help? Making a reservation at ... is very easy!</h1>
        <br />
        <p  style=""color:white"">1. Go to ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2951df9bf553c73f6373e10bed7bef3d72f9146d33560", async() => {
                WriteLiteral("Restaurants");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" section and pick your favourite</p>
        <br />

        <p style=""color:white"">2. Click on Book table button</p>
        <br />
        <p style=""color:white"">3. Complete the form with your desired date, people and hour. Click on CREATE button</p>
        <br />

        <h3>You're all done! You should be able to see your reservation and its details on My Reservations </h3>

    </div>
");
            DefineSection("header", async() => {
                WriteLiteral("\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2951df9bf553c73f6373e10bed7bef3d72f9146d35442", async() => {
                    WriteLiteral("\r\n            <div class=\"input-group\">\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2951df9bf553c73f6373e10bed7bef3d72f9146d35772", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
#nullable restore
#line 257 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.SearchTerm);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                <div class=""input-group-append"">
                    <button class=""btn btn-common"" type=""submit"" style=""height: 100%;margin: 0px;padding-bottom: 5px;padding-top: 2px;margin-left: 8px; ""><i class=""fa-solid fa-magnifying-glass"" style="" padding-top: 5px;""></i></button>
                </div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_16.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            WriteLiteral("    <script>\r\n\r\n\r\n\r\n\r\n    </script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStoreRepository repository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
