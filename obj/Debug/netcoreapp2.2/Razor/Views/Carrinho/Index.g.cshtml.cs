#pragma checksum "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22cbc08757554a8a019107d2a393b8e994104771"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cbc08757554a8a019107d2a393b8e994104771", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1892f3915315deae1b5520336461a6f812b881b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<dotNET_2019.Models.Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EmprestarLivros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px;height:50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
            BeginContext(102, 23, true);
            WriteLiteral("\r\n<h1>Carrinho</h1>\r\n\r\n");
            EndContext();
#line 9 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
 if (Model == null || Model.Count() == 0)
{

#line default
#line hidden
            BeginContext(171, 46, true);
            WriteLiteral("    <br />\r\n    <h3>Carrinho está vazio</h3>\r\n");
            EndContext();
#line 13 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(231, 16, true);
            WriteLiteral("    <br />\r\n    ");
            EndContext();
            BeginContext(247, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22cbc08757554a8a019107d2a393b8e9941047715249", async() => {
                BeginContext(282, 88, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Emprestar Livros\" class=\"btn btn-default\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(377, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
}

#line default
#line hidden
            BeginContext(382, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
 if (TempData["MsgAlert"] != null)
{

#line default
#line hidden
            BeginContext(423, 18, true);
            WriteLiteral("    <br>\r\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 441, "\"", 495, 3);
            WriteAttributeValue("", 449, "alert", 449, 5, true);
            WriteAttributeValue(" ", 454, "alert-dismissible", 455, 18, true);
#line 26 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
WriteAttributeValue(" ", 472, TempData["MsgEstilo"], 473, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(496, 213, true);
            WriteLiteral(" role=\"alert\">\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n    <strong>Aten&ccedil;&atilde;o!!!</strong>&nbsp;");
            EndContext();
            BeginContext(710, 20, false);
#line 30 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
                                              Write(TempData["MsgAlert"]);

#line default
#line hidden
            EndContext();
            BeginContext(730, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 32 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
}

#line default
#line hidden
            BeginContext(747, 224, true);
            WriteLiteral("\r\n\r\n\r\n<br />\r\n\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Produto</th>\r\n            <th>Quantidade</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(1004, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 51 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
                 if(item.Foto != null) {

#line default
#line hidden
            BeginContext(1078, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1098, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cbc08757554a8a019107d2a393b8e9941047719521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1129, "~/", 1129, 2, true);
#line 52 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
AddHtmlAttributeValue("", 1131, item.Foto, 1131, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
                } 
                else {

#line default
#line hidden
            BeginContext(1222, 123, true);
            WriteLiteral("                    <img class=\"card-img-top\" src=\"https://picsum.photos/50/50/?random\" style=\"width:50px;height:50px\" />\r\n");
            EndContext();
#line 56 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1364, 35, true);
            WriteLiteral("            </td>\r\n            <td>");
            EndContext();
            BeginContext(1400, 11, false);
#line 58 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
           Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1435, 15, false);
#line 59 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
           Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(1450, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 61 "D:\GitHub\dotNET_2019\Views\Carrinho\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1475, 24, true);
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
