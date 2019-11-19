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
    public class AirinDaysOfCinemaService : IAiringDaysOfCinemaService
    {

        //Dependency injection
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public AirinDaysOfCinemaService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.AiringDaysOfCinema> Get() {
            return _mapper.Map<List<Model.AiringDaysOfCinema>>(_context.AiringDaysOfCinema.ToList());
        }

        public Model.AiringDaysOfCinema GetById(int id) {
            return _mapper.Map<Model.AiringDaysOfCinema>(_context.AiringDaysOfCinema.Find(id));
        }

        public Model.AiringDaysOfCinema Insert(Model.Requests.InserAiringDayOfCinemaRequest ad) {

            bool validCinemaId = false;
            foreach (var cinema in _context.Cinemas.ToList()) {
                if (ad.CinemaId == cinema.CinemaId) {
                    validCinemaId = true;
                    break;
                }
            }
            if (!validCinemaId) throw new UserException("Could not find sepcified cinemaId!");


            var baseAd = _mapper.Map<Database.AiringDaysOfCinema>(ad);
            var day = baseAd.Date.DayOfWeek;
            var days = _context.AiringDays.ToList();
            foreach (var airingDay in days) {
                if (airingDay.Name == day.ToString()) {
                    baseAd.AiringDayId = airingDay.AiringDayId;
                    break;
                }
            }
            _context.AiringDaysOfCinema.Add(baseAd);
            _context.SaveChanges();
            return _mapper.Map<Model.AiringDaysOfCinema>(baseAd);
        }

        public Model.AiringDaysOfCinema Update(int airingDayId, Model.Requests.InserAiringDayOfCinemaRequest ad) {

            bool validAiringDayId = false;
            foreach (var inDay in _context.AiringDaysOfCinema.ToList()) {
                if (airingDayId == inDay.AiringDaysOfCinemaId) {
                    validAiringDayId = true;
                    break;
                }
            }

            if (!validAiringDayId) throw new UserException("Cannot find specified day with that airingDaysOfCinemaId!");
            bool validCinemaId = false;
            foreach (var cinema in _context.Cinemas.ToList()) {
                if (ad.CinemaId == cinema.CinemaId) {
                    validCinemaId = true;
                    break;
                }
            }

            if (!validCinemaId) throw new UserException("Invalid cinemaId inside of airing day of cinema!");

            var baseAd = _context.AiringDaysOfCinema.Find(airingDayId);
            baseAd.Date = ad.Date;
            var day = ad.Date.DayOfWeek;
            var days = _context.AiringDays.ToList();
            foreach (var airingDay in days) {
                if (airingDay.Name == day.ToString()) {
                    baseAd.AiringDayId = airingDay.AiringDayId;
                    break;
                }
            }
            _context.SaveChanges();
            return _mapper.Map<Model.AiringDaysOfCinema>(baseAd);
        }
    }
}
