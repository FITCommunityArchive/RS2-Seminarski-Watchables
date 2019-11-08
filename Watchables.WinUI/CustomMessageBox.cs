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

        public CustomMessageBox() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width-3 - this.Width, 27);

        }

        public async void Show(string message, string action) {
            if (action == "error") {
                panel1.BackColor = Color.FromArgb(178, 8, 55);
                panel2.BackColor = Color.FromArgb(178, 8, 55);
            }
            else if (action == "success") {
                panel1.BackColor = Color.FromArgb(115, 181, 102);
                panel2.BackColor = Color.FromArgb(115, 181, 102);
            }
            TextLabel.MaximumSize = new Size(this.Width-10, 0);
            TextLabel.AutoSize = true;
            TextLabel.Text = message;     
            this.Show();
            this.Opacity = 0;
            while (this.Opacity < 1.0) {
                await Task.Delay(18);
                this.Opacity += 0.05;
            }
            this.Opacity = 1;
            await Task.Delay(2500);
            while (this.Opacity > 0.0) {
                await Task.Delay(18);
                this.Opacity -= 0.05;
            }
            this.Opacity = 0;
            this.Close();
        }

        private void CustomMessageBox_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
