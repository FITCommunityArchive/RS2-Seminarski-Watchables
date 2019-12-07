using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class CinemasViewModel : BaseViewModel
    {
        public readonly APIService _cinemasAPI = new APIService("cinemas");
        public ObservableCollection<Model.Cinema> Cinemas { get; set; } = new ObservableCollection<Model.Cinema>();
        public ObservableCollection<string> Locations { get; set; } = new ObservableCollection<string>();
        public ICommand GetCinemasButton { get; set; }

        string _selectedLocation = string.Empty;
        public string SelectedLocation {
            get { return _selectedLocation; }
            set { 
                SetProperty(ref _selectedLocation, value); 
                if(value != null) {
                    GetCinemasButton.Execute(null);
                }
            }
        }


        public CinemasViewModel() {
            GetCinemasButton = new Command(async () => await GetCinemas());
        }
        
        public async Task GetCinemas() {

            var allCinemas = await _cinemasAPI.Get<List<Model.Cinema>>(null);
            allCinemas.Sort((a, b) => a.Name.CompareTo(b.Name));

            if (SelectedLocation != null) {
                Model.Requests.CinemasSearchRequest search = new Model.Requests.CinemasSearchRequest() {
                    Location=SelectedLocation
                };

                var c = new List<Model.Cinema>();
                if(SelectedLocation == "All") c = await _cinemasAPI.Get<List<Model.Cinema>>(null);
                else c = await _cinemasAPI.Get<List<Model.Cinema>>(search);
                c.Sort((a, b) => a.Name.CompareTo(b.Name));
                Cinemas.Clear();

                foreach (var cinema in c) {
                    Cinemas.Add(cinema);
                }
            }

            if (Locations.Count == 0) {
                var list = new List<string>();
                list.Add("All");
                foreach (var cinema in allCinemas) {                   
                    list.Add(cinema.Location);
                }
                list = list.Distinct().ToList();

                foreach (var location in list) {
                    Locations.Add(location);
                }
            }
        }
    }
}
