using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.Model.Requests;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class MoviesService : IMoviesService
    {

        //Dependency injection
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public MoviesService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Movie> Get(Model.Requests.MovieSearchRequest request) {

            var query = _context.Movies.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Title)) query = query.Where(m => m.Title.ToLower().StartsWith(request.Title.ToLower()));
            if (!string.IsNullOrWhiteSpace(request.Genre)) query = query.Where(m => m.Genre.ToLower().StartsWith(request.Genre.ToLower()));
            if (request.Year >= 0) query = query.Where(m => m.Year >= request.Year);
            if (request.Rating >= 0) query = query.Where(m => m.Rating >= request.Rating);
            if (!string.IsNullOrWhiteSpace(request.Standalone) && request.Standalone == "true") query = query.Where(m => m.Standalone);
            if (!string.IsNullOrWhiteSpace(request.Standalone) && request.Standalone == "false") query = query.Where(m => !m.Standalone);

            return _mapper.Map<List<Model.Movie>>(query.ToList());
        }

        public Movie GetById(int id) {
            return _mapper.Map<Model.Movie>(_context.Movies.Find(id));
        }

        public Model.Movie Insert(InsertMovieRequest request) {

            var movie = _mapper.Map<Database.Movies>(request);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            return _mapper.Map<Model.Movie>(_mapper.Map<Database.Movies>(request));
        }

        public Movie Update(int movieId, InsertMovieRequest request) {
            var movie = _context.Movies.Find(movieId);
            _mapper.Map(request, movie);
            _context.SaveChanges();
            return _mapper.Map<Model.Movie>(movie);
        }
    }
}
