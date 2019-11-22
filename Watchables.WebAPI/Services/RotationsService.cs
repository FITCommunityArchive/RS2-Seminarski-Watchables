using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class RotationsService : BaseCRUDService<Model.Rotation, Model.Requests.RotationSearchRequest, Database.Rotations, Model.Requests.InsertRotationRequest, Model.Requests.InsertRotationRequest>
    {
        public RotationsService(_160304Context context, IMapper mapper) : base(context, mapper) {
        }

        public override List<Model.Rotation> Get(Model.Requests.RotationSearchRequest search) {
            var query = _context.Set<Database.Rotations>().AsQueryable();


            var list = query.ToList();

            return _mapper.Map<List<Model.Rotation>>(list);
        }

        public override string Delete(int id) {
            return "Sada se desava ovo i nista se ne brise";
        }
    }
}
