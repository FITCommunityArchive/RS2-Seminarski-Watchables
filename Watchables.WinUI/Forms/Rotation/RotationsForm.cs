using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Rotation
{
    public partial class RotationsForm : Form
    {

        private readonly APIService _apiService = new APIService("rotations");
        private readonly APIService _moveiesApi = new APIService("movies");
        private readonly APIService _showsApi = new APIService("shows");
        private readonly Helper _helper = new Helper();

        public RotationsForm() {
            InitializeComponent();
            dgvRotations.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvRotations.EnableHeadersVisualStyles = false;
        }

        private async void RotationsForm_Load(object sender, EventArgs e) {
            var result = await _apiService.Get<List<Model.Rotation>>(null);
            result.Sort((a, b) => a.From.CompareTo(b.From));
            var list = new List<Model.dgvLists.RotationItem>();
            foreach(var rotation in result) {
                var movie = await _moveiesApi.GetById<Model.Movie>(rotation.MovieId);
                var show = await _showsApi.GetById<Model.Show>(rotation.ShowId);
                var Object = new Model.dgvLists.RotationItem() {
                    Available=rotation.Available,
                    ForBirthday=rotation.ForBirthday,
                    From=rotation.From.Date,
                    RotationId=rotation.RotationId,
                    To=rotation.To.Date,
                    MovieId=rotation.MovieId,
                    ShowId=rotation.ShowId,
                    Movie= movie.Title,
                    Show=show.Title
                };
                list.Add(Object);
            }
            dgvRotations.AutoGenerateColumns = false;
            dgvRotations.DataSource = list;
        }

        private async void clearSearch_Click(object sender, EventArgs e) {
            var result = await _apiService.Get<List<Model.Rotation>>(null);
            result.Sort((a, b) => a.From.CompareTo(b.From));
            var list = new List<Model.dgvLists.RotationItem>();
            foreach (var rotation in result) {
                var movie = await _moveiesApi.GetById<Model.Movie>(rotation.MovieId);
                var show = await _showsApi.GetById<Model.Show>(rotation.ShowId);
                var Object = new Model.dgvLists.RotationItem() {
                    Available = rotation.Available,
                    ForBirthday = rotation.ForBirthday,
                    From = rotation.From.Date,
                    RotationId = rotation.RotationId,
                    To = rotation.To.Date,
                    MovieId = rotation.MovieId,
                    ShowId = rotation.ShowId,
                    Movie = movie.Title,
                    Show = show.Title
                };
                list.Add(Object);
            }
            dgvRotations.AutoGenerateColumns = false;
            dgvRotations.DataSource = list;
            BirthdayCB.Checked = false;
        }

        private async void searchBtn_Click(object sender, EventArgs e) {            
            var search = new Model.Requests.RotationSearchRequest() { ForBirthday = (BirthdayCB.Checked) ? "true" : "false" };
            var result = await _apiService.Get<List<Model.Rotation>>(search);
            result.Sort((a, b) => a.From.CompareTo(b.From));
            var list = new List<Model.dgvLists.RotationItem>();
            foreach (var rotation in result) {
                var movie = await _moveiesApi.GetById<Model.Movie>(rotation.MovieId);
                var show = await _showsApi.GetById<Model.Show>(rotation.ShowId);
                var Object = new Model.dgvLists.RotationItem() {
                    Available = rotation.Available,
                    ForBirthday = rotation.ForBirthday,
                    From = rotation.From.Date,
                    RotationId = rotation.RotationId,
                    To = rotation.To.Date,
                    MovieId = rotation.MovieId,
                    ShowId = rotation.ShowId,
                    Movie = movie.Title,
                    Show = show.Title
                };
                list.Add(Object);
            }
            dgvRotations.AutoGenerateColumns = false;
            dgvRotations.DataSource = list;
        }

        private void dgvRotations_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var rotationId = dgvRotations.Rows[e.RowIndex].Cells["RotationId"].Value;
                var action = dgvRotations.Columns[e.ColumnIndex].Name;
                MenuForm menuForm = (MenuForm)this.MdiParent;

                if (action == "Edit") {
                    AddEditRotationForm form = new AddEditRotationForm(menuForm, int.Parse(rotationId.ToString())) {};
                    _helper.ShowForm(form, 15);
                }
                else if (action == "Delete") {
                    MessageBox.Show("Implement delete movie", "To-do");
                }
                else return;
            }
        }

        private void AddMovieBtn_Click(object sender, EventArgs e) {
            MenuForm menuForm = (MenuForm)this.MdiParent;
            AddEditRotationForm form = new AddEditRotationForm(menuForm) {};
            _helper.ShowForm(form, 15);
        }
    }
}
