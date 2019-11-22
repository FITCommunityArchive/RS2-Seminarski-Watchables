using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Watchables.WebAPI.Services;

namespace Watchables.WebAPI.Controllers
{
    public class SubscriptionsController : BaseCRUDController<Model.Subscription, Model.Requests.SubscriptionSearchRequest, Model.Requests.InsertSubscriptionRequest, Model.Requests.InsertSubscriptionRequest>
    {
        public SubscriptionsController(ICRUDService<Model.Subscription, Model.Requests.SubscriptionSearchRequest, Model.Requests.InsertSubscriptionRequest, Model.Requests.InsertSubscriptionRequest> service) : base(service) {
        }

        
    }
}