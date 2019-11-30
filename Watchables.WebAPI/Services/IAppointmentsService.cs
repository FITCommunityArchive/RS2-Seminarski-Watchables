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
        Model.Appointments Insert(Model.Requests.InsertAppointmentRequest app);
        Model.Appointments Update(int appointmentId, Model.Requests.InsertAppointmentRequest app);
        string Delete(int id);
    }
}
