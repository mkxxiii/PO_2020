using System;
using System.Collections.Generic;

#nullable disable

namespace AnimeList.Models
{
    public partial class Anime
    {
        public Anime()
        {
            AnimeGeneros = new HashSet<AnimeGenero>();
            Episodios = new HashSet<Episodio>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeRomaji { get; set; }
        public int IdTemporada { get; set; }
        public int IdDiretor { get; set; }
        public int IdEstudio { get; set; }

        public virtual Diretor IdDiretorNavigation { get; set; }
        public virtual Estudio IdEstudioNavigation { get; set; }
        public virtual Temporadum IdTemporadaNavigation { get; set; }
        public virtual ICollection<AnimeGenero> AnimeGeneros { get; set; }
        public virtual ICollection<Episodio> Episodios { get; set; }
    }
}
