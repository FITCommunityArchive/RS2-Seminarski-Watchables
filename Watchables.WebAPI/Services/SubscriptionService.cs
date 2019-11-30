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

            Helper helper = new Helper(_context);

            var validSubscription = false;
            foreach (var s in _context.Subscriptions.ToList()) {
                if (s.SubscriptionId == id) {
                    validSubscription = true;
                    break;
                }
            }
            if (!validSubscription) throw new UserException("Cannot find a subscription with specified id");

            var subscription = _context.Subscriptions.Find(id);
            helper.DeleteSubscriptionNotification(subscription, $"The subscription with number of movies: {subscription.NumberOfMovies}, number of shows: {subscription.NumberOfShows}, number of tickets: {subscription.NumberOfTickets}, with the price of {subscription.Price}/month, has been removed", "Removal");

            return "Subscription removed";    
        }

        public override Subscription Update(int id, InsertSubscriptionRequest request) {

            var changedSubscription = base.Update(id, request);

            Helper helper = new Helper(_context);
            helper.ChangeSubscriptionNotification(_mapper.Map<Database.Subscriptions>(changedSubscription), $"Subscription information changed (number of movies: {changedSubscription.NumberOfMovies}, number of shows: {changedSubscription.NumberOfShows}, number of tickets: {changedSubscription.NumberOfTickets}, price: {changedSubscription.Price}, avaiable: {changedSubscription.Available}", "Warning");

            return changedSubscription;
        }

    }
}
