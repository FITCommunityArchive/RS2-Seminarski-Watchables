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
    [Authorize(Roles = "Admin")]
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

        [HttpPost]
        public ActionResult<Model.Cinema> Insert(InsertCinemaRequest request) {
            return _service.Insert(request);
        }

      

        [HttpGet("GetHalls/{cinemaId}")]
        public ActionResult<List<Model.Hall>> GetHallsOfCinema(int cinemaId) {
            return _service.GetHallsOfCinema(cinemaId);
        }

        [HttpGet("getProducts/{cinemaId}")]
        public ActionResult<List<Model.Product>> GetProductsOfCinema(int cinemaId) {
            return _service.GetProductsOfCinema(cinemaId);
        }

        [HttpPut("{cinemaId}")]
        public ActionResult<Model.Cinema> Update(int cinemaId, InsertCinemaRequest request) {
            return _service.Update(cinemaId, request);
        }

        [HttpGet("GetCinemasSchedule/{id}")]
        public ActionResult<CinemasScheduleRequest> GetCinemasSchedule(int id) {
            return _service.GetCinemasSchedule(id);
        }
    }
}