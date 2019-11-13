using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IAiringDaysOfCinemaService
    {
        List<Model.AiringDaysOfCinema> Get();
        Model.AiringDaysOfCinema GetById(int id);
    }
}
