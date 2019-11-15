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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addMovieBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.dgvScheduledMovies = new System.Windows.Forms.DataGridView();
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
            this.panel1.Location = new System.Drawing.Point(814, 9);
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
            this.Title.Location = new System.Drawing.Point(12, 9);
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvScheduledMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvScheduledMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScheduledMovies.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvScheduledMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScheduledMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvScheduledMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvScheduledMovies.ColumnHeadersHeight = 40;
            this.dgvScheduledMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CinemaDayMovieId,
            this.MovieId,
            this.Movie,
            this.Appointments,
            this.Apps,
            this.Delete});
            this.dgvScheduledMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScheduledMovies.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvScheduledMovies.GridColor = System.Drawing.Color.White;
            this.dgvScheduledMovies.Location = new System.Drawing.Point(12, 63);
            this.dgvScheduledMovies.Name = "dgvScheduledMovies";
            this.dgvScheduledMovies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvScheduledMovies.RowHeadersVisible = false;
            this.dgvScheduledMovies.RowHeadersWidth = 51;
            this.dgvScheduledMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScheduledMovies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvScheduledMovies.RowTemplate.Height = 45;
            this.dgvScheduledMovies.Size = new System.Drawing.Size(916, 391);
            this.dgvScheduledMovies.TabIndex = 23;
            this.dgvScheduledMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScheduledMovies_CellContentClick_1);
            // 
            // CinemaDayMovieId
            // 
            this.CinemaDayMovieId.DataPropertyName = "CinemaDayMovieId";
            this.CinemaDayMovieId.FillWeight = 128.8824F;
            this.CinemaDayMovieId.HeaderText = "CinemaDayMovieId";
            this.CinemaDayMovieId.MinimumWidth = 6;
            this.CinemaDayMovieId.Name = "CinemaDayMovieId";
            this.CinemaDayMovieId.Visible = false;
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.FillWeight = 128.8824F;
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.MinimumWidth = 6;
            this.MovieId.Name = "MovieId";
            this.MovieId.Visible = false;
            // 
            // Movie
            // 
            this.Movie.DataPropertyName = "Movie";
            this.Movie.FillWeight = 168.1286F;
            this.Movie.HeaderText = "Movie";
            this.Movie.MinimumWidth = 6;
            this.Movie.Name = "Movie";
            // 
            // Appointments
            // 
            this.Appointments.DataPropertyName = "NumberOfAppointments";
            this.Appointments.FillWeight = 105.1745F;
            this.Appointments.HeaderText = "Appointments";
            this.Appointments.MinimumWidth = 6;
            this.Appointments.Name = "Appointments";
            // 
            // Apps
            // 
            this.Apps.FillWeight = 32.07184F;
            this.Apps.HeaderText = "";
            this.Apps.Image = ((System.Drawing.Image)(resources.GetObject("Apps.Image")));
            this.Apps.MinimumWidth = 6;
            this.Apps.Name = "Apps";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 36.86022F;
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
            this.Controls.Add(this.dgvScheduledMovies);
            this.Controls.Add(this.Title);
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
        private System.Windows.Forms.DataGridView dgvScheduledMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinemaDayMovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appointments;
        private System.Windows.Forms.DataGridViewImageColumn Apps;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}