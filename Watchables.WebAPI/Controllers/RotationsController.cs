using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Watchables.WebAPI.Services;

namespace Watchables.WebAPI.Controllers
{
    public class RotationsController : BaseCRUDController<Model.Rotation, Model.Requests.RotationSearchRequest, Model.Requests.InsertRotationRequest, Model.Requests.InsertRotationRequest>
    {
        public RotationsController(ICRUDService<Model.Rotation, Model.Requests.RotationSearchRequest, Model.Requests.InsertRotationRequest, Model.Requests.InsertRotationRequest> service) : base(service) {
        }


    }
}