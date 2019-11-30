using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IHallsService
    {
        List<Model.Hall> Get();
        Model.Hall GetById(int id);
        Model.Hall Insert(Model.Requests.InsertHallRequest hall);
        Model.Hall Update(int hallId, Model.Requests.InsertHallRequest hall);
        string Delete(int id);
    }
}
