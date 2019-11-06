using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watchables.WebAPI.Services
{
    public interface IProductsService
    {
        List<Model.Product> Get();
        Model.Product GetById(int id);             
    }
}
