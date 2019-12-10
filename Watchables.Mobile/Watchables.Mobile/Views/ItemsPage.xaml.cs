using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Watchables.Mobile.Models;
using Watchables.Mobile.Views;
using Watchables.Mobile.ViewModels;

namespace Watchables.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel = null;

        public ItemsPage() {
            InitializeComponent();
            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected async override void OnAppearing() {
            base.OnAppearing();
            await _viewModel.GetData();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new NotificationsPage());
        }

        private async void ToolbarItem_Clicked_1(object sender, EventArgs e) {
            await Navigation.PushAsync(new EditProfilePage());
        }

        private async void Button_Clicked(object sender, EventArgs e) {
            var answer = await Application.Current.MainPage.DisplayAlert("Confirm", $"Cancel this order?", "Yes", "No");
            if (answer) {
                var order = (sender as Button).CommandParameter as Model.ObservableLists.OrderItem;
                _viewModel.CancelOrder(order);
            }
            }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e) {
            await Navigation.PushAsync(new BuyMoviePage((e.Item as Model.Movie).MovieId));
        }

        private async void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e) {
            await Navigation.PushAsync(new BuyShowPage((e.Item as Model.Show).ShowId));
        }

        private async void Button_Clicked_1(object sender, EventArgs e) {
            var answer = await Application.Current.MainPage.DisplayAlert("Confirm", $"Are you sure you want to unsubscribe?", "Yes", "No");
            if (answer) {
                var subscription = (sender as Button).CommandParameter as Model.Subscription;
                _viewModel.Unsubscribe((sender as Button).CommandParameter as Model.Subscription);
            }
        }

        private async void ImageButton_Clicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new PastOrdersPage());
        }
    }
    
}