#pragma checksum "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "200082381aaf6ea682cf8c6d617f322a73bedb92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Errors_Index), @"mvc.1.0.razor-page", @"/Pages/Errors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Errors/Index.cshtml", typeof(AspNetCore.Pages_Errors_Index), @"{status:int?}")]
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
#line 2 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml"
using KKday.Web.B2D.BE.Pages.Errors;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{status:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200082381aaf6ea682cf8c6d617f322a73bedb92", @"/Pages/Errors/Index.cshtml")]
    public class Pages_Errors_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(87, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(112, 537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b952f2c066244b7baa845acfe0c0df9", async() => {
                BeginContext(118, 524, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />

    <link rel=""stylesheet"" href=""https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.7/css/bootstrap.min.css""
          asp-fallback-href=""~/lib/bootstrap/dist/css/bootstrap.min.css""
          asp-fallback-test-class=""sr-only"" asp-fallback-test-property=""position"" asp-fallback-test-value=""absolute"" />

    <style type=""text/css"">
        .page-wrap {
            min-height: 100vh;
        }

    </style>
");
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
            BeginContext(649, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(651, 1338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "533b056ec2f24de4b542c22b456a98b3", async() => {
                BeginContext(657, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 25 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml"
     if (Model.Code == 404)
    {


#line default
#line hidden
                BeginContext(699, 513, true);
                WriteLiteral(@"        <div class=""page-wrap d-flex flex-row align-items-center"">
            <div class=""container"">
                <div class=""row justify-content-center"">
                    <div class=""col-md-12 text-center"">
                        <span class=""display-1 d-block"" style=""font-size:5em;"">404</span>
                        <div class=""mb-4 lead"">The page you are looking for was not found.</div>
                        <a href=""javascript:history.go(-1);"" class=""btn btn-link"">Back to Previous</a>
");
                EndContext();
#line 35 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml"
                         if (ViewData["HOME_PAGE"] != null)
                        {

#line default
#line hidden
                BeginContext(1298, 26, true);
                WriteLiteral("                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1324, "\"", 1353, 1);
#line 37 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml"
WriteAttributeValue("", 1331, ViewData["HOME_PAGE"], 1331, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1354, 34, true);
                WriteLiteral(" class=\"btn btn-default\">Home</a>\n");
                EndContext();
#line 38 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1415, 88, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 43 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml"

    }
    else
    {

#line default
#line hidden
                BeginContext(1529, 23, true);
                WriteLiteral("        <h3>HTTP Error ");
                EndContext();
                BeginContext(1553, 10, false);
#line 47 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml"
                  Write(Model.Code);

#line default
#line hidden
                EndContext();
                BeginContext(1563, 8, true);
                WriteLiteral(" </h3>\r\n");
                EndContext();
#line 48 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Pages/Errors/Index.cshtml"
    }

#line default
#line hidden
                BeginContext(1578, 404, true);
                WriteLiteral(@"
    <script src=""https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.7/bootstrap.min.js""
            asp-fallback-src=""~/lib/bootstrap/dist/js/bootstrap.min.js""
            asp-fallback-test=""window.jQuery && window.jQuery.fn && window.jQuery.fn.modal""
            crossorigin=""anonymous""
            integrity=""sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"">
    </script>

");
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
            BeginContext(1989, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591