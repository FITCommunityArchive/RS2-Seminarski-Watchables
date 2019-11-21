using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Show
{
    public partial class ShowsForm : Form
    {
        private readonly APIService _apiService = new APIService("shows");
        private readonly Helper _helper = new Helper();

        public ShowsForm() {
            InitializeComponent();
            dgvShows.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvShows.EnableHeadersVisualStyles = false;
        }

        private async void ShowsForm_Load(object sender, EventArgs e) {
            var result = await _apiService.Get<List<Model.Show>>(null);
            result.Sort((a, b) => a.Title.CompareTo(b.Title));
            dgvShows.AutoGenerateColumns = false;
            dgvShows.DataSource = result;
            Title.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
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

            string ongoing = "";
            if (OngoingCB.Checked) ongoing = "true";
            else ongoing = "false";

            var search = new Model.Requests.ShowSearchRequest() {
                Rating = rating,
                Ongoing = ongoing,
                Title = Show.Text,
                Year = int.Parse(YearSearch.Value.ToString()),
                Genre = GenreBox.Text
            };

            var list = await _apiService.Get<List<Model.Show>>(search);
            list.Sort((a, b) => a.Title.CompareTo(b.Title));
            dgvShows.AutoGenerateColumns = false;
            dgvShows.DataSource = list;
        }

        private async void clearSearch_Click(object sender, EventArgs e) {
            RatingSearch.Text = "";
            YearSearch.Value = YearSearch.Minimum;
            OngoingCB.Checked = false;
            Show.Text = "";
            GenreBox.Text = "";

            var list = await _apiService.Get<List<Model.Show>>(null);
            list.Sort((a, b) => a.Title.CompareTo(b.Title));
            dgvShows.AutoGenerateColumns = false;
            dgvShows.DataSource = list;
        }

        private void dgvShows_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var showId = dgvShows.Rows[e.RowIndex].Cells["ShowId"].Value;
                var action = dgvShows.Columns[e.ColumnIndex].Name;
                MenuForm menuForm = (MenuForm)this.MdiParent;

                if (action == "Edit" || action == "Title") {
                    AddEditShowForm form = new AddEditShowForm(menuForm, int.Parse(showId.ToString())) {
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

        private void AddShowBtn_Click(object sender, EventArgs e) {
            MenuForm menuForm = (MenuForm)this.MdiParent;
            AddEditShowForm form = new AddEditShowForm(menuForm) {
                MdiParent = menuForm,
                Dock = DockStyle.Fill
            };
            form.Show();
        }
    }
}
