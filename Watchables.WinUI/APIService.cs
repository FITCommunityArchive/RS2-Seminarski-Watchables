using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using Watchables.Model;

namespace Watchables.WinUI
{
    public class APIService
    {
        private readonly string _controller;
        public APIService(string route) {
            _controller = route;
        }

        public async Task<T> Get<T>(object search) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}";

            if (search != null) {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.GetJsonAsync<T>();
            return result;
        }

        public async Task<T> GetById<T>(object id) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{id}";           
            var result = await url.GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}";
            var result = await url.PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>(object id, object request) {

            var url = $"{Properties.Settings.Default.APIUrl}/{_controller}/{id}";
            var result = await url.PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }

    }
}
