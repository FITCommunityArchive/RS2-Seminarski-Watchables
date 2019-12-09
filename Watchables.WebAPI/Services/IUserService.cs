using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IUserService
    {
        List<Model.User> Get(Model.Requests.UserSearchRequest request);
        Model.User GetById(int id);
        Model.User Insert(Model.Requests.InsertUserRequest request);
        Model.User Update(int userId, Model.Requests.InsertUserRequest request);
        string LockToggle(bool flag);
        string BuyItem(Model.Buy buy);
        string DeleteItem(Model.Delete delete);
        List<Model.Movie> RecommendedMovies(int userId);
        List<Model.Show> RecommendedShows(int userId);

        List<Model.Movie> Movies(int id);
        List<Model.Show> Shows(int id);
        List<Model.Subscription> Subscriptions(int id);
        List<Model.Rotation> Rotations(int id);
        List<Model.Notification> Notifications(int id);

        Model.User DeactivateUser(int id);
        Model.User ActivateUser(int id);

    }
}

