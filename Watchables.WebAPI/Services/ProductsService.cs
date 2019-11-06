using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class ProductsService : IProductsService
    {
        //Dependency injection
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public ProductsService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }     

        public List<Product> Get() {
            return _mapper.Map<List<Model.Product>>(_context.Products.ToList());
        }

        public Product GetById(int id) {
            return _mapper.Map<Model.Product>(_context.Products.Find(id));
        }
    }
}
