#pragma checksum "C:\Users\Viking\source\repos\Home1\Home1\Pages\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d12d46e1f0673942a9f420cb26831b762b8061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Home1.Pages.Pages_Products), @"mvc.1.0.razor-page", @"/Pages/Products.cshtml")]
namespace Home1.Pages
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
#line 1 "C:\Users\Viking\source\repos\Home1\Home1\Pages\_ViewImports.cshtml"
using Home1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Viking\source\repos\Home1\Home1\Pages\Products.cshtml"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d12d46e1f0673942a9f420cb26831b762b8061", @"/Pages/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91dd748b0f5013dfc388973ef573cf1e363eec13", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Список товаров</h2>\r\n<table class=\"table\">\r\n    <tr><td>Name</td><td>Age</td></tr>\r\n");
#nullable restore
#line 10 "C:\Users\Viking\source\repos\Home1\Home1\Pages\Products.cshtml"
     foreach (Product product in Model.product)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 241, "\"", 262, 2);
            WriteAttributeValue("", 248, "/", 248, 1, true);
#nullable restore
#line 13 "C:\Users\Viking\source\repos\Home1\Home1\Pages\Products.cshtml"
WriteAttributeValue("", 249, product.Name, 249, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\Viking\source\repos\Home1\Home1\Pages\Products.cshtml"
                                    Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\Viking\source\repos\Home1\Home1\Pages\Products.cshtml"
           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Viking\source\repos\Home1\Home1\Pages\Products.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Home1.Pages.ProductsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Home1.Pages.ProductsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Home1.Pages.ProductsModel>)PageContext?.ViewData;
        public Home1.Pages.ProductsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
