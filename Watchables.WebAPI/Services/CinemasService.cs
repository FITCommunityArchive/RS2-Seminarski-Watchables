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

            var cinema = _mapper.Map<Database.Cinemas>(request);
            _context.Cinemas.Add(cinema);
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

        public Model.Product AddProductToCinema(Model.Product pr) {

            var product = _mapper.Map<Database.Products>(pr);
            var inBaseProducts = _context.Products.Where(p => p.CinemaId == pr.CinemaId).ToList();

            foreach (var inProduct in inBaseProducts) {
                if (inProduct.Name.ToLower() == product.Name.ToLower() && inProduct.Price==product.Price) {
                    return pr;
                }
            }
            _context.Products.Add(product);
            _context.SaveChanges();

            return pr;
        }

        public List<Model.Hall> GetHallsOfCinema(int cinemaId) {
            return _mapper.Map<List<Model.Hall>>(_context.Hall.Where(h => h.CinemaId == cinemaId).ToList());
        }

        public List<Product> GetProductsOfCinema(int cinemaId) {
            return _mapper.Map<List<Model.Product>>(_context.Products.Where(p => p.CinemaId == cinemaId).ToList());
        }

        public Cinema Update(int cinemaId, InsertCinemaRequest request) {
            var cinema = _context.Cinemas.Find(cinemaId);
            _mapper.Map(request, cinema);
            _context.SaveChanges();
            return _mapper.Map<Model.Cinema>(cinema);
        }

        public Model.Hall UpdateHall(int hallId, Model.Hall hall) {
            var baseHall = _context.Hall.Find(hallId);
            baseHall.HallName = hall.HallName;
            baseHall.HallNumber = hall.HallNumber;
            baseHall.NumberOfseats = hall.NumberOfseats;
            _context.SaveChanges();
            return _mapper.Map<Model.Hall>(baseHall);
        }

        public Product UpdateProduct(int productId, Product product) {
            var baseProduct = _context.Products.Find(productId);
            baseProduct.Name = product.Name;
            baseProduct.Price = product.Price;
            _context.SaveChanges();
            return _mapper.Map<Model.Product>(baseProduct);
        }

        public CinemasScheduleRequest GetCinemasSchedule(int id) {

            //cinema
            var cinema = _mapper.Map<Model.Cinema>(_context.Cinemas.Find(id));

            //airing days of cinema
            var baseAiringDaysOfCinema = _context.AiringDaysOfCinema
                .Include(adoc=>adoc.AiringDay)
                .Include(adoc=>adoc.CinemaDayMovie)              
                .Where(adoc => adoc.CinemaId == id)
                .ToList();
            var airingDaysOfCinema = _mapper.Map<List<Model.AiringDaysOfCinema>>(baseAiringDaysOfCinema);

            
            var baseAiringDays = new List<Database.AiringDays>();
            var baseCinemaDayMovies = new List<Database.CinemaDayMovie>();
            var baseMovies = new List<Database.Movies>();
            var baseAppointemnts = new List<Database.Appointments>();
            var baseHalls = new List<Database.Hall>();
            foreach (var airingDayOfCinema in baseAiringDaysOfCinema) {
                baseAiringDays.Add(airingDayOfCinema.AiringDay);
                foreach (var cinemaDayMovie in airingDayOfCinema.CinemaDayMovie) {
                    baseCinemaDayMovies.Add(cinemaDayMovie);
                    foreach (var movie in _context.Movies.ToList()) {
                        if (movie.MovieId == cinemaDayMovie.MovieId) {
                            baseMovies.Add(movie);
                        }
                    }
                    foreach (var appointment in _context.Appointments) {
                        if (appointment.CinemaDayMovieId == cinemaDayMovie.CinemaDayMovieId) {
                            baseAppointemnts.Add(appointment);
                            foreach(var hall in _context.Hall.ToList()) {
                                if (appointment.HallId == hall.HallId) {
                                    baseHalls.Add(hall);
                                }
                            }
                        }

                    }
                }
            }
            baseMovies = baseMovies.Distinct().ToList();
            baseAiringDays = baseAiringDays.Distinct().ToList();
            baseHalls = baseHalls.Distinct().ToList();
            var airingDays = _mapper.Map<List<Model.AiringDay>>(baseAiringDays);
            var cinemaDayMovies = _mapper.Map<List<Model.CinemaDayMovie>>(baseCinemaDayMovies);
            var movies = _mapper.Map<List<Model.Movie>>(baseMovies);
            var appointments = _mapper.Map<List<Model.Appointments>>(baseAppointemnts);
            var halls = _mapper.Map<List<Model.Hall>>(baseHalls);

            airingDaysOfCinema.Sort((a, b) => b.Date.CompareTo(a.Date));


            //return model
            CinemasScheduleRequest schedule = new CinemasScheduleRequest {
                Cinema = cinema,
                AiringDaysOfCinema = airingDaysOfCinema,
                AiringDays = airingDays,
                CinemaDayMovies = cinemaDayMovies,
                Movies = movies,
                Appointments = appointments,
                Halls=halls
            };

            return schedule;
        }

        public Model.AiringDaysOfCinema AddAiringDayToCinema(Model.AiringDaysOfCinema ad) {
            var baseAd = _mapper.Map<Database.AiringDaysOfCinema>(ad);
            var day = baseAd.Date.DayOfWeek;
            var days = _context.AiringDays.ToList();            
            foreach(var airingDay in days) {
                if (airingDay.Name == day.ToString()) {
                    baseAd.AiringDayId = airingDay.AiringDayId;
                    break;
                }
            }            
            _context.AiringDaysOfCinema.Add(baseAd);
            _context.SaveChanges();
            return ad;
        }

        public Model.AiringDaysOfCinema UpdateAiringDay(int airingDayId, Model.AiringDaysOfCinema ad) {
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

        public Model.CinemaDayMovie AddCinemaDayMovieToCinema(Model.CinemaDayMovie cdm) {
            _context.CinemaDayMovie.Add(_mapper.Map<Database.CinemaDayMovie>(cdm));
            _context.SaveChanges();
            return cdm;
        }

        public Model.Appointments AddAppointmentToCinema(Model.Appointments app) {            
            _context.Appointments.Add(_mapper.Map<Database.Appointments>(app));
            _context.SaveChanges();
            return app;
        }

        public Model.Appointments UpdateAppointment(int appointmentId, Model.Appointments app) {
            var baseAppointment = _context.Appointments.Find(appointmentId);
            baseAppointment.Price = app.Price;
            baseAppointment.StartsAt = app.StartsAt;
            baseAppointment.HallId = app.HallId;
            _context.SaveChanges();
            return _mapper.Map<Model.Appointments>(baseAppointment);
        }
    }
}
