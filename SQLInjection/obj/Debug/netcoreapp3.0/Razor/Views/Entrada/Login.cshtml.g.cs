#pragma checksum "C:\Users\maro_\Desktop\CSharp\SQLInjection\Views\Entrada\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf1df300aa202152c3ec1a16c189782825be9d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entrada_Login), @"mvc.1.0.view", @"/Views/Entrada/Login.cshtml")]
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
#line 1 "C:\Users\maro_\Desktop\CSharp\SQLInjection\Views\_ViewImports.cshtml"
using SQLInjection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maro_\Desktop\CSharp\SQLInjection\Views\_ViewImports.cshtml"
using SQLInjection.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf1df300aa202152c3ec1a16c189782825be9d01", @"/Views/Entrada/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05ea1ef890e7f9155b325c010c997148dae9981", @"/Views/_ViewImports.cshtml")]
    public class Views_Entrada_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Login</h2>\r\n");
#nullable restore
#line 2 "C:\Users\maro_\Desktop\CSharp\SQLInjection\Views\Entrada\Login.cshtml"
 using (Html.BeginForm("Login", "Entrada", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Usuario: </label>\r\n    <input type=\"text\" id=\"usuario\" name=\"usuario\" /><br />\r\n    <label>Senha: </label>\r\n    <input type=\"text\" id=\"senha\" name=\"senha\" /><br />\r\n    <input type=\"submit\" value=\"Login\" /><br />\r\n    <label>");
#nullable restore
#line 9 "C:\Users\maro_\Desktop\CSharp\SQLInjection\Views\Entrada\Login.cshtml"
      Write(ViewBag.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 10 "C:\Users\maro_\Desktop\CSharp\SQLInjection\Views\Entrada\Login.cshtml"
}

#line default
#line hidden
#nullable disable
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