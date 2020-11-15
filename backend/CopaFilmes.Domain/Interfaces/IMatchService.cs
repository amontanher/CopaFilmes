using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Interfaces
{
    public interface IMatchService
    {
        Movie PlayMatch(List<Movie> movies);

        Movie UntieMatch(IEnumerable<Movie> movies);
    }
}
