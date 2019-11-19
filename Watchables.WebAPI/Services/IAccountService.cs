using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IAccountService
    {
        List<Model.Account> Get();
        Model.Account GetById(int id);
        Model.Account Insert(Model.Requests.InsertAccountRequest request);
        Model.Account Update(int accountId, Model.Requests.InsertAccountRequest request);
        Model.Account Authenticate(string username, string pass);
    }
}


