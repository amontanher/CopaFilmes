using CopaFilmes.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopaFilmes.Test.Domain
{
    public class MovieTests
    {
        List<Movie> _movies;
        List<Movie> _expected;

        [SetUp]
        public void SetUp()
        {
            _movies = new List<Movie>()
            {
                new Movie{Titulo = "Os Incríveis 2"},
                new Movie{Titulo = "Jurassic World: Reino Ameaçado"},
                new Movie{Titulo = "Oito Mulheres e um Segredo"},
                new Movie{Titulo = "Hereditário"},
                new Movie{Titulo = "Vingadores: Guerra Infinita"},
                new Movie{Titulo = "Deadpool 2"},
                new Movie{Titulo = "Han Solo: Uma História Star Wars"},
                new Movie{Titulo = "Thor: Ragnarok"}
            };

            _expected = new List<Movie>
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
        }

        [Test]
        public void Test()
        {
            var result = Movie.SortTitlesByAlphabeticalOrder(_movies).ToList();

            Assert.AreEqual(_expected[0].Titulo, result[0].Titulo);
            Assert.AreEqual(_expected[4].Titulo, result[4].Titulo);
            Assert.AreEqual(_expected[7].Titulo, result[7].Titulo);
        }
    }
}
