using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Domain.Services
{
    public class ChampionshipService : IChampionshipService
    {
        IMatchService _matchService;

        public ChampionshipService(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public List<ChampionshipResult> Run(IEnumerable<Movie> movies)
        {
            movies = Movie.SortTitlesByAlphabeticalOrder(movies).ToList();

            return RunChampionshipPhases(movies);
        }

        public List<ChampionshipResult> RunChampionshipPhases(IEnumerable<Movie> movies)
        {
            var quarterFinalsRoundResult = StartCurrentChampionshipPhase(movies.ToList());

            var semiFinalsRound = StartCurrentChampionshipPhase(quarterFinalsRoundResult);

            return StartCurrentChampionshipFinalMatch(semiFinalsRound);            
        }

        private List<ChampionshipResult> StartCurrentChampionshipFinalMatch(List<Movie> semiFinalsRound)
        {
            var winner = _matchService.PlayMatch(semiFinalsRound);
            var runnerUp = semiFinalsRound.First(f => f.Id != winner.Id);

            return new List<ChampionshipResult>
            {
                new ChampionshipResult{Position = 1, Title = winner.Titulo},
                new ChampionshipResult{Position = 2, Title = runnerUp.Titulo}
            };
        }

        public List<Movie> StartCurrentChampionshipPhase(List<Movie> movies)
        {
            var result = new List<Movie>();
            var last = movies.Count() - 1;

            var totalMatches = movies.Count() / 2;

            for (int i = 0; i < totalMatches; i++)
            {
                var currentGame = SetCurrentGame(movies[i], movies[last]);

                var matchResult = _matchService.PlayMatch(currentGame);

                result.Add(matchResult);

                last--;
            }

            return result;
        }

        public List<Movie> SetCurrentGame(Movie movieOne, Movie movieTwo)
        {
            return new List<Movie>
            {
                movieOne,
                movieTwo
            };
        }
    }
}
