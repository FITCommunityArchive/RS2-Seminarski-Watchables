namespace Watchables.WinUI.Forms
{
    partial class CinemasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemasForm));
            this.dgvCinemas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.AddCinemaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CinemaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinema = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Products = new System.Windows.Forms.DataGridViewImageColumn();
            this.Halls = new System.Windows.Forms.DataGridViewImageColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewImageColumn();
            this.clearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinemas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCinemas
            // 
            this.dgvCinemas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvCinemas.AllowUserToAddRows = false;
            this.dgvCinemas.AllowUserToDeleteRows = false;
            this.dgvCinemas.AllowUserToResizeColumns = false;
            this.dgvCinemas.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCinemas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvCinemas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCinemas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dgvCinemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCinemas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvCinemas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCinemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvCinemas.ColumnHeadersHeight = 45;
            this.dgvCinemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CinemaId,
            this.Cinema,
            this.Rating,
            this.Address,
            this.Number,
            this.Location,
            this.phoneNumber,
            this.Edit,
            this.Delete,
            this.Products,
            this.Halls,
            this.Schedule});
            this.dgvCinemas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCinemas.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvCinemas.DoubleBuffered = true;
            this.dgvCinemas.EnableHeadersVisualStyles = false;
            this.dgvCinemas.GridColor = System.Drawing.Color.White;
            this.dgvCinemas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.dgvCinemas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCinemas.Location = new System.Drawing.Point(42, 138);
            this.dgvCinemas.Name = "dgvCinemas";
            this.dgvCinemas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCinemas.RowHeadersVisible = false;
            this.dgvCinemas.RowHeadersWidth = 51;
            this.dgvCinemas.RowTemplate.Height = 24;
            this.dgvCinemas.Size = new System.Drawing.Size(1669, 636);
            this.dgvCinemas.TabIndex = 0;
            this.dgvCinemas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCinemas_CellClick);
            // 
            // AddCinemaButton
            // 
            this.AddCinemaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddCinemaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCinemaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCinemaButton.FlatAppearance.BorderSize = 0;
            this.AddCinemaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCinemaButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCinemaButton.ForeColor = System.Drawing.Color.White;
            this.AddCinemaButton.Location = new System.Drawing.Point(0, 792);
            this.AddCinemaButton.Name = "AddCinemaButton";
            this.AddCinemaButton.Size = new System.Drawing.Size(1775, 43);
            this.AddCinemaButton.TabIndex = 1;
            this.AddCinemaButton.Text = "Add cinema";
            this.AddCinemaButton.UseVisualStyleBackColor = false;
            this.AddCinemaButton.Click += new System.EventHandler(this.AddCinemaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of all Watchable cinemas";
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(961, 95);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(315, 28);
            this.searchTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(957, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search for cinemas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1463, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rating from:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.locationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(1293, 95);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(158, 28);
            this.locationTextBox.TabIndex = 8;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ratingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratingTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingTextBox.Location = new System.Drawing.Point(1467, 95);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(141, 28);
            this.ratingTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1289, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Location:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1663, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 11;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CinemaId
            // 
            this.CinemaId.DataPropertyName = "CinemaId";
            this.CinemaId.HeaderText = "CinemaId";
            this.CinemaId.MinimumWidth = 6;
            this.CinemaId.Name = "CinemaId";
            this.CinemaId.Visible = false;
            // 
            // Cinema
            // 
            this.Cinema.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Cinema.DataPropertyName = "Name";
            this.Cinema.FillWeight = 183.744F;
            this.Cinema.HeaderText = "Cinema";
            this.Cinema.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Cinema.MinimumWidth = 6;
            this.Cinema.Name = "Cinema";
            this.Cinema.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cinema.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cinema.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.FillWeight = 102.5255F;
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 202.1238F;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "StreetNumber";
            this.Number.FillWeight = 102.4036F;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.FillWeight = 119.3464F;
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "PhoneNumber";
            this.phoneNumber.FillWeight = 112.0432F;
            this.phoneNumber.HeaderText = "Phone";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            // 
            // Edit
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle23.NullValue")));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle23;
            this.Edit.FillWeight = 59.13768F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 4;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.ToolTipText = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 55.42358F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Products
            // 
            this.Products.FillWeight = 56.31961F;
            this.Products.HeaderText = "";
            this.Products.Image = ((System.Drawing.Image)(resources.GetObject("Products.Image")));
            this.Products.MinimumWidth = 6;
            this.Products.Name = "Products";
            this.Products.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Halls
            // 
            this.Halls.FillWeight = 52.92856F;
            this.Halls.HeaderText = "";
            this.Halls.Image = ((System.Drawing.Image)(resources.GetObject("Halls.Image")));
            this.Halls.MinimumWidth = 6;
            this.Halls.Name = "Halls";
            this.Halls.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Schedule
            // 
            this.Schedule.FillWeight = 54.00425F;
            this.Schedule.HeaderText = "";
            this.Schedule.Image = ((System.Drawing.Image)(resources.GetObject("Schedule.Image")));
            this.Schedule.MinimumWidth = 6;
            this.Schedule.Name = "Schedule";
            this.Schedule.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Schedule.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clearSearch
            // 
            this.clearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearch.FlatAppearance.BorderSize = 0;
            this.clearSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearch.Image = ((System.Drawing.Image)(resources.GetObject("clearSearch.Image")));
            this.clearSearch.Location = new System.Drawing.Point(1626, 93);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(31, 32);
            this.clearSearch.TabIndex = 12;
            this.clearSearch.UseVisualStyleBackColor = true;
            this.clearSearch.Click += new System.EventHandler(this.clearSearch_Click);
            // 
            // CinemasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1775, 835);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCinemaButton);
            this.Controls.Add(this.dgvCinemas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CinemasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinemas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCinemas;
        private System.Windows.Forms.Button AddCinemaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinemaId;
        private System.Windows.Forms.DataGridViewLinkColumn Cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Products;
        private System.Windows.Forms.DataGridViewImageColumn Halls;
        private System.Windows.Forms.DataGridViewImageColumn Schedule;
        private System.Windows.Forms.Button clearSearch;
    }
}