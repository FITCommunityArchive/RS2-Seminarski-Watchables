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
    public partial class RotationsPage : ContentPage
    {
        public RotationsViewModel _viewModel = null;

        public RotationsPage() {
            InitializeComponent();
            BindingContext = _viewModel = new RotationsViewModel();
        }

        protected async override void OnAppearing() {
            base.OnAppearing();
            await _viewModel.ShowRotations();
        }

        private async void Button_Clicked(object sender, EventArgs e) {
            var rotationId = ((sender as Button).CommandParameter as Model.ObservableLists.RotationItem).RotationId;
            await _viewModel.Claim(rotationId);
        }
    }
}