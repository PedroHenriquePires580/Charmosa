#pragma checksum "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cd80fe19208d95601bf29b3daa5a621f487adeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Index), @"mvc.1.0.view", @"/Views/Administrador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Index.cshtml", typeof(AspNetCore.Views_Administrador_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd80fe19208d95601bf29b3daa5a621f487adeb", @"/Views/Administrador/Index.cshtml")]
    public class Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CharmosaApp.MVC.ViewModels.FuncionarioViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(112, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(271, 49, false);
#line 16 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FuncionarioID));

#line default
#line hidden
            EndContext();
            BeginContext(320, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(376, 40, false);
#line 19 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(416, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(472, 45, false);
#line 22 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(517, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(573, 43, false);
#line 25 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(616, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(672, 49, false);
#line 28 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UsuarioFuncao));

#line default
#line hidden
            EndContext();
            BeginContext(721, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(777, 41, false);
#line 31 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Login));

#line default
#line hidden
            EndContext();
            BeginContext(818, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(874, 41, false);
#line 34 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(915, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1033, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1082, 48, false);
#line 43 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FuncionarioID));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1186, 39, false);
#line 46 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1281, 44, false);
#line 49 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1381, 42, false);
#line 52 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1479, 48, false);
#line 55 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UsuarioFuncao));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1583, 40, false);
#line 58 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Login));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1679, 40, false);
#line 61 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1775, 65, false);
#line 64 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1861, 71, false);
#line 65 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1932, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1953, 69, false);
#line 66 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 69 "C:\Users\pedro.henrique\Desktop\CharmosaApp\CharmosaApp\CharmosaApp.MVC\Views\Administrador\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2061, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CharmosaApp.MVC.ViewModels.FuncionarioViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591