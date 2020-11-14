using CopaFilmes.Domain.Championship.Interfaces;
using CopaFilmes.Domain.Entities;

namespace CopaFilmes.Domain.Championship.Services
{
    public class ChampionshipService : IChampionshipService
    {
        public ChampionshipResult Run()
        {
            return new ChampionshipResult { Position = 1, Title = "Title" };
        }
    }
}
