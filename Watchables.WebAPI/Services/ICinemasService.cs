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
        Model.Hall AddHallToCinema(Model.Hall hall);
        Model.Product AddProductToCinema(int cinemaId, Model.Product pr);
        List<Model.Hall> GetHallsOfCinema(int cinemaId);
        List<Model.Product> GetProductsOfCinema(int cinemaId);
    }
}
