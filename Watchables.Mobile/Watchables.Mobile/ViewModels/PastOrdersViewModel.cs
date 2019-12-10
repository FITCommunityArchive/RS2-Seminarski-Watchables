using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class PastOrdersViewModel : BaseViewModel
    {

        public ICommand GetDataCommand { get; set; }
        public APIService _usersApi = new APIService("users");
        public APIService _ordersApi = new APIService("orders");
        public APIService _cdmsApi = new APIService("CinemaDayMovie");
        public APIService _moviesApi = new APIService("movies");
        public APIService _appsApi = new APIService("Appointments");
        public APIService _adocApi = new APIService("AiringDaysOfCinema");
        public APIService _cinemaApi = new APIService("cinemas");
        public APIService _adApi = new APIService("AiringDays");
        public ObservableCollection<Model.ObservableLists.OrderItem> Orders { get; set; } = new ObservableCollection<Model.ObservableLists.OrderItem>();

        public PastOrdersViewModel() {
            GetDataCommand = new Command(async () => await GetData());
        }

        public async Task GetData() {
            var orders = await _ordersApi.Get<List<Model.Order>>(null);
            orders.RemoveAll(o => o.UserId != APIService.User.UserId);
            Orders.Clear();
            foreach (var order in orders) {
                var app = await _appsApi.GetById<Model.Appointments>(order.AppointmentId);
                var cdm = await _cdmsApi.GetById<Model.CinemaDayMovie>(app.CinemaDayMovieId);
                var movie = await _moviesApi.GetById<Model.Movie>(cdm.MovieId);
                var adoc = await _adocApi.GetById<Model.AiringDaysOfCinema>(cdm.AiringDaysOfCinemaId);
                var cinema = await _cinemaApi.GetById<Model.Cinema>(adoc.CinemaId);
                var ad = await _adApi.GetById<Model.AiringDay>(adoc.AiringDayId);

                var today = DateTime.Now.Date;
                if (adoc.Date < today) {

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
        }

    }
}
