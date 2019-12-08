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
    public partial class BuyShowPage : ContentPage
    {
        BuyShowViewModel _viewModel = null;

        public BuyShowPage(int showId) {
            InitializeComponent();
            BindingContext = _viewModel = new BuyShowViewModel();
            _viewModel.Nav = Navigation;
            _viewModel.Init(showId);
        }
    }
}