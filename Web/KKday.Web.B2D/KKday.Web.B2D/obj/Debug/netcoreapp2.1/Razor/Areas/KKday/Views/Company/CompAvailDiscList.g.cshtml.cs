#pragma checksum "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "522771aa78bcfaca4f8f691c23fc0de43d0588e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_KKday_Views_Company_CompAvailDiscList), @"mvc.1.0.view", @"/Areas/KKday/Views/Company/CompAvailDiscList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/KKday/Views/Company/CompAvailDiscList.cshtml", typeof(AspNetCore.Areas_KKday_Views_Company_CompAvailDiscList))]
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
#line 1 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
using KKday.Web.B2D.BE.Models.Model.Common;

#line default
#line hidden
#line 2 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
using KKday.Web.B2D.BE.Models.Model.PriceSetting;

#line default
#line hidden
#line 3 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
using Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522771aa78bcfaca4f8f691c23fc0de43d0588e4", @"/Areas/KKday/Views/Company/CompAvailDiscList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977b9f6ad86b5d9429da0e7ea54509a25193626b", @"/Areas/KKday/Views/_ViewImports.cshtml")]
    public class Areas_KKday_Views_Company_CompAvailDiscList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<B2dDiscountMst>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 8 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
 if (Model == null || Model.Count() < 1)
{

#line default
#line hidden
            BeginContext(225, 10, true);
            WriteLiteral("    <span>");
            EndContext();
            BeginContext(236, 29, false);
#line 10 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
     Write(localizer.Text.Data_Not_Found);

#line default
#line hidden
            EndContext();
            BeginContext(265, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 11 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
}
else
{


#line default
#line hidden
            BeginContext(288, 270, true);
            WriteLiteral(@"    <table id=""disc_tbl"" class=""table table-bordred table-striped fit"">
        <thead>
            <tr>
                <th><input type=""checkbox"" id=""checkall"" /></th>
                <th>Discount Name</th>
            </tr>
        </thead>

        <tbody>
");
            EndContext();
#line 24 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(615, 86, true);
            WriteLiteral("                <tr>\r\n                    <td><input type=\"checkbox\" class=\"checkthis\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 701, "\"", 718, 1);
#line 27 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
WriteAttributeValue("", 709, item.XID, 709, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(719, 101, true);
            WriteLiteral(" aria-label=\"Select discount\" title=\"Select discount in this table\" /></td>\r\n                    <td>");
            EndContext();
            BeginContext(821, 14, false);
#line 28 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
                   Write(item.DISC_NAME);

#line default
#line hidden
            EndContext();
            BeginContext(835, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 30 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"
            }

#line default
#line hidden
            BeginContext(880, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 33 "/Users/zhangfengrong/Documents/GitHub/BID/Src/Web/KKday.Web.B2D/KKday.Web.B2D/Areas/KKday/Views/Company/CompAvailDiscList.cshtml"

}

#line default
#line hidden
            BeginContext(917, 503, true);
            WriteLiteral(@"
<script type=""text/javascript"">
        $(""#disc_tbl #checkall"").click(function () {
            if ($(""#disc_tbl #checkall"").is(':checked')) {
                $(""#disc_tbl input[type=checkbox]"").each(function () {
                    $(this).prop(""checked"", true);
                });

            } else {
                $(""#disc_tbl input[type=checkbox]"").each(function () {
                    $(this).prop(""checked"", false);
                });
            }
        });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<B2dDiscountMst>> Html { get; private set; }
    }
}
#pragma warning restore 1591