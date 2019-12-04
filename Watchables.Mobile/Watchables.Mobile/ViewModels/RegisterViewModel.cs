using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Watchables.Mobile.Views;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {

        private readonly APIService _apiService = new APIService("users");

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

        DateTime _minimumDate = DateTime.Now;
        public DateTime MinimumDate {
            get { return _minimumDate; }
            set { SetProperty(ref _minimumDate, value); }
        }

        DateTime _maximumDate = DateTime.Now;
        public DateTime MaximumDate {
            get { return _maximumDate; }
            set { SetProperty(ref _maximumDate, value); }
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
            MinimumDate = new DateTime(1900, 1, 1);
            MaximumDate = DateTime.Now;
        }

        public void GoBack() {
            Application.Current.MainPage = new LoginPage();
        }

        public async Task Register() {

            if (string.IsNullOrWhiteSpace(Mail) || !Mail.Contains("@") || !Mail.Contains(".") || !Mail.Contains("com")) {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid mail address!", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(FirstName) || FirstName.Length < 4) {
                await Application.Current.MainPage.DisplayAlert("Error", "The 'fist name' field requires 4 letters", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(LastName) || LastName.Length < 4) {
                await Application.Current.MainPage.DisplayAlert("Error", "The 'last name' field requires 4 letters", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(Address) || Address.Length < 5) {
                await Application.Current.MainPage.DisplayAlert("Error", "The 'address' field requires 5 letters", "OK");
                return;
            }

            if(string.IsNullOrWhiteSpace(ImageLink) || !ImageLink.Contains(".jpg")) {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter an image link with the '.jpg' extension", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(PhoneNumber) || PhoneNumber.Length < 9) {
                await Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid phone number", "OK");
                return;
            }

            if (!string.IsNullOrWhiteSpace(PhoneNumber)) {
                string pattern = @"\(?\d{3}\)?-? ?/*\d{3}-? *-?\d{3}";
                Regex reg = new Regex(pattern);
                if (!reg.IsMatch(PhoneNumber)) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Phone number: xxx / xxx - xxx", "OK");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 4 || Username.Length > 50) {
                await Application.Current.MainPage.DisplayAlert("Error", "Username length: 4-50", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(Password) || Password.Length < 4 || Password.Length > 50) {
                await Application.Current.MainPage.DisplayAlert("Error", "Password length: 4-50", "OK");
                return;
            }

            if (!string.IsNullOrWhiteSpace(Password) && Password.Contains(" ")) {
                await Application.Current.MainPage.DisplayAlert("Error", "Password can't contain spaces", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(ConfirmPassword) || ConfirmPassword.Length < 4 || ConfirmPassword.Length > 50) {
                await Application.Current.MainPage.DisplayAlert("Error", "Confirmation length: 4-50", "OK");
                return;
            }

            if (!string.IsNullOrWhiteSpace(ConfirmPassword) && ConfirmPassword.Contains(" ")) {
                await Application.Current.MainPage.DisplayAlert("Error", "Confirmation can't contain spaces", "OK");
                return;
            }

            if (Password != ConfirmPassword) {
                await Application.Current.MainPage.DisplayAlert("Error", "Passwords don't match!", "OK");
                return;
            }

            Model.Requests.InsertUserRequest request = new Model.Requests.InsertUserRequest() {
                Mail=Mail,
                Address=Address, 
                BirthDate=BirthDate,
                ConfirmPassword=ConfirmPassword,
                Password=Password,
                FirstName=FirstName, 
                ImageLink=ImageLink, 
                LastName=LastName, 
                PhoneNumber=PhoneNumber, 
                Username=Username
            };

            try {
                var User = await _apiService.Insert<Model.User>(request);
                APIService.Username = Username;
                APIService.Password = Password;
                APIService.User = User;
                Application.Current.MainPage = new MainPage();
                await Application.Current.MainPage.DisplayAlert("Welcome", "Enjoy your stay at Watchables!", "OK");
            }
            catch {
                await Application.Current.MainPage.DisplayAlert("Error", "The username is already taken!", "OK");
                return;
            }

        }

        public void Show() {
            if (isPassword == "True") isPassword = "False";
            else isPassword = "True";
        }

    }
}
