#pragma checksum "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0e84fbf7ef7fa2a596144f45c16bf8820a584e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catalogo_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Catalogo/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Catalogo/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Catalogo_Views_Home_Index))]
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
#line 1 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\_ViewImports.cshtml"
using CasaDoCodigo;

#line default
#line hidden
#line 2 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\_ViewImports.cshtml"
using CasaDoCodigo.Models;

#line default
#line hidden
#line 3 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\_ViewImports.cshtml"
using CasaDoCodigo.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e84fbf7ef7fa2a596144f45c16bf8820a584e5", @"/Areas/Catalogo/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5764b985c14b19f76680672d581de467d30433a1", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Catalogo_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuscaProdutosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BuscaProdutos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProdutoCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavegacaoCarrossel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Catálogo de Produtos";

#line default
#line hidden
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(85, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(86, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0e84fbf7ef7fa2a596144f45c16bf8820a584e54754", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(119, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 9 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
  
    var produtos = Model.Produtos;

    var categorias =
        produtos
            .Select(m => m.Categoria)
            .Distinct();

#line default
#line hidden
            BeginContext(263, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 18 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
 foreach (var categoria in categorias)
{
    var produtosNaCategoria =
        produtos
        .Where(p => p.Categoria.Id == categoria.Id);


#line default
#line hidden
            BeginContext(406, 8, true);
            WriteLiteral("    <h3>");
            EndContext();
            BeginContext(415, 14, false);
#line 24 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
   Write(categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(429, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
            BeginContext(436, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 444, "\"", 474, 2);
            WriteAttributeValue("", 449, "my-carousel-", 449, 12, true);
#line 26 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
WriteAttributeValue("", 461, categoria.Id, 461, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(475, 134, true);
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\">\n        <!-- Wrapper for slides -->\n        <div class=\"carousel-inner\" role=\"listbox\">\n");
            EndContext();
#line 29 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
              
                const int TAMANHO_PAGINA = 4;

                int paginas = (int)Math.Ceiling((double)produtosNaCategoria.Count() / TAMANHO_PAGINA);
            

#line default
#line hidden
            BeginContext(788, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 34 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
             for (int pagina = 0; pagina < paginas; pagina++)
            {


#line default
#line hidden
            BeginContext(865, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 885, "\"", 928, 2);
            WriteAttributeValue("", 893, "item", 893, 4, true);
#line 37 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 897, pagina == 0 ? "active" : "", 898, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(929, 40, true);
            WriteLiteral(">\n                    <div class=\"row\">\n");
            EndContext();
#line 39 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
                          
                            var produtosDaPagina = produtosNaCategoria.Skip(pagina * TAMANHO_PAGINA).Take(TAMANHO_PAGINA);
                        

#line default
#line hidden
            BeginContext(1145, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 42 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
                         foreach (var produto in produtosDaPagina)
                        {

#line default
#line hidden
            BeginContext(1238, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1266, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0e84fbf7ef7fa2a596144f45c16bf8820a584e510111", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 44 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = produto;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1314, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 45 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1341, 50, true);
            WriteLiteral("                    </div>\n                </div>\n");
            EndContext();
#line 48 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(1406, 49, true);
            WriteLiteral("        </div>\n        <!-- Controls -->\n        ");
            EndContext();
            BeginContext(1455, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0e84fbf7ef7fa2a596144f45c16bf8820a584e512475", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 52 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = categoria;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1512, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 54 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\IdentityServer\CasaDoCodigo\Areas\Catalogo\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuscaProdutosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591