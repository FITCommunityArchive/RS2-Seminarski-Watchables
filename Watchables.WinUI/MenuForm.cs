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
using Watchables.WinUI.Forms.Admin;
using Watchables.WinUI.Forms.Cinema;
using Watchables.WinUI.Forms.Movie;
using Watchables.WinUI.Forms.Rotation;
using Watchables.WinUI.Forms.Show;
using Watchables.WinUI.Forms.Subscription;
using Watchables.WinUI.Forms.User;

namespace Watchables.WinUI
{
    public partial class MenuForm : Form
    {
        private int childFormNumber = 0;

        private string _username;

        private bool _locked;

        public MenuForm(string username) {
            InitializeComponent();
            _username = username;

        }
        
        public void ChangeTopUsername(string newUsername) {
            _username = newUsername;
            User.Text = _username;
        }

        protected override async void OnLoad(EventArgs e) {
            base.OnLoad(e);
            ShowDashboardBtn.PerformClick();
            User.Text = _username;
            APIService apiService = new APIService("users");
            var users = await apiService.Get<List<Model.User>>(null);
            if (users.Count==0) {
                LockCB.Checked = false;
                LockCB.Text = "No users";
            }
            else {
                _locked = users.First().Locked;
                if (users.First().Locked) {
                    LockCB.Text = "    Unlock";
                    LockCB.Checked = true;
                }
                else {
                    LockCB.Text = "    Lock";
                    LockCB.Checked = false;
                }
            }


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


        //MAIN MENU

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
            foreach (Form frm in this.MdiChildren) {
                frm.Close();
            }
            MoviesForm form = new MoviesForm {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            form.Show();
            Slider.Top = ShowMoviesBtn.Top;
            Slider.Height = ShowMoviesBtn.Height;
        }

        private void ShowShowsBtn_Click(object sender, EventArgs e) {
            foreach (Form frm in this.MdiChildren) {
                frm.Close();
            }
            ShowsForm form = new ShowsForm {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            form.Show();
            Slider.Top = ShowShowsBtn.Top;
            Slider.Height = ShowShowsBtn.Height;
        }

        private void ShowSubscriptionsBtn_Click(object sender, EventArgs e) {
            foreach (Form frm in this.MdiChildren) {
                frm.Close();
            }
            SubscriptionsForm form = new SubscriptionsForm {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            form.Show();      
            Slider.Top = ShowSubscriptionsBtn.Top;
            Slider.Height = ShowSubscriptionsBtn.Height;
        }

        private void ShowRotationsBtn_Click(object sender, EventArgs e) {
            foreach (Form frm in this.MdiChildren) {
                frm.Close();
            }
            RotationsForm form = new RotationsForm {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            form.Show();
            Slider.Top = ShowRotationsBtn.Top;
            Slider.Height = ShowRotationsBtn.Height;
        }

        private void ShowUsersBtn_Click(object sender, EventArgs e) {
            foreach (Form frm in this.MdiChildren) {
                frm.Close();
            }
            UsersForm form = new UsersForm {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            form.Show();
            Slider.Top = ShowUsersBtn.Top;
            Slider.Height = ShowUsersBtn.Height;
        }

        private void ExitBtn_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void Logout_Click(object sender, EventArgs e) {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void AdminBtn_Click(object sender, EventArgs e) {
            foreach (Form frm in this.MdiChildren) {
                frm.Close();
            }
            AdminsForm form = new AdminsForm(_username) {
                MdiParent = this,
                Dock = DockStyle.Fill
            };
            form.Show();
            Slider.Top = AdminBtn.Top;
            Slider.Height = AdminBtn.Height;
        }

        private async void LockCB_Click(object sender, EventArgs e) {
            if (LockCB.Text != "No users") {
                APIService service = new APIService("users");
                if (_locked) {
                    LockCB.Checked = false;
                    LockCB.Text = "    Lock";
                    await service.Lock<string>(false);
                }
                else {
                    LockCB.Checked = true;
                    LockCB.Text = "    Unlock";
                    await service.Lock<string>(true);
                }
                _locked = !_locked;
            }
            else LockCB.Checked = false;
        }

        private void ExitBtn_Click_1(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void MinimizeBtn_Click_1(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

    
    }
}
