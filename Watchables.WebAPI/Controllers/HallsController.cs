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
    public class HallsController : ControllerBase
    {
        //Dependency injection 
        private readonly IHallsService _service;
        public HallsController(IHallsService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Hall>> Get() {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Hall> GetById(int id) {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Hall> Inesrt(Model.Requests.InsertHallRequest hall) {
            return _service.Insert(hall);
        }
        [HttpPut("{hallId}")]
        public ActionResult<Model.Hall> Update(int hallId, Model.Requests.InsertHallRequest hall) {
            return _service.Update(hallId, hall);
        }
        [HttpDelete("{hallId}")]
        public ActionResult<string> Delete(int hallId) {
            return _service.Delete(hallId);
        }
    }
}