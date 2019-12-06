using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Watchables.Mobile.ViewModels
{
    public class CinemaScheduleViewModel : BaseViewModel
    {
        public readonly APIService _cinemasApi = new APIService("cinemas");
        public readonly APIService _adocApi = new APIService("AiringDaysOfCinema");
        public readonly APIService _adApi = new APIService("AiringDays");
        public readonly APIService _cdmApi = new APIService("CinemaDayMovie");

        int _cinemaId = 0;
        public int cinemaId {
            get { return _cinemaId; }
            set { SetProperty(ref _cinemaId, value); }
        }

        string _hasSchedule = "True";
        public string HasSchedule {
            get { return _hasSchedule; }
            set { SetProperty(ref _hasSchedule, value); }
        }

        string _hasPicker = "False";
        public string HasPicker {
            get { return _hasPicker; }
            set { SetProperty(ref _hasPicker, value); }
        }

        public ICommand GetDataCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ObservableCollection<Model.ObservableLists.AiringDayOfCinemaItem> Adocs { get; set; } = new ObservableCollection<Model.ObservableLists.AiringDayOfCinemaItem>();
        public ObservableCollection<string> AllDays { get; set; } = new ObservableCollection<string>() { "All", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        string _selectedDay = null;
        public string SelectedDay {
            get { return _selectedDay; }
            set {
                SetProperty(ref _selectedDay, value);
                if (value != null) {
                    GetDataCommand.Execute(null);
                }
            }
        }

        public async void Init(int cinemaId) {
            this.cinemaId = cinemaId;
            var cinema = await _cinemasApi.GetById<Model.Cinema>(cinemaId);
            Title = "Schedule of " + cinema.Name;
        }

        public CinemaScheduleViewModel() {
            GetDataCommand = new Command(async () => await GetData());
        }

        public async Task GetData() {
            var adocs = await _adocApi.Get<List<Model.AiringDaysOfCinema>>(null);
            var ads = await _adApi.Get<List<Model.AiringDay>>(null);
            var cdms = await _cdmApi.Get<List<Model.CinemaDayMovie>>(null);
            var cinema = await _cinemasApi.GetById<Model.Cinema>(cinemaId);
            if ((SelectedDay == "" || SelectedDay == "All") || SelectedDay==null) {

                adocs.RemoveAll(adoc => adoc.CinemaId != cinemaId);
                adocs.Sort((a, b) => a.Date.CompareTo(b.Date));
                var currentDate = DateTime.Now;

                Adocs.Clear();
                foreach (var adoc in adocs) {
                    if (adoc.Date.Date >= currentDate.Date) {
                        string day = "";
                        int numberOfMovies = 0;
                        foreach (var ad in ads) {
                            if (adoc.AiringDayId == ad.AiringDayId) {
                                day = ad.Name;
                                break;
                            }
                        }
                        foreach (var cdm in cdms) {
                            if (cdm.AiringDaysOfCinemaId == adoc.AiringDaysOfCinemaId) {
                                numberOfMovies++;
                            }
                        }

                        var newItem = new Model.ObservableLists.AiringDayOfCinemaItem() {
                            AiringDayOfCinemaId = adoc.AiringDaysOfCinemaId,
                            Date = adoc.Date.ToString("dd. MMM yyyy") + ", ",
                            Day = day + ", ",
                            NumberOfMovies = numberOfMovies,
                            Cinema=cinema.Name
                        };

                        Adocs.Add(newItem);

                    }
                }
                if (Adocs.Count > 0) {
                    HasSchedule = "False";
                    HasPicker = "True";
                } 
            }
            else {
                Adocs.Clear();

                adocs.RemoveAll(adoc => adoc.CinemaId != cinemaId);
                adocs.Sort((a, b) => a.Date.CompareTo(b.Date));
                var currentDate = DateTime.Now;

                Adocs.Clear();
                foreach (var adoc in adocs) {
                    if (adoc.Date.Date >= currentDate.Date) {
                        string day = "";
                        int numberOfMovies = 0;
                        foreach (var ad in ads) {
                            if (adoc.AiringDayId == ad.AiringDayId) {
                                day = ad.Name;
                                break;
                            }
                        }
                        foreach (var cdm in cdms) {
                            if (cdm.AiringDaysOfCinemaId == adoc.AiringDaysOfCinemaId) {
                                numberOfMovies++;
                            }
                        }
                        if (day == SelectedDay) {
                            var newItem = new Model.ObservableLists.AiringDayOfCinemaItem() {
                                AiringDayOfCinemaId = adoc.AiringDaysOfCinemaId,
                                Date = adoc.Date.ToString("dd. MMM yyyy") + ", ",
                                Day = day + ", ",
                                NumberOfMovies = numberOfMovies,
                                Cinema = cinema.Name
                            };

                            Adocs.Add(newItem);
                        }
                    }
                }
                if (Adocs.Count > 0) {
                    HasSchedule = "False";
                    HasPicker = "True";
                }
            }
        }

    }
}
