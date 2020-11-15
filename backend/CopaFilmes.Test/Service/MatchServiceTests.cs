using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Services;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Test.Service
{
    public class MatchServiceTests
    {
        List<Movie> _movies;
        List<Movie> _moviesTieBreaker;

        IMatchService _service;
        Mock<MatchService> _serviceMock;

        [SetUp]
        public void SetUp()
        {
            _serviceMock = new Mock<MatchService>();

            _service = _serviceMock.Object;

            _movies = new List<Movie>
            {
                new Movie{Id = "tt3778644", Titulo = "Han Solo: Uma História Star Wars", Ano = 2018, Nota = 7.2},
                new Movie{Id = "tt5164214", Titulo = "Oito Mulheres e um Segredo", Ano = 2018, Nota = 6.3},
            };

            _moviesTieBreaker = new List<Movie>
            {
                new Movie{Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5},
                new Movie{Id = "tt4881806", Titulo = "Jurassic World: Reino Ameaçado", Ano = 2018, Nota = 8.5},
            };
        }

        [Test]
        public void PlayMatch_WhenRatingsAreDifferent_ShouldReturnTheMovieWithTheHighestRating()
        {
            var result = _service.PlayMatch(_movies);
            Assert.AreEqual(_movies[0].Titulo, result.Titulo);
        }

        [Test]
        public void PlayMatch_WhenRatingsAreEquals_ShouldReturnFirstMovieInAlphabeticalOrder()
        {
            var result = _service.PlayMatch(_movies);
            Assert.AreEqual(_movies[0].Titulo, result.Titulo);
        }

        [Test]
        public void UntieMatch_WhenRatingsAreEquals_ShouldReturnFirstInAlphabeticalOrder()
        {
            var result = _service.UntieMatch(_moviesTieBreaker);
            Assert.AreEqual(_moviesTieBreaker[1].Titulo, result.Titulo);
        }
    }
}
