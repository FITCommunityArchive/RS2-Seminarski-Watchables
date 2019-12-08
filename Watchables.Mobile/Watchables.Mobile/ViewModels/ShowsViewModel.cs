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
    public class ShowsViewModel : BaseViewModel
    {

        public ObservableCollection<Model.Show> Shows { get; set; } = new ObservableCollection<Model.Show>();
        public ObservableCollection<string> Genres { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<int> Ratings { get; set; } = new ObservableCollection<int>() { 0, 1, 2, 4, 5, 6, 7, 8, 9, 10 };
        public ICommand ShowShowsCommand { get; set; }
        public ICommand ForMeButton { get; set; }
        public ICommand AllShowsButton { get; set; }
        public ICommand SearchCommand { get; set; }
        public APIService _showsApi = new APIService("shows");
        public APIService _usersApi = new APIService("users");

        string _genre = string.Empty;
        public string Genre {
            get { return _genre; }
            set {
                SetProperty(ref _genre, value);
                if (value != null) {
                    ShowShowsCommand.Execute(null);
                }

            }
        }

        string _showFilters = string.Empty;
        public string ShowFilters {
            get { return _showFilters; }
            set {
                SetProperty(ref _showFilters, value);
            }
        }

        int _rating = 0;
        public int Rating {
            get { return _rating; }
            set {
                SetProperty(ref _rating, value);
                ShowShowsCommand.Execute(null);
            }
        }

        string _search = string.Empty;
        public string Search {
            get { return _search; }
            set {
                SetProperty(ref _search, value);
                SearchCommand.Execute(null);
            }
        }


        public ShowsViewModel() {
            ShowShowsCommand = new Command(async () => await ShowShows());
            AllShowsButton = new Command(async () => await ShowShows());
            ForMeButton = new Command(async () => await ForMe());
            SearchCommand = new Command(async () => await OnSearch());
        }


        public async Task OnSearch() {
            if (Search != null) {
                Genre = "All";
                Rating = 0;
                Model.Requests.ShowSearchRequest request = new Model.Requests.ShowSearchRequest() {
                    Title = Search
                };
                var shows = await _showsApi.Get<List<Model.Show>>(request);
                Shows.Clear();
                shows.Sort((a, b) => a.Title.CompareTo(b.Title));
                foreach (var show in shows) {
                    Shows.Add(show);
                }
            }
        }

        public async Task ForMe() {
            ShowFilters = "False";
            Shows.Clear();
            var shows = await _usersApi.GetItems<List<Model.Show>>(APIService.User.UserId, "RecommendedShows");
            foreach (var show in shows) {
                Shows.Add(show);
            }
        }

        public async Task ShowShows() {

            ShowFilters = "True";

            Model.Requests.ShowSearchRequest request = new Model.Requests.ShowSearchRequest();
            if (Genre != null) {
                request.Genre = Genre;
                if (request.Genre == "All") request.Genre = "";
            }

            request.Rating = Rating;

           
            var shows = await _showsApi.Get<List<Model.Show>>(request);
            shows.Sort((a, b) => a.Title.CompareTo(b.Title));

            Shows.Clear();
            foreach (var show in shows) {
                Shows.Add(show);
            }
            if (Genres.Count == 0) {
                var list = new List<string>();
                foreach (var show in shows) {
                    list.Add(show.Genre);
                }
                list = list.Distinct().ToList();
                list.Sort();
                list.Insert(0, "All");
                foreach (var genre in list) {
                    Genres.Add(genre);
                }
            }

        }


    }
}
