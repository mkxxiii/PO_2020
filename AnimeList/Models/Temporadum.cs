using System;
using System.Collections.Generic;

#nullable disable

namespace AnimeList.Models
{
    public partial class Temporadum
    {
        public Temporadum()
        {
            Animes = new HashSet<Anime>();
        }

        public int Id { get; set; }
        public string Ano { get; set; }
        public string Estacao { get; set; }

        public virtual ICollection<Anime> Animes { get; set; }
    }
}
