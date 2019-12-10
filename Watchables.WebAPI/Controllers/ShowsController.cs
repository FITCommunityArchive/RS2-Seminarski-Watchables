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
    public class ShowsController : ControllerBase
    {
        //Dependency injection
        private readonly IShowsService _service;
        public ShowsController(IShowsService service) {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Show>> Get([FromQuery]Model.Requests.ShowSearchRequest request) {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Show> GetById(int id) {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Show> Insert(Model.Requests.InsertShowRequest request) {
            return _service.Insert(request);
        }

        [HttpPut("{showId}")]
        public ActionResult<Model.Show> Update(int showId, Model.Requests.InsertShowRequest request) {
            return _service.Update(showId, request);
        }
        [HttpDelete("{showId}")]
        public ActionResult<string> Delete(int showId) {
            return _service.Delete(showId);
        }
    }
}