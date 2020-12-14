using AnimeList.Models;
using System.Collections.Generic;

namespace AnimeList.Class.ViewItens
{
    public class DiretorViewItem : IViewItem
    {
        public DiretorViewItem()
        {
            tradutorSexo = new TradutorSexo("Masculino", "Feminino", "Não Informado");

            tradutorSexo.TokensFeminino = new[] { "F", "f" };
            tradutorSexo.TokensMasculino = new[] { "M", "m" };
        }

        public MensageTransporter Message { get; set; }

        public List<Diretor> Diretores { get; set; }

        public TradutorSexo tradutorSexo { get; }

        public void DevolverMensagemParaView(bool sucesso, string mensagem)
        {
            Message = new MensageTransporter();
            Message.isSucess = sucesso;
            Message.message = mensagem;
        }
    }
}
