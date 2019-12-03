using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Watchables.Mobile.Views;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand BackButton { get; set; }
        public ICommand RegisterButton { get; set; }
        public ICommand ShowButton { get; set; }
        string _mail = string.Empty;
        public string Mail {
            get { return _mail; }
            set { SetProperty(ref _mail, value); }
        }

        string _fisrtName = string.Empty;
        public string FirstName {
            get { return _fisrtName; }
            set { SetProperty(ref _fisrtName, value); }
        }

        string _lastName = string.Empty;
        public string LastName {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        string _phoneNumber = string.Empty;
        public string PhoneNumber {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        string _address = string.Empty;
        public string Address {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        DateTime _birthDate = DateTime.Now;
        public DateTime BirthDate {
            get { return _birthDate; }
            set { SetProperty(ref _birthDate, value); }
        }

        string _imageLink = string.Empty;
        public string ImageLink {
            get { return _imageLink; }
            set { SetProperty(ref _imageLink, value); }
        }

        string _username = string.Empty;
        public string Username {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _confirmPassword = string.Empty;
        public string ConfirmPassword {
            get { return _confirmPassword; }
            set { SetProperty(ref _confirmPassword, value); }
        }

        string _isPassword = string.Empty;
        public string isPassword {
            get { return _isPassword; }
            set { SetProperty(ref _isPassword, value); }
        }


        public RegisterViewModel() {
            BackButton = new Command(() => GoBack());
            RegisterButton = new Command(async () => await Register());
            ShowButton = new Command(() => Show());
            isPassword = "True";
        }

        public void GoBack() {
            Application.Current.MainPage = new LoginPage();
        }

        public async Task Register() {
             await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
        }

        public void Show() {
            if (isPassword == "True") isPassword = "False";
            else isPassword = "True";
        }

    }
}
