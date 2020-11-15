using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Interfaces
{
    public interface IChampionshipService
    {
        ChampionshipResult Run(IEnumerable<Movie> movies);
    }
}
