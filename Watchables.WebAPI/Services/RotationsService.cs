using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.Model.Requests;
using Watchables.WebAPI.Database;
using Watchables.WebAPI.Exceptions;

namespace Watchables.WebAPI.Services
{
    public class RotationsService : BaseCRUDService<Model.Rotation, Model.Requests.RotationSearchRequest, Database.Rotations, Model.Requests.InsertRotationRequest, Model.Requests.InsertRotationRequest>
    {
        public RotationsService(_160304Context context, IMapper mapper) : base(context, mapper) {
        }

        public override List<Model.Rotation> Get(Model.Requests.RotationSearchRequest search) {
            var query = _context.Set<Database.Rotations>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search.ForBirthday) && search.ForBirthday.ToLower() =="true") query = query.Where(r => r.ForBirthday == true);
            if (!string.IsNullOrWhiteSpace(search.ForBirthday) && search.ForBirthday.ToLower() == "false") query = query.Where(r => r.ForBirthday == false);

            var list = query.ToList();

            return _mapper.Map<List<Model.Rotation>>(list);
        }

        public override string Delete(int id) {
            Helper helper = new Helper(_context);

            var validRotation = false;
            foreach (var r in _context.Rotations.ToList()) {
                if (r.RotationId == id) {
                    validRotation = true;
                    break;
                }
            }
            if (!validRotation) throw new UserException("Cannot find a rotation with specified id");

            var rotation = _context.Rotations.Find(id);
            helper.DeleteRotationNotification(rotation, $"The rotation from {rotation.From.Date} to {rotation.To.Date} for '{rotation.Description}', with the movie '{_context.Movies.Find(rotation.MovieId).Title}' and show '{_context.Shows.Find(rotation.ShowId).Title}' hase been removed", "Removal");

            return "Rotation removed";
        }

        public override Rotation Update(int id, InsertRotationRequest request) {
            var changedRotation = base.Update(id, request);
            Helper helper = new Helper(_context);
            helper.ChangeRotationNotification(_mapper.Map<Database.Rotations>(changedRotation), $"Rotation information changed (from: {changedRotation.From.Date}, to: {changedRotation.To.Date}, decription: {changedRotation.Description}, show: {_context.Shows.Find(changedRotation.ShowId).Title}, movie: {_context.Movies.Find(changedRotation.MovieId).Title}, avaiable: {changedRotation.Available})", "Warning");
            return changedRotation;
        }

    }
}
