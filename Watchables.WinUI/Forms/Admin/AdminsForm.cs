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
    public partial class AdminsForm : Form
    {

        private readonly APIService _apiService = new APIService("admins");
        private readonly Helper _helper = new Helper();
        private readonly string _currentUsername;

        public AdminsForm(string currentUsername) {
            InitializeComponent();
            dgvAdmins.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(178, 8, 55);
            dgvAdmins.EnableHeadersVisualStyles = false;
            dgvAdmins.AutoGenerateColumns = false;
            _currentUsername = currentUsername;
        }

        private async void AdminsForm_Load(object sender, EventArgs e) {
            var admins = await _apiService.Get<List<Model.Admin>>(null);
            var list = new List<Model.dgvLists.AdminItem>();
            foreach(var admin in admins) {
                var Object = new Model.dgvLists.AdminItem() {
                    AdminId = admin.AdminId,
                    Username = admin.Account.Username
                };
                list.Add(Object);
            }
            dgvAdmins.DataSource = list;
        }

        private void AddAdminBtn_Click(object sender, EventArgs e) {
            AddEditAdminForm form = new AddEditAdminForm((MenuForm)this.MdiParent, _currentUsername);
            _helper.ShowForm(form, 15);
        }

        private async void dgvAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var adminId = dgvAdmins.Rows[e.RowIndex].Cells["AdminId"].Value;
                var action = dgvAdmins.Columns[e.ColumnIndex].Name;
                MenuForm menuForm = (MenuForm)this.MdiParent;

                if (action == "Edit") {
                    AddEditAdminForm form = new AddEditAdminForm(menuForm, _currentUsername, int.Parse(adminId.ToString())) { };
                    _helper.ShowForm(form, 15);
                }
                else if (action == "Delete") {
                    var confirm = MessageBox.Show("Are you sure to delete this admin? You will be logged out if you delete yourself.", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes) {
                        var mbox = new CustomMessageBox();
                        var admin = await _apiService.GetById<Model.Admin>(adminId);
                        var message = await _apiService.Delete<string>(adminId);
                        if (admin.Account.Username == _currentUsername) {
                            LoginForm form = new LoginForm();
                            form.Show();
                            var menu = (MenuForm)this.MdiParent;
                            menu.Close();
                        }
                        else {
                            AdminsForm form = new AdminsForm(_currentUsername) {
                                MdiParent = (MenuForm)this.MdiParent,
                                Dock = DockStyle.Fill
                            };
                            form.Show();
                            this.Close();
                        }
                        mbox.Show(message, "success");
                    }
                    
                }
            }
            }
    }
}
