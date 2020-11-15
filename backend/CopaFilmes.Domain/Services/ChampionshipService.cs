using CopaFilmes.Domain.Championship.Interfaces;
using CopaFilmes.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Domain.Championship.Services
{
    public class ChampionshipService : IChampionshipService
    {        
        public ChampionshipResult Run(IEnumerable<Movie> movies)
        {
            movies = Movie.SortTitlesByAlphabeticalOrder(movies).ToList();
            
            var qualifyingRoundResult = QualifyingRound(movies.ToList());

            return new ChampionshipResult { Position = 1, Title = "Title" };
        }

        public IEnumerable<Movie> QualifyingRound(List<Movie> movies)
        {
            var result = new List<Movie>();

            for (int i = 0; i < movies.Count(); i++)
            {

            }

            return result;
        }
    }
}
