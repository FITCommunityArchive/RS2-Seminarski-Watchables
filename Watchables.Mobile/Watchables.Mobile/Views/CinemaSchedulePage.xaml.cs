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
    public partial class CinemaSchedulePage : ContentPage
    {

        CinemaScheduleViewModel _viewModel = null;

        public CinemaSchedulePage(int cinemaId) {
            InitializeComponent();
            BindingContext = _viewModel = new CinemaScheduleViewModel();
            _viewModel.Init(cinemaId);
        }

        protected async override void OnAppearing() {
            await _viewModel.GetData();
            base.OnAppearing();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e) {

            var adocId = (e.SelectedItem as Model.ObservableLists.AiringDayOfCinemaItem).AiringDayOfCinemaId;
            var cinema = (e.SelectedItem as Model.ObservableLists.AiringDayOfCinemaItem).Cinema;
            var day = (e.SelectedItem as Model.ObservableLists.AiringDayOfCinemaItem).Day;
            var date = (e.SelectedItem as Model.ObservableLists.AiringDayOfCinemaItem).Date;

            date = date.Substring(0, date.Length - 2);
            day = day.Substring(0, day.Length - 2);

            await Navigation.PushAsync(new AiringDayMoviesPage(adocId, day, cinema, date));
        }
    }
}