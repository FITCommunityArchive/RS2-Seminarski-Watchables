using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.Model.Requests;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class CinemasService : ICinemasService
    {
        //Dependency injection
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public CinemasService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Cinema> Get(Model.Requests.CinemasSearchRequest request) {

            var query = _context.Cinemas.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Name)) query = query.Where(c => c.Name.ToLower().StartsWith(request.Name.ToLower()));
            if (!string.IsNullOrWhiteSpace(request?.Address)) query = query.Where(c => c.Address.ToLower().StartsWith(request.Address.ToLower()));
            if (!string.IsNullOrWhiteSpace(request?.Location)) query = query.Where(c => c.Location.ToLower().StartsWith(request.Location.ToLower()));
            if (request?.Rating >= 0) query = query.Where(c => c.Rating >= request.Rating);  

            return _mapper.Map<List<Model.Cinema>>(query.ToList());       
        }

        public Model.Cinema GetById(int id) {
            return _mapper.Map<Model.Cinema>(_context.Cinemas.Find(id));
        }

        public Model.Cinema Insert(InsertCinemaRequest request) {

            _context.Cinemas.Add(_mapper.Map<Database.Cinemas>(request));
            _context.SaveChanges();
            return _mapper.Map<Model.Cinema>(_mapper.Map<Database.Cinemas>(request));  
        }

        public Model.Hall AddHallToCinema(Model.Hall h) {
            var hall = _mapper.Map<Database.Hall>(h);
            var inBaseHalls = _context.Hall.Where(ha => ha.CinemaId == h.CinemaId).ToList();

            foreach (var inHall in inBaseHalls) {
                if (inHall.HallName.ToLower() == hall.HallName.ToLower() && inHall.HallNumber == hall.HallNumber && hall.NumberOfseats == inHall.NumberOfseats) {
                    return h;
                }
            }
            _context.Hall.Add(hall);
            _context.SaveChanges();

            return h;
        }

        public Model.Product AddProductToCinema(int cinemaId, Model.Product pr) {

            var product = _mapper.Map<Database.Products>(pr);
            var inBaseProducts = _context.Products.ToList();
            bool isThere = false;
            foreach (var inProduct in inBaseProducts) {
                if (inProduct.Name.ToLower() == product.Name.ToLower() && inProduct.Price == product.Price) {

                    var allCinemaProducts = _context.CinemaProducts.ToList();
                    foreach (var cinemaProduct in allCinemaProducts) {
                        if (cinemaProduct.ProductId == inProduct.ProductId && cinemaProduct.CinemaId==cinemaId) {
                            return pr;
                        }
                    }

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

        public List<Model.Hall> GetHallsOfCinema(int cinemaId) {
            return _mapper.Map<List<Model.Hall>>(_context.Hall.Where(h => h.CinemaId == cinemaId).ToList());
        }

        public List<Product> GetProductsOfCinema(int cinemaId) {

            var cinemaProducts = _context.CinemaProducts.Include(cp => cp.Product).ToList();
            var databaseProducts = new List<Database.Products>();
            foreach (var cinemaProduct in cinemaProducts) {
                if (cinemaProduct.CinemaId == cinemaId) databaseProducts.Add(cinemaProduct.Product);
            }

            return _mapper.Map<List<Model.Product>>(databaseProducts);
        }

        public Cinema Update(int cinemaId, InsertCinemaRequest request) {
            var cinema = _context.Cinemas.Find(cinemaId);
            _mapper.Map(request, cinema);
            _context.SaveChanges();
            return _mapper.Map<Model.Cinema>(cinema);            
        }
    }
}
