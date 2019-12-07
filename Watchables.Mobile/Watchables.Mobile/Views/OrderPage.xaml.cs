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
    public partial class OrderPage : ContentPage
    {
        public static int _counter = 0;
        public static int _amount = 0;
        public static bool _first = true;
        public OrderViewModel _viewModel = null;

        public OrderPage(int cdmId, int cinemaId, string day, string date, string cinemaName) {
            InitializeComponent();
            BindingContext = _viewModel = new OrderViewModel();
            _viewModel.Init(cinemaId, cdmId, day, date, cinemaName);
        }


        private void Picker_SelectedIndexChanged_1(object sender, EventArgs e) {

            if ((sender as Picker).SelectedItem != null) {
                Model.ObservableLists.ProductItem product = ((sender as Picker).SelectedItem) as Model.ObservableLists.ProductItem;
                _viewModel.OrderedProducts.Add(product);
                (sender as Picker).SelectedItem = null;
            }
        }



        private async void Button_Clicked(object sender, EventArgs e) {
            if (_viewModel.SelectedItem == null) {
                await Application.Current.MainPage.DisplayAlert("Error", "Please choose an appointment first!", "OK");
                return;
            }
            if (_viewModel.SelectedNumberOfTickets == 0) {
                await Application.Current.MainPage.DisplayAlert("Error", "Please choose an amount of seats!", "OK");
                return;
            }

            var helper = new Helper();
            bool isLocked = await helper.IsLocked();

            if (isLocked) {
                await Application.Current.MainPage.DisplayAlert("Warning", "No orders can be placed at this time, some changes are being made. Plese try again later.", "OK");
                await Navigation.PopAsync();
                return;
            }        

            decimal price = 0;
            foreach(var product in _viewModel.OrderedProducts) {
                price += product.Product.Price;
            }
            price += (_viewModel.SelectedItem.Price * _viewModel.SelectedNumberOfTickets);

            var answer = await Application.Current.MainPage.DisplayAlert("Order", $"Place order for: {price} ?", "Yes", "No");
            if (answer) {
                _viewModel.PlaceOrder();
                await Navigation.PopAsync();
                await Application.Current.MainPage.DisplayAlert("Success", "Order placed successfully", "OK");
            }

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e) {
            Model.ObservableLists.ProductItem product = (e.SelectedItem as Model.ObservableLists.ProductItem);
            _viewModel.OrderedProducts.Remove(product);
        }
    }
}