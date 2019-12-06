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
    public partial class AiringDayMoviesPage : ContentPage
    {

        AiringDayMoviesViewModel _viewModel = null;

        public AiringDayMoviesPage(int adocId, string day, string cinema, string date) {
            InitializeComponent();
            BindingContext = _viewModel = new AiringDayMoviesViewModel();
            _viewModel.Init(adocId, day, cinema, date);
        }

        protected async override void OnAppearing() {
            await _viewModel.GetData();
            base.OnAppearing();
        }
    }
}