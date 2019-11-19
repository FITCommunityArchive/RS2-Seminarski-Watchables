﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using Watchables.Model;
using System.Windows.Forms;

namespace Watchables.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        private readonly string _controller;
        private readonly CustomMessageBox _customMessageBox = new CustomMessageBox();
        public APIService(string route) {
            _controller = route;
        }

        public async Task<T> Get<T>(object search) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}";

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
                    _customMessageBox.Show("Niste authentificirani", "error");
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden) {
                    _customMessageBox.Show("Forbidden", "error");
                }
                throw;
            }

        }

        public async Task<T> GetById<T>(object id) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{id}";           
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}";
            var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>(object id, object request) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{id}";
            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }


        public async Task<T> GetItems<T>(object id, string items) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{items}/{id}";
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> UpdateItem<T>(object id, string action, object item) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{action}/{id}";
            var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(item).ReceiveJson<T>();
            return result;
        }

        public async Task<T> InsertItem<T>(string action, object item) {
         
                var url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{action}";
                var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(item).ReceiveJson<T>();
                return result;           
        
        }

        public async Task<T> CustomGet<T>(string action, object id=null) {

            var url="";
            if (id == null) {
                url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{action}";
            }
            else {
                url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{action}/{id}";
            }
            var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            return result;



        }
    }
}
