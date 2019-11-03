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

        public Model.Product AddProductToCinema(int cinemaId, Model.Product pr) {

            var product = _mapper.Map<Database.Products>(pr);
            var inBaseProducts = _context.Products.ToList();
            bool isThere = false;
            foreach(var inProduct in inBaseProducts) {
                if(inProduct.Name==product.Name && inProduct.Price == product.Price) {
                    var cinemaProducts = new CinemaProducts() {
                        CinemaId = cinemaId,
                        Product = inProduct
                    };
                    _context.CinemaProducts.Add(cinemaProducts);
                    _context.SaveChanges();
                    isThere = true;
                    break;
                }
            }
            if (!isThere) {
                _context.Products.Add(product);
                _context.SaveChanges();
                var cinemaProducts = new CinemaProducts() {
                    CinemaId = cinemaId,
                    Product = product
                };
                _context.CinemaProducts.Add(cinemaProducts);
                _context.SaveChanges();
            }

            return pr;
        }

        public List<Product> GetProductsOfCinema(int cinemaId) {

            var cinemaProducts = _context.CinemaProducts.Include(cp => cp.Product).ToList();
            var databaseProducts = new List<Database.Products>();
            foreach(var cinemaProduct in cinemaProducts) {
                if (cinemaProduct.CinemaId == cinemaId) databaseProducts.Add(cinemaProduct.Product);
            }

            return _mapper.Map<List<Model.Product>>(databaseProducts);
        }
    }
}
