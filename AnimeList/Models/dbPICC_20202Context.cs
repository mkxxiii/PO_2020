using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AnimeList.Models
{
    public partial class dbPICC_20202Context : DbContext
    {
        public dbPICC_20202Context()
        {
        }

        public dbPICC_20202Context(DbContextOptions<dbPICC_20202Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Anime> Animes { get; set; }
        public virtual DbSet<AnimeGenero> AnimeGeneros { get; set; }
        public virtual DbSet<Diretor> Diretors { get; set; }
        public virtual DbSet<Episodio> Episodios { get; set; }
        public virtual DbSet<Estudio> Estudios { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Temporadum> Temporada { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=201.62.57.93;Database=dbPICC_20202;User Id=laboratorio;Password=@laboratorio*;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Anime>(entity =>
            {
                entity.ToTable("Anime", "AnimeList");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NomeRomaji)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDiretorNavigation)
                    .WithMany(p => p.Animes)
                    .HasForeignKey(d => d.IdDiretor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Anime__IdDiretor__4D5F7D71");

                entity.HasOne(d => d.IdEstudioNavigation)
                    .WithMany(p => p.Animes)
                    .HasForeignKey(d => d.IdEstudio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Anime__IdEstudio__4E53A1AA");

                entity.HasOne(d => d.IdTemporadaNavigation)
                    .WithMany(p => p.Animes)
                    .HasForeignKey(d => d.IdTemporada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Anime__IdTempora__4C6B5938");
            });

            modelBuilder.Entity<AnimeGenero>(entity =>
            {
                entity.HasKey(e => new { e.IdAnime, e.IdGenero })
                    .HasName("PK__Anime_Ge__89F4BC6ECC3C0C4C");

                entity.ToTable("Anime_Genero", "AnimeList");

                entity.HasOne(d => d.IdAnimeNavigation)
                    .WithMany(p => p.AnimeGeneros)
                    .HasForeignKey(d => d.IdAnime)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Anime_Gen__IdAni__5224328E");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.AnimeGeneros)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Anime_Gen__IdGen__531856C7");
            });

            modelBuilder.Entity<Diretor>(entity =>
            {
                entity.ToTable("Diretor", "AnimeList");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Episodio>(entity =>
            {
                entity.ToTable("Episodio", "AnimeList");

                entity.Property(e => e.DataEstreia).HasColumnType("date");

                entity.Property(e => e.Visualizado).HasColumnType("bit");

                entity.Property(e => e.DataPrevista).HasColumnType("date");

                entity.Property(e => e.NomeEpisodio)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAnimeNavigation)
                    .WithMany(p => p.Episodios)
                    .HasForeignKey(d => d.IdAnime)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Episodio__IdAnim__55F4C372");
            });

            modelBuilder.Entity<Estudio>(entity =>
            {
                entity.ToTable("Estudio", "AnimeList");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.ToTable("Genero", "AnimeList");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Temporadum>(entity =>
            {
                entity.ToTable("Temporada", "AnimeList");

                entity.Property(e => e.Ano)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Estacao)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
