#pragma checksum "C:\Users\HesenCode\Desktop\Prak.eduhome.28.12.2021\prak.eduhome.28.12.2021\prak.eduhome.28.12.2021\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6de9e5654f1722ab9ad18b1ca57ba68f7086c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\HesenCode\Desktop\Prak.eduhome.28.12.2021\prak.eduhome.28.12.2021\prak.eduhome.28.12.2021\Views\_ViewImports.cshtml"
using prak.eduhome._28._12._2021;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HesenCode\Desktop\Prak.eduhome.28.12.2021\prak.eduhome.28.12.2021\prak.eduhome.28.12.2021\Views\_ViewImports.cshtml"
using prak.eduhome._28._12._2021.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6de9e5654f1722ab9ad18b1ca57ba68f7086c21", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bfbe6c2672178ad53315ec8461b38a3915a88ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html class=\"no-js\" lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6de9e5654f1722ab9ad18b1ca57ba68f7086c213449", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n    <title>Eduhome - Educational HTML Template</title>\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 228, "\"", 238, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""apple-touch-icon"" href=""apple-touch-icon.png"">
    <!-- Place favicon.ico in the root directory -->

    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/animate.css"">
    <link rel=""stylesheet"" href=""css/meanmenu.css"">
    <link rel=""stylesheet"" href=""css/magnific-popup.css"">
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""css/et-line-icon.css"">
    <link rel=""stylesheet"" href=""css/reset.css"">
    <link rel=""stylesheet"" href=""css/ionicons.min.css"">
    <link rel=""stylesheet"" href=""css/material-design-iconic-font.min.css"">
    <link rel=""stylesheet"" href=""css/style.css"">
    <link rel=""stylesheet"" href=""css/responsive.css"">
    <script src=""js/vendor/modernizr-2.8.3.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6de9e5654f1722ab9ad18b1ca57ba68f7086c215764", async() => {
                WriteLiteral(@"
    <!--[if lt IE 8]>
        <p class=""browserupgrade"">You are using an <strong>outdated</strong> browser. Please <a href=""http://browsehappy.com/"">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->
    <!-- Header Area Start -->
    <header class=""top"">
        <div class=""header-area header-sticky fixed"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-3 col-sm-3 col-xs-6"">
                        <div class=""logo"">
                            <a href=""index.html""><img src=""img/logo/logo.png"" alt=""eduhome"" /></a>
                        </div>
                    </div>
                    <div class=""col-md-9 col-sm-9 col-xs-12"">
                        <div class=""content-wrapper one"">
                            <!-- Main Menu Start -->
                            <div class=""main-menu one text-right"">
                                <nav>
                                    <ul>
                    ");
                WriteLiteral(@"                    <li>
                                            <a href=""index.html"">Home</a>
                                            <ul>
                                                <li><a href=""index.html"">Home One</a></li>
                                                <li><a href=""index-2.html"">Home Two</a></li>
                                                <li><a href=""index-3.html"">Home Three</a></li>
                                                <li><a href=""index-4.html"">Home Four</a></li>
                                                <li><a href=""index-5.html"">Home Five</a></li>
                                            </ul>
                                        </li>
                                        <li><a href=""about.html"">About</a></li>
                                        <li>
                                            <a href=""course.html"">courses</a>
                                            <ul>
                                               ");
                WriteLiteral(@" <li><a href=""course.html"">courses</a></li>
                                                <li><a href=""course-details.html"">courses details</a></li>
                                            </ul>
                                        </li>
                                        <li>
                                            <a href=""event.html"">event</a>
                                            <ul>
                                                <li><a href=""event.html"">event</a></li>
                                                <li><a href=""event-left-side-bar.html"">event left sidebar</a></li>
                                                <li><a href=""event-right-side-bar.html"">event right sidebar</a></li>
                                                <li><a href=""event-details.html"">event details</a></li>
                                            </ul>
                                        </li>
                                        <li class=""hidden-sm"">
           ");
                WriteLiteral(@"                                 <a href=""teacher.html"">teacher</a>
                                            <ul>
                                                <li><a href=""teacher.html"">teacher</a></li>
                                                <li><a href=""teacher-details.html"">teacher details</a></li>
                                            </ul>
                                        </li>
                                        <li>
                                            <a href=""blog.html"">blog</a>
                                            <ul>
                                                <li><a href=""blog.html"">blog</a></li>
                                                <li><a href=""blog-left-side-bar.html"">blog left sidebar</a></li>
                                                <li><a href=""blog-right-side-bar.html"">blog righ sidebar</a></li>
                                                <li><a href=""blog-details.html"">blog details</a></li>
                ");
                WriteLiteral(@"                            </ul>
                                        </li>
                                        <li><a href=""contact.html"">Contact</a></li>
                                        <li><a href=""#"">Buy Now</a>
                                    </ul>
                                </nav>
                            </div>
                            <div class=""mobile-menu hidden-lg hidden-md one""></div>
                            <!-- Main Menu End -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- Header Area End -->
    ");
#nullable restore
#line 104 "C:\Users\HesenCode\Desktop\Prak.eduhome.28.12.2021\prak.eduhome.28.12.2021\prak.eduhome.28.12.2021\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Footer Start -->
    <footer class=""footer-area"">
        <div class=""main-footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
                        <div class=""single-widget pr-60"">
                            <div class=""footer-logo pb-25"">
                                <a href=""index.html""><img src=""img/logo/footer-logo.png"" alt=""eduhome""></a>
                            </div>
                            <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and give you a coete account of the system. </p>
                            <div class=""footer-social"">
                                <ul>
                                    <li><a href=""https://www.facebook.com/devitems/?ref=bookmarks""><i class=""zmdi zmdi-facebook""></i></a></li>
                                    <li><a href=""https://www.pinterest.com/devitemsllc/""><i class=""zmdi zmdi-pin");
                WriteLiteral(@"terest""></i></a></li>
                                    <li><a href=""#""><i class=""zmdi zmdi-vimeo""></i></a></li>
                                    <li><a href=""https://twitter.com/devitemsllc""><i class=""zmdi zmdi-twitter""></i></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                            <h3>information</h3>
                            <ul>
                                <li><a href=""#"">addmission</a></li>
                                <li><a href=""#"">Academic Calender</a></li>
                                <li><a href=""event.html"">Event List</a></li>
                                <li><a href=""#"">Hostel &amp; Dinning</a></li>
                                <li><a href=""#"">TimeTable</a></li>
                            </ul>
                        </div>
         ");
                WriteLiteral(@"           </div>
                    <div class=""col-md-2 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                            <h3>useful links</h3>
                            <ul>
                                <li><a href=""course.html"">our courses</a></li>
                                <li><a href=""about.html"">about us</a></li>
                                <li><a href=""teacher.html"">teachers &amp; faculty</a></li>
                                <li><a href=""#"">teams &amp; conditions</a></li>
                                <li><a href=""event.html"">our events</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-6 col-xs-12"">
                        <div class=""single-widget"">
                            <h3>get in touch</h3>
                            <p>Your address goes here, Street<br>City, Roadno 785 New York</p>
                            <p>+880  54");
                WriteLiteral(@"8  986  898  87<br>+880  659  785  658  98</p>
                            <p>info@eduhome.com<br>www.eduhome.com</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""footer-bottom text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <p>Copyright ?? <a href=""https://devitems.com/"" target=""_blank"">HasTech</a> 2017. All Right Reserved By Hastech.</p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- Footer End -->

    <script src=""js/vendor/jquery-1.12.0.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/jquery.meanmenu.js""></script>
    <script src=""js/jquery.magnific-popup.js""></script>
    <script src=""js/ajax-mail.js""></script>
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/jquery.mb.YTP");
                WriteLiteral("layer.js\"></script>\r\n    <script src=\"js/jquery.nicescroll.min.js\"></script>\r\n    <script src=\"js/plugins.js\"></script>\r\n    <script src=\"js/main.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
