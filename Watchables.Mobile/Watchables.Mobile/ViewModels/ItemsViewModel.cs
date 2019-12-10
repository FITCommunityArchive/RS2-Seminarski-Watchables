using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Watchables.Mobile.Models;
using Watchables.Mobile.Views;
using System.Windows.Input;
using System.Collections.Generic;

namespace Watchables.Mobile.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ICommand GetDataCommand { get; set; }
        public ICommand RemoveNotificationCommand { get; set; }
        public APIService _usersApi = new APIService("users");
        public APIService _ordersApi = new APIService("orders");
        public APIService _cdmsApi = new APIService("CinemaDayMovie");
        public APIService _moviesApi = new APIService("movies");
        public APIService _appsApi = new APIService("Appointments");
        public APIService _adocApi = new APIService("AiringDaysOfCinema");
        public APIService _cinemaApi = new APIService("cinemas");
        public APIService _adApi = new APIService("AiringDays");
        public APIService _showsApi = new APIService("Shows");

        public ItemsViewModel() {
            GetDataCommand = new Command(async () => await GetData());
            RemoveNotificationCommand = new Command(() => RemoveNotification());
        }
        string _hasNotifications = string.Empty;
        public string HasNotifications {
            get { return _hasNotifications; }
            set { SetProperty(ref _hasNotifications, value); }
        }
        public ObservableCollection<Model.ObservableLists.OrderItem> Orders { get; set; } = new ObservableCollection<Model.ObservableLists.OrderItem>();
        public ObservableCollection<Model.Movie> Movies { get; set; } = new ObservableCollection<Model.Movie>();
        public ObservableCollection<Model.Show> Shows { get; set; } = new ObservableCollection<Model.Show>();
        public ObservableCollection<Model.Subscription> Subscriptions { get; set; } = new ObservableCollection<Model.Subscription>();
        public ObservableCollection<Model.ObservableLists.RotationItem> Rotations { get; set; } = new ObservableCollection<Model.ObservableLists.RotationItem>();

        public async Task GetData() {
            var notifications = await _usersApi.GetItems<List<Model.Notification>>(APIService.User.UserId, "Notifications");
            if (notifications.Count == 0) HasNotifications = "False";
            else HasNotifications = "True";

            var orders = await _ordersApi.Get<List<Model.Order>>(null);
            orders.RemoveAll(o => o.UserId != APIService.User.UserId);
            Orders.Clear();
            foreach(var order in orders) {
                var app = await _appsApi.GetById<Model.Appointments>(order.AppointmentId);
                var cdm = await _cdmsApi.GetById<Model.CinemaDayMovie>(app.CinemaDayMovieId);
                var movie = await _moviesApi.GetById<Model.Movie>(cdm.MovieId);
                var adoc = await _adocApi.GetById<Model.AiringDaysOfCinema>(cdm.AiringDaysOfCinemaId);
                var cinema = await _cinemaApi.GetById<Model.Cinema>(adoc.CinemaId);
                var ad = await _adApi.GetById<Model.AiringDay>(adoc.AiringDayId);

                var today = DateTime.Now.Date;
                if (adoc.Date >= today) {

                    Model.ObservableLists.OrderItem newItem = new Model.ObservableLists.OrderItem() {
                        Time = app.StartsAt,
                        Movie = movie.Title,
                        OrderId = order.OrderId,
                        Total = order.Total,
                        Date = adoc.Date.ToString("dd. MMM yyyy"),
                        Seats = order.Tickets.Count,
                        Cinema = cinema.Name,
                        Day = ad.Name
                    };
                    Orders.Add(newItem);
                }
            }

            var movies = await _usersApi.GetItems<List<Model.Movie>>(APIService.User.UserId, "Movies");
            movies.Sort((a, b) => a.Title.CompareTo(b.Title));
            Movies.Clear();
            foreach(var movie in movies) {
                Movies.Add(movie);
            }

            var shows = await _usersApi.GetItems<List<Model.Show>>(APIService.User.UserId, "Shows");
            shows.Sort((a, b) => a.Title.CompareTo(b.Title));
            Shows.Clear();
            foreach(var show in shows) {
                Shows.Add(show);
            }

            var subscriptions = await _usersApi.GetItems<List<Model.Subscription>>(APIService.User.UserId, "Subscriptions");
            Subscriptions.Clear();
            foreach (var subscription in subscriptions) {
                Subscriptions.Add(subscription);
            }

            var rotations = await _usersApi.GetItems<List<Model.Rotation>>(APIService.User.UserId, "Rotations");
            Rotations.Clear();
            foreach (var rotation in rotations) {
                var movie = await _moviesApi.GetById<Model.Movie>(rotation.MovieId);
                var show = await _showsApi.GetById<Model.Show>(rotation.ShowId);

                var newItem = new Model.ObservableLists.RotationItem() {
                    Birthday = rotation.ForBirthday,
                    From = rotation.From.Date.ToString("dd. MMMM yy"),
                    To = rotation.To.ToString("dd. MMMM yy"),
                    Description = rotation.Description,
                    MovieImage = movie.ImageLink,
                    ShowImage = show.ImageLink,
                    RotationId = rotation.RotationId
                };

                Rotations.Add(newItem);

            }

        }

        public void RemoveNotification() {
            HasNotifications = "False";
        }

        public async void CancelOrder(Model.ObservableLists.OrderItem order) {
            Orders.Remove(order);
            await _ordersApi.Delete<Model.Order>(order.OrderId);
            HasNotifications = "True";
        }

        public async void Unsubscribe(Model.Subscription subscription) {
            Subscriptions.Remove(subscription);
            Model.Delete delete = new Model.Delete() {
                Item=BuyItem.Subscription,
                ItemId = subscription.SubscriptionId,
                UserId=APIService.User.UserId
            };
            await _usersApi.Delete<Model.Subscription>(delete);
            HasNotifications = "True";
        }

    }
}