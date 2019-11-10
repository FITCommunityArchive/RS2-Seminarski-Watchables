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
using Watchables.WinUI.Forms.Cinema;

namespace Watchables.WinUI.Forms
{
    public partial class CinemasForm : Form
    {

        private readonly APIService _apiService=new APIService("cinemas");

        public CinemasForm() {
            InitializeComponent();
            var nesto = AddCinemaButton.Height;
        }

        protected override async void OnLoad(EventArgs e) {
            base.OnLoad(e);
            var search = new CinemasSearchRequest() { };

            var result = await _apiService.Get<List<Model.Cinema>>(search);
            dgvCinemas.AutoGenerateColumns = false;
            dgvCinemas.DataSource = result;
            Cinema.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;

        }

     

        private async void button1_Click(object sender, EventArgs e) {

            var messageBox = new CustomMessageBox();

            if(!string.IsNullOrWhiteSpace(ratingTextBox.Text) && !decimal.TryParse(ratingTextBox.Text, out decimal n)) {
                messageBox.Show("Enter a valid rating (0-5)!", "error");
                return;
            }

            decimal rating = (!string.IsNullOrWhiteSpace(ratingTextBox.Text)) ? decimal.Parse(ratingTextBox.Text) : (-1);

            if (rating < 0 || rating > 5) {
                messageBox.Show("Enter a valid rating (0-5)!", "error");
                return;
            }
            

            var search = new CinemasSearchRequest() {
                Name= searchTextBox.Text,
                Location=locationTextBox.Text,
                Rating= rating
            };

            var result = await _apiService.Get<List<Model.Cinema>>(search);
            dgvCinemas.AutoGenerateColumns = false;
            dgvCinemas.DataSource = result;
        }

        private void AddCinemaButton_Click(object sender, EventArgs e) {

            MenuForm menuForm = (MenuForm)this.MdiParent;
            AddEditCinemaForm form = new AddEditCinemaForm(menuForm) {
                MdiParent = menuForm,
                Dock = DockStyle.Fill
            };
            form.Show();
        }

        private async void dgvCinemas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var cinemaId = dgvCinemas.Rows[e.RowIndex].Cells["CinemaId"].Value;
                var action = dgvCinemas.Columns[e.ColumnIndex].Name;
                MenuForm menuForm = (MenuForm)this.MdiParent;

                if (action == "Edit" || action == "Cinema") {                    
                    AddEditCinemaForm form = new AddEditCinemaForm(menuForm, int.Parse(cinemaId.ToString())) {
                        MdiParent = menuForm,
                        Dock = DockStyle.Fill
                    };
                    form.Show();
                }
                else if (action == "Delete") {
                    MessageBox.Show("Implement delete cinema", "To-do");
                }
                else if (action == "Halls") {
                    var cinemaName = dgvCinemas.Rows[e.RowIndex].Cells["Cinema"].Value;
                    var cinemaLocation = dgvCinemas.Rows[e.RowIndex].Cells["Location"].Value;

                    CinemasHallsForm cinemasHallsForm = new CinemasHallsForm(menuForm, int.Parse(cinemaId.ToString()), cinemaName.ToString(), cinemaLocation.ToString()){};

                    cinemasHallsForm.Show();

                    cinemasHallsForm.Opacity = 0;
                    while (cinemasHallsForm.Opacity < 1.0) {
                        await Task.Delay(18);
                        cinemasHallsForm.Opacity += 0.05;
                    }
                    cinemasHallsForm.Opacity = 1;
                  

                }
                else if (action == "Schedule") {
                    MessageBox.Show(cinemaId.ToString(), action);
                }
                else if (action == "Products") {
                    MessageBox.Show(cinemaId.ToString(), action);
                }                
                else return;
            }
        }

        private async void clearSearch_Click(object sender, EventArgs e) {
            searchTextBox.Text = "";
            locationTextBox.Text = "";
            ratingTextBox.Text = "";

            var search = new CinemasSearchRequest() { };

            var result = await _apiService.Get<List<Model.Cinema>>(search);
            dgvCinemas.AutoGenerateColumns = false;
            dgvCinemas.DataSource = result;

        }
    }
}
