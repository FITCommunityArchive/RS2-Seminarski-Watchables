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
    public partial class AddEditSubsciptionForm : Form
    {

        public readonly int? _subsciptionId;
        public readonly MenuForm _menuForm;
        public readonly APIService _apiService = new APIService("subscriptions");
        public readonly Helper _helper = new Helper();

        public AddEditSubsciptionForm(MenuForm menuForm, int? subsciptionId=null) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
            _subsciptionId = subsciptionId;
            _menuForm = menuForm;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }

        private async void AddEditSubsciptionForm_Load(object sender, EventArgs e) {
            if (_subsciptionId.HasValue) {
                Title.Text = "Edit subscription";
                var subs = await _apiService.GetById<Model.Subscription>(_subsciptionId);
                Avaiable.Checked = subs.Available;
                Movies.Value = subs.NumberOfMovies;
                Shows.Value = subs.NumberOfShows;
                Tickets.Value = subs.NumberOfTickets;
                Price.Text = subs.Price.ToString();
            }
            else {
                Title.Text = "Add a subscription";
            }
        }

        private async void reloadBtn_Click(object sender, EventArgs e) {
            if (_subsciptionId.HasValue) {
                var subs = await _apiService.GetById<Model.Subscription>(_subsciptionId);
                Avaiable.Checked = subs.Available;
                Movies.Value = subs.NumberOfMovies;
                Shows.Value = subs.NumberOfShows;
                Tickets.Value = subs.NumberOfTickets;
                Price.Text = subs.Price.ToString();
            }
            else {
                Avaiable.Checked = false;
                Movies.Value = 0;
                Shows.Value = 0;
                Tickets.Value = 0;
                Price.Text = "";
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e) {
            var messageBox = new CustomMessageBox();

            if(Movies.Value<1 || Movies.Value > 10) {
                messageBox.Show("Number of movies is in range 1-10", "error");
                return;
            }

            if (Shows.Value < 1 || Shows.Value > 10) {
                messageBox.Show("Number of shows is in range 1-10", "error");
                return;
            }

            if (Tickets.Value < 1 || Tickets.Value > 10) {
                messageBox.Show("Number of tickets is in range 1-10", "error");
                return;
            }

            if (!_helper.ValidateDecimalString(Price.Text, 1, 200)) {
                messageBox.Show("Enter a valid price (1-200)!", "error");
                return;
            }

            Model.Requests.InsertSubscriptionRequest request = new Model.Requests.InsertSubscriptionRequest() {
                Price=decimal.Parse(Price.Text),
                Available=Avaiable.Checked,
                NumberOfMovies=(int)Movies.Value,
                NumberOfShows=(int)Shows.Value,
                NumberOfTickets=(int)Tickets.Value
            };

            if (_subsciptionId.HasValue) {
                await _apiService.Update<Model.Subscription>(_subsciptionId, request);
                messageBox.Show("Subsciption updated succesfully", "Success");

            }
            else {
                await _apiService.Insert<Model.Subscription>(request);
                messageBox.Show("Subsciption added succesfully", "Success");
            }
            this.Close();
            foreach (Form frm in _menuForm.MdiChildren) {
                frm.Close();
            }
            SubscriptionsForm form = new SubscriptionsForm {
                MdiParent = _menuForm,
                Dock = DockStyle.Fill
            };
            form.Show();



        }
    }
}
