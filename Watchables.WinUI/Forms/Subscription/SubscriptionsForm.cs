using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Subscription
{
    public partial class SubscriptionsForm : Form
    {

        private readonly APIService _apiService = new APIService("subscriptions");
        private readonly Helper _helper = new Helper();

        public SubscriptionsForm() {
            InitializeComponent();
            dgvSubscriptions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvSubscriptions.EnableHeadersVisualStyles = false;
        }

        private async void SubscriptionsForm_Load(object sender, EventArgs e) {
            var result = await _apiService.Get<List<Model.Subscription>>(null);
            result.Sort((a, b) => b.Price.CompareTo(a.Price));
            dgvSubscriptions.AutoGenerateColumns = false;
            dgvSubscriptions.AutoGenerateColumns = false;
            dgvSubscriptions.DataSource = result;
        }

        private void dgvSubscriptions_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var subscriptionId = dgvSubscriptions.Rows[e.RowIndex].Cells["SubscriptionId"].Value;
                var action = dgvSubscriptions.Columns[e.ColumnIndex].Name;
                MenuForm menuForm = (MenuForm)this.MdiParent;

                if (action == "Edit") {
                    AddEditSubsciptionForm form = new AddEditSubsciptionForm(menuForm, int.Parse(subscriptionId.ToString()));
                    _helper.ShowForm(form, 15);
                }
                else if (action == "Delete") {
                    MessageBox.Show("Implement delete cinema", "To-do");
                }
            }
        }

        private void AddSubscriptionButton_Click(object sender, EventArgs e) {
            MenuForm menuForm = (MenuForm)this.MdiParent;
            AddEditSubsciptionForm form = new AddEditSubsciptionForm(menuForm);
            _helper.ShowForm(form, 15);
        }

        private async void searchBtn_Click(object sender, EventArgs e) {
            var messageBox = new CustomMessageBox();

            if (!_helper.ValidateDecimalString(PriceScr.Text, 1, 200)) {
                messageBox.Show("Enter a valid price (1-200)!", "error");
                return;
            }

            Model.Requests.SubscriptionSearchRequest search = new Model.Requests.SubscriptionSearchRequest() {
                Price = decimal.Parse(PriceScr.Text),
                NumberOfMovies = (int)MoviesScr.Value,
                NumberOfShows = (int)ShowsScr.Value,
                NumberOfTickets = (int)TicketsScr.Value
            };

            var list = await _apiService.Get<List<Model.Subscription>>(search);
            list.Sort((a, b) => b.Price.CompareTo(a.Price));
            dgvSubscriptions.AutoGenerateColumns = false;
            dgvSubscriptions.DataSource = list;

        }

        private async void clearSearch_Click(object sender, EventArgs e) {
            var result = await _apiService.Get<List<Model.Subscription>>(null);
            result.Sort((a, b) => b.Price.CompareTo(a.Price));
            dgvSubscriptions.AutoGenerateColumns = false;
            dgvSubscriptions.AutoGenerateColumns = false;
            dgvSubscriptions.DataSource = result;

            PriceScr.Text = "";
            MoviesScr.Value = 0;
            ShowsScr.Value = 0;
            TicketsScr.Value = 0;

        }
    }
}
