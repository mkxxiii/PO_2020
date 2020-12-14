using System;
using System.Collections.Generic;

#nullable disable

namespace AnimeList.Models
{
    public partial class Estudio
    {
        public Estudio()
        {
            Animes = new HashSet<Anime>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Anime> Animes { get; set; }
    }
}
