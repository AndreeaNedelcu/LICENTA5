#pragma checksum "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544fe35201047a7278313314036efb856593a20b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LICENTA5.Pages.Home.Views_Home_RestaurantDetails), @"mvc.1.0.view", @"/Views/Home/RestaurantDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544fe35201047a7278313314036efb856593a20b", @"/Views/Home/RestaurantDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba38fbbd23055c2cc0a1c49740cd6f57f9e0b640", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RestaurantDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("GallerySlide d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px; height:400px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-common m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
  
    var photoPath = "../../images/" + (Model.Restaurant.PhotoPath ?? "noimage.jpg");
    var sumRates = 0;
    var NumberOfRates = Model.RestaurantRatings.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\" row justify-content-center\" style=\"color:white; text-decoration:solid\">");
#nullable restore
#line 10 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                                              Write(Model.Restaurant.RestaurantName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>

<div class=""container"" style=""color:white"">

    <!-- Page Section Start -->
    <div class=""page-container blog"">
        <div class=""container"">
            <div class=""row"">
                <!-- Left Sidebar -->
                <div class=""col-md-9 col-sm-12 col-sx-12 lift-sidebar clearfix"">
                    <div class=""blog-post"">

                        <div class=""post"">
                            <div class=""post-img"">
                                <img class=""imageCustom""");
            BeginWriteAttribute("src", " src=", 927, "", 942, 1);
#nullable restore
#line 24 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
WriteAttributeValue("", 932, photoPath, 932, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" width:100%; height:100%\" />\r\n                            </div>\r\n                            <div class=\"post-content\">\r\n                                <h3><a href=\"#\">");
#nullable restore
#line 27 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                           Write(Model.Restaurant.RestaurantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <ul class=\"list\">\r\n                                    <li><span>Program:</span><a href=\"#\"> ");
#nullable restore
#line 29 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                                     Write(Model.Restaurant.openHour);

#line default
#line hidden
#nullable disable
            WriteLiteral("- ");
#nullable restore
#line 29 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                                                                 Write(Model.Restaurant.closingHour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                    <li><span>Capacity:</span><a href=\"#\"> ");
#nullable restore
#line 30 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                                      Write(Model.Restaurant.nrPersMax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                                <div class=\"post-desc\">\r\n                                    <p>\r\n                                        ");
#nullable restore
#line 34 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                   Write(Model.Restaurant.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>

                                </div>
                                <div>
                                    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                                        <ol class=""carousel-indicators"">

");
#nullable restore
#line 42 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                             for (int i = 0; i < Model.Gallery.Count(); i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 44 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 2246, "\"", 2278, 2);
#nullable restore
#line 44 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
WriteAttributeValue("", 2254, i==0 ? "active" : "", 2254, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2277, "", 2278, 1, true);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 45 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ol>\r\n                                        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 48 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                             for (int i = 0; i < Model.Gallery.Count(); i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div");
            BeginWriteAttribute("class", " class=\"", 2644, "\"", 2703, 2);
#nullable restore
#line 50 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
WriteAttributeValue("", 2652, i==0 ? "carousel-item active" : "carousel-item", 2652, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2702, "", 2703, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "544fe35201047a7278313314036efb856593a20b12882", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2804, "~/images/", 2804, 9, true);
#nullable restore
#line 51 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
AddHtmlAttributeValue("", 2813, Model.Gallery[i].URL, 2813, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
AddHtmlAttributeValue("", 2841, Model.Gallery[i].Name, 2841, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n");
#nullable restore
#line 53 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>

                                        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                            <span class=""sr-only"">Previous</span>
                                        </a>
                                        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                                            <span class=""sr-only"">Next</span>
                                        </a>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>



                </div>");
            WriteLiteral(@"
                <!-- Right Sidebar -->
                <div class=""col-md-3 col-sm-12 col-xs-12 right-sidebar"">



                    <!-- Recent Posts widget -->
                    <div class=""widget recent"">
                        <h5 class=""widget-title"">Info</h5>
");
            WriteLiteral(@"                        <br />
                        <ul class=""posts-list"">
                            <li>
                                
                                <div class=""widget-content"">
                                    <a style=""color:white"" href=""#"">Contact</a>
                                    <span style=""color:white"">");
#nullable restore
#line 90 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                         Write(Model.Restaurant.PhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <div class=""clearfix""></div>
                            </li>
                            <li>
                                <div class=""widget-thumb"">
                                    <a href=""#""><img src=""assets/img/blog/thumb1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5089, "\"", 5095, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                                </div>\r\n                                <div class=\"widget-content\" style=\"color:white\">\r\n                                    <a>Rating</a>\r\n                                    <span>");
#nullable restore
#line 100 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                     Write(ViewData["FinalRate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </div>
                                <div class=""clearfix""></div>
                            </li>
                            <li>
                                <div class=""widget-thumb"">
                                    <a href=""#""><img src=""assets/img/blog/thumb2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5667, "\"", 5673, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                                </div>
                                <div class=""widget-content"">
                                    <a style=""color:white"" href=""#"">Comments</a>
                                    <span style=""color:white"">2016/01/30</span>
                                </div>
                                <div class=""clearfix""></div>
                            </li>

                            <li>
                                <div class=""widget-thumb"">
                                    <div class=""container d-flex justify-content-center mt-1"">
                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""stars"">
");
#nullable restore
#line 121 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                     using (Html.BeginForm("RestaurantDetails", "Home", FormMethod.Post))
                                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <input class=""star star-5"" id=""star-5"" type=""radio"" name=""submit"" value=""5"" />
                                                        <label id=""label5"" class=""star star-5"" for=""star-5""></label>
                                                        <input class=""star star-4"" id=""star-4"" type=""radio"" name=""submit"" value=""4"" />
                                                        <label id=""label4"" class=""star star-4"" for=""star-4""></label>
                                                        <input class=""star star-3"" id=""star-3"" type=""radio"" name=""submit"" value=""3"" />
                                                        <label id=""label3"" class=""star star-3"" for=""star-3""></label>
                                                        <input class=""star star-2"" id=""star-2"" type=""radio"" name=""submit"" value=""2"" />
                                                        <label id=""label2"" class=""star star-2"" for=""star-2""></label>
        ");
            WriteLiteral("                                                <input class=\"star star-1\" id=\"star-1\" type=\"radio\" name=\"submit\" value=\"1\" />\r\n                                                        <label id=\"label1\" class=\"star star-1\" for=\"star-1\"></label>\r\n");
#nullable restore
#line 134 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"

                                                        // /Home

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <button type=\"submit\" id=\"btnRate\" class=\"btn btn-common\">Send rate</button>\r\n");
#nullable restore
#line 137 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div class=""clearfix""></div>
                            </li>
                            <li>
                                <div id=""map"" style=""height:230px; width:300px"">

                                </div>
                            </li>

                        </ul>
");
#nullable restore
#line 155 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                         if (Model.Restaurant.EmptySeats.Equals(0))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span> Fully booked </span>\r\n");
#nullable restore
#line 158 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "544fe35201047a7278313314036efb856593a20b23297", async() => {
                WriteLiteral("Book a table");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 161 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                                                                               WriteLiteral(Model.Restaurant.RestaurantID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 162 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Page Section End -->\r\n\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        var latitude = parseFloat(\"");
#nullable restore
#line 180 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                              Write(Model.Restaurant.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n        var longitude = parseFloat(\"");
#nullable restore
#line 181 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
                               Write(Model.Restaurant.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");
        var map;

        function initMap() {
            var markedPlace = { lat: latitude, lng: longitude };
        map = new google.maps.Map(document.getElementById('map'), {
            center: markedPlace,
            zoom: 20
        }
        );
        //const marker = new google.maps.Marker({
        //    position: markedPlace,
        //    map: map,
        //});
        }


    </script>
    <script");
                BeginWriteAttribute("src", " src=\"", 9938, "\"", 10029, 3);
                WriteAttributeValue("", 9944, "https://maps.googleapis.com/maps/api/js?key=", 9944, 44, true);
#nullable restore
#line 199 "C:\Users\Andreea\source\repos\LICENTA5\LICENTA5\Views\Home\RestaurantDetails.cshtml"
WriteAttributeValue("", 9988, ViewData["MyKeyMaps"], 9988, 24, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10012, "&callback=initMap", 10012, 17, true);
                EndWriteAttribute();
                WriteLiteral("\r\n            async defer></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
