using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet]
        public ActionResult<List<Model.Cinema>> Get([FromQuery]Model.Requests.CinemasSearchRequest request) {
            return _service.Get(request);
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<Model.Cinema> GetById(int id) {
            return _service.GetById(id);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult<Model.Cinema> Insert(InsertCinemaRequest request) {
            return _service.Insert(request);
        }
      
        [Authorize]
        [HttpGet("GetHalls/{cinemaId}")]
        public ActionResult<List<Model.Hall>> GetHallsOfCinema(int cinemaId) {
            return _service.GetHallsOfCinema(cinemaId);
        }

        [Authorize]
        [HttpGet("getProducts/{cinemaId}")]
        public ActionResult<List<Model.Product>> GetProductsOfCinema(int cinemaId) {
            return _service.GetProductsOfCinema(cinemaId);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{cinemaId}")]
        public ActionResult<Model.Cinema> Update(int cinemaId, InsertCinemaRequest request) {
            return _service.Update(cinemaId, request);
        }

        [Authorize]
        [HttpGet("GetCinemasSchedule/{id}")]
        public ActionResult<CinemasScheduleRequest> GetCinemasSchedule(int id) {
            return _service.GetCinemasSchedule(id);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{cinemaId}")]
        public ActionResult<string> Delete(int cinemaId) {
            return _service.Delete(cinemaId);
        }
    }
}