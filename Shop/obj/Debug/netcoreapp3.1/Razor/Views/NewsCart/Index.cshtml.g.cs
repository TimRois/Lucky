#pragma checksum "E:\Lucky\Shop\Views\NewsCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44905db4af93b2eee364b2097596ead9709c0fd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsCart_Index), @"mvc.1.0.view", @"/Views/NewsCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44905db4af93b2eee364b2097596ead9709c0fd0", @"/Views/NewsCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff0b90063ddd8d6112b60442813c0a7c462a5ea", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Новость</h2>\r\n<div class=\"row mt-5 mb-2\">\r\n\r\n");
#nullable restore
#line 6 "E:\Lucky\Shop\Views\NewsCart\Index.cshtml"
      
        foreach (News news in Model.getNews)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Lucky\Shop\Views\NewsCart\Index.cshtml"
       Write(Html.Partial("News", news));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Lucky\Shop\Views\NewsCart\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591