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

        [HttpPost]
        public ActionResult<Model.Product> AddProductToCinema(Model.Requests.InsertProductRequest product) {
            return _service.Insert(product);
        }

        [HttpPut("{productId}")]
        public ActionResult<Model.Product> UpdateProduct(int productId, Model.Requests.InsertProductRequest product) {
            return _service.Update(productId, product);
        }
    }
}