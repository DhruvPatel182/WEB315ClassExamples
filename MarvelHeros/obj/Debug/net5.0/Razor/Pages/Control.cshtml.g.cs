#pragma checksum "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8901c6aa5d895cefc695bbaa25055f10dd8332f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MarvelHeros.Pages.Pages_Control), @"mvc.1.0.razor-page", @"/Pages/Control.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8901c6aa5d895cefc695bbaa25055f10dd8332f7", @"/Pages/Control.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d2b75e1cb95ecc33ff537a7b05ee9e389b1361", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Control : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
  
    ViewData["Title"] = "Week 3 page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Control page content goes here</p>\r\n\r\n");
#nullable restore
#line 9 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
  
    var value = 10001;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
 if (value % 2 == 0) // 7 / 2 = 3, 7 % 2 = 1, 13 / 7 = 1, 13 % 7 = 6, 6 % 2 = 0
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>the value variable is even</p>\r\n");
#nullable restore
#line 15 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
}
else if (value >= 9000)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>the value variable is OVER 9000!</p>\r\n");
#nullable restore
#line 19 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>The value variable is neither even nor over 9000 :(</p>\r\n");
#nullable restore
#line 23 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
 switch (value)
{
    case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>The value is number one!</p>\r\n");
#nullable restore
#line 28 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
        break;
    case 9001:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>it\'s BARELY over 9000!</p>\r\n");
#nullable restore
#line 31 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
        break;
    default:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>the number wasn\'t fun</p>\r\n");
#nullable restore
#line 34 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
        break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
 try
{
    throw new InvalidOperationException ("You did an invalid operation");
}
catch (Exception ex)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>the exception message: ");
#nullable restore
#line 43 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
                         Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 44 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
}
finally
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>This happens after the try catch finishes</p>\r\n");
#nullable restore
#line 48 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 52 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
 using(Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        Email: <input type=\"email\" id=\"Email\"");
            BeginWriteAttribute("value", " value=\"", 983, "\"", 991, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button>Register</button>\r\n    </div>\r\n");
#nullable restore
#line 58 "D:\Teaching LOCAL\WEB 315\Class Example\WEB315ClassExamples\MarvelHeros\Pages\Control.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ControlModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ControlModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ControlModel>)PageContext?.ViewData;
        public ControlModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
