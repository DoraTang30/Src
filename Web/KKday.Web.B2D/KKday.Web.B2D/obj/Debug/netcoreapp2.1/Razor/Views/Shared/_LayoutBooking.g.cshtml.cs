#pragma checksum "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0643dca0e5815f8264e124564333f0596862fcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutBooking), @"mvc.1.0.view", @"/Views/Shared/_LayoutBooking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutBooking.cshtml", typeof(AspNetCore.Views_Shared__LayoutBooking))]
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
#line 1 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/_ViewImports.cshtml"
using KKday.Web.B2D.EC;

#line default
#line hidden
#line 2 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/_ViewImports.cshtml"
using KKday.Web.B2D.EC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0643dca0e5815f8264e124564333f0596862fcd", @"/Views/Shared/_LayoutBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1decf7227a59ebd0c9a1b3569a3e4065089e3cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/kkday_logo_final.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("header-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 2026, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca77e0f87d3541b0938c8882d8e6cd6f", async() => {
                BeginContext(29, 111, true);
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\">\n    <title>");
                EndContext();
                BeginContext(141, 12, false);
#line 6 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
      Write(ViewBag.Titl);

#line default
#line hidden
                EndContext();
                BeginContext(153, 128, true);
                WriteLiteral("</title>\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, maximum-scale=1, user-scalable=0\">\n\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 281, "\"", 324, 1);
#line 9 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 288, Url.Content("~/images/favicon.png"), 288, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(325, 66, true);
                WriteLiteral(" rel=\"shortcut icon\" type=\"image/ico\">\n\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 391, "\"", 437, 1);
#line 11 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 398, Url.Content("~/css/bootstrap.min.css"), 398, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(438, 46, true);
                WriteLiteral(" type=\"text/css\" />\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 484, "\"", 524, 1);
#line 12 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 491, Url.Content("~/css/flat-ui.css"), 491, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(525, 20, true);
                WriteLiteral(" type=\"text/css\" />\n");
                EndContext();
                BeginContext(662, 26, true);
                WriteLiteral("    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 688, "\"", 737, 1);
#line 14 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 695, Url.Content("~/css/font-awesome.min.css"), 695, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(738, 46, true);
                WriteLiteral(" type=\"text/css\" />\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 784, "\"", 835, 1);
#line 15 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 791, Url.Content("~/css/bootstrapValidator.css"), 791, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(836, 46, true);
                WriteLiteral(" type=\"text/css\" />\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 882, "\"", 943, 1);
#line 16 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 889, Url.Content("~/css/bootstrap-modal-carousel.min.css"), 889, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(944, 46, true);
                WriteLiteral(" type=\"text/css\" />\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 990, "\"", 1044, 1);
#line 17 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 997, Url.Content("~/css/owl.theme.default.min.css"), 997, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1045, 46, true);
                WriteLiteral(" type=\"text/css\" />\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1091, "\"", 1140, 1);
#line 18 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1098, Url.Content("~/css/owl.carousel.min.css"), 1098, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1141, 46, true);
                WriteLiteral(" type=\"text/css\" />\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1187, "\"", 1237, 1);
#line 19 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1194, Url.Content("~/css/simple-line-icons.css"), 1194, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1238, 46, true);
                WriteLiteral(" type=\"text/css\" />\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1284, "\"", 1323, 1);
#line 20 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1291, Url.Content("~/css/custom.css"), 1291, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1324, 58, true);
                WriteLiteral(" type=\"text/css\" />\n\n    <!-- jQuery 2.0.0 -->\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1382, "\"", 1422, 1);
#line 23 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1388, Url.Content("~/js/jquery.min.js"), 1388, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1423, 51, true);
                WriteLiteral("></script>\n    <!-- Bootstrap 3.3.7 -->\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1474, "\"", 1517, 1);
#line 25 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1480, Url.Content("~/js/bootstrap.min.js"), 1480, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1518, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1540, "\"", 1588, 1);
#line 26 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1546, Url.Content("~/js/bootstrapValidator.js"), 1546, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1589, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1611, "\"", 1653, 1);
#line 27 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1617, Url.Content("~/js/jquery.kkday.js"), 1617, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1654, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1676, "\"", 1728, 1);
#line 28 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1682, Url.Content("~/js/owl.carousel.2.2.1.min.js"), 1682, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1729, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1751, "\"", 1787, 1);
#line 29 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1757, Url.Content("~/js/moment.js"), 1757, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1788, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1810, "\"", 1847, 1);
#line 30 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1816, Url.Content("~/js/vue.min.js"), 1816, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1848, 22, true);
                WriteLiteral("></script>\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1870, "\"", 1913, 1);
#line 31 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
WriteAttributeValue("", 1876, Url.Content("~/js/vue-affix.min.js"), 1876, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1914, 11, true);
                WriteLiteral("></script>\n");
                EndContext();
                BeginContext(1945, 62, true);
                WriteLiteral("    <script type=\"text/javascript\">\n        var _root_path = \'");
                EndContext();
                BeginContext(2008, 17, false);
#line 34 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
                     Write(Url.Content("~/"));

#line default
#line hidden
                EndContext();
                BeginContext(2025, 17, true);
                WriteLiteral("\';\n    </script>\n");
                EndContext();
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
            EndContext();
            BeginContext(2049, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2050, 1636, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a454acb6b1b241f48a687d9dbbd67794", async() => {
                BeginContext(2056, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(2337, 268, true);
                WriteLiteral(@"    <header class=""header fix"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""header-container row"">
                    <div class=""col-xs-8"">
                        <a href=""index.html"">
                            ");
                EndContext();
                BeginContext(2605, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c337d929599b43f4a3505cd82e8be807", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2666, 389, true);
                WriteLiteral(@"
                        </a>
                    </div>
                    <div class=""col-xs-4 text-right"">
                        <div class=""table-row"">

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <div class=""container body-content"" style=""width:100%;padding-left:0;padding-right:0;"">
        ");
                EndContext();
                BeginContext(3056, 12, false);
#line 63 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3068, 407, true);
                WriteLiteral(@"
    </div>
    <footer class=""booking-footer"">
        <div class=""container"">
            <div id=""contact-kkday-row"">
                <div class=""cr-font text-right"" id=""footer-company-info"">
                    <h8 class=""text-muted"">COPYRIGHT © 2016 KKday All rights reserved.</h8>
                </div>
            </div>
        </div>
    </footer>
    <!-- ./footer -->
    <!-- scroll to top -->
");
                EndContext();
                BeginContext(3632, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(3637, 41, false);
#line 81 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Views/Shared/_LayoutBooking.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(3678, 1, true);
                WriteLiteral("\n");
                EndContext();
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
            EndContext();
            BeginContext(3686, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
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