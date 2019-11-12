using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IAiringDayService
    {
        List<Model.AiringDay> Get();
        Model.AiringDay GetById(int id);
    }
}
