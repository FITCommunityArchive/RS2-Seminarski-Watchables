namespace Watchables.WinUI
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.ShowDashboardBtn = new System.Windows.Forms.Button();
            this.ShowCinemasBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Slider = new System.Windows.Forms.Panel();
            this.ShowUsersBtn = new System.Windows.Forms.Button();
            this.ShowRotationsBtn = new System.Windows.Forms.Button();
            this.ShowSubscriptionsBtn = new System.Windows.Forms.Button();
            this.ShowShowsBtn = new System.Windows.Forms.Button();
            this.ShowMoviesBtn = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LockCB = new System.Windows.Forms.CheckBox();
            this.User = new System.Windows.Forms.Label();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowDashboardBtn
            // 
            this.ShowDashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowDashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowDashboardBtn.FlatAppearance.BorderSize = 0;
            this.ShowDashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowDashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowDashboardBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDashboardBtn.ForeColor = System.Drawing.Color.White;
            this.ShowDashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowDashboardBtn.Image")));
            this.ShowDashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowDashboardBtn.Location = new System.Drawing.Point(19, 104);
            this.ShowDashboardBtn.Name = "ShowDashboardBtn";
            this.ShowDashboardBtn.Size = new System.Drawing.Size(272, 59);
            this.ShowDashboardBtn.TabIndex = 0;
            this.ShowDashboardBtn.Text = "  Dashboard";
            this.ShowDashboardBtn.UseVisualStyleBackColor = false;
            this.ShowDashboardBtn.Click += new System.EventHandler(this.ShowDashboardBtn_Click);
            // 
            // ShowCinemasBtn
            // 
            this.ShowCinemasBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowCinemasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowCinemasBtn.FlatAppearance.BorderSize = 0;
            this.ShowCinemasBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowCinemasBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowCinemasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCinemasBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCinemasBtn.ForeColor = System.Drawing.Color.White;
            this.ShowCinemasBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowCinemasBtn.Image")));
            this.ShowCinemasBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowCinemasBtn.Location = new System.Drawing.Point(19, 169);
            this.ShowCinemasBtn.Name = "ShowCinemasBtn";
            this.ShowCinemasBtn.Size = new System.Drawing.Size(272, 65);
            this.ShowCinemasBtn.TabIndex = 1;
            this.ShowCinemasBtn.Text = "Cinemas";
            this.ShowCinemasBtn.UseVisualStyleBackColor = false;
            this.ShowCinemasBtn.Click += new System.EventHandler(this.ShowCinemasBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.AdminBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Slider);
            this.panel1.Controls.Add(this.ShowUsersBtn);
            this.panel1.Controls.Add(this.ShowRotationsBtn);
            this.panel1.Controls.Add(this.ShowSubscriptionsBtn);
            this.panel1.Controls.Add(this.ShowShowsBtn);
            this.panel1.Controls.Add(this.ShowMoviesBtn);
            this.panel1.Controls.Add(this.ShowCinemasBtn);
            this.panel1.Controls.Add(this.ShowDashboardBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 780);
            this.panel1.TabIndex = 4;
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminBtn.FlatAppearance.BorderSize = 0;
            this.AdminBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.AdminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.AdminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.ForeColor = System.Drawing.Color.White;
            this.AdminBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdminBtn.Image")));
            this.AdminBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBtn.Location = new System.Drawing.Point(19, 581);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(272, 64);
            this.AdminBtn.TabIndex = 11;
            this.AdminBtn.Text = "Admins";
            this.AdminBtn.UseVisualStyleBackColor = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Logout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 694);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 86);
            this.panel3.TabIndex = 10;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(19, 10);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(272, 64);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Slider.Location = new System.Drawing.Point(3, 104);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(10, 66);
            this.Slider.TabIndex = 7;
            // 
            // ShowUsersBtn
            // 
            this.ShowUsersBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowUsersBtn.FlatAppearance.BorderSize = 0;
            this.ShowUsersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowUsersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowUsersBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUsersBtn.ForeColor = System.Drawing.Color.White;
            this.ShowUsersBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowUsersBtn.Image")));
            this.ShowUsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowUsersBtn.Location = new System.Drawing.Point(19, 520);
            this.ShowUsersBtn.Name = "ShowUsersBtn";
            this.ShowUsersBtn.Size = new System.Drawing.Size(272, 64);
            this.ShowUsersBtn.TabIndex = 6;
            this.ShowUsersBtn.Text = "Users";
            this.ShowUsersBtn.UseVisualStyleBackColor = false;
            this.ShowUsersBtn.Click += new System.EventHandler(this.ShowUsersBtn_Click);
            // 
            // ShowRotationsBtn
            // 
            this.ShowRotationsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowRotationsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowRotationsBtn.FlatAppearance.BorderSize = 0;
            this.ShowRotationsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowRotationsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowRotationsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowRotationsBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRotationsBtn.ForeColor = System.Drawing.Color.White;
            this.ShowRotationsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowRotationsBtn.Image")));
            this.ShowRotationsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowRotationsBtn.Location = new System.Drawing.Point(19, 450);
            this.ShowRotationsBtn.Name = "ShowRotationsBtn";
            this.ShowRotationsBtn.Size = new System.Drawing.Size(272, 64);
            this.ShowRotationsBtn.TabIndex = 5;
            this.ShowRotationsBtn.Text = "Rotations";
            this.ShowRotationsBtn.UseVisualStyleBackColor = false;
            this.ShowRotationsBtn.Click += new System.EventHandler(this.ShowRotationsBtn_Click);
            // 
            // ShowSubscriptionsBtn
            // 
            this.ShowSubscriptionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowSubscriptionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowSubscriptionsBtn.FlatAppearance.BorderSize = 0;
            this.ShowSubscriptionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowSubscriptionsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowSubscriptionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowSubscriptionsBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSubscriptionsBtn.ForeColor = System.Drawing.Color.White;
            this.ShowSubscriptionsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowSubscriptionsBtn.Image")));
            this.ShowSubscriptionsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowSubscriptionsBtn.Location = new System.Drawing.Point(19, 380);
            this.ShowSubscriptionsBtn.Name = "ShowSubscriptionsBtn";
            this.ShowSubscriptionsBtn.Size = new System.Drawing.Size(272, 64);
            this.ShowSubscriptionsBtn.TabIndex = 4;
            this.ShowSubscriptionsBtn.Text = "     Subscriptions";
            this.ShowSubscriptionsBtn.UseVisualStyleBackColor = false;
            this.ShowSubscriptionsBtn.Click += new System.EventHandler(this.ShowSubscriptionsBtn_Click);
            // 
            // ShowShowsBtn
            // 
            this.ShowShowsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowShowsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowShowsBtn.FlatAppearance.BorderSize = 0;
            this.ShowShowsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowShowsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowShowsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowShowsBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowShowsBtn.ForeColor = System.Drawing.Color.White;
            this.ShowShowsBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowShowsBtn.Image")));
            this.ShowShowsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowShowsBtn.Location = new System.Drawing.Point(19, 310);
            this.ShowShowsBtn.Name = "ShowShowsBtn";
            this.ShowShowsBtn.Size = new System.Drawing.Size(272, 64);
            this.ShowShowsBtn.TabIndex = 3;
            this.ShowShowsBtn.Text = "Shows";
            this.ShowShowsBtn.UseVisualStyleBackColor = false;
            this.ShowShowsBtn.Click += new System.EventHandler(this.ShowShowsBtn_Click);
            // 
            // ShowMoviesBtn
            // 
            this.ShowMoviesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowMoviesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowMoviesBtn.FlatAppearance.BorderSize = 0;
            this.ShowMoviesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowMoviesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ShowMoviesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowMoviesBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMoviesBtn.ForeColor = System.Drawing.Color.White;
            this.ShowMoviesBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowMoviesBtn.Image")));
            this.ShowMoviesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowMoviesBtn.Location = new System.Drawing.Point(19, 240);
            this.ShowMoviesBtn.Name = "ShowMoviesBtn";
            this.ShowMoviesBtn.Size = new System.Drawing.Size(272, 64);
            this.ShowMoviesBtn.TabIndex = 2;
            this.ShowMoviesBtn.Text = "Movies";
            this.ShowMoviesBtn.UseVisualStyleBackColor = false;
            this.ShowMoviesBtn.Click += new System.EventHandler(this.ShowMoviesBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.LockCB);
            this.panel2.Controls.Add(this.MinimizeBtn);
            this.panel2.Controls.Add(this.ExitBtn);
            this.panel2.Controls.Add(this.User);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 29);
            this.panel2.TabIndex = 6;
            // 
            // LockCB
            // 
            this.LockCB.Appearance = System.Windows.Forms.Appearance.Button;
            this.LockCB.AutoSize = true;
            this.LockCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LockCB.Dock = System.Windows.Forms.DockStyle.Right;
            this.LockCB.FlatAppearance.BorderSize = 0;
            this.LockCB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LockCB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LockCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LockCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockCB.ForeColor = System.Drawing.Color.White;
            this.LockCB.Image = ((System.Drawing.Image)(resources.GetObject("LockCB.Image")));
            this.LockCB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LockCB.Location = new System.Drawing.Point(789, 0);
            this.LockCB.Name = "LockCB";
            this.LockCB.Size = new System.Drawing.Size(79, 29);
            this.LockCB.TabIndex = 3;
            this.LockCB.Text = "    Lock";
            this.LockCB.UseVisualStyleBackColor = true;
            this.LockCB.Click += new System.EventHandler(this.LockCB_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(0, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(62, 30);
            this.User.TabIndex = 2;
            this.User.Text = "User";
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(868, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(29, 29);
            this.MinimizeBtn.TabIndex = 4;
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(897, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(50, 29);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Watchables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button ShowDashboardBtn;
        private System.Windows.Forms.Button ShowCinemasBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button ShowUsersBtn;
        private System.Windows.Forms.Button ShowRotationsBtn;
        private System.Windows.Forms.Button ShowSubscriptionsBtn;
        private System.Windows.Forms.Button ShowShowsBtn;
        private System.Windows.Forms.Button ShowMoviesBtn;
        private System.Windows.Forms.Panel Slider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.CheckBox LockCB;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}



