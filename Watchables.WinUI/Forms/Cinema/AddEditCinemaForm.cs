using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchables.Model.Requests;
using Flurl.Http;
using Flurl;
using System.Text.RegularExpressions;

namespace Watchables.WinUI.Forms.Cinema
{
    public partial class AddEditCinemaForm : Form
    {

        private int? _cinemaId = null;
        private readonly APIService _apiService = new APIService("cinemas");
        private MenuForm _menuForm;

        public AddEditCinemaForm(MenuForm menuForm, int? cinemaId = null) {
            InitializeComponent();
            _cinemaId = cinemaId;
            _menuForm = menuForm;
        }

        private void Close_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void AddEditCinemaForm_Load(object sender, EventArgs e) {
            if (_cinemaId.HasValue) {
                Model.Cinema cinema = await _apiService.GetById<Model.Cinema>(_cinemaId);
                Title.Text = $"{cinema.Name}, {cinema.Location}";
                Cinema.Text = cinema.Name;
                Address.Text = cinema.Address;
                StreetNumber.Value = cinema.StreetNumber;
                Location.Text = cinema.Location;
                PhoneNumber.Text = cinema.PhoneNumber;
                Rating.Text = cinema.Rating.ToString();
                Description.Text = cinema.Description;
                ImageLink.Text = cinema.ImageLink;

                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                    $"<img alt='No available image with the provided link' src={cinema.ImageLink} class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
            }
            else {
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                   $"<img alt='No available image with the provided link' src=https://www.deadlineclaims.com/wp-content/uploads/2017/02/placeholder-image.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
                Title.Text = "Add a new cinema";
            }
            
        }

        private async void SaveBtn_Click(object sender, EventArgs e) {

            var messageBox = new CustomMessageBox();

            if (string.IsNullOrWhiteSpace(Cinema.Text) || Cinema.Text.Length<4) {
                messageBox.Show("The cinema field requires 4 letters!", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(Address.Text) || Address.Text.Length < 5) {
                messageBox.Show("The address field requires 5 letters!", "error");
                return;
            }
            if (string.IsNullOrWhiteSpace(Location.Text) || Location.Text.Length < 4) {
                messageBox.Show("The location field requires 4 letters!", "error");
                return;
            }

            if (StreetNumber.Value<=0 || StreetNumber.Value >100) {
                messageBox.Show("Enter a valid street number (1-100)!", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(Description.Text) || Description.Text.Length < 5) {
                messageBox.Show("The description field requires 5 letters!", "error");
                return;
            }
            if (string.IsNullOrWhiteSpace(ImageLink.Text) || !ImageLink.Text.Contains(".jpg")) {
                messageBox.Show("Enter a valid '.jpg' image link!", "error");
                return;
            }
           
            if(string.IsNullOrWhiteSpace(Rating.Text) || !decimal.TryParse(Rating.Text, out decimal n)) {
                messageBox.Show("Enter a valid rating (0-5)!", "error");
                return;
            }           
            decimal rating = decimal.Parse(Rating.Text);
            if (rating<0 || rating > 5) {
                messageBox.Show("Enter a valid rating (0-5)!", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(PhoneNumber.Text) || PhoneNumber.Text.Length < 9) {
                messageBox.Show("Enter a valid phone number", "error");
                return;
            }
            if (!string.IsNullOrWhiteSpace(PhoneNumber.Text)) {
                string pattern = @"\(?\d{3}\)?-? ?/*\d{3}-? *-?\d{3}";
                Regex reg = new Regex(pattern);
                if (!reg.IsMatch(PhoneNumber.Text)) {
                    messageBox.Show("Phone number: xxx/xxx-xxx", "error");
                    return;
                }            
            }


            InsertCinemaRequest request = new InsertCinemaRequest() {
            Name=Cinema.Text,
            Address=Address.Text,
            StreetNumber = (int)StreetNumber.Value,
            Location = Location.Text,
            PhoneNumber = PhoneNumber.Text,
            Rating = decimal.Parse(Rating.Text),
            Description = Description.Text,
            ImageLink = ImageLink.Text
            };

            if (_cinemaId.HasValue) {
                await _apiService.Update<Model.Cinema>(_cinemaId, request);                
            }
            else {
                await _apiService.Insert<Model.Cinema>(request);               
            }
            this.Close();
            foreach (Form frm in _menuForm.MdiChildren) {
                frm.Close();
            }
            CinemasForm form = new CinemasForm {
                MdiParent = _menuForm,
                Dock = DockStyle.Fill
            };           
            form.Show();
            if (_cinemaId.HasValue) {
                messageBox.Show("Cinema updated successfully!", "success");
            }
            else {
                messageBox.Show("Cinema added successfully!", "success");
            }
        }     

     

        private void ImageLink_KeyUp(object sender, KeyEventArgs e) {
            if (string.IsNullOrWhiteSpace(ImageLink.Text)) {
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                  $"<img alt='No available image with the provided link' src=https://www.deadlineclaims.com/wp-content/uploads/2017/02/placeholder-image.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
            }
            else {
                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                 $"<img src={ImageLink.Text} alt='No available image with the provided link' class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
            }
        }

        private async void Reset_Click(object sender, EventArgs e) {
            if (_cinemaId.HasValue) {
                Model.Cinema cinema = await _apiService.GetById<Model.Cinema>(_cinemaId);
                Title.Text = $"{cinema.Name}, {cinema.Location}";
                Cinema.Text = cinema.Name;
                Address.Text = cinema.Address;
                StreetNumber.Value = cinema.StreetNumber;
                Location.Text = cinema.Location;
                PhoneNumber.Text = cinema.PhoneNumber;
                Rating.Text = cinema.Rating.ToString();
                Description.Text = cinema.Description;
                ImageLink.Text = cinema.ImageLink;

                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                    $"<img alt='No available image with the provided link' src={cinema.ImageLink} class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
            }
            else {

                Title.Text = "";
                Cinema.Text = "";
                Address.Text = "";
                StreetNumber.Value = 0;
                Location.Text = "";
                PhoneNumber.Text = "";
                Rating.Text = "";
                Description.Text = "";
                ImageLink.Text = "";


                Image.DocumentText = "<style>.imgStyle{color:red; object-fit:cover;} body{margin:0;}</style>" +
                   $"<img alt='No available image with the provided link' src=https://www.deadlineclaims.com/wp-content/uploads/2017/02/placeholder-image.jpg class='imgStyle' width='{Image.Width}' height='{Image.Height}'/>";
                Title.Text = "Add a new cinema";
            }
        }
    }
}
