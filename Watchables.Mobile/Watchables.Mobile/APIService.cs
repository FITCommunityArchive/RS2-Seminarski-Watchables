using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Watchables.Model;
using Xamarin.Forms;

namespace Watchables.Mobile
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Model.User User { get; set; }
        private readonly string _controller;
        public APIService(string route) {
            _controller = route;
        }

        #if DEBUG
        private string _apiUrl = "http://localhost:51756/api";
#endif
#if RELEASE
        private string _apiUrl = "http://localhost:51756/api";
#endif

        public async Task<T> Get<T>(object search) {

            var url = $"{_apiUrl}/{_controller}";

            if (search != null) {
                url += "?";
                url += await search.ToQueryString();
            }
            try {
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }

        }

        public async Task<T> GetById<T>(object id) {

            var url = $"{_apiUrl}/{_controller}/{id}";
            try {
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }

        public async Task<string> Delete<T>(object id) {

            var url = $"{_apiUrl}/{_controller}/{id}";
            try {
                var result = await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveString();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }

        public async Task<T> Insert<T>(object request) {

            var url = $"{_apiUrl}/{_controller}";
            try {
                var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }

        public async Task<T> Update<T>(object id, object request) {

            var url = $"{_apiUrl}/{_controller}/{id}";
            try {
                var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }


        public async Task<T> GetItems<T>(object id, string items) {

            var url = $"{_apiUrl}/{_controller}/{items}/{id}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> UpdateItem<T>(object id, string action, object item) {

            var url = $"{_apiUrl}/{_controller}/{action}/{id}";
            try {
                var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(item).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }

        public async Task<T> InsertItem<T>(string action, object item) {

            var url = $"{_apiUrl}/{_controller}/{action}";
            try {
                var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(item).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }

        public async Task<T> CustomGet<T>(string action, object id = null) {

            var url = "";
            if (id == null) {
                url = $"{_apiUrl}/{_controller}/{action}";
            }
            else {
                url = $"{_apiUrl}/{_controller}/{action}/{id}";
            }
            try {
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }

        public async Task<string> Lock<T>(bool flag) {

            var url = $"{_apiUrl}/{_controller}/Lock/{flag}";
            try {
                var result = await url.WithBasicAuth(Username, Password).GetStringAsync();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }

        public async Task<string> Buy<T>(Model.Buy buy) {

            var url = $"{_apiUrl}/{_controller}/BuyItem";
            try {
                var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(buy).ReceiveString();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }
        
        public async Task<string> Delete<T>(Model.Delete delete) {

            var url = $"{_apiUrl}/{_controller}/DeleteItem";
            try {
                var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(delete).ReceiveString();
                return result;
            }
            catch (FlurlHttpException ex) {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access denied!", "OK");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    await Application.Current.MainPage.DisplayAlert("Error", "Access forbidden!", "OK");
                }
                throw;
            }
        }
    }
}
