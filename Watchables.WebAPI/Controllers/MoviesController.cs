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
        public ActionResult<List<Model.Movie>> Get() {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Movie> GetById(int id) {
            return _service.GetById(id);
        }

    }
}