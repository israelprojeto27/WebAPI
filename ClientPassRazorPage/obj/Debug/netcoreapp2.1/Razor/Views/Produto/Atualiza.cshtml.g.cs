#pragma checksum "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e2c3094d319d6c84cf255358dca45c4201074f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Atualiza), @"mvc.1.0.view", @"/Views/Produto/Atualiza.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Atualiza.cshtml", typeof(AspNetCore.Views_Produto_Atualiza))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e2c3094d319d6c84cf255358dca45c4201074f", @"/Views/Produto/Atualiza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a982248650965abde0c4057333854a91c9aec58", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Atualiza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientPassRazorPage.api.ProdutoData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Produto/Atualiza"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
  
    ViewData["Title"] = "Atualiza";

#line default
#line hidden
            BeginContext(90, 57, true);
            WriteLiteral("\r\n<h2>Atualiza</h2>\r\n\r\n<h4>ProdutoData</h4>\r\n<hr />\r\n\r\n\r\n");
            EndContext();
            BeginContext(147, 1291, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a79fcc9cce44af59a9512f078952051", async() => {
                BeginContext(194, 52, true);
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"id\" name=\"produto.Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 246, "\"", 273, 1);
#line 14 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
WriteAttributeValue("", 254, ViewBag.Produto.Id, 254, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(274, 165, true);
                WriteLiteral(" />\r\n\r\n    <div class=\"form-group mx-sm-3 mb-2\">\r\n        <labe for=\"nome\">Nome</labe>\r\n        <input type=\"text\" id=\"nome\" name=\"produto.Nome\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 439, "\"", 468, 1);
#line 18 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
WriteAttributeValue("", 447, ViewBag.Produto.Nome, 447, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(469, 54, true);
                WriteLiteral(" />\r\n        <small class=\"text-danger\">\r\n            ");
                EndContext();
                BeginContext(524, 38, false);
#line 20 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
       Write(Html.ValidationMessage("produto.Nome"));

#line default
#line hidden
                EndContext();
                BeginContext(562, 214, true);
                WriteLiteral("\r\n        </small>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group mx-sm-3 mb-2\">\r\n        <labe for=\"descricao\">Descrição</labe>\r\n        <input type=\"text\" id=\"descricao\" name=\"produto.Descricao\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 776, "\"", 810, 1);
#line 27 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
WriteAttributeValue("", 784, ViewBag.Produto.Descricao, 784, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(811, 54, true);
                WriteLiteral(" />\r\n        <small class=\"text-danger\">\r\n            ");
                EndContext();
                BeginContext(866, 43, false);
#line 29 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
       Write(Html.ValidationMessage("produto.Descricao"));

#line default
#line hidden
                EndContext();
                BeginContext(909, 196, true);
                WriteLiteral("\r\n        </small>\r\n    </div>\r\n\r\n    <div class=\"form-group mx-sm-3 mb-2\">\r\n        <labe for=\"preco\">Preço</labe>\r\n        <input type=\"text\" id=\"preco\" name=\"produto.Preco\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1105, "\"", 1135, 1);
#line 35 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
WriteAttributeValue("", 1113, ViewBag.Produto.Preco, 1113, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1136, 54, true);
                WriteLiteral(" />\r\n        <small class=\"text-danger\">\r\n            ");
                EndContext();
                BeginContext(1191, 39, false);
#line 37 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
       Write(Html.ValidationMessage("produto.Preco"));

#line default
#line hidden
                EndContext();
                BeginContext(1230, 167, true);
                WriteLiteral("\r\n        </small>\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Atualizar </button>\r\n\r\n    <br>  <br>\r\n\r\n    <small class=\"text-success\">\r\n        ");
                EndContext();
                BeginContext(1398, 15, false);
#line 46 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Produto\Atualiza.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1413, 18, true);
                WriteLiteral("\r\n    </small>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1438, 17, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1455, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "584cd9d3c3614f95bf065461774b131f", async() => {
                BeginContext(1477, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1493, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientPassRazorPage.api.ProdutoData> Html { get; private set; }
    }
}
#pragma warning restore 1591