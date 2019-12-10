using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class NotificationViewModel : BaseViewModel
    {

        public ObservableCollection<Model.Notification> Notifications { get; set; } = new ObservableCollection<Model.Notification>();
        public ICommand GetNotificationsCommand { get; set; }
        public APIService _usersApi = new APIService("users");
        public APIService _notificationApi = new APIService("notifications");

        public NotificationViewModel() {
            GetNotificationsCommand = new Command(async () => await GetNotifications());
        }

        public async Task GetNotifications() {
            var notifications = await _usersApi.GetItems<List<Model.Notification>>(APIService.User.UserId, "Notifications");
            Notifications.Clear();
            foreach(var notification in notifications) {
                Notifications.Add(notification);
            }
        }

        public async void RemoveNotification(Model.Notification notification) {
            await _notificationApi.RemoveNotification(notification.NotificationId, APIService.User.UserId);
            Notifications.Remove(notification);
        }


    }
}
