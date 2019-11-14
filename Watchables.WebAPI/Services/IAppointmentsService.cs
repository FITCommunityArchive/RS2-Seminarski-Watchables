using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IAppointmentsService
    {
        List<Model.Appointments> Get();
        Model.Appointments GetById(int id);
    }
}
