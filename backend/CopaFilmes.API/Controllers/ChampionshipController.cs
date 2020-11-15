using CopaFilmes.Domain.Interfaces;
using CopaFilmes.Domain.Services;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Infra.CrossCutting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaFilmes.API.Controllers
{
    [ApiController]
    [Route("api/championship")]
    public class ChampionshipController : ControllerBase
    {
        IChampionshipService _service;

        public ChampionshipController(IChampionshipService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ChampionshipResult> GenerateChampionship([FromBody] IEnumerable<Movie> movies)
        {
            var championshipResult = _service.Run(movies);
            return Ok(championshipResult);
        }
    }
}
