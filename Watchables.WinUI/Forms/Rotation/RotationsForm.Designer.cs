namespace Watchables.WinUI.Forms.Rotation
{
    partial class RotationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotationsForm));
            this.dgvRotations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.BirthdayCB = new System.Windows.Forms.CheckBox();
            this.clearSearch = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Show = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movieid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RotationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRotations
            // 
            this.dgvRotations.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvRotations.AllowUserToAddRows = false;
            this.dgvRotations.AllowUserToDeleteRows = false;
            this.dgvRotations.AllowUserToResizeColumns = false;
            this.dgvRotations.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRotations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRotations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRotations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dgvRotations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRotations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvRotations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRotations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRotations.ColumnHeadersHeight = 45;
            this.dgvRotations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RotationId,
            this.From,
            this.To,
            this.Movieid,
            this.Movie,
            this.ShowId,
            this.Show,
            this.Birthday,
            this.Available,
            this.Edit,
            this.Delete});
            this.dgvRotations.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRotations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRotations.GridColor = System.Drawing.Color.White;
            this.dgvRotations.Location = new System.Drawing.Point(57, 145);
            this.dgvRotations.Name = "dgvRotations";
            this.dgvRotations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRotations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRotations.RowHeadersVisible = false;
            this.dgvRotations.RowHeadersWidth = 51;
            this.dgvRotations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRotations.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRotations.RowTemplate.Height = 45;
            this.dgvRotations.Size = new System.Drawing.Size(1669, 618);
            this.dgvRotations.TabIndex = 16;
            this.dgvRotations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRotations_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "List of all rotations";
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddMovieBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMovieBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddMovieBtn.FlatAppearance.BorderSize = 0;
            this.AddMovieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovieBtn.ForeColor = System.Drawing.Color.White;
            this.AddMovieBtn.Location = new System.Drawing.Point(0, 792);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(1775, 43);
            this.AddMovieBtn.TabIndex = 18;
            this.AddMovieBtn.Text = "Add rotation";
            this.AddMovieBtn.UseVisualStyleBackColor = false;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            // 
            // BirthdayCB
            // 
            this.BirthdayCB.AutoSize = true;
            this.BirthdayCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayCB.Location = new System.Drawing.Point(1512, 101);
            this.BirthdayCB.Name = "BirthdayCB";
            this.BirthdayCB.Size = new System.Drawing.Size(99, 25);
            this.BirthdayCB.TabIndex = 29;
            this.BirthdayCB.Text = "Birthday";
            this.BirthdayCB.UseVisualStyleBackColor = true;
            // 
            // clearSearch
            // 
            this.clearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearch.FlatAppearance.BorderSize = 0;
            this.clearSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearch.Image = ((System.Drawing.Image)(resources.GetObject("clearSearch.Image")));
            this.clearSearch.Location = new System.Drawing.Point(1641, 96);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(31, 32);
            this.clearSearch.TabIndex = 28;
            this.clearSearch.UseVisualStyleBackColor = true;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(1678, 94);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(48, 32);
            this.searchBtn.TabIndex = 27;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Delete
            // 
            this.Delete.FillWeight = 34.08641F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 31.0967F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            // 
            // Available
            // 
            this.Available.DataPropertyName = "Available";
            this.Available.FillWeight = 75.78967F;
            this.Available.HeaderText = "Available";
            this.Available.MinimumWidth = 6;
            this.Available.Name = "Available";
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "forBirthday";
            this.Birthday.FillWeight = 75.78967F;
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.MinimumWidth = 6;
            this.Birthday.Name = "Birthday";
            // 
            // Show
            // 
            this.Show.DataPropertyName = "Show";
            this.Show.FillWeight = 153.2524F;
            this.Show.HeaderText = "Show";
            this.Show.MinimumWidth = 6;
            this.Show.Name = "Show";
            // 
            // ShowId
            // 
            this.ShowId.DataPropertyName = "ShowId";
            this.ShowId.HeaderText = "ShowId";
            this.ShowId.MinimumWidth = 6;
            this.ShowId.Name = "ShowId";
            this.ShowId.Visible = false;
            // 
            // Movie
            // 
            this.Movie.DataPropertyName = "Movie";
            this.Movie.FillWeight = 164.4111F;
            this.Movie.HeaderText = "Movie";
            this.Movie.MinimumWidth = 6;
            this.Movie.Name = "Movie";
            // 
            // Movieid
            // 
            this.Movieid.DataPropertyName = "MovieId";
            this.Movieid.HeaderText = "MovieId";
            this.Movieid.MinimumWidth = 6;
            this.Movieid.Name = "Movieid";
            this.Movieid.Visible = false;
            // 
            // To
            // 
            this.To.DataPropertyName = "To";
            this.To.FillWeight = 75.78967F;
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 6;
            this.To.Name = "To";
            // 
            // From
            // 
            this.From.DataPropertyName = "From";
            this.From.FillWeight = 75.78967F;
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 6;
            this.From.Name = "From";
            // 
            // RotationId
            // 
            this.RotationId.DataPropertyName = "RotationId";
            this.RotationId.HeaderText = "RotationId";
            this.RotationId.MinimumWidth = 6;
            this.RotationId.Name = "RotationId";
            this.RotationId.Visible = false;
            // 
            // RotationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 835);
            this.Controls.Add(this.BirthdayCB);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.AddMovieBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRotations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RotationsForm";
            this.Text = "RotationsForm";
            this.Load += new System.EventHandler(this.RotationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRotations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMovieBtn;
        private System.Windows.Forms.CheckBox BirthdayCB;
        private System.Windows.Forms.Button clearSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RotationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movieid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Show;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}