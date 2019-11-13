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
    public class InitializeController : ControllerBase
    {
        //Dependency injection
        private readonly IInitializeService _service;
        public InitializeController(IInitializeService service) {
            _service = service;
        }

        [HttpPost("AddDays")]
        public ActionResult<string> AddDays() {
            return _service.AddDays();
        }


        [HttpPost("AddMovies")]
        public ActionResult<string> AddMovies() {
            return _service.AddMovies();
        }

        [HttpPost("Schedule")]
        public ActionResult<string> Init() {
            return _service.Init();
        }

    }
}