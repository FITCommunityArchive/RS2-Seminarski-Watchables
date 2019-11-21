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
    
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //Dependency injection 
        private readonly IUserService _service;
        public UsersController(IUserService service) {
            _service = service;
        }

        
        [HttpPost]
        public ActionResult<Model.User> Insert(Model.Requests.InsertUserRequest request) {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult<List<Model.User>> Get([FromQuery]Model.Requests.UserSearchRequest request) {
            return _service.Get(request);
        }

        [Authorize(Roles = "Korisnik")]
        [HttpPut("{userId}")]
        public ActionResult<Model.User> Update(int userId, Model.Requests.InsertUserRequest request) {
           return _service.Update(userId, request);
        }

        [Authorize(Roles = "Admin, Korisnik")]
        [HttpGet("{userId}")]
        public ActionResult<Model.User> GetById(int userId) {
            return _service.GetById(userId);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("Lock/{flag}")]
        public ActionResult<string> LockToggle(bool flag) {
            return _service.LockToggle(flag);
        }   
    }
}