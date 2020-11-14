using CopaFilmes.Domain.Championship.Interfaces;
using CopaFilmes.Domain.Championship.Services;

namespace CopaFilmes.Infra.CrossCutting
{
    public static class ConfigureServices
    {
        public static void RegisterInstances()
        {
            ServiceLocators.Register<IChampionshipService>(nameof(ChampionshipService), new ChampionshipService());
        }
    }
}
