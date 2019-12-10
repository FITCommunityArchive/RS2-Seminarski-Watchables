using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IAnalyticsService
    {

        public List<Model.UsersMovies> GetMovies();
        public List<Model.UsersShows> GetShows();
        public List<Model.UsersSubscriptions> GetSubscriptions();

    }
}
