using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watchables.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Watchables.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationsPage : ContentPage
    {
        NotificationViewModel _viewModel = null;

        public NotificationsPage() {
            InitializeComponent();
            BindingContext = _viewModel = new NotificationViewModel();
        }

        protected async override void OnAppearing() {
            base.OnAppearing();
            await _viewModel.GetNotifications();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e) {
            _viewModel.RemoveNotification(e.Item as Model.Notification);
        }
    }
}