#pragma checksum "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f26aad843e61ca3faaf800a0d6eb4dbac83be900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Edit), @"mvc.1.0.view", @"/Views/Stylists/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Edit.cshtml", typeof(AspNetCore.Views_Stylists_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26aad843e61ca3faaf800a0d6eb4dbac83be900", @"/Views/Stylists/Edit.cshtml")]
    public class Views_Stylists_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(60, 45, true);
            WriteLiteral("<h2>Edit the List</h2>\n<h4>Edit this Stylist ");
            EndContext();
            BeginContext(106, 36, false);
#line 7 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml"
                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(142, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(181, 40, false);
#line 10 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.HiddenFor(model => model.StylistId));

#line default
#line hidden
            EndContext();
            BeginContext(227, 34, false);
#line 11 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(267, 35, false);
#line 12 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(304, 68, true);
            WriteLiteral("    <input type= \"submit\" value=\"Save\" class = \"btn btn-Default\" />\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(374, 5, true);
            WriteLiteral("\n<p> ");
            EndContext();
            BeginContext(380, 42, false);
#line 17 "/Users/Guest/Desktop/Eau-Claire/HairSalon/Views/Stylists/Edit.cshtml"
Write(Html.ActionLink("Back to List...","Index"));

#line default
#line hidden
            EndContext();
            BeginContext(422, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
