using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchables.WinUI.Forms;
using Watchables.WinUI.Forms.Cinema;

namespace Watchables.WinUI
{
    public partial class MenuForm : Form
    {
        private int childFormNumber = 0;

        public MenuForm() {
            InitializeComponent();          
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            ShowDashboardBtn.PerformClick();
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void ShowDashboardBtn_Click(object sender, EventArgs e) {
            foreach (Form frm in this.MdiChildren) {
                frm.Close();
            }
            DashboardForm form = new DashboardForm {
                MdiParent = this,
                Dock=DockStyle.Fill                   
        };         
            form.Show();
            Slider.Top = ShowDashboardBtn.Top;
            Slider.Height = ShowDashboardBtn.Height;
        }

        private void ShowCinemasBtn_Click(object sender, EventArgs e) {
            foreach (Form frm in this.MdiChildren) {
                frm.Close();
            }
            CinemasForm form = new CinemasForm {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            form.Show();
            Slider.Height = ShowCinemasBtn.Height;
            Slider.Top = ShowCinemasBtn.Top;
        }

        private void ShowMoviesBtn_Click(object sender, EventArgs e) {         
            Slider.Top = ShowMoviesBtn.Top;
            Slider.Height = ShowMoviesBtn.Height;
        }

        private void ShowShowsBtn_Click(object sender, EventArgs e) {
            Slider.Top = ShowShowsBtn.Top;
            Slider.Height = ShowShowsBtn.Height;
        }

        private void ShowSubscriptionsBtn_Click(object sender, EventArgs e) {
            Slider.Top = ShowSubscriptionsBtn.Top;
            Slider.Height = ShowSubscriptionsBtn.Height;
        }

        private void ShowRotationsBtn_Click(object sender, EventArgs e) {
            Slider.Top = ShowRotationsBtn.Top;
            Slider.Height = ShowRotationsBtn.Height;
        }

        private void ShowUsersBtn_Click(object sender, EventArgs e) {
            Slider.Top = ShowUsersBtn.Top;
            Slider.Height = ShowUsersBtn.Height;
        }

        private void ExitBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
