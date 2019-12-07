using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {

        int _cinemaId = 0;
        public int CinemaId {
            get { return _cinemaId; }
            set { SetProperty(ref _cinemaId, value); }
        }

        int _cdmId = 0;
        public int CdmId {
            get { return _cdmId; }
            set { SetProperty(ref _cdmId, value); }
        }

        string _day = string.Empty;
        public string Day {
            get { return _day; }
            set { SetProperty(ref _day, value); }
        }

        string _date = string.Empty;
        public string Date{
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        string _cinemaNam = string.Empty;
        public string CinemaName {
            get { return _cinemaNam; }
            set { SetProperty(ref _cinemaNam, value); }
        }

        Model.Movie _movie = new Model.Movie();
        public Model.Movie Movie {
            get { return _movie; }
            set { SetProperty(ref _movie, value); }
        }

        public APIService _cinemasApi = new APIService("cinemas");
        public APIService _moviesApi = new APIService("movies");
        public APIService _cdmApi = new APIService("CinemaDayMovie");
        public APIService _appApi = new APIService("Appointments");
        public APIService _hallsApi = new APIService("halls");
        public APIService _ordersApi = new APIService("orders");
        public ObservableCollection<Model.ObservableLists.AppointmentItem> Apps { get; set; } = new ObservableCollection<Model.ObservableLists.AppointmentItem>();
        public ObservableCollection<int> Seats { get; set; } = new ObservableCollection<int>();
        public ObservableCollection<Model.ObservableLists.ProductItem> Products { get; set; } = new ObservableCollection<Model.ObservableLists.ProductItem>();
        public ObservableCollection<Model.ObservableLists.ProductItem> OrderedProducts { get; set; } = new ObservableCollection<Model.ObservableLists.ProductItem>();
        public ICommand ClearCommand { get; set; }
        


        Model.ObservableLists.AppointmentItem _selectedItem = null;
        public Model.ObservableLists.AppointmentItem SelectedItem {
            get { return _selectedItem; }
            set { 
                SetProperty(ref _selectedItem, value);
                if (value != null) {
                    Seats.Clear();
                    var freeSeats = value.HallNumberOfSeats - value.SoldSeats;
                    for (var i = 1; i <= freeSeats; i++) {
                        Seats.Add(i);
                    }
                }
            }
        }


        int _selectedNumberOfTickets = 0;
        public int SelectedNumberOfTickets {
            get { return _selectedNumberOfTickets; }
            set { SetProperty(ref _selectedNumberOfTickets, value); }
        }

        public async void Init(int cinemaId, int cdmId, string day, string date, string cinemaName) {
            CinemaId = cinemaId;
            CdmId = cdmId;
            Day = day;
            Date = date;
            CinemaName = cinemaName;
            Title = CinemaName + ", " + date + ", " + day;
            var cdm = await _cdmApi.GetById<Model.CinemaDayMovie>(CdmId);
            var movie = await _moviesApi.GetById<Model.Movie>(cdm.MovieId);
            Movie = movie;

            var apps = await _appApi.Get<List<Model.Appointments>>(null);
            apps.RemoveAll(app => app.CinemaDayMovieId != CdmId);

            foreach(var app in apps) {
                var hall = await _hallsApi.GetById<Model.Hall>(app.HallId);
                Model.ObservableLists.AppointmentItem newItem = new Model.ObservableLists.AppointmentItem() {
                    HallId = hall.HallId,
                    AppId = app.AppointmentId,
                    HallName = hall.HallName,
                    HallNumber = hall.HallNumber,
                    Price = app.Price,
                    SoldSeats = app.SoldSeats,
                    StartsAt = app.StartsAt,
                    Display = app.StartsAt + "h / Price: " + app.Price + " / ",
                    HallNumberOfSeats=hall.NumberOfseats
                };

                if (hall.NumberOfseats == app.SoldSeats) newItem.Full = true;
                else newItem.Full = false;

                if (newItem.Full) newItem.Display += "No more seats left";
                else {
                    newItem.Display += "Sets: ";
                    newItem.Display += (hall.NumberOfseats - app.SoldSeats).ToString();
                }

                Apps.Add(newItem); 
            }

            var products = await _cinemasApi.CustomGet<List<Model.Product>>("getProducts",CinemaId);
            foreach(var product in products) {
                Model.ObservableLists.ProductItem newItem = new Model.ObservableLists.ProductItem() {
                    Product = product,
                    Display = product.Name + " / Price: " + product.Price
                };
                Products.Add(newItem);
            }
        }

        public async void PlaceOrder() {

            var app = await _appApi.GetById<Model.Appointments>(SelectedItem.AppId);

            Model.Requests.InsertOrderRequest request = new Model.Requests.InsertOrderRequest() {
                Appointment = app,
                NumberOfTickets = _selectedNumberOfTickets,
                Products = new List<Model.Product>(),
                UserId=APIService.User.UserId
            };

            foreach(var product in OrderedProducts) {
                request.Products.Add(product.Product);
            }

            await _ordersApi.Insert<Model.Order>(request);

        }

        public OrderViewModel() {
            ClearCommand = new Command(() => Clear());
        }

        public void Clear() {
            OrderedProducts.Clear();
        }

    }
}
