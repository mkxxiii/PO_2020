using System;
using System.Collections.Generic;

#nullable disable

namespace AnimeList.Models
{
    public partial class Episodio
    {
        public int Id { get; set; }
        public int IdAnime { get; set; }
        public short NumeroEpisodio { get; set; }
        public DateTime DataPrevista { get; set; }
        public DateTime? DataEstreia { get; set; }
        public string NomeEpisodio { get; set; }
        public short? Duracao { get; set; }

        public bool Visualizado { get; set; }

        public virtual Anime IdAnimeNavigation { get; set; }
    }
}
