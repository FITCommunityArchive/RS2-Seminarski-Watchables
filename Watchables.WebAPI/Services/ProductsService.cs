using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Exceptions;

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

        public Model.Product Insert(Model.Requests.InsertProductRequest pr) {

            bool validCinemaId = false;
            foreach (var cinema in _context.Cinemas.ToList()) {
                if (pr.CinemaId == cinema.CinemaId) {
                    validCinemaId = true;
                    break;
                }
            }
            if (!validCinemaId) throw new UserException("Could not find sepcified cinemaId!");

            var product = _mapper.Map<Database.Products>(pr);
            var inBaseProducts = _context.Products.Where(p => p.CinemaId == pr.CinemaId).ToList();

            foreach (var inProduct in inBaseProducts) {
                if (inProduct.Name.ToLower() == product.Name.ToLower() && inProduct.Price == product.Price && inProduct.CinemaId == product.CinemaId) {
                    return _mapper.Map<Model.Product>(product);
                }
            }
            _context.Products.Add(product);
            _context.SaveChanges();

            return _mapper.Map<Model.Product>(product);
        }

        public Product Update(int productId, Model.Requests.InsertProductRequest product) {

            bool validProductId = false;
            foreach (var inProdict in _context.Products.ToList()) {
                if (productId == inProdict.ProductId) {
                    validProductId = true;
                    break;
                }
            }

            if (!validProductId) throw new UserException("Cannot find specified Product with that productId!");
            var baseProduct = _context.Products.Find(productId);

            bool validCinemaId = false;
            foreach (var cinema in _context.Cinemas.ToList()) {
                if (product.CinemaId == cinema.CinemaId) {
                    validCinemaId = true;
                    break;
                }
            }

            if (!validCinemaId) throw new UserException("Invalid cinemaId inside of hall!");

            baseProduct.Name = product.Name;
            baseProduct.Price = product.Price;
            _context.SaveChanges();
            return _mapper.Map<Model.Product>(baseProduct);
        }
    }
}
