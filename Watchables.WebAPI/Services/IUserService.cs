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
    }
}
