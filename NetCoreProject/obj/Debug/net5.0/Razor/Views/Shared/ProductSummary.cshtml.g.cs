#pragma checksum "D:\Profile\CSharp\CShaprt\NetCoreProject\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c399824020c416406cee0ef4ba1fcddf547f2ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
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
#line 1 "D:\Profile\CSharp\CShaprt\NetCoreProject\Views\_ViewImports.cshtml"
using NetCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Profile\CSharp\CShaprt\NetCoreProject\Views\_ViewImports.cshtml"
using NetCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Profile\CSharp\CShaprt\NetCoreProject\Views\_ViewImports.cshtml"
using NetCoreProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c399824020c416406cee0ef4ba1fcddf547f2ce", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160a94e889960e88aad9b52c4aba4dd212e8ffaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card my-4 w-50\">\r\n    <div class=\"card-header\">\r\n        ");
#nullable restore
#line 17 "D:\Profile\CSharp\CShaprt\NetCoreProject\Views\Shared\ProductSummary.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 20 "D:\Profile\CSharp\CShaprt\NetCoreProject\Views\Shared\ProductSummary.cshtml"
                          Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"card-text\">");
#nullable restore
#line 21 "D:\Profile\CSharp\CShaprt\NetCoreProject\Views\Shared\ProductSummary.cshtml"
                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <a href=\"#\" class=\"btn btn-primary\">");
#nullable restore
#line 22 "D:\Profile\CSharp\CShaprt\NetCoreProject\Views\Shared\ProductSummary.cshtml"
                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
