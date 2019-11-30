using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Watchables.WebAPI.Services;

namespace Watchables.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        //Dependency injection
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Movie>> Get([FromQuery]Model.Requests.MovieSearchRequest request) {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Movie> GetById(int id) {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Movie> Insert(Model.Requests.InsertMovieRequest request) {
            return _service.Insert(request);
        }

        [HttpPut("{movieId}")]
        public ActionResult<Model.Movie> Update(int movieId, Model.Requests.InsertMovieRequest request) {
            return _service.Update(movieId, request);
        }

        [HttpDelete("{movieId}")]
        public ActionResult<string> Delete(int movieId) {
            return _service.Delete(movieId);
        }

    }
}