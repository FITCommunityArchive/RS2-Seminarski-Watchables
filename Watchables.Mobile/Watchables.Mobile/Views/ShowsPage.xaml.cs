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
    public partial class ShowsPage : ContentPage
    {
        ShowsViewModel _viewModel = null;

        public ShowsPage() {
            InitializeComponent();
            BindingContext = _viewModel = new ShowsViewModel();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e) {
            var showId = (e.Item as Model.Show).ShowId;
            await Navigation.PushAsync(new BuyShowPage(showId));
        }
    }
}