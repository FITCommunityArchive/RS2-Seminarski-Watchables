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
    public partial class CinemasHallsForm : Form
    {

        private readonly MenuForm _menuForm;
        private readonly int _cinemaId;
        private readonly string _cinemaName;
        private readonly string _cinemaLoactin;
        private readonly APIService _apiService = new APIService("cinemas");

        public CinemasHallsForm(MenuForm menuForm, int cinemaId, string cinemaName, string cinemaLocation) {
            InitializeComponent();
            _menuForm = menuForm;
            _cinemaId = cinemaId;
            _cinemaName = cinemaName;
            _cinemaLoactin = cinemaLocation;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height-AddHallBtn.Height-20);
        }

        private async void CinemasHallsForm_Load(object sender, EventArgs e) {
            Title.Text = $"Halls of {_cinemaName}";
            var result = await _apiService.GetItems<List<Model.Hall>>(_cinemaId, "GetHalls");
            result.Sort((a, b) => a.HallName.CompareTo(b.HallName));
            dgvHalls.AutoGenerateColumns = false;
            dgvHalls.DataSource = result;
        }

        private async void closeBtn_Click(object sender, EventArgs e) {
            while (this.Opacity > 0.0) {
                await Task.Delay(18);
                this.Opacity -= 0.05;
            }
            this.Opacity = 0;
            this.Close();
        }

        private async void dgvHalls_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var hallId = dgvHalls.Rows[e.RowIndex].Cells["HallId"].Value;
                var action = dgvHalls.Columns[e.ColumnIndex].Name;
                if (action == "Edit") {
                    AddEditHallForm form = new AddEditHallForm(_menuForm, this, _cinemaName, _cinemaLoactin, _cinemaId, int.Parse(hallId.ToString())) { };
                    form.Show();

                    form.Opacity = 0;
                    while (form.Opacity < 1.0) {
                        await Task.Delay(15);
                        form.Opacity += 0.05;
                    }
                    form.Opacity = 1;
                }
                else if (action == "Delete") {
                    MessageBox.Show("Implement delete", "To-Do");
                }
            }
            }

        private async void AddHallBtn_Click(object sender, EventArgs e) {
            AddEditHallForm form = new AddEditHallForm(_menuForm, this, _cinemaName, _cinemaLoactin, _cinemaId) { };
            form.Show();

            form.Opacity = 0;
            while (form.Opacity < 1.0) {
                await Task.Delay(15);
                form.Opacity += 0.05;
            }
            form.Opacity = 1;
        }

   
    }
}
