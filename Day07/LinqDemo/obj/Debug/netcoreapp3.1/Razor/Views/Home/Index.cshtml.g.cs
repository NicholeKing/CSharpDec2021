#pragma checksum "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32463753711db53b93cf7de26fd7446e5ed5d5e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\_ViewImports.cshtml"
using LinqDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\_ViewImports.cshtml"
using LinqDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32463753711db53b93cf7de26fd7446e5ed5d5e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1fe10d9f7dafb6eb852759e359fdfcea41da3f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h2>All games</h2>
    <table class=""table table-striped"">
        <tr>
            <th>Title</th>
            <th>Genre</th>
            <th>Price</th>
            <th>Rating</th>
            <th>Platform</th>
            <th># Players</th>
        </tr>
");
#nullable restore
#line 16 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
          
            foreach(Game g in ViewBag.AllGames)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 22 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                    Write(g.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Platform);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.minNumPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 25 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                                      Write(g.maxNumPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
    <h2>All Adventure Games</h2>
    <table class=""table table-striped"">
        <tr>
            <th>Title</th>
            <th>Genre</th>
            <th>Price</th>
            <th>Rating</th>
            <th>Platform</th>
            <th># Players</th>
        </tr>
");
#nullable restore
#line 40 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
          
            foreach(Game g in ViewBag.AdventGames)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 46 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                    Write(g.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Platform);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.minNumPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 49 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                                      Write(g.maxNumPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
    <h2>Games by max number of players</h2>
    <table class=""table table-striped"">
        <tr>
            <th>Title</th>
            <th>Genre</th>
            <th>Price</th>
            <th>Rating</th>
            <th>Platform</th>
            <th># Players</th>
        </tr>
");
#nullable restore
#line 64 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
          
            foreach(Game g in ViewBag.MaxPlayers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 70 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                    Write(g.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Platform);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 73 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.minNumPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 73 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                                      Write(g.maxNumPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 75 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
    <h2>Games under $20</h2>
    <table class=""table table-striped"">
        <tr>
            <th>Title</th>
            <th>Genre</th>
            <th>Price</th>
            <th>Rating</th>
            <th>Platform</th>
            <th># Players</th>
        </tr>
");
#nullable restore
#line 88 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
          
            foreach(Game g in ViewBag.Under20)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 92 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 93 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 94 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                    Write(g.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 95 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 96 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.Platform);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 97 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                   Write(g.minNumPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 97 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
                                      Write(g.maxNumPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 99 "C:\Users\nicho\Desktop\CodingDojo\ClassMaterial\CSharpDec2021\Day07\LinqDemo\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
