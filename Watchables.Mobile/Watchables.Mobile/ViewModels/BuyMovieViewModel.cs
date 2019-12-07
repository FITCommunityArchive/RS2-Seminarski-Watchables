using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class BuyMovieViewModel : BaseViewModel
    {

        public readonly APIService _moviesApi = new APIService("movies");
        private readonly APIService _usersApi = new APIService("users");
        public ICommand BuyCommnd { get; set; }

        Model.Movie _movie = null;
        public Model.Movie Movie {
            get { return _movie; }
            set { SetProperty(ref _movie, value); }
        }

        string _btn = string.Empty;
        public string Btn {
            get { return _btn; }
            set { SetProperty(ref _btn, value); }
        }

        INavigation _nav = null;
        public INavigation Nav {
            get { return _nav; }
            set { SetProperty(ref _nav, value); }
        }

        public async void Init(int movieId) {
            var movie = await _moviesApi.GetById<Model.Movie>(movieId);
            Title = movie.Title;
            Movie = movie;
            Btn = $"Buy ({movie.Price})";
        }

        public BuyMovieViewModel() {
            BuyCommnd = new Command(async () => await Buy());
        }

        public async Task Buy() {

            var answer = await Application.Current.MainPage.DisplayAlert("Confirm", $"Buy '{Movie.Title}' for {Movie.Price}?", "Yes", "No");
            if (answer) {
                Helper helper = new Helper();
                var isLocked = await helper.IsLocked();
                if (isLocked) {
                    await Nav.PopAsync();
                    await Application.Current.MainPage.DisplayAlert("Warning", "No orders can be placed at this time, some changes are being made. Plese try again later.", "OK");
                }
                else {
                    Model.Buy buy = new Model.Buy() {
                        Item = BuyItem.Movie,
                        ItemId = Movie.MovieId,
                        UserId = APIService.User.UserId
                    };
                    try {
                        await _usersApi.Buy<string>(buy);
                        await Nav.PopAsync();
                        await Application.Current.MainPage.DisplayAlert("Success", "Movies bought successfully", "OK");
                    }
                    catch {
                        await Nav.PopAsync();
                        await Application.Current.MainPage.DisplayAlert("Oops", $"You already bought '{Movie.Title}'", "OK");
                    }
                   
                   
                }
            }
        }
    }
}
