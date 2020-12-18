using AnimeList.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimeList.Class.ViewItens
{
    public class EpisodioViewItem : IViewItem
    {
        public MensageTransporter Message { get; set; }

        public Anime Anime { get; set; }

        public List<Episodio> Episodios { get; set; }

        public void DevolverMensagemParaView(bool sucesso, string mensagem)
        {
            Message = new MensageTransporter();
            Message.isSucess = sucesso;
            Message.message = mensagem;
        }
    }
}
