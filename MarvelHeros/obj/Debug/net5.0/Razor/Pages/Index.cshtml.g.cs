#pragma checksum "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc96d19206c72ab284f34881eaf2e8941e6a914a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MarvelHeros.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MarvelHeros.Pages
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
#line 1 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\_ViewImports.cshtml"
using MarvelHeros;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc96d19206c72ab284f34881eaf2e8941e6a914a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d2b75e1cb95ecc33ff537a7b05ee9e389b1361", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
  
    ViewData["Title"] = "Marvel Heros Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
  
    var quote = "The future depends on what you do today. - Mahatma Gandhi";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 9 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
    Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
  
    quote = "Hate cannot drive out hate, only love can do that. - Martin Luther King, Jr.";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>");
#nullable restore
#line 14 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
Write(quote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
#nullable restore
#line 17 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
  
    var pokemonCards = new [] {
        new {
            name = "pikachu",
            type = "electric",
            level = 5
        },
        new {
            name = "eevee",
            type = "normal",
            level = 7
        }, 
        new {
            name = "charmander",
            type = "fire",
            level = 3
        }
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
 for (var i = 0; i < pokemonCards.Length; i++)
{
    var pokemon = pokemonCards[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("Pokemon name: ");
#nullable restore
#line 40 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
                   Write(pokemon.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 40 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
                                                 
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h4>Hello World!</h4>\r\n    <p>The current time on the server is ");
#nullable restore
#line 46 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
                                    Write(Model.todaysDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
            WriteLiteral("@Username</p>\r\n    <p>email me at amillerman01");
            WriteLiteral("@stclaircollege.ca</p>\r\n    &nbsp;\r\n    &lt;\r\n    <p>");
#nullable restore
#line 51 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
  Write(DateTime.IsLeapYear(2017));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Last week this time: ");
#nullable restore
#line 52 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
                        Write(DateTime.Now - TimeSpan.FromDays(7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    ");
#nullable restore
#line 53 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Index.cshtml"
Write("<span>Hello span</span>");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
