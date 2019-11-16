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
    }
}
