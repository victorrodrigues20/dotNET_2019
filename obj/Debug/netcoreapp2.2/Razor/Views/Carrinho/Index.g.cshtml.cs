#pragma checksum "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d4cd4178546266b927413ccd238b0462115c4ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carrinho/Index.cshtml", typeof(AspNetCore.Views_Carrinho_Index))]
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
#line 1 "D:\GitHub\dotNET_2019\Views\_ViewImports.cshtml"
using dotNET_2019;

#line default
#line hidden
#line 2 "D:\GitHub\dotNET_2019\Views\_ViewImports.cshtml"
using dotNET_2019.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d4cd4178546266b927413ccd238b0462115c4ca", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1892f3915315deae1b5520336461a6f812b881b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<dotNET_2019.Models.Livro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
 if (Model == null || Model.Count() == 0)
{

#line default
#line hidden
            BeginContext(150, 46, true);
            WriteLiteral("    <br />\r\n    <h3>Carrinho está vazio</h3>\r\n");
            EndContext();
#line 11 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"

}

#line default
#line hidden
            BeginContext(201, 221, true);
            WriteLiteral("\r\n<br />\r\n\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>..</th>\r\n            <th>Produto</th>\r\n            <th>Quantidade</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(455, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
            BeginContext(585, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(602, 11, false);
#line 29 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
           Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(613, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(637, 15, false);
#line 30 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
           Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(652, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
}

#line default
#line hidden
            BeginContext(677, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<dotNET_2019.Models.Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591