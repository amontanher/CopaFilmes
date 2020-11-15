using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Interfaces
{
    public interface IChampionshipService
    {
        ChampionshipResult Run(IEnumerable<Movie> movies);
        List<Movie> RunChampionshipPhases(IEnumerable<Movie> movies);
        List<Movie> StartCurrentChampionshipPhase(List<Movie> movies);
        List<Movie> SetCurrentGame(Movie movieOne, Movie movieTwo);
    }
}
