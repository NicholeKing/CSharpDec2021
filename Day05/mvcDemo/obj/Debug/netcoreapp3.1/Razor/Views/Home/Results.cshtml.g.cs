#pragma checksum "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\day05\mvcDemo\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b836097107744c9aabf070604c391c9741d4187d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\day05\mvcDemo\Views\_ViewImports.cshtml"
using mvcDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\day05\mvcDemo\Views\_ViewImports.cshtml"
using mvcDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b836097107744c9aabf070604c391c9741d4187d", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c062e1f076296254b3e94d9681dcd041e2183a9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>You submitted your pet!</h1>\r\n\r\n<h2>Pet Name: ");
#nullable restore
#line 5 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\day05\mvcDemo\Views\Home\Results.cshtml"
         Write(Model.petName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Pet Type: ");
#nullable restore
#line 6 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\day05\mvcDemo\Views\Home\Results.cshtml"
         Write(Model.petType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Pet Age: ");
#nullable restore
#line 7 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\day05\mvcDemo\Views\Home\Results.cshtml"
        Write(Model.petAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591
