using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Services;
using Moq;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace CopaFilmes.Test
{
    [TestFixture]
    public class ChampionshipServiceTests
    {
        List<Movie> _allMovies;
        List<Movie> _allMoviesOrdered;
        List<Movie> _quarterFinalsMovies;
        List<Movie> _semiFinalsMovies;

        List<ChampionshipResult> _championshipResult;

        IChampionshipService _service;

        Mock<IMatchService> _matchService;
        Mock<ChampionshipService> _serviceMock;

        [SetUp]
        public void Setup()
        {
            _matchService = new Mock<IMatchService>();
            _serviceMock = new Mock<ChampionshipService>(_matchService.Object);

            _service = _serviceMock.Object;

            _allMovies = new List<Movie>()
            {
                new Movie{Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5},
                new Movie{Id = "tt4881806", Titulo = "Jurassic World: Reino Ameaçado", Ano = 2018, Nota = 6.7},
                new Movie{Id = "tt5164214", Titulo = "Oito Mulheres e um Segredo", Ano = 2018, Nota = 6.3},
                new Movie{Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8},
                new Movie{Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8},
                new Movie{Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1},
                new Movie{Id = "tt3778644", Titulo = "Han Solo: Uma História Star Wars", Ano = 2018, Nota = 7.2},
                new Movie{Id = "tt3501632", Titulo = "Thor: Ragnarok", Ano = 2017, Nota = 7.9},
            };

            _allMoviesOrdered = new List<Movie>
            {
                new Movie{Titulo = "Deadpool 2"},
                new Movie{Titulo = "Han Solo: Uma História Star Wars"},
                new Movie{Titulo = "Hereditário"},
                new Movie{Titulo = "Jurassic World: Reino Ameaçado"},
                new Movie{Titulo = "Oito Mulheres e um Segredo"},
                new Movie{Titulo = "Os Incríveis 2"},
                new Movie{Titulo = "Thor: Ragnarok"},
                new Movie{Titulo = "Vingadores: Guerra Infinita"}
            };

            _quarterFinalsMovies = new List<Movie>()
            {
                new Movie{Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8},
                new Movie{Id = "tt3501632", Titulo = "Thor: Ragnarok", Ano = 2017, Nota = 7.9},
                new Movie{Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5},
                new Movie{Id = "tt4881806", Titulo = "Jurassic World: Reino Ameaçado", Ano = 2018, Nota = 6.7},
            };

            _semiFinalsMovies = new List<Movie>()
            {
                new Movie{Id = "tt4154756", Titulo = "Vingadores: Guerra Infinita", Ano = 2018, Nota = 8.8},
                new Movie{Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5},
            };

            _championshipResult = new List<ChampionshipResult>
            {
                new ChampionshipResult { Position = 1, Title = "Vingadores: Guerra Infinita"},
                new ChampionshipResult { Position = 2, Title = "Os Incríveis 2"},
            };

            _matchService.Setup(s => s.PlayMatch(It.IsAny<List<Movie>>())).Returns(_allMoviesOrdered[7]);
        }

        [Test]
        public void SetCurrentGame_WhenReceiveTwoMovies_ShoulReturnMoviesList()
        {
            var result = _service.SetCurrentGame(_allMovies[0], _allMovies[7]);

            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Has.Exactly(2).Items);
        }

        [Test]
        public void StartCurrentChampionshipPhase_WhenQualifiers_ShouldReturnQuarterFinalsResult()
        {            
            var result = _service.StartCurrentChampionshipPhase(_allMoviesOrdered);

            Assert.That(result, Has.Exactly(4).Items);
            Assert.AreEqual(_allMoviesOrdered[7].Titulo, result[2].Titulo);
        }

        [Test]
        public void StartCurrentChampionshipPhase_WhenQuarterFinals_ShouldReturnSemiFinalsResult()
        {
            var result = _service.StartCurrentChampionshipPhase(_quarterFinalsMovies);

            Assert.That(result, Has.Exactly(2).Items);
            Assert.AreEqual(_allMoviesOrdered[7].Titulo, result[0].Titulo);
        }

        [Test]
        public void StartCurrentChampionshipFinalMatch_WhenFinalRound_ShouldReturnChampionshipResult()
        {
            var result = _service.StartCurrentChampionshipFinalMatch(_semiFinalsMovies);
            
            Assert.That(result, Has.Exactly(1).Matches<ChampionshipResult>(m => m.Position == _championshipResult[0].Position));
            Assert.That(result, Has.Exactly(1).Matches<ChampionshipResult>(m => m.Title == _championshipResult[0].Title));

            Assert.That(result, Has.Exactly(1).Matches<ChampionshipResult>(m => m.Position == _championshipResult[1].Position));
            Assert.That(result, Has.Exactly(1).Matches<ChampionshipResult>(m => m.Title == _championshipResult[1].Title));
        }
    }
}