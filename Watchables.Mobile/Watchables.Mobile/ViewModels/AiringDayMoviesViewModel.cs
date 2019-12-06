using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class AiringDayMoviesViewModel : BaseViewModel
    {
        string _cinema = string.Empty;
        public string Cinema {
            get { return _cinema; }
            set { SetProperty(ref _cinema, value); }
        }

        string _date = string.Empty;
        public string Date {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        int _adocId = 0;
        public int AdocId {
            get { return _adocId; }
            set { SetProperty(ref _adocId, value); }
        }

        string _day = string.Empty;
        public string Day {
            get { return _day; }
            set { SetProperty(ref _day, value); }
        }

        public APIService _cdmApi = new APIService("CinemaDayMovie");
        public APIService _moviesApi = new APIService("movies");
        public APIService _appApi = new APIService("Appointments");
        public ICommand GetDataCommand { get; set; }
        public ObservableCollection<Model.ObservableLists.CdmItem> CdmItems { get; set; } = new ObservableCollection<Model.ObservableLists.CdmItem>();

        public AiringDayMoviesViewModel() {
            GetDataCommand = new Command(async () => { await GetData(); });
        }


        public void Init(int adocId, string day, string cinema, string date) {
            AdocId = adocId;
            Day = day;
            Cinema = cinema;
            Date = date;
            Title = Cinema + ", " + date + ", " + day;
        }

        public async Task GetData() {
            var cdms = await _cdmApi.Get<List<Model.CinemaDayMovie>>(null);
            var apps = await _appApi.Get<List<Model.Appointments>>(null);
            cdms.RemoveAll(cdm => cdm.AiringDaysOfCinemaId != AdocId);
            CdmItems.Clear();

            foreach (var cdm in cdms) {
                var movie = await _moviesApi.GetById<Model.Movie>(cdm.MovieId);
                var newItem = new Model.ObservableLists.CdmItem() {
                    Movie = movie,
                    CinemaDayMovieId = cdm.CinemaDayMovieId,
                    Appointments = new ObservableCollection<Model.Appointments>()
                };
                foreach (var app in apps) {
                    if (app.CinemaDayMovieId == cdm.CinemaDayMovieId) {
                        newItem.Appointments.Add(app);
                    }
                }
                CdmItems.Add(newItem);
            }
        }

    }
}
