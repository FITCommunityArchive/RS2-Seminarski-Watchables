﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Watchables.Mobile.Views;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        private readonly APIService _apiService = new APIService("users");

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

        string _isPassword = string.Empty;
        public string isPassword {
            get { return _isPassword; }
            set { SetProperty(ref _isPassword, value); }
        }

        public ICommand LoginButton { get; set; }
        public ICommand ShowButton { get; set; }
        public ICommand RegisterButton { get; set; }

        public LoginViewModel() {

            LoginButton = new Command(async () => await Login());
            ShowButton = new Command(() => Show());
            RegisterButton = new Command(() => Register());
            Username = "mobile";
            Password = "test";
            isPassword = "True";
        }


        async Task Login() {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try {
                var allUsers = await _apiService.Get<List<Model.User>>(null);
                foreach(var u in allUsers) {
                    if (u.Account.Username == Username) {
                        var user = await _apiService.GetById<Model.User>(u.UserId);
                        if (!user.Active) {
                            await Application.Current.MainPage.DisplayAlert("Error", $"This account has been deactivated!", "OK");
                            return;
                        }
                        APIService.User = user;
                    }
                }
                Application.Current.MainPage = new MainPage();
            }
            catch {

            }
        }

        void Show() {
            if (isPassword == "True") isPassword = "False";
            else isPassword = "True";
        }

        void Register() {
            Application.Current.MainPage = new RegisterPage();
        }
    }
}
