#pragma checksum "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6953ca4905b91a926bddff7b0f39e14e8a90b25f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_painelUsuario), @"mvc.1.0.view", @"/Views/Page/painelUsuario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/painelUsuario.cshtml", typeof(AspNetCore.Views_Page_painelUsuario))]
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
#line 1 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
using Senai.ProjetoFinal.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6953ca4905b91a926bddff7b0f39e14e8a90b25f", @"/Views/Page/painelUsuario.cshtml")]
    public class Views_Page_painelUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/painel-style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(70, 320, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f87bbad64c96423d83d00f90f1614b09", async() => {
                BeginContext(76, 169, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    ");
                EndContext();
                BeginContext(245, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "42d4dbfe7be145af99ec4b6924652804", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                BeginContext(331, 52, true);
                WriteLiteral("\r\n    <title>Painel de controle - Usuários</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(390, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(392, 1389, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c52a48e030f4b3a8a58a091e4c8ceaa", async() => {
                BeginContext(398, 549, true);
                WriteLiteral(@"
    
    <div class=""sidebar"">
        <a href=""/Page/PainelUsuario"">Usuários</a>
        <a href=""/Page/PainelComentario"">Depoimentos</a>
        <a href=""/Comentario/Comentarios"">Página inicial</a>
    </div>

    <center>

        
        <div class=""content"">
            <table>
                <tr>
                    <th>ID</th>
                    <th>Nome</th>
                    <th>Email</th>
                    <th>Senha</th>
                    <th>Adm</th>
                    <th></th>
                </tr>
");
                EndContext();
#line 32 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
                 foreach (UsuarioModel usuario in ViewData["Usuarios"] as List<UsuarioModel>) {

#line default
#line hidden
                BeginContext(1044, 84, true);
                WriteLiteral("                <tr class=\"row\">\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1129, 10, false);
#line 35 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
                   Write(usuario.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1139, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1219, 12, false);
#line 38 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
                   Write(usuario.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(1231, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1311, 13, false);
#line 41 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
                   Write(usuario.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1324, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1404, 13, false);
#line 44 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
                   Write(usuario.Senha);

#line default
#line hidden
                EndContext();
                BeginContext(1417, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1497, 11, false);
#line 47 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
                   Write(usuario.Adm);

#line default
#line hidden
                EndContext();
                BeginContext(1508, 81, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1589, "\"", 1627, 2);
                WriteAttributeValue("", 1596, "/Usuario/Excluir?id=", 1596, 20, true);
#line 50 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
WriteAttributeValue("", 1616, usuario.Id, 1616, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1628, 64, true);
                WriteLiteral(">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 53 "C:\Users\45346351841\Documents\Projetos\senai-projeto-primeiro-semestre\Views\Page\painelUsuario.cshtml"
                }

#line default
#line hidden
                BeginContext(1711, 63, true);
                WriteLiteral("            </table>\r\n        </div>\r\n    </center>\r\n        \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1781, 9, true);
            WriteLiteral("\r\n</html>");
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