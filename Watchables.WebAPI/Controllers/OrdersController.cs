using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Watchables.WebAPI.Services;

namespace Watchables.WebAPI.Controllers
{

    public class OrdersController : BaseCRUDController<Model.Order, Model.Requests.OrderSerachRequest, Model.Requests.InsertOrderRequest, Model.Requests.InsertOrderRequest>
    {
        public OrdersController(ICRUDService<Model.Order, Model.Requests.OrderSerachRequest, Model.Requests.InsertOrderRequest, Model.Requests.InsertOrderRequest> service) : base(service) {
        }
    }
}