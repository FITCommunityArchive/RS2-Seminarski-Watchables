using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Exceptions;

namespace Watchables.WebAPI.Services
{
    public class CinemaDayMovieService : ICinemaDayMovieService
    {
        //Dependency injection
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public CinemaDayMovieService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.CinemaDayMovie> Get() {
            return _mapper.Map<List<Model.CinemaDayMovie>>(_context.CinemaDayMovie.ToList());
        }

        public Model.CinemaDayMovie GetById(int id) {
            return _mapper.Map<Model.CinemaDayMovie>(_context.CinemaDayMovie.Find(id));
        }

        public Model.CinemaDayMovie Insert(Model.Requests.InsertCinemaDayMovieRequest cdm) {


            bool validAirinDayOfCinema = false;
            foreach (var day in _context.AiringDaysOfCinema) {
                if (cdm.AiringDaysOfCinemaId == day.AiringDaysOfCinemaId) {
                    validAirinDayOfCinema = true;
                    break;
                }
            }
            if (!validAirinDayOfCinema) throw new UserException("Invalid airingDaysOfCinemaId");

            bool validMovie = false;
            foreach (var movie in _context.Movies.Where(m => !m.Standalone).ToList()) {
                if (cdm.MovieId == movie.MovieId) {
                    validMovie = true;
                    break;
                }
            }
            if (!validMovie) throw new UserException("Invalid movieId");

            var CDM = _mapper.Map<Database.CinemaDayMovie>(cdm);
            _context.CinemaDayMovie.Add(CDM);
            _context.SaveChanges();
            return _mapper.Map<Model.CinemaDayMovie>(CDM);
        }

    }
}
