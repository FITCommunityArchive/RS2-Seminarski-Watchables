using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class HallsService : IHallsService
    {
        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public HallsService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public Model.Hall AddHallToCinema(int cinemaId, Model.Hall h) {
            var hall = _mapper.Map<Database.Hall>(h);
            var inBaseHalls = _context.Hall.Where(h => h.CinemaId == cinemaId).ToList();

            foreach(var inHall in inBaseHalls) {
                if(inHall.HallName==hall.HallName && inHall.HallNumber==hall.HallNumber && hall.NumberOfseats == inHall.NumberOfseats) {
                    return h;
                }
            }
            hall.CinemaId = cinemaId;
            _context.Hall.Add(hall);
            _context.SaveChanges();

            return h;
        }

        public List<Model.Hall> Get() {            
            return _mapper.Map<List<Model.Hall>>(_context.Hall.ToList());
        }

        public Model.Hall GetById(int id) {
            return _mapper.Map<Model.Hall>(_context.Hall.Find(id));
        }

        public List<Model.Hall> GetHallsOfCinema(int cinemaId) {
            return _mapper.Map<List<Model.Hall>>(_context.Hall.Where(h => h.CinemaId == cinemaId).ToList());
        }
    }
}
