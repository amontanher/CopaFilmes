using CopaFilmes.Domain.Entities;

namespace CopaFilmes.Domain.Interfaces
{
    public interface IMatchService
    {
        Movie PlayMatch(Movie movieOne, Movie movieTwo);
    }
}
