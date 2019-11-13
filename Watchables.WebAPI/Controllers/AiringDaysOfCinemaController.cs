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
    public class AiringDaysOfCinemaController : ControllerBase
    {
        //Dependency injection
        private readonly IAiringDaysOfCinemaService _service;
        public AiringDaysOfCinemaController(IAiringDaysOfCinemaService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.AiringDaysOfCinema>> Get() {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public ActionResult<Model.AiringDaysOfCinema> GetById(int id) {
            return _service.GetById(id);
        }
    }
}