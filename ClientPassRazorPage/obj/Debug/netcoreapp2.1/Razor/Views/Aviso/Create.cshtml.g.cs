#pragma checksum "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Aviso\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ed6d7f0da34967d557cc15191843df72a05103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aviso_Create), @"mvc.1.0.view", @"/Views/Aviso/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aviso/Create.cshtml", typeof(AspNetCore.Views_Aviso_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ed6d7f0da34967d557cc15191843df72a05103", @"/Views/Aviso/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a982248650965abde0c4057333854a91c9aec58", @"/Views/_ViewImports.cshtml")]
    public class Views_Aviso_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Aviso/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Aviso\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(44, 25, true);
            WriteLiteral("\r\n<h2>Novo Aviso</h2>\r\n\r\n");
            EndContext();
            BeginContext(69, 828, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad6cb35837ba41a9bb9cefc2ae161052", async() => {
                BeginContext(112, 237, true);
                WriteLiteral("\r\n\r\n    <div class=\"form-group mx-sm-3 mb-2\">\r\n        <label for=\"descricao\">Descricao </label>\r\n        <input type=\"text\" id=\"descricao\" name=\"aviso.Descricao\" class=\"form-control\" />\r\n        <small class=\"text-danger\">\r\n            ");
                EndContext();
                BeginContext(350, 41, false);
#line 14 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Aviso\Create.cshtml"
       Write(Html.ValidationMessage("aviso.Descricao"));

#line default
#line hidden
                EndContext();
                BeginContext(391, 257, true);
                WriteLiteral(@"
        </small>

    </div>

    <div class=""form-group"">
        <label for=""tipoAviso"">Tipo Aviso </label>
        <input type=""text"" id=""tipoAviso"" name=""aviso.TipoAviso"" class=""form-control"" />
        <small class=""text-danger"">
            ");
                EndContext();
                BeginContext(649, 41, false);
#line 23 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Aviso\Create.cshtml"
       Write(Html.ValidationMessage("aviso.TipoAviso"));

#line default
#line hidden
                EndContext();
                BeginContext(690, 166, true);
                WriteLiteral("\r\n        </small>\r\n    </div>\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary\">Cadastrar </button>\r\n\r\n    <br> <br>\r\n\r\n    <small class=\"text-success\">\r\n        ");
                EndContext();
                BeginContext(857, 15, false);
#line 32 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Aviso\Create.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(872, 18, true);
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
            BeginContext(897, 12, true);
            WriteLiteral("\r\n\r\n<br>\r\n\r\n");
            EndContext();
            BeginContext(910, 43, false);
#line 39 "D:\ProjectVisualStudio\ClientPassRazorPage\ClientPassRazorPage\Views\Aviso\Create.cshtml"
Write(Html.ActionLink("Voltar", "Index", "Aviso"));

#line default
#line hidden
            EndContext();
            BeginContext(953, 4, true);
            WriteLiteral("\r\n\r\n");
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
