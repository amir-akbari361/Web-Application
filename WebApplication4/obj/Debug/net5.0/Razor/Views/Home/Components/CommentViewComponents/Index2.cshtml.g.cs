#pragma checksum "D:\DoreWeb\WebApplication4n\WebApplication4\Views\Home\Components\CommentViewComponents\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6e86f85089e4eb764e0253aa3e5a8c45a7eb2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_CommentViewComponents_Index2), @"mvc.1.0.view", @"/Views/Home/Components/CommentViewComponents/Index2.cshtml")]
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
#line 1 "D:\DoreWeb\WebApplication4n\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoreWeb\WebApplication4n\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6e86f85089e4eb764e0253aa3e5a8c45a7eb2f", @"/Views/Home/Components/CommentViewComponents/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_CommentViewComponents_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BE.Nazarat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DoreWeb\WebApplication4n\WebApplication4\Views\Home\Components\CommentViewComponents\Index2.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"tiny-slider text-center client-testi\">\r\n        <p class=\"text-light para-dark h6 fst-italic\">\"");
#nullable restore
#line 5 "D:\DoreWeb\WebApplication4n\WebApplication4\Views\Home\Components\CommentViewComponents\Index2.cshtml"
                                                  Write(item.Nazarat_Matn);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""</p>
        <ul class=""list-unstyled mb-0 mt-3"">
            <li class=""list-inline-item""><i class=""mdi mdi-star text-warning""></i></li>
            <li class=""list-inline-item""><i class=""mdi mdi-star text-warning""></i></li>
            <li class=""list-inline-item""><i class=""mdi mdi-star text-warning""></i></li>
            <li class=""list-inline-item""><i class=""mdi mdi-star text-warning""></i></li>
            <li class=""list-inline-item""><i class=""mdi mdi-star text-warning""></i></li>
        </ul>
        <h6 class=""text-light title-dark""> ");
#nullable restore
#line 13 "D:\DoreWeb\WebApplication4n\WebApplication4\Views\Home\Components\CommentViewComponents\Index2.cshtml"
                                      Write(item.Nazarat_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 788, "\"", 828, 2);
            WriteAttributeValue("", 794, "images/client/", 794, 14, true);
#nullable restore
#line 14 "D:\DoreWeb\WebApplication4n\WebApplication4\Views\Home\Components\CommentViewComponents\Index2.cshtml"
WriteAttributeValue("", 808, item.Nazarat_avatar, 808, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid avatar avatar-small rounded-circle mx-auto shadow\"");
            BeginWriteAttribute("alt", " alt=\"", 897, "\"", 903, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n");
#nullable restore
#line 16 "D:\DoreWeb\WebApplication4n\WebApplication4\Views\Home\Components\CommentViewComponents\Index2.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BE.Nazarat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
