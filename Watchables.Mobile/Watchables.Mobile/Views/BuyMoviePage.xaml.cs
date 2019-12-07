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
    public partial class BuyMoviePage : ContentPage
    {
        BuyMovieViewModel _viewModel = null;

        public BuyMoviePage(int movieId) {
            InitializeComponent();
            BindingContext = _viewModel = new BuyMovieViewModel();
            _viewModel.Nav = Navigation;
            _viewModel.Init(movieId);
           
        }
   
    }
}