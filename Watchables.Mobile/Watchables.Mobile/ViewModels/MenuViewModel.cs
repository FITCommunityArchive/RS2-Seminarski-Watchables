using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Watchables.Mobile.Views;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {

        public ICommand LogoutButton { get; set; }

        string _name = string.Empty;
        public string Name {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
     
        string _imageLink = string.Empty;
        public string ImageLink {
            get { return _imageLink; }
            set { SetProperty(ref _imageLink, value); }
        }

        public MenuViewModel() {
            LogoutButton = new Command(() => Logout());
            ImageLink = APIService.User.ImageLink;
            Name = APIService.User.FirstName +" "+ APIService.User.LastName;
        }

        public void Logout() {
            Application.Current.MainPage = new LoginPage();
        }

    }
}
