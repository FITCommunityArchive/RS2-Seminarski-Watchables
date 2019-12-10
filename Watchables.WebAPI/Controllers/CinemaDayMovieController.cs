using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Watchables.WebAPI.Services;

namespace Watchables.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaDayMovieController : ControllerBase
    {
        //Dependency injection
        private readonly ICinemaDayMovieService _service;
        public CinemaDayMovieController(ICinemaDayMovieService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.CinemaDayMovie>> Get() {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public ActionResult<Model.CinemaDayMovie> GetById(int id) {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.CinemaDayMovie> AddCinemaDayMovieToCinema(Model.Requests.InsertCinemaDayMovieRequest cdm) {
            return _service.Insert(cdm);
        }
        [HttpDelete("{cdmId}")]
        public ActionResult<string> Delete(int cdmId) {
            return _service.Delete(cdmId);
        }
    }
}