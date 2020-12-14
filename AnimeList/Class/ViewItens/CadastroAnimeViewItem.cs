using AnimeList.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimeList.Class.ViewItens
{
    public class CadastroAnimeViewItem : IViewItem
    {
        public MensageTransporter Message { get; set; }

        public List<SelectListItem> Temporadas { get; set; }

        public List<SelectListItem> Diretores { get; set; }

        public List<SelectListItem> Estudios { get; set; }

        public List<SelectListItem> Generos { get; set; }

        public void DevolverMensagemParaView(bool sucesso, string mensagem)
        {
            Message = new MensageTransporter();
            Message.isSucess = sucesso;
            Message.message = mensagem;
        }
    }
}
