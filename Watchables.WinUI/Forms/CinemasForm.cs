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

        private void locationTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}
