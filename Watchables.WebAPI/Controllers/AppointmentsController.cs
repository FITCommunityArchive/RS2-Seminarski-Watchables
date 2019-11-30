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
        [HttpPost]
        public ActionResult<Model.Appointments> AddAppointmentToCinema(Model.Requests.InsertAppointmentRequest app) {
            return _service.Insert(app);
        }
        [HttpPut("{appointmentId}")]
        public ActionResult<Model.Appointments> UpdateAppointment(int appointmentId, Model.Requests.InsertAppointmentRequest ap) {
            return _service.Update(appointmentId, ap);
        }
        [HttpDelete("{appointmentId}")]
        public ActionResult<string> Delete(int appointmentId) {
            return _service.Delete(appointmentId);
        }
    }
}