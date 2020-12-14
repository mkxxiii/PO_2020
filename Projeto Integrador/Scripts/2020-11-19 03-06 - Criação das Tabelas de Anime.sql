create table AnimeList.Temporada
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
    Ano char(4) NOT NULL,
    Estacao CHAR(1) NOT NULL
)

INSERT INTO AnimeList.Temporada(Ano,Estacao)
VALUES
('2020', 'V'),
('2020', 'P'),
('2020', 'O'),
('2020', 'I'),
('2021', 'V'),
('2021', 'P'),
('2021', 'O'),
('2021', 'I')

CREATE TABLE AnimeList.Genero
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
    Descricao varchar(100) NOT NULL
)

INSERT INTO AnimeList.Genero (Descricao)
VALUES
('Shoujo'),
('Shounen'),
('Josei'),
('Seinen'),
('Ação'),
('Comédia'),
('Romance'),
('Isekai'),
('Harém'),
('Suspense'),
('Terror'),
('Sci-Fi')

create table AnimeList.Diretor 
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
    Nome varchar(100) NOT NULL,
    DataNascimento date NULL,
    Sexo char(1) NULL
)

INSERT INTO AnimeList.Diretor(Nome, DataNascimento, Sexo)
values('Mitsue Yamazaki', NULL, 'F')

create table AnimeList.Estudio 
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
    Nome varchar(100) NOT NULL
)

INSERT INTO AnimeList.Estudio(Nome)
values('Doga Kobo')

CREATE table AnimeList.Anime
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
    Nome varchar(500) NOT NULL,
    NomeRomaji varchar(500) NULL,
    IdTemporada int FOREIGN KEY REFERENCES AnimeList.Temporada(Id) NOT NULL,
    IdDiretor int FOREIGN KEY REFERENCES AnimeList.Diretor(Id) NOT NULL,
    IdEstudio int FOREIGN KEY REFERENCES AnimeList.Estudio(Id) NOT NULL
)

INSERT INTO AnimeList.Anime(Nome, NomeRomaji, IdTemporada, IdDiretor, IdEstudio)
VALUES ('Maoujou de Oyasumi', 'Maoujou de Oyasumi', 3, 1, 1)

CREATE TABLE AnimeList.Anime_Genero
(
    IdAnime int FOREIGN KEY REFERENCES AnimeList.Anime(Id) NOT NULL,
    IdGenero int FOREIGN KEY REFERENCES AnimeList.Genero(Id) NOT NULL,
    PRIMARY KEY(IdAnime,IdGenero)
)

CREATE TABLE AnimeList.Episodio
(
    Id INT PRIMARY KEY IDENTITY NOT NULL,
    IdAnime int FOREIGN KEY REFERENCES AnimeList.Anime(Id) NOT NULL,
    NumeroEpisodio SMALLINT NOT NULL,
    DataPrevista date NOT NULL,
    DataEstreia date NULL,
    NomeEpisodio varchar(200) NULL,
    Duracao SMALLINT NULL
)

INSERT INTO AnimeList.Episodio
(IdAnime,NumeroEpisodio,DataPrevista,DataEstreia,NomeEpisodio,Duracao)
VALUES
(1,1,'2020-10-01','2020-10-10','Ep 1',23),
(1,2,'2020-10-01',NULL,'Ep 2',23),
(1,3,'2020-10-01',NULL,'Ep 3',23),
(1,4,'2020-10-01',NULL,'Ep 4',23),
(1,5,'2020-10-01',NULL,'Ep 5',23),
(1,6,'2020-10-01',NULL,'Ep 6',23),
(1,7,'2020-10-01',NULL,'Ep 7',23),
(1,8,'2020-10-01',NULL,'Ep 8',23),
(1,9,'2020-10-01',NULL,'Ep 9',23),
(1,10,'2020-10-01',NULL,'Ep 10',23),
(1,11,'2020-10-01',NULL,'Ep 11',23),
(1,12,'2020-10-01',NULL,'Ep 12',23)

INSERT INTO AnimeList.Anime_Genero(IdAnime,IdGenero)
VALUES
(1,2),
(1,6)
