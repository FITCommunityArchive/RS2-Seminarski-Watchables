using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Watchables.WebAPI.Services;

namespace Watchables.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase {
        //Dependency injection
        private readonly IProductsService _service;
        public ProductsController(IProductsService service) {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Model.Product>> Get() {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Model.Product> GetById(int id) {
            return _service.GetById(id);
        }

        [HttpPost("addToCinema/{cinemaId}")]
        public ActionResult<Model.Product> AddProductToCinema(int cinemaId, Model.Product product) {
            return _service.AddProductToCinema(cinemaId, product);
        }

        [HttpGet("getProducts/{cinemaId}")]
        public ActionResult<List<Model.Product>> GetProductsOfCinema(int cinemaId) {
            return _service.GetProductsOfCinema(cinemaId);
        }
    }
}