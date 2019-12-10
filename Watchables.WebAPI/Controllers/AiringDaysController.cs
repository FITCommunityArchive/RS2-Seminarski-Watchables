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
    public class AiringDaysController : ControllerBase
    {
        //Dependency injection
        private readonly IAiringDayService _service;
        public AiringDaysController(IAiringDayService service) {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.AiringDay>> Get() {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Model.AiringDay> GetById(int id) {
            return _service.GetById(id);
        }

    }
}