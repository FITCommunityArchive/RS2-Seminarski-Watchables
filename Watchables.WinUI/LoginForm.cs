using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI
{
    public partial class LoginForm : Form
    {

        public readonly APIService _apiService = new APIService("admins");
        public readonly Helper _helper = new Helper();

        public LoginForm() {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void Login_Click(object sender, EventArgs e) {
            var username = Username.Text;
            var password = Password.Text;

            APIService.Username = username;
            APIService.Password = password;

            try {
                await _apiService.Get<List<Model.Admin>>(null);
                this.Hide();
                var form = new MenuForm(username);
                form.Show();            

            }
            catch {/*error handled in API service*/ }
        }

        private void eye_Click(object sender, EventArgs e) {
            if (Password.PasswordChar == '*') Password.PasswordChar = '\0';
            else Password.PasswordChar = '*';
        }

    }
}
