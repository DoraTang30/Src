#pragma checksum "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2159adaac23618e6996328f6bcd441703ad0f839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_KKday_Views_Company_CompanyStatus), @"mvc.1.0.view", @"/Areas/KKday/Views/Company/CompanyStatus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/KKday/Views/Company/CompanyStatus.cshtml", typeof(AspNetCore.Areas_KKday_Views_Company_CompanyStatus))]
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
#line 1 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/_ViewImports.cshtml"
using KKday.Web.B2D.BE;

#line default
#line hidden
#line 2 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/_ViewImports.cshtml"
using KKday.Web.B2D.BE.Areas.KKday.Models;

#line default
#line hidden
#line 1 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
using KKday.Web.B2D.BE.Models.Model.Company;

#line default
#line hidden
#line 2 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
using KKday.Web.B2D.BE.App_Code;

#line default
#line hidden
#line 3 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
using KKday.Web.B2D.BE.Models.Model.Common;

#line default
#line hidden
#line 4 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
using Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2159adaac23618e6996328f6bcd441703ad0f839", @"/Areas/KKday/Views/Company/CompanyStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977b9f6ad86b5d9429da0e7ea54509a25193626b", @"/Areas/KKday/Views/_ViewImports.cshtml")]
    public class Areas_KKday_Views_Company_CompanyStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(199, 45, true);
            WriteLiteral("\r\n<ul id=\"progressbar\" class=\"progressbar\">\r\n");
            EndContext();
            BeginContext(291, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 298, "\"", 357, 1);
#line 14 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
WriteAttributeValue("", 306, string.Compare(Model, "00") >= 0 ? "active" : "", 306, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(358, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(360, 34, false);
#line 14 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
                                                               Write(localizer.Text.Company_Progress_00);

#line default
#line hidden
            EndContext();
            BeginContext(394, 14, true);
            WriteLiteral("</li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 408, "\"", 467, 1);
#line 15 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
WriteAttributeValue("", 416, string.Compare(Model, "01") >= 0 ? "active" : "", 416, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(468, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(470, 34, false);
#line 15 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
                                                               Write(localizer.Text.Company_Progress_01);

#line default
#line hidden
            EndContext();
            BeginContext(504, 14, true);
            WriteLiteral("</li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 518, "\"", 577, 1);
#line 16 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
WriteAttributeValue("", 526, string.Compare(Model, "02") >= 0 ? "active" : "", 526, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(578, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(580, 34, false);
#line 16 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
                                                               Write(localizer.Text.Company_Progress_02);

#line default
#line hidden
            EndContext();
            BeginContext(614, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 17 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
     if (Model.Equals("03"))
    {

#line default
#line hidden
            BeginContext(658, 27, true);
            WriteLiteral("        <li class=\"active\">");
            EndContext();
            BeginContext(686, 34, false);
#line 19 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
                      Write(localizer.Text.Company_Progress_03);

#line default
#line hidden
            EndContext();
            BeginContext(720, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 20 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
    }
    else if (Model.Equals("04"))
    {

#line default
#line hidden
            BeginContext(775, 27, true);
            WriteLiteral("        <li class=\"active\">");
            EndContext();
            BeginContext(803, 34, false);
#line 23 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
                      Write(localizer.Text.Company_Progress_04);

#line default
#line hidden
            EndContext();
            BeginContext(837, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 24 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(868, 21, true);
            WriteLiteral("        <li class=\"\">");
            EndContext();
            BeginContext(890, 34, false);
#line 27 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
                Write(localizer.Text.Company_Progress_NA);

#line default
#line hidden
            EndContext();
            BeginContext(924, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 28 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompanyStatus.cshtml"
    }

#line default
#line hidden
            BeginContext(938, 6, true);
            WriteLiteral("</ul> ");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591