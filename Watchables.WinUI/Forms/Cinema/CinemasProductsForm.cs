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
    public partial class CinemasProductsForm : Form
    {

        private readonly MenuForm _menuForm;
        private readonly int _cinemaId;
        private readonly string _cinemaName;
        private readonly APIService _apiService = new APIService("cinemas");
        private readonly Helper _helper = new Helper();
       
        public CinemasProductsForm(MenuForm menuForm, int cinemaId, string cinemaName) {
            InitializeComponent();
            _menuForm = menuForm;
            _cinemaId = cinemaId;
            _cinemaName = cinemaName;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - AddProductBtn.Height - 20);
        }

        private async void CinemasProductsForm_Load(object sender, EventArgs e) {
            Title.Text = $"Producst of {_cinemaName}";
            var result = await _apiService.GetItems<List<Model.Product>>(_cinemaId, "GetProducts");
            result.Sort((a, b) => a.Name.CompareTo(b.Name));
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = result;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var productId = dgvProducts.Rows[e.RowIndex].Cells["ProductId"].Value;
                var action = dgvProducts.Columns[e.ColumnIndex].Name;
                if (action == "Edit") {
                    AddEditProductForm form = new AddEditProductForm(_menuForm, this, _cinemaName, _cinemaId, int.Parse(productId.ToString())) { };
                    _helper.ShowForm(form, 15);
                }
                else if (action == "Delete") {
                    MessageBox.Show("Implement delete", "To-Do");
                }
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e) {
            AddEditProductForm form = new AddEditProductForm(_menuForm, this, _cinemaName, _cinemaId) { };
            _helper.ShowForm(form, 15);
        }
    }
}
