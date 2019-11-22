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

            CreateMap<Database.Admins, Model.Admin>().ReverseMap();
            CreateMap<Database.Admins, Model.Requests.InsertAdminRequest>().ReverseMap();

            CreateMap<Database.Account, Model.Account>().ReverseMap();
            CreateMap<Database.Account, Model.Requests.InsertAccountRequest>().ReverseMap();

            CreateMap<Database.Users, Model.User>().ReverseMap();
            CreateMap<Database.Users, Model.Requests.InsertUserRequest>().ReverseMap();

            CreateMap<Database.Hall, Model.Requests.InsertHallRequest>().ReverseMap();
            CreateMap<Database.Products, Model.Requests.InsertProductRequest>().ReverseMap();

            CreateMap<Database.AiringDaysOfCinema, Model.Requests.InserAiringDayOfCinemaRequest>().ReverseMap();
            CreateMap<Database.CinemaDayMovie, Model.Requests.InsertCinemaDayMovieRequest>().ReverseMap();

            CreateMap<Database.Appointments, Model.Requests.InsertAppointmentRequest>().ReverseMap();

            CreateMap<Database.Subscriptions, Model.Subscription>().ReverseMap();
            CreateMap<Database.Subscriptions, Model.Requests.InsertSubscriptionRequest>().ReverseMap();

            CreateMap<Database.Rotations, Model.Rotation>().ReverseMap();
            CreateMap<Database.Rotations, Model.Requests.InsertRotationRequest>().ReverseMap();

        }
    }
}
