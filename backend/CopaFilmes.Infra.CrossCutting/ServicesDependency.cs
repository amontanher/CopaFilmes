using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Services;
using CopaFilmes.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Infra.CrossCutting
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IChampionshipService, ChampionshipService>();
            services.AddTransient<IMatchService, MatchService>();
        }
    }
}
