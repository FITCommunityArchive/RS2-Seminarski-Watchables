using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Exceptions;

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

        public List<Model.Hall> Get() {
            return _mapper.Map<List<Model.Hall>>(_context.Hall.ToList());
        }

        public Model.Hall GetById(int id) {
            return _mapper.Map<Model.Hall>(_context.Hall.Find(id));
        }

        public Model.Hall Insert(Model.Requests.InsertHallRequest h) {

            bool validCinemaId = false;
            foreach (var cinema in _context.Cinemas.ToList()) {
                if (h.CinemaId == cinema.CinemaId) {
                    validCinemaId = true;
                    break;
                }
            }
            if (!validCinemaId) throw new UserException("Could not find sepcified cinemaId!");


            var hall = _mapper.Map<Database.Hall>(h);

            var inBaseHalls = _context.Hall.Where(ha => ha.CinemaId == h.CinemaId).ToList();

            foreach (var inHall in inBaseHalls) {
                if (inHall.HallName.ToLower() == hall.HallName.ToLower() && inHall.HallNumber == hall.HallNumber && hall.NumberOfseats == inHall.NumberOfseats && hall.CinemaId == inHall.CinemaId) {
                    return _mapper.Map<Model.Hall>(hall);
                }
            }
            _context.Hall.Add(hall);
            _context.SaveChanges();

            return _mapper.Map<Model.Hall>(hall);
        }

        public Model.Hall Update(int hallId, Model.Requests.InsertHallRequest hall) {


            bool validHallId = false;
            foreach (var inHall in _context.Hall.ToList()) {
                if (hallId == inHall.HallId) {
                    validHallId = true;
                    break;
                }
            }

            if (!validHallId) throw new UserException("Cannot find specified Hall with that hallId!");
            var baseHall = _context.Hall.Find(hallId);

            bool validCinemaId = false;
            foreach (var cinema in _context.Cinemas.ToList()) {
                if (hall.CinemaId == cinema.CinemaId) {
                    validCinemaId = true;
                    break;
                }
            }

            if (!validCinemaId) throw new UserException("Invalid cinemaId inside of hall!");

            var oldName = baseHall.HallName;
            baseHall.HallName = hall.HallName;
            baseHall.HallNumber = hall.HallNumber;
            baseHall.NumberOfseats = hall.NumberOfseats;
            _context.SaveChanges();

            var list = _context.Appointments.Where(a => a.HallId == baseHall.HallId).ToList();

            var helper = new Helper(_context);
            helper.NonDeleteNotification(list, $"The hall '{oldName}' was renamed to '{baseHall.HallName}'!", "Information");


            return _mapper.Map<Model.Hall>(baseHall);
        }

        public string Delete(int id) {

            Helper helper = new Helper(_context);

            var validHall = false;
            foreach(var h in _context.Hall.ToList()) {
                if (h.HallId == id) {
                    validHall = true;
                    break;
                }
            }
            if (!validHall) throw new UserException("Cannot find hall with specified id");

            var hall = _context.Hall.Find(id);

            string notificationContent = $"The hall '{hall.HallName} {hall.HallNumber}' in the '{_context.Cinemas.Find(hall.CinemaId).Name}' cinema, has been removed, with all it's appointments";

            helper.DeleteAppointmentsNotification(_context.Appointments.Where(a => a.HallId == id).ToList(), notificationContent, "Removal");

            _context.Hall.Remove(hall);
            _context.SaveChanges();

            return "Hall removed";
        }


    }
}
