using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Domain.Entities
{
    public class Movie
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public double Nota { get; set; }

        public static IEnumerable<Movie> SortTitlesByAlphabeticalOrder(IEnumerable<Movie> movies)
        {
            return movies.OrderBy(o => o.Titulo);
        }
    }
}
