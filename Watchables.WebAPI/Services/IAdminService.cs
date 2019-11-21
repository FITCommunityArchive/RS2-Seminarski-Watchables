using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IAdminService
    {
        public Model.Admin Insert(Model.Requests.InsertAdminRequest request);
        public List<Model.Admin> Get();
        public Model.Admin Update(int adminId, Model.Requests.InsertAdminRequest request);
        Model.Admin GetById(int id);
        string Delete(int id);

    }
}
