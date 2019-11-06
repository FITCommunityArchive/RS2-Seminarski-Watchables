using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class HallsService : IHallsService
    {
        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public HallsService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }      

        public List<Model.Hall> Get() {            
            return _mapper.Map<List<Model.Hall>>(_context.Hall.ToList());
        }

        public Model.Hall GetById(int id) {
            return _mapper.Map<Model.Hall>(_context.Hall.Find(id));
        }

      
    }
}
