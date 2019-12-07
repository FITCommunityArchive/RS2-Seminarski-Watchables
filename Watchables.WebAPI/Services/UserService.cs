using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class UserService : IUserService
    {

        //Dependency injection 
        private readonly _160304Context _context;
        private readonly IMapper _mapper;
        private readonly IAccountService _accoutnService;
        public UserService(_160304Context context, IMapper mapper, IAccountService accountService) {
            _context = context;
            _mapper = mapper;
            _accoutnService = accountService;
        }

        public string BuyItem(Buy buy) {

            bool validUser = false;
            foreach(var user in _context.Users.ToList()) {
                if (user.UserId == buy.UserId) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user could not be found");

            if (buy.Item == global::BuyItem.Movie) {

                bool valid = false;
                foreach (var item in _context.Movies.ToList()) {
                    if (item.MovieId == buy.ItemId) {
                        valid = true;
                        break;
                    }
                }
                if (!valid) throw new UserException("The movie could not be found");


                Database.UsersMovies newMovie = new UsersMovies() {
                    MovieId = buy.ItemId,
                    UserId = buy.UserId
                };
                _context.UsersMovies.Add(newMovie);
                _context.SaveChanges();
                return "Movie bought!";

            }
            else if(buy.Item == global::BuyItem.Show) {

                bool valid = false;
                foreach (var item in _context.Shows.ToList()) {
                    if (item.ShowId == buy.ItemId) {
                        valid = true;
                        break;
                    }
                }
                if (!valid) throw new UserException("The show could not be found");


                Database.UsersShows newShow = new UsersShows() {
                    ShowId = buy.ItemId,
                    UserId = buy.UserId
                };
                _context.UsersShows.Add(newShow);
                _context.SaveChanges();

                return "Show bought!";
            }
            else if (buy.Item == global::BuyItem.Subscription) {

                bool valid = false;
                foreach (var item in _context.Subscriptions.ToList()) {
                    if (item.SubscriptionId == buy.ItemId) {
                        valid = true;
                        break;
                    }
                }
                if (!valid) throw new UserException("The subscription could not be found");


                Database.UsersSubscriptions newSubscription = new UsersSubscriptions() {
                    SubscriptionId = buy.ItemId,
                    UserId = buy.UserId
                };
                _context.UsersSubscriptions.Add(newSubscription);
                _context.SaveChanges();

                return "Subscription bought!";
            }

            else {

                bool valid = false;
                foreach (var item in _context.Rotations.ToList()) {
                    if (item.RotationId == buy.ItemId) {
                        valid = true;
                        break;
                    }
                }
                if (!valid) throw new UserException("The rotation could not be found");


                Database.UsersRotations newRotation = new UsersRotations() {
                    RotationId = buy.ItemId,
                    UserId = buy.UserId
                };
                _context.UsersRotations.Add(newRotation);
                _context.SaveChanges();

                return "Rotation bought!";
            }           
        }

        public string DeleteItem(Delete delete) {

            bool validUser = false;
            foreach (var user in _context.Users.ToList()) {
                if (user.UserId == delete.UserId) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user could not be found");

            if (delete.Item == global::BuyItem.Movie) {
                var inBase = _context.UsersMovies.Where(i => i.MovieId == delete.ItemId && i.UserId == i.UserId).Single();
                if (inBase == null) throw new UserException("Movie could not be found");
                _context.UsersMovies.Remove(inBase);
                _context.SaveChanges();
                return "Movie deleted";
            }

            else if(delete.Item == global::BuyItem.Show) {
                var inBase = _context.UsersShows.Where(i => i.ShowId == delete.ItemId && i.UserId == i.UserId).Single();
                if (inBase == null) throw new UserException("Show could not be found");
                _context.UsersShows.Remove(inBase);
                _context.SaveChanges();
                return "Show deleted";
            }

            else if (delete.Item == global::BuyItem.Subscription) {
                var inBase = _context.UsersSubscriptions.Where(i => i.SubscriptionId == delete.ItemId && i.UserId == i.UserId).Single();
                if (inBase == null) throw new UserException("Subscription could not be found");
                _context.UsersSubscriptions.Remove(inBase);
                _context.SaveChanges();
                return "Subscription deleted";
            }

            else {
                var inBase = _context.UsersRotations.Where(i => i.RotationId == delete.ItemId && i.UserId == i.UserId).Single();
                if (inBase == null) throw new UserException("Rotation could not be found");
                _context.UsersRotations.Remove(inBase);
                _context.SaveChanges();
                return "Rotation deleted";
            }

        }

        public List<Model.User> Get(Model.Requests.UserSearchRequest request) {

            var query = _context.Users.Include(u=>u.Account).AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.FirstName)) query = query.Where(m => m.FirstName.ToLower().StartsWith(request.FirstName.ToLower()));
            if (!string.IsNullOrWhiteSpace(request.LastName)) query = query.Where(m => m.LastName.ToLower().StartsWith(request.LastName.ToLower()));
            if (!string.IsNullOrWhiteSpace(request.Userneme)) query = query.Where(m => m.Account.Username.ToLower().StartsWith(request.Userneme.ToLower()));

            return _mapper.Map<List<Model.User>>(query.ToList());
        }

        public User GetById(int id) {
            return _mapper.Map<Model.User>(_context.Users.Include(u => u.Account).Single(u=>u.UserId==id));
        }

        public Model.User Insert(InsertUserRequest request) {

            var user = _mapper.Map<Database.Users>(request);

            request.Role = Role.Korisnik;
            var accountId = _accoutnService.Insert(request).AccountId;

            user.AccountId = accountId;
            user.Locked = false;

            _context.Users.Add(user);
            _context.SaveChanges();

            return _mapper.Map<Model.User>(user);
        }

        public string LockToggle(bool flag) {
            foreach (var user in _context.Users.ToList()) user.Locked = flag;
            _context.SaveChanges();
            if (flag) return "Users are locked";
            else return "Users are unlocked";
        }

        public User Update(int userId, InsertUserRequest request) {
            var user = _context.Users.Find(userId);
            _mapper.Map(request, user);
            _context.SaveChanges();

            _accoutnService.Update(user.AccountId, request);


            return _mapper.Map<Model.User>(user);
        }
    }
}
