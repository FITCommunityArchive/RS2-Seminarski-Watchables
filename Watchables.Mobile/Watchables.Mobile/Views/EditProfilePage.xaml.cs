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
    public partial class EditProfilePage : ContentPage
    {
        EditProfileViewModel _viewModel = null;

        public EditProfilePage() {
            InitializeComponent();
            BindingContext = _viewModel = new EditProfileViewModel();
            _viewModel.Nav = Navigation;
        }
        protected override void OnAppearing() {
            base.OnAppearing();
            _viewModel.GetData();
        }


    }
}