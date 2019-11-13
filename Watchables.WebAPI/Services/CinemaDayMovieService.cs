using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;

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
    }
}
