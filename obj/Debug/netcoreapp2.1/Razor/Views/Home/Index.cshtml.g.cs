#pragma checksum "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fb3bd72cc79bbe946dc40ea0afc1868f986b878"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
using MultasTransito.Controllers;

#line default
#line hidden
#line 2 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
using MultasTransito.Models;

#line default
#line hidden
#line 3 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
using MultasTransito.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb3bd72cc79bbe946dc40ea0afc1868f986b878", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c63bbded5c51ccab2361d7644f35dd7e9119b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MultasTransito.Models.Vehiculo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/load-file.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(148, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(175, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb3bd72cc79bbe946dc40ea0afc1868f986b8785909", async() => {
                BeginContext(181, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(303, 23, false);
#line 11 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
      Write(ViewData["Amilcar Bot"]);

#line default
#line hidden
                EndContext();
                BeginContext(326, 28, true);
                WriteLiteral(" - Amilcar Bot</title>    \r\n");
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
            BeginContext(361, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(365, 3118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb3bd72cc79bbe946dc40ea0afc1868f986b8787612", async() => {
                BeginContext(371, 16, true);
                WriteLiteral("    \r\n    \r\n    ");
                EndContext();
                BeginContext(387, 549, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb3bd72cc79bbe946dc40ea0afc1868f986b8788011", async() => {
                    BeginContext(408, 55, true);
                    WriteLiteral("\r\n        <h2>Elije la municipalidad a consultar</h2>\r\n");
                    EndContext();
#line 18 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
         for (var i = 0; i < @ViewBag.NombreMunisLenght; i++)
        {

#line default
#line hidden
                    BeginContext(537, 59, true);
                    WriteLiteral("            <input name=\"Index\" id=\"checks\" type=\"checkbox\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 596, "\"", 606, 1);
#line 20 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
WriteAttributeValue("", 604, i, 604, 2, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(607, 25, true);
                    WriteLiteral(" />\r\n            <strong>");
                    EndContext();
                    BeginContext(633, 22, false);
#line 21 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
               Write(ViewBag.NombreMunis[i]);

#line default
#line hidden
                    EndContext();
                    BeginContext(655, 18, true);
                    WriteLiteral("</strong> <br />\r\n");
                    EndContext();
#line 22 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                    BeginContext(684, 245, true);
                    WriteLiteral("        <div>\r\n            <button type=\"button\" class=\"btn btn-primary\"><strong>Validar</strong></button>\r\n            <input type=\"radio\" class=\"text-right\" />\r\n            <label><strong>Seleccione todos</strong></label>\r\n        </div>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(936, 85, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3 form-horizontal\">\r\n            ");
                EndContext();
                BeginContext(1021, 1805, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb3bd72cc79bbe946dc40ea0afc1868f986b87811675", async() => {
                    BeginContext(1092, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 32 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
                    BeginContext(1156, 495, true);
                    WriteLiteral(@"                    <br />
                    <input type=""text"" class=""form-control"" name=""ingreseNit"" placeholder=""Ingrese Nit"" required autofocus>
                    <br />
                    <input type=""text"" class=""form-control"" name=""tipoPlaca"" placeholder=""Tipo de placa"" required autofocus>
                    <br />
                    <input type=""number"" class=""form-control"" name=""numeroPlaca"" placeholder=""Número de placa"" required autofocus>
                    <br />
");
                    EndContext();
#line 41 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
                }

#line default
#line hidden
                    BeginContext(1670, 19, true);
                    WriteLiteral("            <div>\r\n");
                    EndContext();
#line 43 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
                 using (Html.BeginForm("Index", "Home", FormMethod.Post, new
                {
                    enctype = "multipart/form-data"
                }))
                {
                    

#line default
#line hidden
                    BeginContext(1900, 23, false);
#line 48 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
                    EndContext();
                    BeginContext(1925, 186, true);
                    WriteLiteral("                    <label for=\"file-upload\" class=\"subir\">\r\n                        <i class=\"fas fa-cloud-upload-alt\"></i><strong>Seleccionar archivo</strong>\r\n                        ");
                    EndContext();
                    BeginContext(2111, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6fb3bd72cc79bbe946dc40ea0afc1868f986b87814129", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2147, 179, true);
                    WriteLiteral("\r\n                    </label>\r\n                    <input id=\"file-upload\" onchange=\'cambiar()\' type=\"file\" style=\'display: none;\' />\r\n                    <div id=\"info\"></div>\r\n");
                    EndContext();
#line 59 "C:\Users\Jonathan Villeda\Documents\Propuesta BDG\MultasBot\Views\Home\Index.cshtml"
                    

                }

#line default
#line hidden
                    BeginContext(2631, 188, true);
                    WriteLiteral("            </div>\r\n                <button class=\"btn btn-success btn-lg btn-block\" type=\"button\">\r\n                    <strong>Consultar</strong>\r\n                </button>\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2826, 26, true);
                WriteLiteral("\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(2852, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fb3bd72cc79bbe946dc40ea0afc1868f986b87817677", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2917, 559, true);
                WriteLiteral(@"
        <script>
            $(document).ready(function () {
                function contains(text_one, text_twoo) {
                    return text_one.toLowerCase().indexOf(text_twoo.toLowerCase()) != -1;
                }
                $(""#Search"").keyup(function () {
                    var searchText = $(this).val();
                    $(""#Search"").each(function () {
                        this.toggle(contains($(this).text(), searchText));
                    });
                });
            });
        </script>
    </div>
");
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
            BeginContext(3483, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MultasTransito.Models.Vehiculo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
