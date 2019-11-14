using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class AppointmentsService : IAppointmentsService
    {
        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public AppointmentsService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Appointments> Get() {
            return _mapper.Map<List<Model.Appointments>>(_context.Appointments.ToList());
        }

        public Model.Appointments GetById(int id) {
            return _mapper.Map<Model.Appointments>(_context.Appointments.Find(id));
        }
    }
}
