using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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

        string _address = string.Empty;
        public string Address {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        string _location = string.Empty;
        public string Location {
            get { return _location; }
            set { SetProperty(ref _location, value); }
        }

        int _streetNumber = 0;
        public int StreetNumber {
            get { return _streetNumber; }
            set { SetProperty(ref _streetNumber, value); }
        }

        string _phoneNumber = string.Empty;
        public string PhoneNumber {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber  , value); }
        }

        decimal _rating = 0;
        public decimal Rating {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }

        string _description = string.Empty;
        public string Description {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        string _open = string.Empty;
        public string Open {
            get { return _open; }
            set { SetProperty(ref _open, value); }
        }

        Color _openColor;
        public Color OpenColor {
            get { return _openColor; }
            set { SetProperty(ref _openColor, value); }
        }

        public async void SetCinema(int cinemaId) {
            var cinema = await _apiService.GetById<Model.Cinema>(cinemaId);
            ImageLink = cinema.ImageLink;
            CinemaId = cinema.CinemaId;
            Name = cinema.Name;
            Address = cinema.Address;
            Location = cinema.Location;
            Rating = cinema.Rating;
            Description = cinema.Description;
            StreetNumber = cinema.StreetNumber;
            PhoneNumber = cinema.PhoneNumber;

            var day = DateTime.Today.DayOfWeek;
            var currentTime = DateTime.Now.TimeOfDay;

            if (day.ToString() != "Saturday" && day.ToString() != "Sunday") {
                string from = "09:00:00";
                string to = "23:30:00";
                var From = DateTime.ParseExact(from, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
                var To = DateTime.ParseExact(to, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
                if(currentTime<From && currentTime > To) {
                    Open = "Closed";
                    OpenColor = Color.Red;
                }
                else {
                    Open = "Open";
                    OpenColor = Color.Green;
                }
            }

            if (day.ToString() == "Saturday") {
                string from = "09:00:00";
                string to = "00:00:00";
                var From = DateTime.ParseExact(from, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
                var To = DateTime.ParseExact(to, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
                if (currentTime < From && currentTime > To) {
                    Open = "Closed";
                }
                else {
                    Open = "Open";
                }
            }

            if (day.ToString() == "Sunday") {
                string from = "11:00:00";
                string to = "23:00:00";
                var From = DateTime.ParseExact(from, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
                var To = DateTime.ParseExact(to, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
                if (currentTime < From && currentTime > To) {
                    Open = "Closed";
                }
                else {
                    Open = "Open";
                }
            }



        }

    }
}
