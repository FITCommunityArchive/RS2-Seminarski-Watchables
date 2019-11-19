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
    public class AdminsController : ControllerBase
    {

        //Dependency injection 
        private readonly IAdminService _service;
        public AdminsController(IAdminService service) {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Model.Admin> Insert(Model.Requests.InsertAdminRequest request) {
            return _service.Insert(request);
        }

        [HttpGet]
        public ActionResult<List<Model.Admin>> Get() {
            return _service.Get();
        }
        [HttpPut("{adminId}")]
        public ActionResult<Model.Admin> Update(int adminId, Model.Requests.InsertAdminRequest request) {
            return _service.Update(adminId, request);
        }
    }
}
