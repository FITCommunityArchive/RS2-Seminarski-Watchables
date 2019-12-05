using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Mobile.ViewModels
{
    public class CinemaScheduleViewModel : BaseViewModel
    {
        public readonly APIService _cinemasApi = new APIService("cinemas");

        int _cinemaId = 0;
        public int cinemaId {
            get { return _cinemaId; }
            set { SetProperty(ref _cinemaId, value); }
        }



        public async void Init(int cinemaId) {
            this.cinemaId = cinemaId;
            var cinema = await _cinemasApi.GetById<Model.Cinema>(cinemaId);
            Title = "Schedule of " + cinema.Name;
        }

    }
}
