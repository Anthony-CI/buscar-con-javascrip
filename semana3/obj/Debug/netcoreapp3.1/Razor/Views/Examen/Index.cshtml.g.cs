#pragma checksum "C:\Users\alciS\source\repos\semana3\semana3\Views\Examen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06d3692e0f3a0ae81fa173e1ae967c2a49e2e6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Examen_Index), @"mvc.1.0.view", @"/Views/Examen/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\alciS\source\repos\semana3\semana3\Views\_ViewImports.cshtml"
using semana3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alciS\source\repos\semana3\semana3\Views\_ViewImports.cshtml"
using semana3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06d3692e0f3a0ae81fa173e1ae967c2a49e2e6e", @"/Views/Examen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3521c0ff0ec922714c6f2119fc717af284bce346", @"/Views/_ViewImports.cshtml")]
    public class Views_Examen_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alciS\source\repos\semana3\semana3\Views\Examen\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Examenes</h1>
<a class=""btn btn-primary"" href=""/Examen/Crear"" role=""button"">Crear</a>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Tema</th>
            <th scope=""col"">Fecha Registro</th>
            

        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 20 "C:\Users\alciS\source\repos\semana3\semana3\Views\Examen\Index.cshtml"
         foreach (var examen in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\alciS\source\repos\semana3\semana3\Views\Examen\Index.cshtml"
           Write(examen.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 25 "C:\Users\alciS\source\repos\semana3\semana3\Views\Examen\Index.cshtml"
           Write(examen.Tema.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            <td>");
#nullable restore
#line 27 "C:\Users\alciS\source\repos\semana3\semana3\Views\Examen\Index.cshtml"
           Write(examen.FechaRegistro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\alciS\source\repos\semana3\semana3\Views\Examen\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
