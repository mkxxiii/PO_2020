#pragma checksum "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0f9f0f9c4404056210a8ea409faeadfe4214a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anime_Edit), @"mvc.1.0.view", @"/Views/Anime/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0f9f0f9c4404056210a8ea409faeadfe4214a0", @"/Views/Anime/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1209438b1ef02b6cba37190e9cbaa4e21b37ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Anime_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnimeList.Class.ViewItens.CadastroAnimeViewItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
  
    if (Model.AnimeCadastro.Id == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Criar</h2>\r\n");
#nullable restore
#line 11 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Editar</h2>\r\n");
#nullable restore
#line 15 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Anime</h4>\r\n    <hr />\r\n\r\n    ");
#nullable restore
#line 26 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
Write(Html.HiddenFor(model => model.AnimeCadastro.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 30 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
   Write(Html.LabelFor(model => model.AnimeCadastro.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.EditorFor(model => model.AnimeCadastro.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnimeCadastro.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 38 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
   Write(Html.LabelFor(model => model.AnimeCadastro.NomeRomaji, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.EditorFor(model => model.AnimeCadastro.NomeRomaji, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 41 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnimeCadastro.NomeRomaji, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       if (Model.AnimeCadastro.Id == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 48 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
           Write(Html.LabelFor(model => model.qtdEpisodios, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
               Write(Html.EditorFor(model => model.qtdEpisodios, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 51 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.qtdEpisodios, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 58 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
   Write(Html.LabelFor(model => model.AnimeCadastro.IdTemporada, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.DropDownListFor(model => model.AnimeCadastro.IdTemporada, Model.Temporadas, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 61 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnimeCadastro.IdTemporada, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 66 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
   Write(Html.LabelFor(model => model.AnimeCadastro.IdDiretor, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.DropDownListFor(model => model.AnimeCadastro.IdDiretor, Model.Diretores, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 69 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnimeCadastro.IdDiretor, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 74 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
   Write(Html.LabelFor(model => model.AnimeCadastro.IdEstudio, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 76 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.DropDownListFor(model => model.AnimeCadastro.IdEstudio, Model.Estudios, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 77 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.AnimeCadastro.IdEstudio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <button type=\"submit\" class=\"btn btn-success btn-xs\">Salvar</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 87 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 90 "C:\Users\emanu\Documents\Uniaraxa Victor\AnimeList\AnimeList\Views\Anime\Edit.cshtml"
Write(Html.ActionLink("Retornar a Listagem", "Index", "Anime"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnimeList.Class.ViewItens.CadastroAnimeViewItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
