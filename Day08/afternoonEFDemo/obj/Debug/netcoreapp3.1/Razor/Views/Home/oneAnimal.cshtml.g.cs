#pragma checksum "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\Home\oneAnimal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5458978a23de523638a5dc8cb8b02e9332391043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_oneAnimal), @"mvc.1.0.view", @"/Views/Home/oneAnimal.cshtml")]
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
#line 1 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\_ViewImports.cshtml"
using afternoonEFDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\_ViewImports.cshtml"
using afternoonEFDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5458978a23de523638a5dc8cb8b02e9332391043", @"/Views/Home/oneAnimal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a315dbfcae209e2a16ed09990cc2169e3a134e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_oneAnimal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Animal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 2 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\Home\oneAnimal.cshtml"
Write(Model.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Number of legs: ");
#nullable restore
#line 3 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\Home\oneAnimal.cshtml"
               Write(Model.numLegs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Is a mammal? ");
#nullable restore
#line 4 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\Home\oneAnimal.cshtml"
                   
    if(Model.isMammal)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>Yes</span>\r\n");
#nullable restore
#line 8 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\Home\oneAnimal.cshtml"
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>No</span>\r\n");
#nullable restore
#line 10 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\Home\oneAnimal.cshtml"
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 219, "\"", 249, 2);
            WriteAttributeValue("", 226, "/delete/", 226, 8, true);
#nullable restore
#line 12 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\Home\oneAnimal.cshtml"
WriteAttributeValue("", 234, Model.AnimalId, 234, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 288, "\"", 316, 2);
            WriteAttributeValue("", 295, "/edit/", 295, 6, true);
#nullable restore
#line 13 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day08\afternoonEFDemo\Views\Home\oneAnimal.cshtml"
WriteAttributeValue("", 301, Model.AnimalId, 301, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Edit</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Animal> Html { get; private set; }
    }
}
#pragma warning restore 1591
