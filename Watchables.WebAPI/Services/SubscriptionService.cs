using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.WebAPI.Database;

namespace Watchables.WebAPI.Services
{
    public class SubscriptionService : BaseCRUDService<Model.Subscription, Model.Requests.SubscriptionSearchRequest, Database.Subscriptions, Model.Requests.InsertSubscriptionRequest, Model.Requests.InsertSubscriptionRequest>
    {
        public SubscriptionService(_160304Context context, IMapper mapper) : base(context, mapper) {
        }

        public override List<Model.Subscription> Get(Model.Requests.SubscriptionSearchRequest search) {
            var query = _context.Set<Database.Subscriptions>().AsQueryable();

            if (search.NumberOfMovies > 0) query = query.Where(s => s.NumberOfMovies > search.NumberOfMovies);
            if (search.NumberOfShows > 0) query = query.Where(s => s.NumberOfShows > search.NumberOfShows);
            if (search.NumberOfTickets > 0) query = query.Where(s => s.NumberOfTickets > search.NumberOfTickets);
            if (search.Price > 0) query = query.Where(s => s.Price > search.Price);

            var list = query.ToList();

            return _mapper.Map<List<Model.Subscription>>(list);
        }

        public override string Delete(int id) {
            return "Sada se desava ovo i nista se ne brise";    
        }
    }
}
