using BlazorMivies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMivies.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> getMovies();
    }
}
