﻿using AutoMapper;
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


            baseHall.HallName = hall.HallName;
            baseHall.HallNumber = hall.HallNumber;
            baseHall.NumberOfseats = hall.NumberOfseats;
            _context.SaveChanges();
            return _mapper.Map<Model.Hall>(baseHall);
        }


    }
}
