using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;

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
    }
}
