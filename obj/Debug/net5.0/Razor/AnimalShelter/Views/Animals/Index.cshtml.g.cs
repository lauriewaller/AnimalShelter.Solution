#pragma checksum "/Users/lauriewaller/Documents/EP/Animals.Solution/AnimalShelter/Views/Animals/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463fb4e7b92025b4ab3c13b198d55fba20353834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.AnimalShelter_Views_Animals_Index), @"mvc.1.0.view", @"/AnimalShelter/Views/Animals/Index.cshtml")]
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
#line 5 "/Users/lauriewaller/Documents/EP/Animals.Solution/AnimalShelter/Views/Animals/Index.cshtml"
using AnimalShelter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463fb4e7b92025b4ab3c13b198d55fba20353834", @"/AnimalShelter/Views/Animals/Index.cshtml")]
    public class AnimalShelter_Views_Animals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnimalShelter.Models.Animal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/lauriewaller/Documents/EP/Animals.Solution/AnimalShelter/Views/Animals/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Animals</h1>\n\n<ul>\n");
#nullable restore
#line 11 "/Users/lauriewaller/Documents/EP/Animals.Solution/AnimalShelter/Views/Animals/Index.cshtml"
   foreach (Animal animal in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 13 "/Users/lauriewaller/Documents/EP/Animals.Solution/AnimalShelter/Views/Animals/Index.cshtml"
   Write(Html.ActionLink($"{animal.Name}", "Details", new { id = animal.AnimalId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \n");
#nullable restore
#line 14 "/Users/lauriewaller/Documents/EP/Animals.Solution/AnimalShelter/Views/Animals/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<p>");
#nullable restore
#line 17 "/Users/lauriewaller/Documents/EP/Animals.Solution/AnimalShelter/Views/Animals/Index.cshtml"
Write(Html.ActionLink("Add new Animal", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnimalShelter.Models.Animal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
