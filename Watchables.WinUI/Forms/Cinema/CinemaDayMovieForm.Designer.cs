namespace Watchables.WinUI.Forms.Cinema
{
    partial class CinemaDayMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemaDayMovieForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.dgvScheduledMovies = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CinemaDayMovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appointments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apps = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // addMovieBtn
            // 
            this.addMovieBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.addMovieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMovieBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addMovieBtn.FlatAppearance.BorderSize = 0;
            this.addMovieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovieBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieBtn.ForeColor = System.Drawing.Color.White;
            this.addMovieBtn.Location = new System.Drawing.Point(0, 460);
            this.addMovieBtn.Name = "addMovieBtn";
            this.addMovieBtn.Size = new System.Drawing.Size(940, 39);
            this.addMovieBtn.TabIndex = 9;
            this.addMovieBtn.Text = "Add movie";
            this.addMovieBtn.UseVisualStyleBackColor = false;
            this.addMovieBtn.Click += new System.EventHandler(this.addMovieBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(814, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 36);
            this.panel1.TabIndex = 10;
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(72, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(42, 36);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(18, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(99, 34);
            this.Title.TabIndex = 22;
            this.Title.Text = "label1";
            // 
            // dgvScheduledMovies
            // 
            this.dgvScheduledMovies.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvScheduledMovies.AllowUserToAddRows = false;
            this.dgvScheduledMovies.AllowUserToDeleteRows = false;
            this.dgvScheduledMovies.AllowUserToResizeColumns = false;
            this.dgvScheduledMovies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvScheduledMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScheduledMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScheduledMovies.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvScheduledMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScheduledMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvScheduledMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScheduledMovies.ColumnHeadersHeight = 45;
            this.dgvScheduledMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CinemaDayMovieId,
            this.MovieId,
            this.Movie,
            this.Appointments,
            this.Apps,
            this.Delete});
            this.dgvScheduledMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScheduledMovies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScheduledMovies.DoubleBuffered = true;
            this.dgvScheduledMovies.EnableHeadersVisualStyles = false;
            this.dgvScheduledMovies.GridColor = System.Drawing.Color.White;
            this.dgvScheduledMovies.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.dgvScheduledMovies.HeaderForeColor = System.Drawing.Color.White;
            this.dgvScheduledMovies.Location = new System.Drawing.Point(24, 78);
            this.dgvScheduledMovies.Name = "dgvScheduledMovies";
            this.dgvScheduledMovies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvScheduledMovies.RowHeadersVisible = false;
            this.dgvScheduledMovies.RowHeadersWidth = 51;
            this.dgvScheduledMovies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvScheduledMovies.RowTemplate.Height = 45;
            this.dgvScheduledMovies.Size = new System.Drawing.Size(886, 368);
            this.dgvScheduledMovies.TabIndex = 23;
            this.dgvScheduledMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScheduledMovies_CellContentClick);
            // 
            // CinemaDayMovieId
            // 
            this.CinemaDayMovieId.DataPropertyName = "CinemaDayMovieId";
            this.CinemaDayMovieId.HeaderText = "CinemaDayMovieId";
            this.CinemaDayMovieId.MinimumWidth = 6;
            this.CinemaDayMovieId.Name = "CinemaDayMovieId";
            this.CinemaDayMovieId.Visible = false;
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.MinimumWidth = 6;
            this.MovieId.Name = "MovieId";
            this.MovieId.Visible = false;
            // 
            // Movie
            // 
            this.Movie.DataPropertyName = "Movie";
            this.Movie.FillWeight = 185.5894F;
            this.Movie.HeaderText = "Movie";
            this.Movie.MinimumWidth = 6;
            this.Movie.Name = "Movie";
            // 
            // Appointments
            // 
            this.Appointments.DataPropertyName = "NumberOfAppointments";
            this.Appointments.FillWeight = 160.0739F;
            this.Appointments.HeaderText = "Appointments";
            this.Appointments.MinimumWidth = 6;
            this.Appointments.Name = "Appointments";
            // 
            // Apps
            // 
            this.Apps.FillWeight = 27.24866F;
            this.Apps.HeaderText = "";
            this.Apps.Image = ((System.Drawing.Image)(resources.GetObject("Apps.Image")));
            this.Apps.MinimumWidth = 6;
            this.Apps.Name = "Apps";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 27.08803F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // CinemaDayMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(940, 499);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.dgvScheduledMovies);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addMovieBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CinemaDayMovieForm";
            this.Text = "CinemaDayMovieForm";
            this.Load += new System.EventHandler(this.CinemaDayMovieForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMovieBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label Title;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvScheduledMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinemaDayMovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointments;
        private System.Windows.Forms.DataGridViewImageColumn Apps;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}