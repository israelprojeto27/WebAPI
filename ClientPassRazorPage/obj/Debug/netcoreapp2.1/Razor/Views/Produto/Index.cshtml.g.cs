#pragma checksum "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ab89960a99e2f45cf4d18083286d5adf0648a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\_ViewImports.cshtml"
using ClientPassRazorPage;

#line default
#line hidden
#line 2 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\_ViewImports.cshtml"
using ClientPassRazorPage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ab89960a99e2f45cf4d18083286d5adf0648a99", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a982248650965abde0c4057333854a91c9aec58", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 23, true);
            WriteLiteral("\r\n<h2>Produtos</h2>\r\n\r\n");
            EndContext();
            BeginContext(65, 52, false);
#line 7 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml"
Write(Html.ActionLink("Novo Produto", "Create", "Produto"));

#line default
#line hidden
            EndContext();
            BeginContext(117, 232, true);
            WriteLiteral("\r\n\r\n<br>\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nome </th>\r\n            <th>Preço </th>\r\n            <th>Descrição </th>\r\n            <th> </th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 22 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml"
         foreach (var produto in ViewBag.ListaProdutos)
        {

#line default
#line hidden
            BeginContext(417, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(456, 12, false);
#line 25 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml"
               Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(468, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(496, 13, false);
#line 26 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml"
               Write(produto.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(509, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(537, 17, false);
#line 27 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml"
               Write(produto.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(554, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(582, 58, false);
#line 28 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml"
               Write(Html.ActionLink("Editar", "Edit", new { id = produto.Id} ));

#line default
#line hidden
            EndContext();
            BeginContext(640, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(677, 30, true);
            WriteLiteral("    </tbody>\r\n\r\n\r\n</table>\r\n\r\n");
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
