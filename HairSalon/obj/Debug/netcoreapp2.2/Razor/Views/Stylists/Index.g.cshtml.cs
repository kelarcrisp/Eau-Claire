#pragma checksum "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f96d5c86978e6285274552fee4ad5f995b3cff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Index), @"mvc.1.0.view", @"/Views/Stylists/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Index.cshtml", typeof(AspNetCore.Views_Stylists_Index))]
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
#line 6 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f96d5c86978e6285274552fee4ad5f995b3cff1", @"/Views/Stylists/Index.cshtml")]
    public class Views_Stylists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(86, 30, true);
            WriteLiteral("\n    <h2>List of Stylist</h2>\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
     if(Model.Count== 0)
    {

#line default
#line hidden
            BeginContext(147, 50, true);
            WriteLiteral("        <h3> No Cuisine has been added yet!!</h3>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(203, 10, true);
            WriteLiteral("\n    <ul>\n");
            EndContext();
#line 16 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
         foreach (Stylist stylist in Model)
        {

#line default
#line hidden
            BeginContext(267, 33, true);
            WriteLiteral("            <li>\n                ");
            EndContext();
            BeginContext(301, 74, false);
#line 19 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
           Write(Html.ActionLink($"{stylist.Name}","Details", new { id= stylist.stylistId}));

#line default
#line hidden
            EndContext();
            BeginContext(375, 19, true);
            WriteLiteral("\n            </li>\n");
            EndContext();
#line 21 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(404, 17, true);
            WriteLiteral("    </ul>\n    <p>");
            EndContext();
            BeginContext(422, 44, false);
#line 23 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
  Write(Html.ActionLink("Add new Stylist", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(466, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(475, 40, false);
#line 24 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(515, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(524, 55, false);
#line 25 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("List of Stylist", "Index", "Stylists"));

#line default
#line hidden
            EndContext();
            BeginContext(579, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.>> Html { get; private set; }
    }
}
#pragma warning restore 1591
