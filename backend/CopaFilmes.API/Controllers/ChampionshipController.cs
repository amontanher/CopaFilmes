using CopaFilmes.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CopaFilmes.API.Controllers
{
    [ApiController]
    [Route("api/championship")]
    public class ChampionshipController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<ChampionshipResult> GenerateChampionship([FromBody] List<Movie> movies)
        {
            return Ok();
        }
    }
}
