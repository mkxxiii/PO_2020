using System;
using System.Collections.Generic;

#nullable disable

namespace AnimeList.Models
{
    public partial class Genero
    {
        public Genero()
        {
            AnimeGeneros = new HashSet<AnimeGenero>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<AnimeGenero> AnimeGeneros { get; set; }
    }
}
