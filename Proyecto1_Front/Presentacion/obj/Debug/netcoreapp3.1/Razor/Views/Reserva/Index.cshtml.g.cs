#pragma checksum "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8382e26092a8fadf9c1c43e193b292f280bc7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reserva_Index), @"mvc.1.0.view", @"/Views/Reserva/Index.cshtml")]
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
#line 1 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\_ViewImports.cshtml"
using Presentacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\_ViewImports.cshtml"
using Presentacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8382e26092a8fadf9c1c43e193b292f280bc7f", @"/Views/Reserva/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf57c469e1b8e05140e56e7f20f29b558100cc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Reserva_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Presentacion.Models.ReservaModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CrearReserva", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reserva", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b8382e26092a8fadf9c1c43e193b292f280bc7f4226", async() => {
                WriteLiteral("Crear nueva reserva");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaEntrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fechaSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cantAdultos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cantNinos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cantHabitaciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Codigo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fechaEntrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.fechaSalida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cantAdultos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cantNinos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cantHabitaciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.ActionLink("Modificar", "EditaReserva", "Reserva", new { item.ID }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 65 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Eliminar", "Reserva", new { item.ID }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Jason\Documents\1. UAM\2022\PROGRA AVANZADA\PROYECTO\Version 2\Proyecto1\Proyecto1_Front\Presentacion\Views\Reserva\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Presentacion.Models.ReservaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
