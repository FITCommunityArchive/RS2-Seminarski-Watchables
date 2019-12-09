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
    public class NotificationsController : ControllerBase
    {

        //Dependency injection 
        private readonly INotificationService _service;
        public NotificationsController(INotificationService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Notification>> Get() {
            return _service.Get();
        }
        [HttpDelete("RemoveNotification/{userNotificationId}")]
        public ActionResult<string> RemoveNotification(int userNotificationId) {
            return _service.RemoveNotification(userNotificationId);
        }

    }
}