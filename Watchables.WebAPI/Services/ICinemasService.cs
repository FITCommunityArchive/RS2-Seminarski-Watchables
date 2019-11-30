using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model.Requests;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public interface ICinemasService
    {
        List<Model.Cinema> Get(Model.Requests.CinemasSearchRequest request);
        Model.Cinema GetById(int id);
        Model.Cinema Insert(InsertCinemaRequest request);
        List<Model.Hall> GetHallsOfCinema(int cinemaId);
        List<Model.Product> GetProductsOfCinema(int cinemaId);
        Model.Cinema Update(int cinemaId, InsertCinemaRequest request);
        CinemasScheduleRequest GetCinemasSchedule(int id);
        string Delete(int id);
    }
}
