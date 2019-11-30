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
            var oldDate = baseAd.Date.Date;
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

            var cdms = _context.CinemaDayMovie.Where(c => c.AiringDaysOfCinemaId == baseAd.AiringDaysOfCinemaId).ToList();
            var list = new List<Database.Appointments>();
            foreach(var cdm in cdms) {
                foreach(var app in _context.Appointments.ToList()) {
                    if (app.CinemaDayMovieId == cdm.CinemaDayMovieId) {
                        list.Add(app);
                    }
                }
            }

            Helper helper = new Helper(_context);
            helper.NonDeleteNotification(list, $"Orders from the {oldDate} have been changed to the {baseAd.Date.Date}", "Warning");

            return _mapper.Map<Model.AiringDaysOfCinema>(baseAd);
        }

        public string Delete(int id) {

            Helper helper = new Helper(_context);

            var validAdoc = false;
            foreach (var a in _context.AiringDaysOfCinema.ToList()) {
                if (a.AiringDaysOfCinemaId == id) {
                    validAdoc = true;
                    break;
                }
            }
            if (!validAdoc) throw new UserException("Cannot find airing day of cinema with specified id");

            var adoc = _context.AiringDaysOfCinema.Find(id);

            string notificationContent = $"The airing day on {adoc.Date.Date}, {_context.AiringDays.Find(adoc.AiringDayId).Name} was removed";

            helper.DeleteCdmsNotification(_context.CinemaDayMovie.Where(cdm=>cdm.AiringDaysOfCinemaId==id).ToList(), notificationContent, "Removal");

            _context.AiringDaysOfCinema.Remove(adoc);
            _context.SaveChanges();

            return "Airing day of cinema removed";
        }

    }
}
