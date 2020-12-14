using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeList.Class
{
    public class TradutorSexo
    {
        public TradutorSexo(string homem, string mulher, string excessao)
        {
            DescricaoMasculino = homem;
            DescricaoFeminino = mulher;
            DescricaoExcessao = excessao;
        }

        public string[] TokensMasculino { get; set; }

        public string[] TokensFeminino { get; set; }

        private string DescricaoMasculino { get; set; }

        private string DescricaoFeminino { get; set; }

        private string DescricaoExcessao { get; set; }

        public string TraduzirSexo(string input)
        {
            if (TokensMasculino.Contains(input))
                return DescricaoMasculino;
            else if(TokensFeminino.Contains(input))
                return DescricaoFeminino;
            else
                return DescricaoExcessao;
        }
    }
}
