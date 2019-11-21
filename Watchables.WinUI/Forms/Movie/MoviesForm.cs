using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Movie
{
    public partial class MoviesForm : Form
    {

        private readonly APIService _apiService = new APIService("movies");
        private readonly Helper _helper = new Helper();

        public MoviesForm() {
            InitializeComponent();
            dgvMovies.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvMovies.EnableHeadersVisualStyles = false;
        }

        private async void MoviesForm_Load(object sender, EventArgs e) {
            var result = await _apiService.Get<List<Model.Movie>>(null);
            result.Sort((a, b) => a.Title.CompareTo(b.Title));
            dgvMovies.AutoGenerateColumns = false;
            dgvMovies.DataSource = result;
            Title.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var movieId = dgvMovies.Rows[e.RowIndex].Cells["MovieId"].Value;
                var action = dgvMovies.Columns[e.ColumnIndex].Name;
                MenuForm menuForm = (MenuForm)this.MdiParent;

                if (action == "Edit" || action == "Title") {
                    AddEditMovieForm form = new AddEditMovieForm(menuForm, int.Parse(movieId.ToString())) {
                        MdiParent = menuForm,
                        Dock = DockStyle.Fill
                    };
                    form.Show();
                }
                else if (action == "Delete") {
                    MessageBox.Show("Implement delete movie", "To-do");
                }              
                else return;
            }
        }

        private void AddMovieBtn_Click(object sender, EventArgs e) {
            MenuForm menuForm = (MenuForm)this.MdiParent;
            AddEditMovieForm form = new AddEditMovieForm(menuForm) {
                MdiParent = menuForm,
                Dock = DockStyle.Fill
            };
            form.Show();
        }

        private async void searchBtn_Click(object sender, EventArgs e) {
            var messageBox = new CustomMessageBox();

            if (!string.IsNullOrWhiteSpace(RatingSearch.Text) && !decimal.TryParse(RatingSearch.Text, out decimal n)) {
                messageBox.Show("Enter a valid rating (0-10)!", "error");
                return;
            }

            decimal rating = (!string.IsNullOrWhiteSpace(RatingSearch.Text)) ? decimal.Parse(RatingSearch.Text) : (0);

            if (rating < 0 || rating > 10) {
                messageBox.Show("Enter a valid rating (0-10)!", "error");
                return;
            }

            string standalone = "";            
            if (StandaloneCB.Checked) standalone = "true";
            else standalone = "false";

            var search = new Model.Requests.MovieSearchRequest() {
                Rating = rating,
                Standalone = standalone,
                Title = Movie.Text,
                Year = int.Parse(YearSearch.Value.ToString()),
                Genre = GenreBox.Text
            };

            var list = await _apiService.Get<List<Model.Movie>>(search);
            list.Sort((a, b) => a.Title.CompareTo(b.Title));
            dgvMovies.AutoGenerateColumns = false;
            dgvMovies.DataSource = list;

        }

        private async void clearSearch_Click(object sender, EventArgs e) {
            RatingSearch.Text = "";
            YearSearch.Value = YearSearch.Minimum;
            StandaloneCB.Checked = false;
            Movie.Text = "";
            GenreBox.Text = "";

            var list = await _apiService.Get<List<Model.Movie>>(null);
            list.Sort((a, b) => a.Title.CompareTo(b.Title));
            dgvMovies.AutoGenerateColumns = false;
            dgvMovies.DataSource = list;
        }

     
    }
}
