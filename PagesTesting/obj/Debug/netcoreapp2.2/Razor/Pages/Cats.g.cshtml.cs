#pragma checksum "C:\Users\HRI\source\repos\EFCoreTesting\PagesTesting\Pages\Cats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89b2c1e64ab84efe665d1a2205d6387c5ba40b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PagesTesting.Pages.Pages_Cats), @"mvc.1.0.razor-page", @"/Pages/Cats.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Cats.cshtml", typeof(PagesTesting.Pages.Pages_Cats), null)]
namespace PagesTesting.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\HRI\source\repos\EFCoreTesting\PagesTesting\Pages\_ViewImports.cshtml"
using PagesTesting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89b2c1e64ab84efe665d1a2205d6387c5ba40b4", @"/Pages/Cats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916b7b88ea55c14fd0fae84319b8ba55ebd8c690", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cats : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\HRI\source\repos\EFCoreTesting\PagesTesting\Pages\Cats.cshtml"
  
    ViewData["Title"] = "Cats";

#line default
#line hidden
            BeginContext(84, 26, true);
            WriteLiteral("\r\n\r\n<h1>Cats</h1>\r\n\r\n<div>");
            EndContext();
            BeginContext(111, 13, false);
#line 10 "C:\Users\HRI\source\repos\EFCoreTesting\PagesTesting\Pages\Cats.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(124, 41, true);
            WriteLiteral("</div>\r\n\r\n<img src=\"images/cat.jpg\"/>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagesTesting.Pages.CatsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PagesTesting.Pages.CatsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PagesTesting.Pages.CatsModel>)PageContext?.ViewData;
        public PagesTesting.Pages.CatsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
