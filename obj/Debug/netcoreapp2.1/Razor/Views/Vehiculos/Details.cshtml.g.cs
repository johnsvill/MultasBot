#pragma checksum "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c635908e034fb101b6e0d74b43b9d3ebe1ad2fff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehiculos_Details), @"mvc.1.0.view", @"/Views/Vehiculos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehiculos/Details.cshtml", typeof(AspNetCore.Views_Vehiculos_Details))]
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
#line 1 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\_ViewImports.cshtml"
using MultasTransito;

#line default
#line hidden
#line 2 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\_ViewImports.cshtml"
using MultasTransito.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c635908e034fb101b6e0d74b43b9d3ebe1ad2fff", @"/Views/Vehiculos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c63bbded5c51ccab2361d7644f35dd7e9119b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehiculos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MultasTransito.Models.Vehiculo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 145, true);
            WriteLiteral("\r\n<h2>Detalles</h2>\r\n\r\n<div>\r\n    <h4>Vehiculo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal form-group-sm\">        \r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(230, 41, false);
#line 14 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(271, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(315, 37, false);
#line 17 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(396, 41, false);
#line 20 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdNit));

#line default
#line hidden
            EndContext();
            BeginContext(437, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(481, 37, false);
#line 23 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdNit));

#line default
#line hidden
            EndContext();
            BeginContext(518, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(562, 41, false);
#line 26 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(603, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(647, 37, false);
#line 29 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(684, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(728, 42, false);
#line 32 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(770, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(814, 38, false);
#line 35 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(896, 39, false);
#line 38 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Año));

#line default
#line hidden
            EndContext();
            BeginContext(935, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(979, 35, false);
#line 41 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Año));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1058, 45, false);
#line 44 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoPlaca));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1147, 41, false);
#line 47 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoPlaca));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1232, 43, false);
#line 50 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdMulta));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1319, 39, false);
#line 53 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdMulta));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1402, 47, false);
#line 56 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroPlaca));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1493, 43, false);
#line 59 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumeroPlaca));

#line default
#line hidden
            EndContext();
            BeginContext(1536, 51, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>    \r\n    ");
            EndContext();
            BeginContext(1587, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f67e1706aba42ef86295ca914888587", async() => {
                BeginContext(1662, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Vehiculos\Details.cshtml"
                                                   WriteLiteral(Model.IdPlaca);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1672, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1678, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc710b87d2b44c4aa4df7d169256d1c", async() => {
                BeginContext(1700, 24, true);
                WriteLiteral("Ver registros ingresados");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1728, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MultasTransito.Models.Vehiculo> Html { get; private set; }
    }
}
#pragma warning restore 1591
