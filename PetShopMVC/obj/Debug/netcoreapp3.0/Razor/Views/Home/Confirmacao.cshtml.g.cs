#pragma checksum "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\Home\Confirmacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f9544036744600c0a1dc9567e401c2f077cea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmacao), @"mvc.1.0.view", @"/Views/Home/Confirmacao.cshtml")]
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
#line 1 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\_ViewImports.cshtml"
using PetShopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\_ViewImports.cshtml"
using PetShopMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f9544036744600c0a1dc9567e401c2f077cea2", @"/Views/Home/Confirmacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263d1c03a15a145af01c395be45e655e9f5b01f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cadastro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agendamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<h2>Dados cadastrados: </h2>

<table>
    <thead>
        <tr>
            <th>Nome </th>
            <th>Telefone</th>
            <th>Data</th>
            <th>Animal</th>  
            <th>Necessidade</th>  
        </tr>
    </thead>
    
    <tbody>         
");
#nullable restore
#line 18 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\Home\Confirmacao.cshtml"
             foreach (Cadastro a in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 21 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\Home\Confirmacao.cshtml"
           Write(a.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 22 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\Home\Confirmacao.cshtml"
           Write(a.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\Home\Confirmacao.cshtml"
           Write(a.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\Home\Confirmacao.cshtml"
           Write(a.Animal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\Home\Confirmacao.cshtml"
           Write(a.Necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>              \r\n                          \r\n        </tr>   \r\n");
#nullable restore
#line 28 "C:\Users\maro_\Desktop\CSharp\PetShopMVC\Views\Home\Confirmacao.cshtml"
            }             

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n    </tbody>\r\n</table>\r\n\r\n<p> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7f9544036744600c0a1dc9567e401c2f077cea25412", async() => {
                WriteLiteral(" Realizar novo cadastro");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\r\n        \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cadastro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
