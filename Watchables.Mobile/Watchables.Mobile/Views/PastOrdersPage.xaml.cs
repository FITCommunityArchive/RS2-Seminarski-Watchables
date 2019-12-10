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
    public partial class PastOrdersPage : ContentPage
    {
        public PastOrdersViewModel _viewModel = null;

        public PastOrdersPage() {
            InitializeComponent();
            BindingContext = _viewModel = new PastOrdersViewModel();
        }

        protected async override void OnAppearing() {
            base.OnAppearing();
            await _viewModel.GetData();
        }
    }
}