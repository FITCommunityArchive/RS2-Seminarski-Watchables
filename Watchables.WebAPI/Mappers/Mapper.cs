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
        }
    }
}
