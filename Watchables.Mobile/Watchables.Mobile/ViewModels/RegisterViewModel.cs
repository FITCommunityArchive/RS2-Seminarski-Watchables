using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Watchables.Mobile.Views;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand BackButton { get; set; }
        public RegisterViewModel() {
            BackButton = new Command(() => GoBack());
        }

        public void GoBack() {
            Application.Current.MainPage = new LoginPage();
        }
    }
}
