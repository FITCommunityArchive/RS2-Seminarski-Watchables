using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Watchables.Model.Requests;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Services;

namespace Watchables.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {

        //Dependency injection
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Cinema>> Get([FromQuery]Model.Requests.CinemasSearchRequest request) {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Cinema> GetById(int id) {
            return _service.GetById(id);
        }
   
        [HttpPost("insert")]
        public ActionResult<InsertCinemaRequest> Insert(InsertCinemaRequest request) {
            return _service.Insert(request);
        }

    }
}