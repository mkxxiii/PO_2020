using System;
using System.Collections.Generic;

#nullable disable

namespace AnimeList.Models
{
    public partial class AnimeGenero
    {
        public int IdAnime { get; set; }
        public int IdGenero { get; set; }

        public virtual Anime IdAnimeNavigation { get; set; }
        public virtual Genero IdGeneroNavigation { get; set; }
    }
}
