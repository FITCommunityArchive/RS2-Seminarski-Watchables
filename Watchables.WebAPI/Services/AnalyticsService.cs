using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class AnalyticsService : IAnalyticsService
    {

        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public AnalyticsService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.UsersMovies> GetMovies() {
            return _mapper.Map<List<Model.UsersMovies>>(_context.UsersMovies.ToList());
        }

        public List<Model.UsersShows> GetShows() {
            return _mapper.Map<List<Model.UsersShows>>(_context.UsersShows.ToList());
        }

        public List<Model.UsersSubscriptions> GetSubscriptions() {
            return _mapper.Map<List<Model.UsersSubscriptions>>(_context.UsersSubscriptions.ToList());
        }
    }
}
