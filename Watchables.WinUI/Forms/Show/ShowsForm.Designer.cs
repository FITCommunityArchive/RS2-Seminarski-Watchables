namespace Watchables.WinUI.Forms.Show
{
    partial class ShowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowsForm));
            this.dgvShows = new System.Windows.Forms.DataGridView();
            this.ShowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seasons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ongoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AddShowBtn = new System.Windows.Forms.Button();
            this.OngoingCB = new System.Windows.Forms.CheckBox();
            this.YearSearch = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.RatingSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.TextBox();
            this.clearSearch = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShows
            // 
            this.dgvShows.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvShows.AllowUserToAddRows = false;
            this.dgvShows.AllowUserToDeleteRows = false;
            this.dgvShows.AllowUserToResizeColumns = false;
            this.dgvShows.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvShows.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShows.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dgvShows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShows.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvShows.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShows.ColumnHeadersHeight = 45;
            this.dgvShows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowId,
            this.Title,
            this.Genre,
            this.Year,
            this.Seasons,
            this.Rating,
            this.Price,
            this.Ongoing,
            this.Edit,
            this.Delete});
            this.dgvShows.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShows.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShows.GridColor = System.Drawing.Color.White;
            this.dgvShows.Location = new System.Drawing.Point(48, 150);
            this.dgvShows.Name = "dgvShows";
            this.dgvShows.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShows.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShows.RowHeadersVisible = false;
            this.dgvShows.RowHeadersWidth = 51;
            this.dgvShows.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShows.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShows.RowTemplate.Height = 45;
            this.dgvShows.Size = new System.Drawing.Size(1669, 618);
            this.dgvShows.TabIndex = 17;
            this.dgvShows.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShows_CellContentClick);
            // 
            // ShowId
            // 
            this.ShowId.DataPropertyName = "ShowId";
            this.ShowId.HeaderText = "ShowId";
            this.ShowId.MinimumWidth = 6;
            this.ShowId.Name = "ShowId";
            this.ShowId.Visible = false;
            // 
            // Title
            // 
            this.Title.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 188.7358F;
            this.Title.HeaderText = "Title";
            this.Title.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "Genre";
            this.Genre.FillWeight = 129.6577F;
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.FillWeight = 101.3559F;
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Seasons
            // 
            this.Seasons.DataPropertyName = "NumberOfSeasons";
            this.Seasons.FillWeight = 119.4319F;
            this.Seasons.HeaderText = "Seasons";
            this.Seasons.MinimumWidth = 6;
            this.Seasons.Name = "Seasons";
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.FillWeight = 94.33714F;
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 81.39174F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Ongoing
            // 
            this.Ongoing.DataPropertyName = "Ongoing";
            this.Ongoing.FillWeight = 99.82124F;
            this.Ongoing.HeaderText = "Ongoing";
            this.Ongoing.MinimumWidth = 6;
            this.Ongoing.Name = "Ongoing";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 45.01011F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 40.25852F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 58);
            this.label1.TabIndex = 16;
            this.label1.Text = "List of all shows";
            // 
            // AddShowBtn
            // 
            this.AddShowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddShowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddShowBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddShowBtn.FlatAppearance.BorderSize = 0;
            this.AddShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShowBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShowBtn.ForeColor = System.Drawing.Color.White;
            this.AddShowBtn.Location = new System.Drawing.Point(0, 792);
            this.AddShowBtn.Name = "AddShowBtn";
            this.AddShowBtn.Size = new System.Drawing.Size(1775, 43);
            this.AddShowBtn.TabIndex = 18;
            this.AddShowBtn.Text = "Add show";
            this.AddShowBtn.UseVisualStyleBackColor = false;
            this.AddShowBtn.Click += new System.EventHandler(this.AddShowBtn_Click);
            // 
            // OngoingCB
            // 
            this.OngoingCB.AutoSize = true;
            this.OngoingCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OngoingCB.Location = new System.Drawing.Point(1499, 104);
            this.OngoingCB.Name = "OngoingCB";
            this.OngoingCB.Size = new System.Drawing.Size(103, 25);
            this.OngoingCB.TabIndex = 35;
            this.OngoingCB.Text = "Ongoing";
            this.OngoingCB.UseVisualStyleBackColor = true;
            // 
            // YearSearch
            // 
            this.YearSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSearch.Location = new System.Drawing.Point(986, 105);
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
            this.YearSearch.TabIndex = 34;
            this.YearSearch.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(982, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Year from:";
            // 
            // RatingSearch
            // 
            this.RatingSearch.BackColor = System.Drawing.Color.Snow;
            this.RatingSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RatingSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingSearch.Location = new System.Drawing.Point(1147, 104);
            this.RatingSearch.Name = "RatingSearch";
            this.RatingSearch.Size = new System.Drawing.Size(141, 28);
            this.RatingSearch.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1143, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rating from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Search for shows:";
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.Snow;
            this.Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Show.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(649, 105);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(315, 28);
            this.Show.TabIndex = 29;
            // 
            // clearSearch
            // 
            this.clearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearch.FlatAppearance.BorderSize = 0;
            this.clearSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearch.Image = ((System.Drawing.Image)(resources.GetObject("clearSearch.Image")));
            this.clearSearch.Location = new System.Drawing.Point(1627, 100);
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
            this.searchBtn.Location = new System.Drawing.Point(1664, 98);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(48, 32);
            this.searchBtn.TabIndex = 27;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // GenreBox
            // 
            this.GenreBox.BackColor = System.Drawing.Color.Snow;
            this.GenreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenreBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreBox.Location = new System.Drawing.Point(1305, 103);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(171, 28);
            this.GenreBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1301, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Genre:";
            // 
            // ShowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 835);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OngoingCB);
            this.Controls.Add(this.YearSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RatingSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.AddShowBtn);
            this.Controls.Add(this.dgvShows);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowsForm";
            this.Text = "ShowsForm";
            this.Load += new System.EventHandler(this.ShowsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddShowBtn;
        private System.Windows.Forms.CheckBox OngoingCB;
        private System.Windows.Forms.NumericUpDown YearSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RatingSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Show;
        private System.Windows.Forms.Button clearSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowId;
        private System.Windows.Forms.DataGridViewLinkColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seasons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ongoing;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.Label label5;
    }
}