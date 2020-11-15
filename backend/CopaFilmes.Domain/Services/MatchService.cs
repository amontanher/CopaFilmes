using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Domain.Services
{
    public class MatchService : IMatchService
    {
        public Movie PlayMatch(List<Movie> movies)
        {
            var movieOne = movies.First();
            var movieTwo = movies.Last();

            if (movieOne.Nota.Equals(movieTwo.Nota))
                return UntieMatch(movies);

            return movies.Aggregate((m1, m2) => m1.Nota > m2.Nota ? m1 : m2);            
        }

        public Movie UntieMatch(IEnumerable<Movie> movies)
        {
            movies = Movie.SortTitlesByAlphabeticalOrder(movies);
            return movies.First();
        }
    }
}
