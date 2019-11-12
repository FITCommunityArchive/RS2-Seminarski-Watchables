using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
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

        public List<Model.Movie> Get() {
            return _mapper.Map<List<Model.Movie>>(_context.Movies.ToList());
        }

        public Movie GetById(int id) {
            return _mapper.Map<Model.Movie>(_context.Movies.Find(id));
        }
    }
}
