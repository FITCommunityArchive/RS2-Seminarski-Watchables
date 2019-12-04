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
    public partial class CinemasPage : ContentPage
    {

        CinemasViewModel _cinemasViewModel = null;

        public CinemasPage() {
            InitializeComponent();
            BindingContext = _cinemasViewModel = new CinemasViewModel();          
        }

        protected async override void OnAppearing() {
            await _cinemasViewModel.GetCinemas();
            base.OnAppearing();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e) {            
            await Navigation.PushAsync(new CinemaProfilePage((e.SelectedItem as Model.Cinema).CinemaId));
        }
    }
}