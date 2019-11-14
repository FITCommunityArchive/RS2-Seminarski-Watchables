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

        [HttpPost]
        public ActionResult<Model.Cinema> Insert(InsertCinemaRequest request) {
            return _service.Insert(request);
        }

        [HttpPost("addHall")]
        public ActionResult<Model.Hall> AddHallToCinema(Model.Hall hall) {
            return _service.AddHallToCinema(hall);
        }

        [HttpPost("addProduct")]
        public ActionResult<Model.Product> AddProductToCinema(Model.Product product) {
            return _service.AddProductToCinema(product);
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
        [HttpPut("updateHall/{hallId}")]
        public ActionResult<Model.Hall> UpdateHall(int hallId, Model.Hall hall) {
            return _service.UpdateHall(hallId, hall);
        }
        [HttpPut("updateProduct/{productId}")]
        public ActionResult<Model.Product> UpdateProduct(int productId, Model.Product product) {
            return _service.UpdateProduct(productId, product);
        }

        [HttpGet("GetCinemasSchedule/{id}")]
        public ActionResult<CinemasScheduleRequest> GetCinemasSchedule(int id) {
            return _service.GetCinemasSchedule(id);
        }

        [HttpPost("addAiringDay")]
        public ActionResult<Model.AiringDaysOfCinema> AddAiringDayToCinema(Model.AiringDaysOfCinema ad) {
            return _service.AddAiringDayToCinema(ad);
        }
        [HttpPut("updateAiringDay/{airingDayId}")]
        public ActionResult<Model.AiringDaysOfCinema> UpdateAiringDay(int airingDayId, Model.AiringDaysOfCinema ad) {
            return _service.UpdateAiringDay(airingDayId, ad);
        }
        [HttpPost("AddCinemaDayMovie")]
        public ActionResult<Model.CinemaDayMovie> AddCinemaDayMovieToCinema(Model.CinemaDayMovie cdm) {
            return _service.AddCinemaDayMovieToCinema(cdm);
        }
        [HttpPost("AddAppointment")]
        public ActionResult<Model.Appointments> AddAppointmentToCinema(Model.Appointments app) {
            return _service.AddAppointmentToCinema(app);
        }
        [HttpPut("updateAppointment/{appointmentId}")]
        public ActionResult<Model.Appointments> UpdateAppointment(int appointmentId, Model.Appointments ap) {
            return _service.UpdateAppointment(appointmentId, ap);
        }

    }
}