using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Mobile.ViewModels
{
    public class CinemaProfileViewModel : BaseViewModel
    {
        private readonly APIService _apiService = new APIService("cinemas");

        string _imageLink = string.Empty;
        public string ImageLink {
            get { return _imageLink; }
            set { SetProperty(ref _imageLink, value); }
        }

        int _cinemaId = 0;
        public int CinemaId {
            get { return _cinemaId; }
            set { SetProperty(ref _cinemaId, value); }
        }

        string _name = string.Empty;
        public string Name {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }


        public async void SetCinema(int cinemaId) {
            var cinema = await _apiService.GetById<Model.Cinema>(cinemaId);
            ImageLink = cinema.ImageLink;
            CinemaId = cinema.CinemaId;
            Name = cinema.Name;
        }


    }
}
