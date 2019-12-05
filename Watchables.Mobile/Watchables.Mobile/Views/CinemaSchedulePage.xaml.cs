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
    public partial class CinemaSchedulePage : ContentPage
    {

        CinemaScheduleViewModel _viewModel = null;

        public CinemaSchedulePage(int cinemaId) {
            InitializeComponent();
            BindingContext = _viewModel = new CinemaScheduleViewModel();
            _viewModel.Init(cinemaId);
        }
    }
}