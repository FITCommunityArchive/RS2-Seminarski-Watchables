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
    public partial class AddEditProductForm : Form
    {

        private readonly MenuForm _menuForm;
        private readonly int _cinemaId;
        private readonly int? _productId;
        private readonly CinemasProductsForm _cinemasProductsForm;
        private readonly string _cinemaName;
        private readonly APIService _apiService = new APIService("products");
        private readonly Helper _helper = new Helper();

        public AddEditProductForm(MenuForm menuForm, CinemasProductsForm cinemasProductsForm, string cinemaName, int cinemaId, int? productId = null) {
            InitializeComponent();
            _menuForm = menuForm;
            _cinemaId = cinemaId;
            _productId = productId;
            _cinemasProductsForm = cinemasProductsForm;
            _cinemaName = cinemaName;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
        }

        private async void AddEditProductForm_Load(object sender, EventArgs e) {
            if (_productId.HasValue) {
                
                var product = await _apiService.GetById<Model.Product>(_productId);
                ProductName.Text = product.Name;
                ProductPrice.Text = product.Price.ToString();
                Title.Text = $"Product of: {_cinemaName}";
            }
            else {
                Title.Text = $"Product to: {_cinemaName}";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }

        private async void reloadBtn_Click(object sender, EventArgs e) {
            if (_productId.HasValue) {
                APIService productsApi = new APIService("products");
                var product = await productsApi.GetById<Model.Product>(_productId);
                ProductName.Text = product.Name;
                ProductPrice.Text = product.Price.ToString();
            }
            else {
                ProductName.Text = "";
                ProductPrice.Text = "";
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e) {
            var messageBox = new CustomMessageBox();

            if (string.IsNullOrWhiteSpace(ProductName.Text) || ProductName.Text.Length < 3) {
                messageBox.Show("The name field requires 3 letters!", "error");
                return;
            }

            if (!_helper.ValidateDecimalString(ProductPrice.Text, 1, 150)) {
                messageBox.Show("Enter a valid price (1-150)!", "error");
                return;
            }

            Model.Requests.InsertProductRequest product = new Model.Requests.InsertProductRequest() {
                Name = ProductName.Text,
                Price = decimal.Parse(ProductPrice.Text),
                CinemaId = _cinemaId
            };

            if (_productId.HasValue) {
                
                await _apiService.Update<Model.Product>(_productId, product);
                messageBox.Show("Product updated succesfully", "Success");

            }
            else {
             
                await _apiService.Insert<Model.Product>(product);
                messageBox.Show("Product added succesfully", "Success");
            }

            CinemasProductsForm form = new CinemasProductsForm(_menuForm, _cinemaId, _cinemaName);
            _cinemasProductsForm.Close();
            _helper.CloseForm(this, 15);
            _helper.ShowForm(form, 15);
        }

   
    }
}
