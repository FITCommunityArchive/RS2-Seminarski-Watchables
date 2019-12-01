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
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.DataSource = result;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }


        private void AddProductBtn_Click(object sender, EventArgs e) {
            AddEditProductForm form = new AddEditProductForm(_menuForm, this, _cinemaName, _cinemaId) { };
            _helper.ShowForm(form, 15);
        }

        private async void dgvProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var productId = dgvProducts.Rows[e.RowIndex].Cells["ProductId"].Value;
                var action = dgvProducts.Columns[e.ColumnIndex].Name;
                var productApi = new APIService("products");
                var product = await productApi.GetById<Model.Product>(productId);
                CustomMessageBox messageBox = new CustomMessageBox();
                if (action == "Edit") {
                    AddEditProductForm form = new AddEditProductForm(_menuForm, this, _cinemaName, _cinemaId, int.Parse(productId.ToString())) { };
                    _helper.ShowForm(form, 15);
                }
                else if (action == "Delete") {
                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete '{product.Name}' for {product.Price} in '{_cinemaName}'?", "Delete product", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        Helper helper = new Helper();
                        await productApi.Delete<Model.Product>(productId);
                        helper.CloseForm(this, 15);
                        CinemasProductsForm form = new CinemasProductsForm(_menuForm, _cinemaId, _cinemaName);
                        helper.ShowForm(form, 15);
                        messageBox.Show("Product deleted successfully", "success");
                    }
                }
            }
        }
    }
}
