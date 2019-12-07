using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watchables.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Watchables.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviesPage : ContentPage
    {

        MoviesViewModel _viewModel = null;

        public MoviesPage() {
            InitializeComponent();
            BindingContext = _viewModel = new MoviesViewModel();
        }

        protected async override void OnAppearing() {
            base.OnAppearing();
            await _viewModel.ShowMovies();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e) {
            var movieId = (e.Item as Model.Movie).MovieId;
            await Navigation.PushAsync(new BuyMoviePage(movieId));
        }
    }
}