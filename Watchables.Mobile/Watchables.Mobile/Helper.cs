using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Watchables.Mobile
{
    public class Helper
    {
        public readonly APIService _usersApi = new APIService("users");
        public async Task<bool> IsLocked() {
            var user = await _usersApi.GetById<Model.User>(APIService.User.UserId);
            return user.Locked;
        }
    }
}
