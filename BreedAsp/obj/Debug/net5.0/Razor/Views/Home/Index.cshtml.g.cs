#pragma checksum "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1bc72007cbc87679afb607220e4f158fca9606"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\_ViewImports.cshtml"
using BreedAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\_ViewImports.cshtml"
using BreedAsp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\_ViewImports.cshtml"
using BreedAsp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e1bc72007cbc87679afb607220e4f158fca9606", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ecce30197b0112cc4d351fc3dbdd0f48b6812bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/p1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/p4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/p2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/p3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/p6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/portfolio/p5.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""home_banner_area"">
    <div class=""banner_inner"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-between"">
                <div class=""col-lg-6"">
                    <div class=""banner_content"">
                        <h3>");
#nullable restore
#line 9 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                       Write(Model.Header.Subheader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <h1 class=\"text-uppercase\">");
#nullable restore
#line 10 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                                              Write(Model.Header.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <h5 class=\"text-uppercase\">");
#nullable restore
#line 11 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                                              Write(Model.Header.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <div class=""social_icons my-5"">
                            <a href=""#""><i class=""ti-twitter""></i></a>
                            <a href=""#""><i class=""ti-skype""></i></a>
                            <a href=""#""><i class=""ti-instagram""></i></a>
                            <a href=""#""><i class=""ti-dribbble""></i></a>
                            <a href=""#""><i class=""ti-vimeo""></i></a>
                        </div>
                        <a class=""primary_btn"" href=""#""><span>See My Work</span></a>
                    </div>
                </div>
                <div class=""col-lg-4"">
                    <div class=""home_right_img"">
                        <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 1221, "\"", 1249, 1);
#nullable restore
#line 24 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1227, Model.Header.ImageUrl, 1227, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1250, "\"", 1256, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""statistics_area"">
    <div class=""container"">
        <div class=""row justify-content-lg-start justify-content-center"">
            <div class=""col-lg-2 col-md-3"">
                <div class=""statistics_item"">
                    <h3><span class=""counter"">15</span>k+</h3>
                    <p>Happy Customer</p>
                </div>
            </div>
            <div class=""col-lg-2 col-md-3"">
                <div class=""statistics_item"">
                    <h3><span class=""counter"">12</span>k+</h3>
                    <p>Ticket Solved</p>
                </div>
            </div>
            <div class=""col-lg-2 col-md-3"">
                <div class=""statistics_item"">
                    <h3><span class=""counter"">9</span>/10</h3>
                    <p>Average Rating</p>
                </div>
            </div>
        </div>
    </div>
</section>");
            WriteLiteral("\r\n\r\n\r\n<section class=\"about_area section_gap\">\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-start align-items-center\">\r\n            <div class=\"col-lg-5\">\r\n                <div class=\"about_img\">\r\n                    <img");
            BeginWriteAttribute("class", " class=\"", 2527, "\"", 2535, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 2536, "\"", 2570, 1);
#nullable restore
#line 64 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2542, Model.AboutSection.ImageUrl, 2542, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2571, "\"", 2577, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
            <div class=""offset-lg-1 col-lg-5"">
                <div class=""main_title text-left"">
                    <p class=""top_text"">About me <span></span></p>
                    <h2>
                        ");
#nullable restore
#line 71 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                   Write(Model.AboutSection.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n                    <p>\r\n                        ");
#nullable restore
#line 74 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                   Write(Model.AboutSection.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                    <a class=""primary_btn"" href=""#""><span>Download CV</span></a>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""services_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""main_title"">
                    <p class=""top_text"">Our Service <span></span></p>
                    <h2>
                        What Service We <br>
                        Offer For You
                    </h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 98 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
             foreach (var item in Model.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 mb-4 mb-lg-0\">\r\n                    <div class=\"service_item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3844, "\"", 3864, 1);
#nullable restore
#line 102 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
WriteAttributeValue("", 3850, item.ImageUrl, 3850, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3865, "\"", 3871, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h4>");
#nullable restore
#line 103 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                       Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>\r\n                            ");
#nullable restore
#line 105 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <a href=\"#\" class=\"primary_btn2 mt-35\">Learn More</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 110 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
    </div>
</section>


<section class=""testimonial_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""main_title"">
                    <p class=""top_text"">Our Tesitmonial <span></span></p>
                    <h2>
                        Honourable Client Says <br>
                        About Me
                    </h2>
                </div>
            </div>
        </div>
        <div class=""owl-carousel owl-theme testimonial-slider "">
");
#nullable restore
#line 132 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
             foreach (var item in Model.Testimonials)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"testimonial-item\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-lg-6\">\r\n                            <div class=\"testi-img mb-4 mb-lg-0\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 5041, "\"", 5061, 1);
#nullable restore
#line 138 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
WriteAttributeValue("", 5047, item.ImageUrl, 5047, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5062, "\"", 5068, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-lg-6\">\r\n                            <div class=\"testi-right\">\r\n                                <h4>");
#nullable restore
#line 143 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p><small>");
#nullable restore
#line 144 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                                     Write(item.Subheader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                                <p>");
#nullable restore
#line 145 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <ul class=\"star_rating mt-4\">\r\n");
#nullable restore
#line 147 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                                     for (int i = 0; i < item.Rating; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><span><i class=\"fas fa-star\"></i></span></li>\r\n");
#nullable restore
#line 150 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                                     for (int i = 0; i < 5 - item.Rating; i++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"disable\"><span><i class=\"fas fa-star\"></i></span></li>\r\n");
#nullable restore
#line 154 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 160 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>


<section class=""portfolio_area"" id=""portfolio"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""main_title"">
                    <p class=""top_text"">Our Portfolio <span></span></p>
                    <h2>
                        Check Our Recent <br>
                        Client Work
                    </h2>
                </div>
            </div>
        </div>
        <div class=""filters portfolio-filter"">
            <ul>
                <li class=""active"" data-filter=""*"">all</li>
                <li data-filter="".popular"">popular</li>
                <li data-filter="".latest""> latest</li>
                <li data-filter="".following"">following</li>
                <li data-filter="".upcoming"">upcoming</li>
            </ul>
        </div>
        <div class=""filters-content"">
            <div class=""row portfolio-grid"">
                <div class=""grid-sizer col-md-");
            WriteLiteral("3 col-lg-3\"></div>\r\n                <div class=\"col-lg-6 col-md-6 all following\">\r\n                    <div class=\"single_portfolio\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e1bc72007cbc87679afb607220e4f158fca960619248", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""overlay""></div>
                        <div class=""short_info"">
                            <h4><a href=""portfolio-details.html"">Lens Mockup Design</a></h4>
                            <p>Art, Illustration</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-6 all latest popular upcoming"">
                    <div class=""single_portfolio"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e1bc72007cbc87679afb607220e4f158fca960620943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""overlay""></div>
                        <div class=""short_info"">
                            <h4><a href=""portfolio-details.html"">Lens Mockup Design</a></h4>
                            <p>Art, Illustration</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 all latest following"">
                    <div class=""single_portfolio"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e1bc72007cbc87679afb607220e4f158fca960622631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""overlay""></div>
                        <div class=""short_info"">
                            <h4><a href=""portfolio-details.html"">Lens Mockup Design</a></h4>
                            <p>Art, Illustration</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-6 all latest upcoming"">
                    <div class=""single_portfolio"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e1bc72007cbc87679afb607220e4f158fca960624318", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""overlay""></div>
                        <div class=""short_info"">
                            <h4><a href=""portfolio-details.html"">Lens Mockup Design</a></h4>
                            <p>Art, Illustration</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-6 all popular"">
                    <div class=""single_portfolio"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e1bc72007cbc87679afb607220e4f158fca960625997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""overlay""></div>
                        <div class=""short_info"">
                            <h4><a href=""portfolio-details.html"">Lens Mockup Design</a></h4>
                            <p>Art, Illustration</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-6 all popular latest following"">
                    <div class=""single_portfolio"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e1bc72007cbc87679afb607220e4f158fca960627693", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""overlay""></div>
                        <div class=""short_info"">
                            <h4><a href=""portfolio-details.html"">Lens Mockup Design</a></h4>
                            <p>Art, Illustration</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""blog-area section-gap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""main_title"">
                    <p class=""top_text"">Our blog <span></span></p>
                    <h2>
                        Latest Story From <br>
                        Our Blog
                    </h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 271 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
             foreach (var item in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6\">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"thumb\">\r\n                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 11286, "\"", 11306, 1);
#nullable restore
#line 276 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
WriteAttributeValue("", 11292, item.ImageUrl, 11292, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 11307, "\"", 11313, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""short_details"">
                            <div class=""meta-top d-flex"">
                                <a href=""#""><i class=""ti-user""></i> Admin post</a>
                                <a href=""#""><i class=""ti-calendar""></i> ");
#nullable restore
#line 281 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                                                                   Write(item.ShareDate.ToString("MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                            <a class=\"d-block\" href=\"single-blog.html\">\r\n                                <h4>");
#nullable restore
#line 284 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                               Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </a>\r\n                            <div class=\"text-wrap\">\r\n                                <p>\r\n                                    ");
#nullable restore
#line 288 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                            <a href=\"#\" class=\"primary_btn2\">Learn More</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 295 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
    </div>
</section>


<section class=""brands-area section_gap_bottom"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""owl-carousel brand-carousel"">

");
#nullable restore
#line 309 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                     foreach (var item in Model.Brands)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"single-brand-item d-table\">\r\n                            <div class=\"d-table-cell\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 12768, "\"", 12788, 1);
#nullable restore
#line 313 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
WriteAttributeValue("", 12774, item.ImageUrl, 12774, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 12789, "\"", 12795, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 316 "C:\Users\axmed\source\repos\BreedAsp\BreedAsp\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
