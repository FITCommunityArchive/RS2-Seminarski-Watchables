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
    public class UsersController : ControllerBase
    {
        //Dependency injection 
        private readonly IUserService _service;
        public UsersController(IUserService service) {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult<Model.User> Insert(Model.Requests.InsertUserRequest request) {
            return _service.Insert(request);
        }

        [HttpGet]
        public ActionResult<List<Model.User>> Get([FromQuery]Model.Requests.UserSearchRequest request) {
            return _service.Get(request);
        }

        [Authorize(Roles = "Korisnik")]
        [HttpPut("{userId}")]
        public ActionResult<Model.User> Update(int userId, Model.Requests.InsertUserRequest request) {
           return _service.Update(userId, request);
        }

        [HttpGet("{userId}")]
        public ActionResult<Model.User> GetById(int userId) {
            return _service.GetById(userId);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("Lock/{flag}")]
        public ActionResult<string> LockToggle(bool flag) {
            return _service.LockToggle(flag);
        }

        [Authorize(Roles = "Korisnik")]
        [HttpPost("BuyItem")]
        public ActionResult<string> Buy(Model.Buy buy) {
            return _service.BuyItem(buy);
        }

        [Authorize(Roles = "Korisnik")]
        [HttpPost("DeleteItem")]
        public ActionResult<string> Delete(Model.Delete delete) {
            return _service.DeleteItem(delete);
        }

        [Authorize(Roles = "Korisnik")]
        [HttpGet("RecommendedMovies/{userId}")]
        public ActionResult<List<Model.Movie>> RecommendedMovies(int userId) {
            return _service.RecommendedMovies(userId);
        }

        [Authorize(Roles = "Korisnik")]
        [HttpGet("RecommendedShows/{userId}")]
        public ActionResult<List<Model.Show>> RecommendedShows(int userId) {
            return _service.RecommendedShows(userId);
        }

        [Authorize(Roles = "Korisnik, Admin")]
        [HttpGet("Movies/{userId}")]
        public ActionResult<List<Model.Movie>> Movies(int userId) {
            return _service.Movies(userId);
        }

        [Authorize(Roles = "Korisnik, Admin")]
        [HttpGet("Shows/{userId}")]
        public ActionResult<List<Model.Show>> Shows(int userId) {
            return _service.Shows(userId);
        }

        [Authorize(Roles = "Korisnik, Admin")]
        [HttpGet("Subscriptions/{userId}")]
        public ActionResult<List<Model.Subscription>> Subscriptions(int userId) {
            return _service.Subscriptions(userId);
        }

        [Authorize(Roles = "Korisnik, Admin")]
        [HttpGet("Rotations/{userId}")]
        public ActionResult<List<Model.Rotation>> Rotations(int userId) {
            return _service.Rotations(userId);
        }

        [Authorize(Roles = "Korisnik, Admin")]
        [HttpGet("Notifications/{userId}")]
        public ActionResult<List<Model.Notification>> Notifications(int userId) {
            return _service.Notifications(userId);
        }

        [Authorize(Roles = "Korisnik, Admin")]
        [HttpPost("Deactivate/{userId}")]
        public ActionResult<Model.User> DeactivateUser(int userId) {
            return _service.DeactivateUser(userId);
        }

        [Authorize(Roles = "Korisnik, Admin")]
        [HttpPost("Activate/{userId}")]
        public ActionResult<Model.User> ActivateUser(int userId) {
            return _service.ActivateUser(userId);
        }

    }
}