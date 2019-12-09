using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;

namespace Watchables.Mobile.ViewModels
{
    public class RotationsViewModel : BaseViewModel
    {

        public ObservableCollection<Model.ObservableLists.RotationItem> Rotations { get; set; } = new ObservableCollection<Model.ObservableLists.RotationItem>();
        public ICommand ShowRotationsCommand { get; set; }
        public readonly APIService _rotationsApi = new APIService("rotations");
        public readonly APIService _moviesApi = new APIService("movies");
        public readonly APIService _showsApi = new APIService("shows");
        public APIService _usersApi = new APIService("Users");

        public RotationsViewModel() {
            ShowRotationsCommand = new Command(async () => await ShowRotations());
        }

        public async Task ShowRotations() {
            var rotations = await _rotationsApi.Get<List<Model.Rotation>>(null);
            rotations.RemoveAll(r => !r.Available);
            var currentDate = DateTime.Now.Date;
            rotations.RemoveAll(r => !((currentDate > r.From) && (currentDate < r.To)));
            rotations.RemoveAll(r => (r.ForBirthday) && (currentDate.Date != APIService.User.BirthDate.Date));
            rotations = (from item in rotations orderby item.ForBirthday descending select item).ToList();

            Rotations.Clear();
            foreach (var rotation in rotations) {
                var movie = await _moviesApi.GetById<Model.Movie>(rotation.MovieId);
                var show = await _showsApi.GetById<Model.Show>(rotation.ShowId);

                var newItem = new Model.ObservableLists.RotationItem() {
                    Birthday = rotation.ForBirthday,
                    From = rotation.From.Date.ToString("dd. MMMM yy"),
                    To =rotation.To.ToString("dd. MMMM yy"),
                    Description=rotation.Description,
                    MovieImage=movie.ImageLink, 
                    ShowImage=show.ImageLink,
                    RotationId=rotation.RotationId
                };

                Rotations.Add(newItem);
                
            }
        }

        public async Task Claim(int rotationId) {

            var answer = await Application.Current.MainPage.DisplayAlert("Confirm", $"Claim this rotation?", "Yes", "No");
            if (answer) {
                Helper helper = new Helper();
                var isLocked = await helper.IsLocked();
                if (isLocked) {
                    await Application.Current.MainPage.DisplayAlert("Warning", "No rotations can be placed at this time, some changes are being made. Plese try again later.", "OK");
                }
                else {
                    Model.Buy buy = new Model.Buy() {
                        Item = BuyItem.Rotation,
                        ItemId = rotationId,
                        UserId = APIService.User.UserId
                    };
                    try {
                        await _usersApi.Buy<string>(buy);
                        await Application.Current.MainPage.DisplayAlert("Success", "You have claimed the rotation successfully!", "OK");
                    }
                    catch {
                        await Application.Current.MainPage.DisplayAlert("Oops", $"You have already claimed this rotation!", "OK");
                    }
                }
            }
        }


    }
}
