#pragma checksum "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85aeef07e08c30c5670a2435693134d27c77d9db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_CadastrarFuncionario), @"mvc.1.0.view", @"/Views/Administrador/CadastrarFuncionario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/CadastrarFuncionario.cshtml", typeof(AspNetCore.Views_Administrador_CadastrarFuncionario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85aeef07e08c30c5670a2435693134d27c77d9db", @"/Views/Administrador/CadastrarFuncionario.cshtml")]
    public class Views_Administrador_CadastrarFuncionario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CharmosaApp.MVC.ViewModels.FuncionarioViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
  
    ViewData["Title"] = "CadastrarFuncionario";
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(141, 292, true);
            WriteLiteral(@"
<h2>CadastrarFuncionario</h2>

<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""CadastrarFuncionario"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group row"">
                ");
            EndContext();
            BeginContext(434, 86, false);
#line 17 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.LabelFor(model => model.Nome, "Nome", new { @class = "col-form-label col-sm-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(520, 63, true);
            WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(584, 84, false);
#line 19 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
               Write(Html.TextBoxFor(model => model.Nome, null, new { @class = "form-control col-sm-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(668, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(691, 84, false);
#line 20 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
               Write(Html.ValidationMessageFor(model => model.Nome, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(775, 117, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                \r\n                <div class=\"form-group col-sm-4\">\r\n                    ");
            EndContext();
            BeginContext(893, 95, false);
#line 25 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
               Write(Html.LabelFor(model => model.Sobrenome, "Sobrenome", new { @class = "control-label col-sm-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(988, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1011, 89, false);
#line 26 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
               Write(Html.TextBoxFor(model => model.Sobrenome, null, new { @class = "form-control col-sm-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1123, 89, false);
#line 27 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
               Write(Html.ValidationMessageFor(model => model.Sobrenome, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 113, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n           \r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1326, 96, false);
#line 32 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.LabelFor(model => model.Salario, "Salario (R$)", new { @class = "control-label col-sm-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1441, 87, false);
#line 33 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.TextBoxFor(model => model.Salario, null, new { @class = "form-control col-sm-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1547, 87, false);
#line 34 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.ValidationMessageFor(model => model.Salario, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 156, true);
            WriteLiteral("\r\n            </div>\r\n            <!-- Lista de função-->\r\n\r\n            <!-- fim Lista de função-->\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1791, 87, false);
#line 40 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.LabelFor(model => model.Login, "Login", new { @class = "control-label col-sm-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1897, 85, false);
#line 41 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.TextBoxFor(model => model.Login, null, new { @class = "form-control col-sm-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2001, 85, false);
#line 42 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.ValidationMessageFor(model => model.Login, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2163, 87, false);
#line 45 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.LabelFor(model => model.Senha, "Senha", new { @class = "control-label col-sm-1" }));

#line default
#line hidden
            EndContext();
            BeginContext(2250, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2269, 85, false);
#line 46 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.TextBoxFor(model => model.Senha, null, new { @class = "form-control col-sm-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2354, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2373, 85, false);
#line 47 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.ValidationMessageFor(model => model.Senha, null, new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2458, 78, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2537, 106, false);
#line 51 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
           Write(Html.Label("Cadastrar","Cadastrar",new { @class= "form-control btn btn-primary col-sm-2", @type="submit"}));

#line default
#line hidden
            EndContext();
            BeginContext(2643, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2712, 120, true);
            WriteLiteral("            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2850, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 63 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\CadastrarFuncionario.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
