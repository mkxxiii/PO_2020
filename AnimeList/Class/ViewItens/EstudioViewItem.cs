using AnimeList.Models;
using System.Collections.Generic;

namespace AnimeList.Class.ViewItens
{
    public class EstudioViewItem : IViewItem
    {
        public MensageTransporter Message { get; set; }

        public List<Estudio> Estudios { get; set; }

        public void DevolverMensagemParaView(bool sucesso, string mensagem)
        {
            Message = new MensageTransporter();
            Message.isSucess = sucesso;
            Message.message = mensagem;
        }
    }
}
