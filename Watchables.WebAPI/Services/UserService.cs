using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watchables.Model;
using Watchables.Model.Requests;
using Watchables.WebAPI.CBF;
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
        private readonly WordBagGenerator _wordBagGenerator = new WordBagGenerator();
        private readonly Similarity _similarity = new Similarity();

        public string BuyItem(Buy buy) {

            bool validUser = false;
            foreach(var user in _context.Users.ToList()) {
                if (user.UserId == buy.UserId) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user could not be found");

            Database.Notifications notification = new Notifications() {
                Created = DateTime.Now,
                Type = "Add"
            };
            Database.UsersNotifications not = new UsersNotifications() {
                UserId = buy.UserId
            };
            

            if (buy.Item == global::BuyItem.Movie) {

                bool valid = false;
                foreach (var item in _context.Movies.ToList()) {
                    if (item.MovieId == buy.ItemId) {
                        valid = true;
                        break;
                    }
                }
                if (!valid) throw new UserException("The movie could not be found");


                Database.UsersMovies newMovie = new Database.UsersMovies {
                    MovieId = buy.ItemId,
                    UserId = buy.UserId,
                    PurchaseDate=DateTime.Now,
                    PurchaseAmount=_context.Movies.Find(buy.ItemId).Price
                };
                _context.UsersMovies.Add(newMovie);
                notification.Content = $"{_context.Users.Find(buy.UserId).FirstName} {_context.Users.Find(buy.UserId).LastName} bought the movie '{_context.Movies.Find(buy.ItemId).Title}'";
                _context.Notifications.Add(notification);
                not.Notification = notification;
                _context.UsersNotifications.Add(not);
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


                Database.UsersShows newShow = new Database.UsersShows() {
                    ShowId = buy.ItemId,
                    UserId = buy.UserId,
                    PurchaseDate = DateTime.Now,
                    PurchaseAmount = _context.Shows.Find(buy.ItemId).Price
                };
                _context.UsersShows.Add(newShow);
                notification.Content = $"{_context.Users.Find(buy.UserId).FirstName} {_context.Users.Find(buy.UserId).LastName} bought the show '{_context.Shows.Find(buy.ItemId).Title}'";
                _context.Notifications.Add(notification);
                not.Notification = notification;
                _context.UsersNotifications.Add(not);
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


                Database.UsersSubscriptions newSubscription = new Database.UsersSubscriptions() {
                    SubscriptionId = buy.ItemId,
                    UserId = buy.UserId,
                    SubscriptionDate=DateTime.Now
                };
                _context.UsersSubscriptions.Add(newSubscription);
               

                notification.Content = $"{_context.Users.Find(buy.UserId).FirstName} {_context.Users.Find(buy.UserId).LastName} subscribed for {_context.Subscriptions.Find(buy.ItemId).Price}";
                _context.Notifications.Add(notification);
                not.Notification = notification;
                _context.UsersNotifications.Add(not);
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
                    UserId = buy.UserId,
                    RotationClaimed=DateTime.Now
                };
                _context.UsersRotations.Add(newRotation);
                var rotation = _context.Rotations.Include(r => r.Movie).Include(r => r.Show).Single(r => r.RotationId == buy.ItemId);
                notification.Content = $"{_context.Users.Find(buy.UserId).FirstName} {_context.Users.Find(buy.UserId).LastName} claimed the rotation '{rotation.Movie.Title} / {rotation.Show.Title}'";
                _context.Notifications.Add(notification);
                not.Notification = notification;
                _context.UsersNotifications.Add(not);
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

            Database.Notifications notification = new Notifications() {
                Created = DateTime.Now,
                Type = "Removal"
            };
            Database.UsersNotifications not = new UsersNotifications() {
                UserId = delete.UserId
            };

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
                notification.Content = $"{_context.Users.Find(delete.UserId).FirstName} {_context.Users.Find(delete.UserId).LastName} canceled a subscription of {_context.Subscriptions.Find(delete.ItemId).Price}";
                _context.Notifications.Add(notification);
                not.Notification = notification;
                _context.UsersNotifications.Add(not);
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
            user.Active = true;

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

        public List<Movie> RecommendedMovies(int userId) {

            var consumerList = _context.UsersMovies.Where(um=>um.UserId == userId).Include(um => um.Movie).ToList();
            List<Model.Movie> usersMovies = new List<Movie>();
            foreach(var movie in consumerList) {
                usersMovies.Add(_mapper.Map<Model.Movie>(movie.Movie));
            }
            var allMovies = _mapper.Map<List<Model.Movie>>(_context.Movies.ToList());
            foreach(var item in usersMovies) {
                allMovies.RemoveAll(m => m.MovieId == item.MovieId);
            }
            List<ItemScore<Model.Movie>> allMoviesWithScore = new List<ItemScore<Movie>>();
            foreach(var movie in allMovies) {
                ItemScore<Model.Movie> newItem = new ItemScore<Movie>() {
                    Item = movie,
                    Score = 0
                };
                allMoviesWithScore.Add(newItem);
            }

            foreach(var movie in allMoviesWithScore) {
                foreach(var usersMovie in usersMovies) {
                    movie.Score += _similarity.CalculateSimilarity(_wordBagGenerator.GenerateWordBag<Model.Movie>(movie.Item), _wordBagGenerator.GenerateWordBag<Model.Movie>(usersMovie));
                }
            }

            allMoviesWithScore.Sort((a, b) => b.Score.CompareTo(a.Score));
            List<Model.Movie> recommendedMovies = new List<Movie>();
            foreach(var movie in allMoviesWithScore) {
                recommendedMovies.Add(movie.Item);
            }

            return recommendedMovies;
        }

        public List<Show> RecommendedShows(int userId) {

            var consumerList = _context.UsersShows.Where(um => um.UserId == userId).Include(um => um.Show).ToList();
            List<Model.Show> usersShows = new List<Show>();
            foreach (var show in consumerList) {
                usersShows.Add(_mapper.Map<Model.Show>(show.Show));
            }
            var allShows = _mapper.Map<List<Model.Show>>(_context.Shows.ToList());
            foreach (var item in usersShows) {
                allShows.RemoveAll(m => m.ShowId == item.ShowId);
            }
            List<ItemScore<Model.Show>> allShowsWithScore = new List<ItemScore<Show>>();
            foreach (var show in allShows) {
                ItemScore<Model.Show> newItem = new ItemScore<Show>() {
                    Item = show,
                    Score = 0
                };
                allShowsWithScore.Add(newItem);
            }

            foreach (var show in allShowsWithScore) {
                foreach (var usersShow in usersShows) {
                    show.Score += _similarity.CalculateSimilarity(_wordBagGenerator.GenerateWordBag<Model.Show>(show.Item), _wordBagGenerator.GenerateWordBag<Model.Show>(usersShow));
                }
            }

            allShowsWithScore.Sort((a, b) => b.Score.CompareTo(a.Score));
            List<Model.Show> recommendedShows = new List<Show>();
            foreach (var show in allShowsWithScore) {
                recommendedShows.Add(show.Item);
            }

            return recommendedShows;
        }

        public List<Movie> Movies(int id) {

            bool validUser = false;
            foreach(var user in _context.Users.ToList()) {
                if (user.UserId == id) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user with that id could not be found!");

            var list = _context.UsersMovies.Include(l => l.Movie).Where(l => l.UserId == id).ToList();
            var items = new List<Model.Movie>();
            foreach (var item in list) {
                items.Add(_mapper.Map<Model.Movie>(item.Movie));
            }
            return items;
        }

        public List<Show> Shows(int id) {
            bool validUser = false;
            foreach (var user in _context.Users.ToList()) {
                if (user.UserId == id) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user with that id could not be found!");

            var list = _context.UsersShows.Include(l => l.Show).Where(l => l.UserId == id).ToList();
            var items = new List<Model.Show>();
            foreach (var item in list) {
                items.Add(_mapper.Map<Model.Show>(item.Show));
            }
            return items;
        }

        public List<Subscription> Subscriptions(int id) {
            bool validUser = false;
            foreach (var user in _context.Users.ToList()) {
                if (user.UserId == id) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user with that id could not be found!");

            var list = _context.UsersSubscriptions.Include(l => l.Subscription).Where(l => l.UserId == id).ToList();
            var items = new List<Model.Subscription>();
            foreach (var item in list) {
                items.Add(_mapper.Map<Model.Subscription>(item.Subscription));
            }
            return items;
        }

        public List<Rotation> Rotations(int id) {
            bool validUser = false;
            foreach (var user in _context.Users.ToList()) {
                if (user.UserId == id) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user with that id could not be found!");

            var list = _context.UsersRotations.Include(l => l.Rotation).Where(l => l.UserId == id).ToList();
            var items = new List<Model.Rotation>();
            foreach (var item in list) {
                items.Add(_mapper.Map<Model.Rotation>(item.Rotation));
            }
            return items;
        }

        public List<Notification> Notifications(int id) {
            bool validUser = false;
            foreach (var user in _context.Users.ToList()) {
                if (user.UserId == id) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user with that id could not be found!");

            var list = _context.UsersNotifications.Include(l => l.Notification).Where(l => l.UserId == id).ToList();
            var items = new List<Model.Notification>();
            foreach (var item in list) {
                items.Add(_mapper.Map<Model.Notification>(item.Notification));
            }
            return items;
        }

        public Model.User DeactivateUser(int id) {
            bool validUser = false;
            foreach (var user in _context.Users.ToList()) {
                if (user.UserId == id) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user with that id could not be found!");
            _context.Users.Find(id).Active = false;
            _context.SaveChanges();
            return _mapper.Map<Model.User>(_context.Users.Find(id));
        }

        public Model.User ActivateUser(int id) {
            bool validUser = false;
            foreach (var user in _context.Users.ToList()) {
                if (user.UserId == id) {
                    validUser = true;
                    break;
                }
            }
            if (!validUser) throw new UserException("The user with that id could not be found!");
            _context.Users.Find(id).Active = true;
            _context.SaveChanges();
            return _mapper.Map<Model.User>(_context.Users.Find(id));
        }
    }
}
