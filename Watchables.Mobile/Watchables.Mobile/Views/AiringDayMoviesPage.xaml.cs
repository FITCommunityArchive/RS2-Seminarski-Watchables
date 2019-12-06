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
    public partial class AiringDayMoviesPage : ContentPage
    {

        AiringDayMoviesViewModel _viewModel = null;

        public AiringDayMoviesPage(int adocId, string day, string cinema, string date, int cinemaId) {
            InitializeComponent();
            BindingContext = _viewModel = new AiringDayMoviesViewModel();
            _viewModel.Init(adocId, day, cinema, date, cinemaId);
        }

        protected async override void OnAppearing() {
            await _viewModel.GetData();
            base.OnAppearing();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e) {
            var cdmId = (e.SelectedItem as Model.ObservableLists.CdmItem).CinemaDayMovieId;
            await Navigation.PushAsync(new OrderPage(cdmId, _viewModel.CinemaId, _viewModel.Day, _viewModel.Date, _viewModel.Cinema));
        }
    }
}