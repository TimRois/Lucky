#pragma checksum "E:\Lucky\Shop\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b73c96c107d837cc5b0c0de118571f231068d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
#line 1 "E:\Lucky\Shop\Views\_ViewImports.cshtml"
using Lucky.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Lucky\Shop\Views\_ViewImports.cshtml"
using Lucky.Date;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Lucky\Shop\Views\_ViewImports.cshtml"
using Lucky.Date.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Lucky\Shop\Views\_ViewImports.cshtml"
using Lucky.Date.Models.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2b73c96c107d837cc5b0c0de118571f231068d2", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff0b90063ddd8d6112b60442813c0a7c462a5ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Результат поиска</h2>\r\n<div class=\"row mt-5 mb-2\">\r\n\r\n");
#nullable restore
#line 6 "E:\Lucky\Shop\Views\Search\Index.cshtml"
      
        foreach (Pet pet in Model.getPets)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Lucky\Shop\Views\Search\Index.cshtml"
       Write(Html.Partial("AllPets", pet));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Lucky\Shop\Views\Search\Index.cshtml"
                                         ;
        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
