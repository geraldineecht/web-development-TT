#pragma checksum "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4ffd4ac8e764987f572dd92328994819911a623"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Login.Pages.Pages_Admin_view), @"mvc.1.0.razor-page", @"/Pages/Admin_view.cshtml")]
namespace Login.Pages
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
#line 1 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\_ViewImports.cshtml"
using Login;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ffd4ac8e764987f572dd92328994819911a623", @"/Pages/Admin_view.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b60792a64df811a7c7ac641c3c007b2ece0a158", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_view : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/adminView.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("simple-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(@"bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full pl-10 p-2.5  dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gray-900"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4ffd4ac8e764987f572dd92328994819911a6236900", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Aplicantes</title>


    <script src=""https://cdn.tailwindcss.com""></script>
    <link rel=""stylesheet"" href=""https://unpkg.com/flowbite@1.4.5/dist/flowbite.min.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4ffd4ac8e764987f572dd92328994819911a6237525", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\" href=\"https://fonts.sandbox.google.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@20..48,100..700,0..1,-50..200\" />\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4ffd4ac8e764987f572dd92328994819911a6239581", async() => {
                WriteLiteral(@"

    <div class=""-body-container bg-primary bg-gray-900"">
        <header class=""header-container headerScroll headerScrollTransparent header-bg bg-gray-900 stiky"" id=""header-id"">
            <nav class=""navbar container mx-auto"" id=""navbar-id"">

                <div class=""nav-container"">
                    <a href=""#"" id=""nav-logo""><img class=""img-attributes"" src=""/img/LogoBlanco.png""");
                BeginWriteAttribute("alt", " alt=\"", 1112, "\"", 1118, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>

                    <div class=""navbar-toggle"" id=""mobile-menu"">
                        <span class=""bar""></span>
                        <span class=""bar""></span>
                        <span class=""bar last-bar""></span>
                    </div>

                    <ul class=""nav-menu"">
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-links"">Industries</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-links"">Solutions</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-links"">Insights & News</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#"" class=""nav-links"">About us</a>
                        </li>
                        <li");
                BeginWriteAttribute("class", " class=\"", 2066, "\"", 2074, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <a href=""#"" class=""nav-links pd-r-0"">
                                <span class=""material-symbols-outlined"">
                                    search
                                </span>
                            </a>
                        </li>
                    </ul>
                </div>

            </nav>
        </header>
    </div>


    <div class=""container mx-auto -height-90"" id=""TITLE-Y-SEARCH"">
        <div class=""px-6 py-6"">
            <h5 class=""text-3xl font-bold leading-none text-gray-900 dark:text-white text-spacing text-gray-50"">Aplicantes</h5>
        </div>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4ffd4ac8e764987f572dd92328994819911a62312213", async() => {
                    WriteLiteral(@"
            <div class=""flex px-6 pb-4"">
                <label for=""simple-search"" class=""sr-only"">Search</label>
                <div class=""relative w-full"">
                    <div class=""flex absolute inset-y-0 left-0 items-center pl-3 pointer-events-none"">
                        <svg class=""w-5 h-5 text-gray-500 dark:text-gray-400"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z"" clip-rule=""evenodd""></path></svg>
                    </div>
                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e4ffd4ac8e764987f572dd92328994819911a62313150", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 77 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchTerm);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                </div>
                <button type=""submit"" class=""p-2.5 ml-2 text-sm font-medium text-white bg-blue-500 rounded-lg border border-blue-700 hover:bg-blue-600 focus:ring-4 focus:outline-none focus:ring-blue-300 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800""><svg class=""w-5 h-5"" fill=""none"" stroke=""currentColor"" viewBox=""0 0 24 24"" xmlns=""http://www.w3.org/2000/svg""><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z""></path></svg></button>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <div class=""flex px-6"" id=""DROPDOWNS"">
            <div class=""flex gap-2"">
                <div>
                    <button id=""dropdownDefault"" data-dropdown-toggle=""dropdown"" class=""text-white bg-blue-500 hover:bg-blue-600 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-4 py-2.5 text-center inline-flex items-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800"" type=""button"">Perfiles<svg class=""w-4 h-4 ml-2"" fill=""none"" stroke=""currentColor"" viewBox=""0 0 24 24"" xmlns=""http://www.w3.org/2000/svg""><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M19 9l-7 7-7-7""></path></svg></button>
                    <!-- Dropdown menu -->
                    <div id=""dropdown"" class=""z-10 hidden bg-white divide-y divide-gray-100 rounded shadow w-44 dark:bg-gray-700"">
                        <ul class=""py-1 text-sm text-gray-700 dark:text-gray-200"" aria-labelledby=""dropdownDefault"">
                            <li>
      ");
                WriteLiteral(@"                          <a href=""/Admin_view?SearchTerm=Data Scientist"" class=""block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white"">Data Scientist</a>
                            </li>
                            <li>
                                <a href=""/Admin_view?SearchTerm=Data Engineer"" class=""block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white"">Data Engineer</a>
                            </li>
                            <li>
                                <a href=""/Admin_view?SearchTerm=.Net Developer"" class=""block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white"">.Net Developer</a>
                            </li>
                            <li>
                                <a href=""/Admin_view?SearchTerm=Java Developer"" class=""block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white"">Java Developer</a>
                            </li>
                            <li>
        ");
                WriteLiteral(@"                        <a href=""/Admin_view?SearchTerm=QA Automation"" class=""block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white"">QA Automation</a>
                            </li>
                            <li>
                                <a href=""/Admin_view?SearchTerm=Front End Developer"" class=""block px-4 py-2 hover:bg-gray-100 dark:hover:bg-gray-600 dark:hover:text-white"">Front End Developer</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>




        <div class=""py-4 px-6"">

            <div class=""relative overflow-x-auto shadow-md sm:rounded-lg"">
                <table class=""w-full text-sm text-left text-gray-500 dark:text-gray-400"">
                    <thead class=""text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400"">
                        <tr>
                            <th scope=""col"" class=""p-4"">
             ");
                WriteLiteral(@"                   <div class=""flex items-center"">
                                    <input id=""checkbox-all"" type=""checkbox"" class=""w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600"">
                                    <label for=""checkbox-all"" class=""sr-only"">checkbox</label>
                                </div>
                            </th>
                            <th scope=""col"" class=""px-6 py-3"">
                                Nombre
                            </th>
                            <th scope=""col"" class=""px-6 py-3"">
                                Perfil
                            </th>
                            <th scope=""col"" class=""px-6 py-3"">
                                Puntuación
                            </th>
                            <th scope=""col"" class=""px-6 py-3"">
                                Tiempo
         ");
                WriteLiteral(@"                   </th>
                            <th scope=""col"" class=""px-6 py-3"">
                                CV
                            </th>
                            <th scope=""col"" class=""px-6 py-3"">
                                <span class=""sr-only"">Edit</span>
                            </th>
                        </tr>
                    </thead>

                    <tbody>

");
#nullable restore
#line 152 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"
                         foreach (var item in Model.ListaUsuarios)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <tr class=""bg-white border-b dark:bg-gray-800 dark:border-gray-700 hover:bg-gray-50 dark:hover:bg-gray-600"">
                                <td class=""w-4 p-4"">
                                    <div class=""flex items-center"">
                                        <input id=""checkbox-table-1"" type=""checkbox"" class=""w-4 h-4 text-blue-600 bg-gray-100 border-gray-300 rounded focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600"">
                                        <label for=""checkbox-table-1"" class=""sr-only"">checkbox</label>
                                    </div>
                                </td>
                                <th scope=""row"" class=""px-6 py-4 font-medium text-gray-900 dark:text-white whitespace-nowrap"">
                                    ");
#nullable restore
#line 162 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"
                               Write(Html.DisplayFor(modelItem => item.NombreUsuario));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 163 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ApellidoPaterno));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 164 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ApellidoMaterno));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </th>\r\n                                <td class=\"px-6 py-4\">\r\n                                    ");
#nullable restore
#line 167 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TipoPerfil));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </td>
                                <td class=""px-6 py-4"">
                                    100
                                </td>
                                <td class=""px-6 py-4"">
                                    30:16 min
                                </td>
                                <td class=""px-6 py-4"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 10654, "\"", 10719, 2);
                WriteAttributeValue("", 10661, "/CV?idAplicante=", 10661, 16, true);
#nullable restore
#line 176 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"
WriteAttributeValue("", 10677, Html.DisplayFor(modelItem => item.idUser), 10677, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded"">
                                    Mostrar CV
                                    </a>
                                </td>
                                <td class=""px-6 py-4 text-right"">
                                    <a href=""#"" class=""font-medium text-blue-600 dark:text-blue-500 hover:underline"" target=""_blank"">Edit</a>
                                </td>
                            </tr>
");
#nullable restore
#line 184 "C:\Users\aleja\Documents\GitHub\web-development-TT\AplicacionWeb\ASP.net\Login\Login\Pages\Admin_view.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </tbody>
                </table>
                
            </div>

        </div>


        <div class=""px-6 -pb-6"">
            <div class=""page-selection"">
                <div class=""page-enum-container"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 11584, "\"", 11591, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""generic-btn hover:bg-gray-200 dark:hover:bg-gray-600"">
                            <svg class=""mr-2 w-5 h-5"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M7.707 14.707a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414l4-4a1 1 0 011.414 1.414L5.414 9H17a1 1 0 110 2H5.414l2.293 2.293a1 1 0 010 1.414z"" clip-rule=""evenodd""></path></svg>
                            <p>Anterior</p>
                        </div>
                    </a>
                    <a");
                BeginWriteAttribute("href", " href=\"", 12140, "\"", 12147, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"generic-btn bg-blue-500 text-white hover:bg-blue-600\">\r\n                            <p>1</p>\r\n                        </div>\r\n                    </a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 12361, "\"", 12368, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"generic-btn hover:bg-gray-200 dark:hover:bg-gray-600\">\r\n                            <p>2</p>\r\n                        </div>\r\n                    </a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 12582, "\"", 12589, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"generic-btn hover:bg-gray-200 dark:hover:bg-gray-600\">\r\n                            <p>3</p>\r\n                        </div>\r\n                    </a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 12803, "\"", 12810, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"generic-btn hover:bg-gray-200 dark:hover:bg-gray-600\">\r\n                            <p>4</p>\r\n                        </div>\r\n                    </a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 13024, "\"", 13031, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"generic-btn hover:bg-gray-200 dark:hover:bg-gray-600\">\r\n                            <p>5</p>\r\n                        </div>\r\n                    </a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 13245, "\"", 13252, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <div class=""generic-btn hover:bg-gray-200 dark:hover:bg-gray-600"">
                            <p>Siguiente</p>
                            <svg class=""ml-2 w-5 h-5"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M12.293 5.293a1 1 0 011.414 0l4 4a1 1 0 010 1.414l-4 4a1 1 0 01-1.414-1.414L14.586 11H3a1 1 0 110-2h11.586l-2.293-2.293a1 1 0 010-1.414z"" clip-rule=""evenodd""></path></svg>
                        </div>
                    </a>

                </div>
            </div>
        </div>
    </div>


    <footer class=""p-4 bg-gray-900 md:flex md:items-center md:justify-center md:p-6 dark:bg-gray-900   flex justify-center"">
        <span class=""text-sm text-gray-500 sm:text-center dark:text-gray-400"">
            Atos SE 2022 all rights reserved
        </span>

    </footer>

    <script src=""https://unpkg.com/flowbite@1.4.5/dist/flowbite.js""></script>
    <script src=""/CV/app.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Atos.Pages.Admin_viewModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Atos.Pages.Admin_viewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Atos.Pages.Admin_viewModel>)PageContext?.ViewData;
        public Atos.Pages.Admin_viewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
