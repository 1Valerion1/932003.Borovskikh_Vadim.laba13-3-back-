#pragma checksum "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "799ff4f27574d02bf539890a9247ee7f70e355ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_QuizResult), @"mvc.1.0.view", @"/Views/Mockups/QuizResult.cshtml")]
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
#line 1 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\_ViewImports.cshtml"
using WebBack3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
using WebBack3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"799ff4f27574d02bf539890a9247ee7f70e355ad", @"/Views/Mockups/QuizResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e14a305214765624e9704f61aa646de717d4b42", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_QuizResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Questions>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
   int i = 0;
    ViewData["Title"] = "Quiz Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<h2>Right Answers ");
#nullable restore
#line 7 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
             Write(IdentityMap.rights);

#line default
#line hidden
#nullable disable
            WriteLiteral(" out ");
#nullable restore
#line 7 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
                                     Write(IdentityMap.alls);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 8 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
 foreach (Questions a in Model)
{
    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 11 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 11 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
        Write(a.problem);

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 11 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
                     Write(a.yanswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 12 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
}    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\vvadi\Documents\GitHub\932003.Borovskikh_Vadim.laba13(3 back)\WebBack3\Views\Mockups\QuizResult.cshtml"
  IdentityMap.Up();

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Questions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
