#pragma checksum "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d45e319c03ce43fbcfd0fe462e95587c1de73ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LeagueTable), @"mvc.1.0.view", @"/Views/Home/LeagueTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LeagueTable.cshtml", typeof(AspNetCore.Views_Home_LeagueTable))]
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
#line 1 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\_ViewImports.cshtml"
using CoreMVCExportPDF;

#line default
#line hidden
#line 2 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\_ViewImports.cshtml"
using CoreMVCExportPDF.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d45e319c03ce43fbcfd0fe462e95587c1de73ac", @"/Views/Home/LeagueTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581dbabb5c76e9ece312f78d83a4208d695555d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LeagueTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreMVCExportPDF.Models.LeagueTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
  
    ViewData["Title"] = "LeagueTable";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(116, 129, true);
            WriteLiteral("<div class=\"jumbotron p-2 text-center border border-primary\">\r\n    <p class=\"h4\">Date created: <span class=\"badge badge-primary\">");
            EndContext();
            BeginContext(246, 40, false);
#line 7 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
                                                             Write(Model.DateCreated.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(286, 82, true);
            WriteLiteral("</span></p><br />\r\n    <p class=\"h4\">Game Week: <span class=\"badge badge-primary\">");
            EndContext();
            BeginContext(369, 14, false);
#line 8 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
                                                          Write(Model.gameWeek);

#line default
#line hidden
            EndContext();
            BeginContext(383, 435, true);
            WriteLiteral(@"</span></p>
</div>
<h1>Completed Game Schedule</h1>
<h4 class=""text-muted"">NBA League 2019-2020</h4>
<table class=""table table-bordered"">
    <thead style=""background-color: #1d428a"">
        <tr class=""text-white"">
            <th scope=""col"">Position</th>
            <th scope=""col"">Team</th>
            <th scope=""col"">Games Played</th>
            <th scope=""col"">Points</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
         for (int i = 0; i < Model.rows.Count; i++)
        {

#line default
#line hidden
            BeginContext(882, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(933, 22, false);
#line 25 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
                           Write(Model.rows[i].position);

#line default
#line hidden
            EndContext();
            BeginContext(955, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(983, 18, false);
#line 26 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
               Write(Model.rows[i].club);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1029, 22, false);
#line 27 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
               Write(Model.rows[i].numGames);

#line default
#line hidden
            EndContext();
            BeginContext(1051, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1079, 20, false);
#line 28 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
               Write(Model.rows[i].points);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "C:\Users\groov\OneDrive\Desktop\CoreMVCExportPDF\CoreMVCExportPDF\Views\Home\LeagueTable.cshtml"
        }

#line default
#line hidden
            BeginContext(1136, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreMVCExportPDF.Models.LeagueTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
