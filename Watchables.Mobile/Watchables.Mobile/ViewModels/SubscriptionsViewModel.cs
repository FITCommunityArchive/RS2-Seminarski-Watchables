using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class SubscriptionsViewModel : BaseViewModel
    {
        public APIService _subApi = new APIService("Subscriptions");
        public APIService _usersApi = new APIService("Users");
        public ObservableCollection<Model.Subscription> Subscriptions { get; set; } = new ObservableCollection<Model.Subscription>();
        ICommand GetSubscriptionsCommand { get; set; }

        public SubscriptionsViewModel() {
            GetSubscriptionsCommand = new Command(async () => await GetSubscriptions());
        }

        public async Task GetSubscriptions() {
            var subs = await _subApi.Get<List<Model.Subscription>>(null);
            subs.RemoveAll(s => !s.Available);
            Subscriptions.Clear();
            foreach(var sub in subs) {
                Subscriptions.Add(sub);
            }
        }

        INavigation _nav = null;
        public INavigation Nav {
            get { return _nav; }
            set { SetProperty(ref _nav, value); }
        }


        public async Task Subscribe(int subId, decimal price) {

            var answer = await Application.Current.MainPage.DisplayAlert("Confirm", $"Are you sure you want to subscribe for {price}/month?", "Yes", "No");
            if (answer) {
                Helper helper = new Helper();
                var isLocked = await helper.IsLocked();
                if (isLocked) {
                    await Nav.PopAsync();
                    await Application.Current.MainPage.DisplayAlert("Warning", "No subscriptions can be placed at this time, some changes are being made. Plese try again later.", "OK");
                }
                else {
                    Model.Buy buy = new Model.Buy() {
                        Item = BuyItem.Subscription,
                        ItemId = subId,
                        UserId = APIService.User.UserId
                    };
                    try {
                        await _usersApi.Buy<string>(buy);
                        await Application.Current.MainPage.DisplayAlert("Success", "You have subscribed successfully!", "OK");
                    }
                    catch {
                        await Application.Current.MainPage.DisplayAlert("Oops", $"You are already subscribed to this subscription box!", "OK");
                    }
                }
            }
        }

    }
}
