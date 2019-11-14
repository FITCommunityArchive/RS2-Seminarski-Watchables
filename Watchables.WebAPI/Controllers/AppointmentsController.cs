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
    public class AppointmentsController : ControllerBase
    {
        //Dependency injection 
        private readonly IAppointmentsService _service;
        public AppointmentsController(IAppointmentsService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Appointments>> Get() {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Appointments> GetById(int id) {
            return _service.GetById(id);
        }
    }
}