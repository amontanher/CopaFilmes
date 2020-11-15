using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Interfaces
{
    public interface IChampionshipService
    {
        List<ChampionshipResult> Run(IEnumerable<Movie> movies);
        List<Movie> SetCurrentGame(Movie movieOne, Movie movieTwo);
        List<Movie> StartCurrentChampionshipPhase(List<Movie> movies);
        List<ChampionshipResult> RunChampionshipPhases(IEnumerable<Movie> movies);
        List<ChampionshipResult> StartCurrentChampionshipFinalMatch(List<Movie> semiFinalsRound);
    }
}
