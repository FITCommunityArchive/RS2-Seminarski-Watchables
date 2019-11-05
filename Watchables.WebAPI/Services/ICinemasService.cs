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
        InsertCinemaRequest Insert(InsertCinemaRequest request);
      
    }
}
