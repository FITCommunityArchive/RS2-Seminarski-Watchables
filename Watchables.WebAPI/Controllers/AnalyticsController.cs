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
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {

        //Dependency injection 
        private readonly IAnalyticsService _service;
        public AnalyticsController(IAnalyticsService service) {
            _service = service;
        }

        [HttpGet("Movies")]
        public ActionResult<List<Model.UsersMovies>> GetMovies() {
            return _service.GetMovies();
        }

        [HttpGet("Shows")]
        public ActionResult<List<Model.UsersShows>> GetShows() {
            return _service.GetShows();
        }

        [HttpGet("Subscriptions")]
        public ActionResult<List<Model.UsersSubscriptions>> GetSubscriptions() {
            return _service.GetSubscriptions();
        }


    }
}