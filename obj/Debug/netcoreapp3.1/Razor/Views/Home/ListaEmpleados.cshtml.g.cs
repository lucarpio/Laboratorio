#pragma checksum "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a531e0393cd97b4e37cda4800697c566d52c541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaEmpleados), @"mvc.1.0.view", @"/Views/Home/ListaEmpleados.cshtml")]
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
#line 1 "C:\Users\axcel\Downloads\Laboratorio\Views\_ViewImports.cshtml"
using Laboratorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\axcel\Downloads\Laboratorio\Views\_ViewImports.cshtml"
using Laboratorio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a531e0393cd97b4e37cda4800697c566d52c541", @"/Views/Home/ListaEmpleados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ef00895db6a42a2e71872298127620593d82b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaEmpleados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Laboratorio.Models.Empleado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
  
    ViewData["Title"] = "Tabla de empleados";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""table-responsive"">
    <table class=""table table-hover table-dark"">
        <thead class=""thead-dark"">
            <tr>
                    <th scope=""col"">
                        #
                    </th>
                    <th scope=""col"">
                        ");
#nullable restore
#line 14 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
                   Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
#nullable restore
#line 17 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
                   Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
                   Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
                   Write(Html.DisplayNameFor(model => model.Dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
                   Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
                   Write(Html.DisplayNameFor(model => model.Agree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th scope=\"col\">\r\n                        ");
#nullable restore
#line 35 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
                   Write(Html.DisplayNameFor(model => model.Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">#</th>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>  \r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>                                   \r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Agree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Birth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 70 "C:\Users\axcel\Downloads\Laboratorio\Views\Home\ListaEmpleados.cshtml"
    }        

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Laboratorio.Models.Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591