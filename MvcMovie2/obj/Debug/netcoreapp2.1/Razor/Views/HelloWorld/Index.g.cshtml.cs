#pragma checksum "/Users/Dresen_HP/Projects/MvcMovie2/MvcMovie2/Views/HelloWorld/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "883da6f01845235ed14ff0c6b090491a2f04554b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HelloWorld/Index.cshtml", typeof(AspNetCore.Views_HelloWorld_Index))]
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
#line 1 "/Users/Dresen_HP/Projects/MvcMovie2/MvcMovie2/Views/_ViewImports.cshtml"
using MvcMovie2;

#line default
#line hidden
#line 2 "/Users/Dresen_HP/Projects/MvcMovie2/MvcMovie2/Views/_ViewImports.cshtml"
using MvcMovie2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"883da6f01845235ed14ff0c6b090491a2f04554b", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b08ca65582abc24be58c17a2356d7ce63790e6d", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Dresen_HP/Projects/MvcMovie2/MvcMovie2/Views/HelloWorld/Index.cshtml"
  
    ViewData["Title"] = "Movie List";

#line default
#line hidden
            BeginContext(46, 60, true);
            WriteLiteral("<h2>My Movie List</h2>\r\n<p>Hello from our View Template!</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
