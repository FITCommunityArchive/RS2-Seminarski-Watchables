using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class AiringDayService : IAiringDayService
    {
        //Dependency injection
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public AiringDayService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<AiringDay> Get() {
            return _mapper.Map<List<Model.AiringDay>>(_context.AiringDays.ToList());
        }

        public AiringDay GetById(int id) {
            return _mapper.Map<Model.AiringDay>(_context.AiringDays.Find(id));
        }
    }
}
