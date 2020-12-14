using System;
using System.Collections.Generic;

#nullable disable

namespace AnimeList.Models
{
    public partial class Diretor
    {
        public Diretor()
        {
            Animes = new HashSet<Anime>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Sexo { get; set; }

        public virtual ICollection<Anime> Animes { get; set; }
    }
}
