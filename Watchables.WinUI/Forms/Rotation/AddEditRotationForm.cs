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
    public partial class AddEditRotationForm : Form
    {
        private readonly int? _rotationId;
        private readonly MenuForm _menuForm;
        private readonly APIService _apiService = new APIService("rotations");
        private readonly APIService _moviesApi = new APIService("movies");
        private readonly APIService _showsApi = new APIService("shows");
        private readonly Helper _helper = new Helper();

        public AddEditRotationForm(MenuForm menuForm, int? rotationId=null) {
            InitializeComponent();
            _menuForm = menuForm;
            _rotationId = rotationId;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }

        private async void AddEditRotationForm_Load(object sender, EventArgs e) {
            var shows = await _showsApi.Get<List<Model.Show>>(null);
            var movies = await _moviesApi.Get<List<Model.Movie>>(null);
            movies.Sort((a, b) => a.Title.CompareTo(b.Title));
            shows.Sort((a, b) => a.Title.CompareTo(b.Title));

            Shows.DisplayMember = "Text";
            Shows.ValueMember = "Value";
            foreach (var show in shows) {
                Shows.Items.Add(new { Text = show.Title, Value = show.ShowId });
            }
            if (Shows.Items.Count != 0) {
                Shows.SelectedIndex = 0;
            }

            Movies.DisplayMember = "Text";
            Movies.ValueMember = "Value";
            foreach (var movie in movies) {
                Movies.Items.Add(new { Text = movie.Title, Value = movie.MovieId });
            }
            if (Movies.Items.Count != 0) {
                Movies.SelectedIndex = 0;
            }


            if (_rotationId.HasValue) {
                Title.Text = "Edit rotation";
                var rotation = await _apiService.GetById<Model.Rotation>(_rotationId);
                From.Value = rotation.From.Date;
                To.Value = rotation.To.Date;
                Description.Text = rotation.Description;
                Available.Checked = rotation.Available;
                Birthday.Checked = rotation.ForBirthday;
                var movie = await _moviesApi.GetById<Model.Movie>(rotation.MovieId);
                var show = await _showsApi.GetById<Model.Show>(rotation.ShowId);
                Movies.SelectedIndex = Movies.FindStringExact(movie.Title);
                Shows.SelectedIndex = Shows.FindStringExact(show.Title);
            }
            else {
                Title.Text = "Add a rotation";
            }
        }

        private async void reloadBtn_Click(object sender, EventArgs e) {
            if (_rotationId.HasValue) {
                var rotation = await _apiService.GetById<Model.Rotation>(_rotationId);
                From.Value = rotation.From.Date;
                To.Value = rotation.To.Date;
                Description.Text = rotation.Description;
                Available.Checked = rotation.Available;
                Birthday.Checked = rotation.ForBirthday;
                var movie = await _moviesApi.GetById<Model.Movie>(rotation.MovieId);
                var show = await _showsApi.GetById<Model.Show>(rotation.ShowId);
                Movies.SelectedIndex = Movies.FindStringExact(movie.Title);
                Shows.SelectedIndex = Shows.FindStringExact(show.Title);
            }
            else {
                From.Value = DateTime.Now;
                To.Value = DateTime.Now;
                Description.Text = "";
                Available.Checked = false;
                Birthday.Checked = false;
                Movies.SelectedIndex = -1;
                Shows.SelectedIndex = -1;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e) {

        }
    }
}
