#pragma checksum "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1781356d178a7e008500d4caec6bf8912dfe578a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_BuscaProdutos), @"mvc.1.0.view", @"/Views/Pedido/BuscaProdutos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/BuscaProdutos.cshtml", typeof(AspNetCore.Views_Pedido_BuscaProdutos))]
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
#line 1 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo;

#line default
#line hidden
#line 2 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo.Models;

#line default
#line hidden
#line 3 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\_ViewImports.cshtml"
using CasaDoCodigo.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1781356d178a7e008500d4caec6bf8912dfe578a", @"/Views/Pedido/BuscaProdutos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5764b985c14b19f76680672d581de467d30433a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_BuscaProdutos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuscaProdutosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "pesquisa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control input-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("categoria ou produto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "buscaprodutos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
  
    ViewData["Title"] = "Busca de Produtos";

#line default
#line hidden
            BeginContext(50, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(82, 230, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-md-4\">\n            <h2>Buscar produtos</h2>\n            <div id=\"custom-search-input\">\n                <div class=\"input-group col-md-12\">\n                    ");
            EndContext();
            BeginContext(312, 555, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1781356d178a7e008500d4caec6bf8912dfe578a6711", async() => {
                BeginContext(345, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(370, 190, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1781356d178a7e008500d4caec6bf8912dfe578a7116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 14 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Pesquisa);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(560, 300, true);
                WriteLiteral(@"
                        <span class=""input-group-btn"">
                            <button class=""btn btn-info btn-lg"" type=""submit"">
                                <i class=""glyphicon glyphicon-search""></i>
                            </button>
                        </span>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(867, 77, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
#line 29 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
  
    var produtos = Model.Produtos;

    var categorias =
        produtos
            .Select(m => m.Categoria)
            .Distinct();

#line default
#line hidden
            BeginContext(1086, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 38 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
 foreach (var categoria in categorias)
{
    var produtosNaCategoria =
        produtos
        .Where(p => p.Categoria.Id == categoria.Id);


#line default
#line hidden
            BeginContext(1229, 8, true);
            WriteLiteral("    <h3>");
            EndContext();
            BeginContext(1238, 14, false);
#line 44 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
   Write(categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1252, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
            BeginContext(1259, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1267, "\"", 1297, 2);
            WriteAttributeValue("", 1272, "my-carousel-", 1272, 12, true);
#line 46 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
WriteAttributeValue("", 1284, categoria.Id, 1284, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1298, 134, true);
            WriteLiteral(" class=\"carousel slide\" data-ride=\"carousel\">\n        <!-- Wrapper for slides -->\n        <div class=\"carousel-inner\" role=\"listbox\">\n");
            EndContext();
#line 49 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
              
                const int TAMANHO_PAGINA = 4;

                int paginas = (int)Math.Ceiling((double)produtosNaCategoria.Count() / TAMANHO_PAGINA);
            

#line default
#line hidden
            BeginContext(1611, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 54 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
             for (int pagina = 0; pagina < paginas; pagina++)
            {


#line default
#line hidden
            BeginContext(1688, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1708, "\"", 1751, 2);
            WriteAttributeValue("", 1716, "item", 1716, 4, true);
#line 57 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
WriteAttributeValue(" ", 1720, pagina == 0 ? "active" : "", 1721, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1752, 40, true);
            WriteLiteral(">\n                    <div class=\"row\">\n");
            EndContext();
#line 59 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
                          
                            var produtosDaPagina = produtosNaCategoria.Skip(pagina * TAMANHO_PAGINA).Take(TAMANHO_PAGINA);
                        

#line default
#line hidden
            BeginContext(1968, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 62 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
                         foreach (var produto in produtosDaPagina)
                        {


#line default
#line hidden
            BeginContext(2062, 283, true);
            WriteLiteral(@"                            <div class=""col-md-3 col-sm-3 col-lg-3"">
                                <div class=""panel panel-default"">
                                    <div class=""panel-body"">
                                        <img class=""img-produto-carrossel center-block""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2345, "\"", 2395, 3);
            WriteAttributeValue("", 2351, "/images/produtos/large_", 2351, 23, true);
#line 68 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
WriteAttributeValue("", 2374, produto.Codigo, 2374, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 2391, ".jpg", 2391, 4, true);
            EndWriteAttribute();
            BeginContext(2396, 191, true);
            WriteLiteral(" />\n                                    </div>\n                                    <div class=\"panel-footer produto-footer\">\n                                        <div class=\"produto-nome\">");
            EndContext();
            BeginContext(2588, 12, false);
#line 71 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
                                                             Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2600, 67, true);
            WriteLiteral("</div>\n                                        <div><h4><strong>R$ ");
            EndContext();
            BeginContext(2668, 13, false);
#line 72 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
                                                       Write(produto.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(2681, 131, true);
            WriteLiteral("</strong></h4></div>\n                                        <div class=\"text-center\">\n                                            ");
            EndContext();
            BeginContext(2812, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1781356d178a7e008500d4caec6bf8912dfe578a17055", async() => {
                BeginContext(2990, 9, true);
                WriteLiteral("Adicionar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
                                                     WriteLiteral(produto.Codigo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3003, 165, true);
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                </div>\n                            </div>\n");
            EndContext();
#line 81 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
                        }

#line default
#line hidden
            BeginContext(3194, 50, true);
            WriteLiteral("                    </div>\n                </div>\n");
            EndContext();
#line 84 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"

            }

#line default
#line hidden
            BeginContext(3259, 81, true);
            WriteLiteral("        </div>\n        <!-- Controls -->\n        <a class=\"left carousel-control\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3340, "\"", 3373, 2);
            WriteAttributeValue("", 3347, "#my-carousel-", 3347, 13, true);
#line 88 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
WriteAttributeValue("", 3360, categoria.Id, 3360, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3374, 224, true);
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\n            <span class=\"glyphicon glyphicon-chevron-left\" aria-hidden=\"true\"></span>\n            <span class=\"sr-only\">Previous</span>\n        </a>\n        <a class=\"right carousel-control\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3598, "\"", 3631, 2);
            WriteAttributeValue("", 3605, "#my-carousel-", 3605, 13, true);
#line 92 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
WriteAttributeValue("", 3618, categoria.Id, 3618, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3632, 191, true);
            WriteLiteral(" role=\"button\" data-slide=\"next\">\n            <span class=\"glyphicon glyphicon-chevron-right\" aria-hidden=\"true\"></span>\n            <span class=\"sr-only\">Next</span>\n        </a>\n    </div>\n");
            EndContext();
#line 97 "C:\Users\linda\source\repos\lindalvo\aspnetmvc\identity\CasaDoCodigo\Views\Pedido\BuscaProdutos.cshtml"
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
