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
    public partial class SubscriptionsPage : ContentPage
    {
        SubscriptionsViewModel _viewModel = null;

        public SubscriptionsPage() {
            InitializeComponent();
            BindingContext = _viewModel = new SubscriptionsViewModel();
        }

        protected async override void OnAppearing() {
            base.OnAppearing();
            _viewModel.Nav = Navigation;
            await _viewModel.GetSubscriptions();
        }

        private async void Button_Clicked(object sender, EventArgs e) {
            var sub = ((sender as Button).CommandParameter as Model.Subscription);
            await _viewModel.Subscribe(sub.SubscriptionId, sub.Price);
        }
    }
}