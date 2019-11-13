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
        Model.Product AddProductToCinema(Model.Product pr);
        Model.AiringDaysOfCinema AddAiringDayToCinema(Model.AiringDaysOfCinema ad);
        Model.CinemaDayMovie AddCinemaDayMovieToCinema(Model.CinemaDayMovie cdm);

        List<Model.Hall> GetHallsOfCinema(int cinemaId);
        List<Model.Product> GetProductsOfCinema(int cinemaId);

        Model.Cinema Update(int cinemaId, InsertCinemaRequest request);
        Model.Hall UpdateHall(int hallId, Model.Hall hall);
        Model.Product UpdateProduct(int productId, Model.Product product);
        Model.AiringDaysOfCinema UpdateAiringDay(int airingDayId, Model.AiringDaysOfCinema ad);

        CinemasScheduleRequest GetCinemasSchedule(int id);


    }
}
