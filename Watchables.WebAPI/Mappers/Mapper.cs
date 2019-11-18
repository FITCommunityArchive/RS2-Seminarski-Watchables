using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper() {
            CreateMap<Database.Cinemas, Model.Cinema>().ReverseMap();
            CreateMap<Database.Products, Model.Product>().ReverseMap();
            CreateMap<Database.Hall, Model.Hall>().ReverseMap();
            CreateMap<Database.Cinemas, Model.Requests.InsertCinemaRequest>().ReverseMap();
            CreateMap<Database.AiringDays, Model.AiringDay>().ReverseMap();
            CreateMap<Database.AiringDaysOfCinema, Model.AiringDaysOfCinema>().ReverseMap();
            CreateMap<Database.CinemaDayMovie, Model.CinemaDayMovie>().ReverseMap();
            CreateMap<Database.Appointments, Model.Appointments>().ReverseMap();
            CreateMap<Database.Movies, Model.Movie>().ReverseMap();
            CreateMap<Database.Movies, Model.Requests.InsertMovieRequest>().ReverseMap();
            CreateMap<Database.Shows, Model.Show>().ReverseMap();
            CreateMap<Database.Shows, Model.Requests.InsertShowRequest>().ReverseMap();
        }
    }
}
