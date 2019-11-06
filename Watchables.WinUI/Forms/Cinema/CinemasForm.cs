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

namespace Watchables.WinUI.Forms
{
    public partial class CinemasForm : Form
    {

        private readonly APIService _apiService=new APIService("cinemas");

        public CinemasForm() {
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e) {
            base.OnLoad(e);
            var search = new CinemasSearchRequest() { };

            var result = await _apiService.Get<List<Model.Cinema>>(search);
            dgvCinemas.AutoGenerateColumns = false;
            dgvCinemas.DataSource = result;
            Cinema.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;

        }

        private void AddCinemaButton_Click(object sender, EventArgs e) {

        }

        private async void button1_Click(object sender, EventArgs e) {

            decimal value = (!string.IsNullOrWhiteSpace(ratingTextBox.Text)) ? decimal.Parse(ratingTextBox.Text) : 0;

            var search = new CinemasSearchRequest() {
                Name= searchTextBox.Text,
                Location=locationTextBox.Text,
                Rating=value                
            };

            var result = await _apiService.Get<List<Model.Cinema>>(search);
            dgvCinemas.AutoGenerateColumns = false;
            dgvCinemas.DataSource = result;


        }
      
        private void dgvCinemas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var cinemaId = dgvCinemas.Rows[e.RowIndex].Cells["CinemaId"].Value;
                var action = dgvCinemas.Columns[e.ColumnIndex].Name;
                if (action == "Edit") {
                    MessageBox.Show(cinemaId.ToString(), action);
                }
                else if (action == "Delete") {
                    MessageBox.Show(cinemaId.ToString(), action);
                }
                else if (action == "Halls") {
                    MessageBox.Show(cinemaId.ToString(), action);
                }
                else if (action == "Schedule") {
                    MessageBox.Show(cinemaId.ToString(), action);
                }
                else if (action == "Products") {
                    MessageBox.Show(cinemaId.ToString(), action);
                }
                else if (action == "Cinema") {
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
