using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IShowsService
    {
        List<Model.Show> Get(Model.Requests.ShowSearchRequest request);
        Model.Show GetById(int id);
        Model.Show Insert(Model.Requests.InsertShowRequest request);
        Model.Show Update(int movieId, Model.Requests.InsertShowRequest request);
    }
}
