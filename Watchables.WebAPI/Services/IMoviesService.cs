using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IMoviesService
    {
        List<Model.Movie> Get(Model.Requests.MovieSearchRequest request);
        Model.Movie GetById(int id);
        Model.Movie Insert(Model.Requests.InsertMovieRequest request);
        Model.Movie Update(int movieId, Model.Requests.InsertMovieRequest request);
    }
}
