using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class ShowsService : IShowsService
    {
        //Dependency injection
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        public ShowsService(_160304Context context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Show> Get(Model.Requests.ShowSearchRequest request) {

            var query = _context.Shows.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Title)) query = query.Where(s => s.Title.ToLower().StartsWith(request.Title.ToLower()));
            if (request.Year >= 0) query = query.Where(s => s.Year >= request.Year);
            if (request.Rating >= 0) query = query.Where(s => s.Rating >= request.Rating);
            if (!string.IsNullOrWhiteSpace(request.Ongoing) && request.Ongoing == "true") query = query.Where(s => s.Ongoing);
            if (!string.IsNullOrWhiteSpace(request.Ongoing) && request.Ongoing == "false") query = query.Where(s => !s.Ongoing);

            return _mapper.Map<List<Model.Show>>(query.ToList());
        }


        public Model.Show GetById(int id) {
            return _mapper.Map<Model.Show>(_context.Shows.Find(id));
        }

        public Model.Show Insert(Model.Requests.InsertShowRequest request) {

            var show = _mapper.Map<Database.Shows>(request);
            _context.Shows.Add(show);
            _context.SaveChanges();

            return _mapper.Map<Model.Show>(_mapper.Map<Database.Shows>(request));
        }

        public Model.Show Update(int showId, Model.Requests.InsertShowRequest request) {
            var show = _context.Shows.Find(showId);
            _mapper.Map(request, show);
            _context.SaveChanges();
            return _mapper.Map<Model.Show>(show);
        }

    }
}
