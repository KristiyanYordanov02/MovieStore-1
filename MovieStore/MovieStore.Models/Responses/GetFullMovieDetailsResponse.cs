using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Responses
{
    public class GetFullMovieDetailsResponse
    {
        IEnumerable<MovieView> Movies { get; set; } = [];
    }
}
