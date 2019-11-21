using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI.Forms.Admin
{
    public partial class AddEditAdminForm : Form
    {

        private readonly APIService _apiService = new APIService("admins");
        private readonly Helper _helper = new Helper();
        private readonly int? _adminId;
        private readonly MenuForm _menuForm;
        private string _currentUsername;

        public AddEditAdminForm(MenuForm menuForm, string currentUsername, int? adminId=null) {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - 20 - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - saveBtn.Height - 20);
            _adminId = adminId;
            _menuForm = menuForm;
            _currentUsername = currentUsername;
        }

        private async void AddEditAdminForm_Load(object sender, EventArgs e) {
            if (_adminId.HasValue) {
                Title.Text = "Edit admin";
                var admin = await _apiService.GetById<Model.Admin>(_adminId);
                Username.Text = admin.Account.Username;
            }
            else {
                Title.Text = "Add an admin";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            _helper.CloseForm(this, 15);
        }

        private async void reloadBtn_Click(object sender, EventArgs e) {
            if (_adminId.HasValue) {
                var admin = await _apiService.GetById<Model.Admin>(_adminId);
                Username.Text = admin.Account.Username;
            }
            else {
                Username.Text = "";                
            }
            PassTxt.Text = "";
            Confirm.Text = "";
        }

        private void PassBtn_Click(object sender, EventArgs e) {
            if (PassTxt.PasswordChar == '*') PassTxt.PasswordChar = '\0';
            else PassTxt.PasswordChar = '*';
        }

        private void CnfBtn_Click(object sender, EventArgs e) {
            if (Confirm.PasswordChar == '*') Confirm.PasswordChar = '\0';
            else Confirm.PasswordChar = '*';
        }

        private async void saveBtn_Click(object sender, EventArgs e) {

            var messageBox = new CustomMessageBox();

            if (string.IsNullOrWhiteSpace(Username.Text) || Username.TextLength < 4 || Username.TextLength > 50) {
                messageBox.Show("Username length: 4-50", "error");
                return;
            }

            if (string.IsNullOrWhiteSpace(PassTxt.Text) || PassTxt.TextLength<4 || PassTxt.TextLength > 50) {
                messageBox.Show("Password length: 4-50", "error");
                return;
            }

            if (!string.IsNullOrWhiteSpace(PassTxt.Text) && PassTxt.Text.Contains(" ")) {
                messageBox.Show("Password can't contain spaces", "error");
                return;
            }


            if (string.IsNullOrWhiteSpace(Confirm.Text) || Confirm.TextLength <4  || Confirm.TextLength > 50) {
                messageBox.Show("Confirmation length: 4-50", "error");
                return;
            }
          
            if (!string.IsNullOrWhiteSpace(Confirm.Text) && Confirm.Text.Contains(" ")) {
                messageBox.Show("Confirmation can't contain spaces", "error");
                return;
            }

            if (PassTxt.Text != Confirm.Text) {
                messageBox.Show("Passwords don't match!", "error");
                return;
            }
            
            var allAdmins = await _apiService.Get<List<Model.Admin>>(null);
          
            if (_adminId.HasValue) {
                var admin = await _apiService.GetById<Model.Admin>(_adminId);
                allAdmins.RemoveAll(a => a.Account.Username == admin.Account.Username);
            }

            foreach (var admin in allAdmins) {
                if (Username.Text == admin.Account.Username) {
                    messageBox.Show("Username already taken!", "error");
                    return;
                }
            }
            var thisAdmin= new Model.Admin();
            if (_adminId.HasValue) {
                thisAdmin = await _apiService.GetById<Model.Admin>(_adminId);
            }

            Model.Requests.InsertAdminRequest request = new Model.Requests.InsertAdminRequest() {
                Username = Username.Text,
                Password = PassTxt.Text,
                ConfirmPassword = Confirm.Text
            };

            if (_adminId.HasValue) {
                await _apiService.Update<Model.Admin>(_adminId, request);
                messageBox.Show("Admin updated successfully!", "success");
            }
            else {
                await _apiService.Insert<Model.Admin>(request);
                messageBox.Show("Admin added successfully!", "success");
            }

            if (_adminId.HasValue) {               
                if (thisAdmin.Account.Username == _currentUsername) {
                    _currentUsername = Username.Text;
                    APIService.Username = Username.Text;
                    APIService.Password = PassTxt.Text;
                    _menuForm.ChangeTopUsername(_currentUsername);
                }
            }

            foreach (var child in _menuForm.MdiChildren) {
                child.Close();
            }

            AdminsForm form = new AdminsForm(_currentUsername) {
                MdiParent = _menuForm,
                Dock = DockStyle.Fill
            };
            form.Show();
            _helper.CloseForm(this, 15);

        }
    }
}
