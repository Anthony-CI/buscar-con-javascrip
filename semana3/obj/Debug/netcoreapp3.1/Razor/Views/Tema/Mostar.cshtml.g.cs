#pragma checksum "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc04d1c1a5dddd4ca8435f5bb7f1fa54eeb417dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tema_Mostar), @"mvc.1.0.view", @"/Views/Tema/Mostar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc04d1c1a5dddd4ca8435f5bb7f1fa54eeb417dd", @"/Views/Tema/Mostar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3521c0ff0ec922714c6f2119fc717af284bce346", @"/Views/_ViewImports.cshtml")]
    public class Views_Tema_Mostar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Mostar";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table id=\"Tabla\" class=\"table\">\r\n\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
         foreach (var tema in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
               Write(tema.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
               Write(tema.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
               Write(tema.Categoria.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 355, "\"", 388, 2);
            WriteAttributeValue("", 362, "/Tema/Eliminar?id=", 362, 18, true);
#nullable restore
#line 20 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
WriteAttributeValue("", 380, tema.Id, 380, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 426, "\"", 457, 2);
            WriteAttributeValue("", 433, "/Tema/Editar?id=", 433, 16, true);
#nullable restore
#line 21 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
WriteAttributeValue("", 449, tema.Id, 449, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 538, "\"", 576, 2);
            WriteAttributeValue("", 545, "/Pregunta/index?temaId=", 545, 23, true);
#nullable restore
#line 24 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
WriteAttributeValue("", 568, tema.Id, 568, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Preguntas</a>\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\alciS\source\repos\semana3\semana3\Views\Tema\Mostar.cshtml"
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
