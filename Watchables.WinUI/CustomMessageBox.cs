using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchables.WinUI
{
    public partial class CustomMessageBox : Form
    {

        private readonly string _message;

        public CustomMessageBox(string message) {
            InitializeComponent();
            _message = message;
        }

        private void MessageBox_Load(object sender, EventArgs e) {
            TextLabel.Text = _message;
        }

        private void OkBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
