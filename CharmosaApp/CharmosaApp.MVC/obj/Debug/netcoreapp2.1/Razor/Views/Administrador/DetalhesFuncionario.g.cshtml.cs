#pragma checksum "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ed34fb2c3df98c953a84434053b32186096455"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_DetalhesFuncionario), @"mvc.1.0.view", @"/Views/Administrador/DetalhesFuncionario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/DetalhesFuncionario.cshtml", typeof(AspNetCore.Views_Administrador_DetalhesFuncionario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ed34fb2c3df98c953a84434053b32186096455", @"/Views/Administrador/DetalhesFuncionario.cshtml")]
    public class Views_Administrador_DetalhesFuncionario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CharmosaApp.MVC.ViewModels.FuncionarioViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
  
    ViewData["Title"] = "DetalhesFuncionario";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(138, 75, true);
            WriteLiteral("\r\n\r\n<div class=\"container div-view\">\r\n    <h2>Informações do Funcionario - ");
            EndContext();
            BeginContext(214, 36, false);
#line 10 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
                                Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(250, 158, true);
            WriteLiteral("</h2>\r\n\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(409, 49, false);
#line 17 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayNameFor(model => model.FuncionarioID));

#line default
#line hidden
            EndContext();
            BeginContext(458, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(526, 45, false);
#line 20 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayFor(model => model.FuncionarioID));

#line default
#line hidden
            EndContext();
            BeginContext(571, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(639, 40, false);
#line 23 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(679, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(747, 36, false);
#line 26 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(783, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(851, 45, false);
#line 29 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(896, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(964, 41, false);
#line 32 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1073, 43, false);
#line 35 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1184, 39, false);
#line 38 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1291, 49, false);
#line 41 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayNameFor(model => model.UsuarioFuncao));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1408, 45, false);
#line 44 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayFor(model => model.UsuarioFuncao));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1521, 41, false);
#line 47 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayNameFor(model => model.Login));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1630, 37, false);
#line 50 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
               Write(Html.DisplayFor(model => model.Login));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 129, true);
            WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(1797, 100, false);
#line 57 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\DetalhesFuncionario.cshtml"
           Write(Html.ActionLink("Editar", "CadastrarUsuario","Administrador",null, new { @class="btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 135, true);
            WriteLiteral(" |\r\n      \r\n                <a asp-action=\"Index\">Back to List</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CharmosaApp.MVC.ViewModels.FuncionarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
