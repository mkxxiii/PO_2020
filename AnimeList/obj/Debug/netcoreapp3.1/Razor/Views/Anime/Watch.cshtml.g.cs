#pragma checksum "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8cf077747d80271564e89a5db0176a5417f3418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_Watch), @"mvc.1.0.view", @"/Views/Anime/Watch.cshtml")]
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
#line 1 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\_ViewImports.cshtml"
using AnimeList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\_ViewImports.cshtml"
using AnimeList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cf077747d80271564e89a5db0176a5417f3418", @"/Views/Anime/Watch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1209438b1ef02b6cba37190e9cbaa4e21b37ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Watch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimeList.Class.ViewItens.EpisodioViewItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
  
    ViewData["Title"] = "Visualizar Anime";
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
 if (Model.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 177, "\"", 279, 5);
            WriteAttributeValue("", 185, "alert", 185, 5, true);
#nullable restore
#line 10 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
WriteAttributeValue(" ", 190, Model.Message.isSucess ? "alert-success" : "alert-danger", 191, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 251, "alert-dismissible", 252, 18, true);
            WriteAttributeValue(" ", 269, "fade", 270, 5, true);
            WriteAttributeValue(" ", 274, "show", 275, 5, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        ");
#nullable restore
#line 11 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
   Write(Model.Message.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <h2>Assistir - ");
#nullable restore
#line 20 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
                  Write(Model.Anime.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 20 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
                                      Write(Model.Anime.NomeRomaji);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <span>");
#nullable restore
#line 24 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
         Write(Html.ActionLink("Voltar", "Index", "Anime", new { @class = "btn btn-warning btn-xs" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
    </div>

    <div class=""row"">
        <table class=""table table-bordred table-striped"">

            <thead>
                <tr>
                    <th>Numero Episodio</th>
                    <th>Titulo</th>
                    <th>Duracao (min)</th>
                    <th>-</th>
                </tr>
            </thead>
            <tbody>

");
#nullable restore
#line 40 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
                 foreach (var item in Model.Episodios)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NumeroEpisodio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NomeEpisodio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Duracao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <p data-placement=\"top\" data-toggle=\"tooltip\" title=\"Assistir\">\r\n                                <span>");
#nullable restore
#line 54 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
                                 Write(Html.ActionLink("Assistir", "WatchEp", "Anime", new { id = item.Id }, item.Visualizado ? new { @class = "btn btn-success btn-xs" } : new { @class = "btn btn-warning btn-xs" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </p>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Watch.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimeList.Class.ViewItens.EpisodioViewItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
