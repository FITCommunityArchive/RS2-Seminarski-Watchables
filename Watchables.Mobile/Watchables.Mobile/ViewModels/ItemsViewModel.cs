using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Watchables.Mobile.Models;
using Watchables.Mobile.Views;
using System.Windows.Input;
using System.Collections.Generic;

namespace Watchables.Mobile.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ICommand GetDataCommand { get; set; }
        public ICommand RemoveNotificationCommand { get; set; }
        public APIService _usersApi = new APIService("users");

        public ItemsViewModel() {
            GetDataCommand = new Command(async () => await GetData());
            RemoveNotificationCommand = new Command(() => RemoveNotification());
        }
        string _hasNotifications = string.Empty;
        public string HasNotifications {
            get { return _hasNotifications; }
            set { SetProperty(ref _hasNotifications, value); }
        }


        public async Task GetData() {
            var notifications = await _usersApi.GetItems<List<Model.Notification>>(APIService.User.UserId, "Notifications");
            if (notifications.Count == 0) HasNotifications = "False";
            else HasNotifications = "True";
        }

        public void RemoveNotification() {
            HasNotifications = "False";
        }

    }
}