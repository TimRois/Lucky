#pragma checksum "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fec6426a126315c4a3638ab7422501372a5918b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Shop\Shop\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fec6426a126315c4a3638ab7422501372a5918b", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b4a223d86ab48f70061b3a8f5d65bdada8992b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Text</h2>\r\n<h3>");
#nullable restore
#line 3 "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml"
Write(Model.currCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<div class=\"row mt-5 mb-2\">\r\n    \r\n");
#nullable restore
#line 6 "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml"
      
        foreach (var car in Model.allCars)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4\">\r\n            <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 218, "\"", 232, 1);
#nullable restore
#line 11 "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml"
WriteAttributeValue("", 224, car.img, 224, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 233, "\"", 248, 1);
#nullable restore
#line 11 "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml"
WriteAttributeValue("", 239, car.name, 239, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h2> ");
#nullable restore
#line 12 "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml"
            Write(car.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 13 "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml"
          Write(car.shortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Price: ");
#nullable restore
#line 14 "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml"
                 Write(car.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p><a class=\"btn btn-warning\" href=\"#\">more info</a></p>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\User\source\repos\Shop\Shop\Views\Cars\List.cshtml"

        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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