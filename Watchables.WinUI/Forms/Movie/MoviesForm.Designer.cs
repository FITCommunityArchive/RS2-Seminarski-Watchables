namespace Watchables.WinUI.Forms.Movie
{
    partial class MoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Standalone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.clearSearch = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RatingSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Movie = new System.Windows.Forms.TextBox();
            this.YearSearch = new System.Windows.Forms.NumericUpDown();
            this.StandaloneCB = new System.Windows.Forms.CheckBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AllowUserToResizeColumns = false;
            this.dgvMovies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dgvMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovies.ColumnHeadersHeight = 45;
            this.dgvMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieId,
            this.Title,
            this.Genre,
            this.Year,
            this.Rating,
            this.Duration,
            this.Price,
            this.Standalone,
            this.Edit,
            this.Delete});
            this.dgvMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovies.GridColor = System.Drawing.Color.White;
            this.dgvMovies.Location = new System.Drawing.Point(45, 149);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMovies.RowHeadersVisible = false;
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMovies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMovies.RowTemplate.Height = 45;
            this.dgvMovies.Size = new System.Drawing.Size(1669, 710);
            this.dgvMovies.TabIndex = 15;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieId";
            this.MovieId.FillWeight = 118.8829F;
            this.MovieId.HeaderText = "MovieId";
            this.MovieId.MinimumWidth = 6;
            this.MovieId.Name = "MovieId";
            this.MovieId.Visible = false;
            // 
            // Title
            // 
            this.Title.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 222.8445F;
            this.Title.HeaderText = "Title";
            this.Title.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Title.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.FillWeight = 131.9828F;
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.FillWeight = 90.04834F;
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.FillWeight = 84.05313F;
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.FillWeight = 83.17787F;
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 70.79221F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Standalone
            // 
            this.Standalone.DataPropertyName = "Standalone";
            this.Standalone.FillWeight = 112.2131F;
            this.Standalone.HeaderText = "Standalone";
            this.Standalone.MinimumWidth = 6;
            this.Standalone.Name = "Standalone";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 41.03027F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 44.97501F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "List of all movies";
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
            this.AddMovieBtn.Location = new System.Drawing.Point(0, 877);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(1775, 43);
            this.AddMovieBtn.TabIndex = 16;
            this.AddMovieBtn.Text = "Add movie";
            this.AddMovieBtn.UseVisualStyleBackColor = false;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            // 
            // clearSearch
            // 
            this.clearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearch.FlatAppearance.BorderSize = 0;
            this.clearSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearch.Image = ((System.Drawing.Image)(resources.GetObject("clearSearch.Image")));
            this.clearSearch.Location = new System.Drawing.Point(1629, 102);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(31, 32);
            this.clearSearch.TabIndex = 18;
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
            this.searchBtn.Location = new System.Drawing.Point(1666, 100);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(48, 32);
            this.searchBtn.TabIndex = 17;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(953, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Year from:";
            // 
            // RatingSearch
            // 
            this.RatingSearch.BackColor = System.Drawing.Color.Snow;
            this.RatingSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatingSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingSearch.Location = new System.Drawing.Point(1116, 106);
            this.RatingSearch.Name = "RatingSearch";
            this.RatingSearch.Size = new System.Drawing.Size(141, 28);
            this.RatingSearch.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1112, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rating from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(620, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Search for movies:";
            // 
            // Movie
            // 
            this.Movie.BackColor = System.Drawing.Color.Snow;
            this.Movie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Movie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie.Location = new System.Drawing.Point(624, 104);
            this.Movie.Name = "Movie";
            this.Movie.Size = new System.Drawing.Size(315, 28);
            this.Movie.TabIndex = 19;
            // 
            // YearSearch
            // 
            this.YearSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSearch.Location = new System.Drawing.Point(957, 105);
            this.YearSearch.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.YearSearch.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.YearSearch.Name = "YearSearch";
            this.YearSearch.Size = new System.Drawing.Size(138, 28);
            this.YearSearch.TabIndex = 25;
            this.YearSearch.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // StandaloneCB
            // 
            this.StandaloneCB.AutoSize = true;
            this.StandaloneCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandaloneCB.Location = new System.Drawing.Point(1461, 106);
            this.StandaloneCB.Name = "StandaloneCB";
            this.StandaloneCB.Size = new System.Drawing.Size(128, 25);
            this.StandaloneCB.TabIndex = 26;
            this.StandaloneCB.Text = "Standalone";
            this.StandaloneCB.UseVisualStyleBackColor = true;
            // 
            // GenreBox
            // 
            this.GenreBox.BackColor = System.Drawing.Color.Snow;
            this.GenreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenreBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreBox.Location = new System.Drawing.Point(1276, 105);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(164, 28);
            this.GenreBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1272, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Genre:";
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 920);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StandaloneCB);
            this.Controls.Add(this.YearSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RatingSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Movie);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.AddMovieBtn);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMovieBtn;
        private System.Windows.Forms.Button clearSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RatingSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Movie;
        private System.Windows.Forms.NumericUpDown YearSearch;
        private System.Windows.Forms.CheckBox StandaloneCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewLinkColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Standalone;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.Label label5;
    }
}