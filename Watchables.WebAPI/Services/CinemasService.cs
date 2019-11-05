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

        public InsertCinemaRequest Insert(InsertCinemaRequest request) {

            var cinema = _mapper.Map<Database.Cinemas>(request.Cinema);
            var halls = _mapper.Map<List<Database.Hall>>(request.Halls);
            var products = _mapper.Map<List<Database.Products>>(request.Products);
            var inBaseProducts = _context.Products.ToList();
            var airingDays = _context.AiringDays.ToList();

     
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();

            foreach(var hall in halls) {
                hall.Cinema = cinema;
                _context.Hall.Add(hall);
                _context.SaveChanges();
            }

            foreach(var product in products) {
                bool added = false;
                foreach(var inProduct in inBaseProducts) {
                    if(product.Name==inProduct.Name && product.Price == inProduct.Price) {
                        var cinemaProduct = new Database.CinemaProducts() {
                            Cinema = cinema,
                            Product = inProduct
                        };
                        _context.CinemaProducts.Add(cinemaProduct);
                        _context.SaveChanges();
                        added = true;
                        break;
                    }
                }
                if (!added) {
                    var cinemaProduct = new Database.CinemaProducts() {
                        Cinema = cinema,
                        Product = product
                    };
                    _context.Products.Add(product);
                    _context.CinemaProducts.Add(cinemaProduct);
                    _context.SaveChanges();
                }  
            }
            foreach(var day in airingDays) {
                var airingDaysOfCinema = new AiringDaysOfCinema() {
                    Cinema=cinema,
                    AiringDay=day
                };
                _context.AiringDaysOfCinema.Add(airingDaysOfCinema);
                _context.SaveChanges();
            }
            return request;
        }
    }
}
