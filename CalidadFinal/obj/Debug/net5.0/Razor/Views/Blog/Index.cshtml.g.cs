#pragma checksum "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5f7bdda0af36041e261c21603a4109fa86ec6e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\_ViewImports.cshtml"
using CalidadFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\_ViewImports.cshtml"
using CalidadFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f7bdda0af36041e261c21603a4109fa86ec6e8", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c74487ba2303f73b4ff679e50a7b8b56341495", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #0c002e"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5f7bdda0af36041e261c21603a4109fa86ec6e83610", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"" integrity=""sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI"" crossorigin=""anonymous""></script>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5f7bdda0af36041e261c21603a4109fa86ec6e85014", async() => {
                WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-7\">\r\n");
#nullable restore
#line 11 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
         foreach (var item in @Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div  style=\"background-color: #adb5bd\" class=\"card\">\r\n                <h3 class=\"card-header\">\r\n                    <a style=\"color: #0b2e13\"");
                BeginWriteAttribute("href", " href=\"", 744, "\"", 780, 2);
                WriteAttributeValue("", 751, "/Post/DetallePost?id=", 751, 21, true);
#nullable restore
#line 15 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
WriteAttributeValue("", 772, item.Id, 772, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <p style = \"font-family:Arial, Helvetica, sans-serif;\">\r\n                       ");
#nullable restore
#line 17 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
                  Write(item.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n                        \r\n                    </a>\r\n                </h3>\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 23 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
                     foreach (var details in ViewBag.detalles)
                    {
                        if (details.IdNota == item.Id)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-3\">\r\n                                <span style=\"color: #0b2e13 \" class=\"badge badge-success\">");
#nullable restore
#line 28 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
                                                                                           foreach (var item1 in @ViewBag.etiquetas)
                                                                                          {
                                                                                              if (details.IdEtiqueta==item1.Id)
                                                                                              {
                                                                                                  

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
                                                                                             Write(item1.Nombre);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
                                                                                                               
                                                                                              }
                                                                                          }

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span> 
                                <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-tag-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M2 1a1 1 0 0 0-1 1v4.586a1 1 0 0 0 .293.707l7 7a1 1 0 0 0 1.414 0l4.586-4.586a1 1 0 0 0 0-1.414l-7-7A1 1 0 0 0 6.586 1H2zm4 3.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0z""/>
                                </svg>
                            </div>
");
#nullable restore
#line 39 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
                        }
                      
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 44 "D:\Upn 2020-2\Calidad\ExamenFinal\CalidadFinal\CalidadFinal\Views\Blog\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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