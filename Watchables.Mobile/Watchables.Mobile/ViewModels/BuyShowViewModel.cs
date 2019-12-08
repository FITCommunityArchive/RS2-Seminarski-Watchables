using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class BuyShowViewModel : BaseViewModel
    {

        public readonly APIService _showsApi = new APIService("shows");
        private readonly APIService _usersApi = new APIService("users");
        public ICommand BuyCommnd { get; set; }

        Model.Show _show = null;
        public Model.Show Show {
            get { return _show; }
            set { SetProperty(ref _show, value); }
        }

        string _btn = string.Empty;
        public string Btn {
            get { return _btn; }
            set { SetProperty(ref _btn, value); }
        }

        INavigation _nav = null;
        public INavigation Nav {
            get { return _nav; }
            set { SetProperty(ref _nav, value); }
        }

        public async void Init(int showId) {
            var show = await _showsApi.GetById<Model.Show>(showId);
            Title = show.Title;
            Show = show;
            Btn = $"Buy ({show.Price})";
        }

        public BuyShowViewModel() {
            BuyCommnd = new Command(async () => await Buy());
        }

        public async Task Buy() {

            var answer = await Application.Current.MainPage.DisplayAlert("Confirm", $"Buy '{Show.Title}' for {Show.Price}?", "Yes", "No");
            if (answer) {
                Helper helper = new Helper();
                var isLocked = await helper.IsLocked();
                if (isLocked) {
                    await Nav.PopAsync();
                    await Application.Current.MainPage.DisplayAlert("Warning", "No orders can be placed at this time, some changes are being made. Plese try again later.", "OK");
                }
                else {
                    Model.Buy buy = new Model.Buy() {
                        Item = BuyItem.Show,
                        ItemId = Show.ShowId,
                        UserId = APIService.User.UserId
                    };
                    try {
                        await _usersApi.Buy<string>(buy);
                        await Nav.PopAsync();
                        await Application.Current.MainPage.DisplayAlert("Success", "Show bought successfully", "OK");
                    }
                    catch {
                        await Nav.PopAsync();
                        await Application.Current.MainPage.DisplayAlert("Oops", $"You already bought '{Show.Title}'", "OK");
                    }
                }
            }
        }
    }
}
