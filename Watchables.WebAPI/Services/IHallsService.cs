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
        List<Model.Hall> GetHallsOfCinema(int cinemaId);
        Model.Hall AddHallToCinema(int cinemaId, Model.Hall hall);
    }
}
