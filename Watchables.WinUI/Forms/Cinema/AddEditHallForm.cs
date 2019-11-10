using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Cinema
{
    public partial class AddEditHallForm : Form
    {

        private readonly MenuForm _menuForm;
        private readonly int _cinemaId;
        private readonly int? _hallId;
        private readonly CinemasHallsForm _cinemasHallsForm;
        private readonly string _cinemaName;
        private readonly string _cinemaLocation;
        private readonly APIService _apiService = new APIService("cinemas");

        public AddEditHallForm(MenuForm menuForm, CinemasHallsForm cinemasHallsForm, string cinemaName, string cinemaLocation, int cinemaId, int? hallId = null) {
            InitializeComponent();
            _menuForm = menuForm;
            _cinemaId = cinemaId;
            _hallId = hallId;
            _cinemasHallsForm = cinemasHallsForm;
            _cinemaName = cinemaName;
            _cinemaLocation = cinemaLocation;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
        }

        private async void AddEditHallForm_Load(object sender, EventArgs e) {
            if (_hallId.HasValue) {
                APIService hallsApi = new APIService("halls");
                var hall = await hallsApi.GetById<Model.Hall>(_hallId);
                HallName.Text = hall.HallName;
                HallNumber.Value = hall.HallNumber;
                HallSeats.Value = hall.NumberOfseats;
                Title.Text = $"Hall of: {_cinemaName}";
            }
            else {
                Title.Text = $"Hall to: {_cinemaName}";
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e) {
            var messageBox = new CustomMessageBox();

            if (string.IsNullOrWhiteSpace(HallName.Text) || HallName.Text.Length < 4) {
                messageBox.Show("The hall name field requires 4 letters!", "error");
                return;
            }

            if (HallNumber.Value < 1 || HallNumber.Value > 100) {
                messageBox.Show("Enter a valid hall number (1-100)!", "error");
                return;
            }
            if (HallSeats.Value < 1 || HallSeats.Value > 100) {
                messageBox.Show("Enter valid seats (1-100)!", "error");
                return;
            }
          
            if (_hallId.HasValue) {
                Model.Hall hall = new Model.Hall() {
                    HallName = HallName.Text,
                    HallNumber = (int)HallNumber.Value,
                    NumberOfseats = (int)HallSeats.Value
                };
                await _apiService.UpdateItem<Model.Hall>(_hallId, "updateHall", hall);
                messageBox.Show("Hall updated succesfully", "Success");
              
            }
            else {
                Model.Hall hall = new Model.Hall() {
                    HallName = HallName.Text,
                    HallNumber = (int)HallNumber.Value,
                    NumberOfseats = (int)HallSeats.Value,
                    CinemaId = _cinemaId
                };
                await _apiService.InsertItem<Model.Hall>("addHall", hall);
                messageBox.Show("Hall added succesfully", "Success");
            }

            CinemasHallsForm form = new CinemasHallsForm(_menuForm, _cinemaId, _cinemaName, _cinemaLocation);
            _cinemasHallsForm.Close();
            while (this.Opacity > 0.0) {
                await Task.Delay(15);
                this.Opacity -= 0.05;
            }
            this.Opacity = 0;
            this.Close();           
            form.Show();
            form.Opacity = 0;
            while (form.Opacity < 1.0) {
                await Task.Delay(15);
                form.Opacity += 0.05;
            }
            form.Opacity = 1;

        }

        private async void closeBtn_Click(object sender, EventArgs e) {
            while (this.Opacity > 0.0) {
                await Task.Delay(15);
                this.Opacity -= 0.05;
            }
            this.Opacity = 0;
            this.Close();
        }

        private async void reloadBtn_Click(object sender, EventArgs e) {
            if (_hallId.HasValue) {
                APIService hallsApi = new APIService("halls");
                var hall = await hallsApi.GetById<Model.Hall>(_hallId);
                HallName.Text = hall.HallName;
                HallNumber.Value = hall.HallNumber;
                HallSeats.Value = hall.NumberOfseats;
            }
            else {
                HallName.Text = "";
                HallNumber.Value =0;
                HallSeats.Value = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e) {

        }

       
    }
}
