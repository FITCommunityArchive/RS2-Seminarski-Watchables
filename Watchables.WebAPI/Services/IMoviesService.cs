using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IMoviesService
    {
        List<Model.Movie> Get();
        Model.Movie GetById(int id);
    }
}
