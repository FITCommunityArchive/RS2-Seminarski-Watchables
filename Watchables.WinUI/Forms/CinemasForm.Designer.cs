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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCinemaBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CinemaScheduleBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteCinemaBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinemas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCinemas
            // 
            this.dgvCinemas.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvCinemas.AllowUserToAddRows = false;
            this.dgvCinemas.AllowUserToDeleteRows = false;
            this.dgvCinemas.AllowUserToOrderColumns = true;
            this.dgvCinemas.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvCinemas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCinemas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCinemas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCinemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCinemas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCinemas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCinemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCinemas.ColumnHeadersHeight = 50;
            this.dgvCinemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cinema,
            this.Rating,
            this.Address,
            this.Number,
            this.Location,
            this.phoneNumber,
            this.EditCinemaBtn,
            this.CinemaScheduleBtn,
            this.DeleteCinemaBtn});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCinemas.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvCinemas.DoubleBuffered = true;
            this.dgvCinemas.EnableHeadersVisualStyles = false;
            this.dgvCinemas.HeaderBgColor = System.Drawing.Color.CornflowerBlue;
            this.dgvCinemas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCinemas.Location = new System.Drawing.Point(41, 113);
            this.dgvCinemas.Name = "dgvCinemas";
            this.dgvCinemas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCinemas.RowHeadersVisible = false;
            this.dgvCinemas.RowHeadersWidth = 51;
            this.dgvCinemas.RowTemplate.Height = 24;
            this.dgvCinemas.Size = new System.Drawing.Size(1576, 437);
            this.dgvCinemas.TabIndex = 0;
            // 
            // AddCinemaButton
            // 
            this.AddCinemaButton.BackColor = System.Drawing.Color.White;
            this.AddCinemaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCinemaButton.Location = new System.Drawing.Point(41, 567);
            this.AddCinemaButton.Name = "AddCinemaButton";
            this.AddCinemaButton.Size = new System.Drawing.Size(1576, 43);
            this.AddCinemaButton.TabIndex = 1;
            this.AddCinemaButton.Text = "Add cinema";
            this.AddCinemaButton.UseVisualStyleBackColor = false;
            this.AddCinemaButton.Click += new System.EventHandler(this.AddCinemaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of all Watchable cinemas";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(857, 61);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(315, 28);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(853, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search for cinemas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1363, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rating from:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(1189, 61);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(158, 28);
            this.locationTextBox.TabIndex = 8;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingTextBox.Location = new System.Drawing.Point(1367, 61);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(131, 28);
            this.ratingTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1185, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Location:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1515, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cinema
            // 
            this.Cinema.DataPropertyName = "Name";
            this.Cinema.FillWeight = 121.3367F;
            this.Cinema.HeaderText = "Cinema";
            this.Cinema.MinimumWidth = 6;
            this.Cinema.Name = "Cinema";
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.FillWeight = 121.3367F;
            this.Rating.HeaderText = "Rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 121.3367F;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "StreetNumber";
            this.Number.FillWeight = 121.3367F;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.FillWeight = 121.3367F;
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "PhoneNumber";
            this.phoneNumber.FillWeight = 121.3367F;
            this.phoneNumber.HeaderText = "Phone";
            this.phoneNumber.MinimumWidth = 6;
            this.phoneNumber.Name = "phoneNumber";
            // 
            // EditCinemaBtn
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.EditCinemaBtn.DefaultCellStyle = dataGridViewCellStyle19;
            this.EditCinemaBtn.FillWeight = 59.84549F;
            this.EditCinemaBtn.HeaderText = "";
            this.EditCinemaBtn.MinimumWidth = 4;
            this.EditCinemaBtn.Name = "EditCinemaBtn";
            this.EditCinemaBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditCinemaBtn.Text = "Edit";
            this.EditCinemaBtn.UseColumnTextForButtonValue = true;
            // 
            // CinemaScheduleBtn
            // 
            this.CinemaScheduleBtn.FillWeight = 60.10453F;
            this.CinemaScheduleBtn.HeaderText = "";
            this.CinemaScheduleBtn.MinimumWidth = 6;
            this.CinemaScheduleBtn.Name = "CinemaScheduleBtn";
            this.CinemaScheduleBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CinemaScheduleBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CinemaScheduleBtn.Text = "Schedule";
            this.CinemaScheduleBtn.UseColumnTextForButtonValue = true;
            // 
            // DeleteCinemaBtn
            // 
            this.DeleteCinemaBtn.FillWeight = 52.02961F;
            this.DeleteCinemaBtn.HeaderText = "";
            this.DeleteCinemaBtn.MinimumWidth = 6;
            this.DeleteCinemaBtn.Name = "DeleteCinemaBtn";
            this.DeleteCinemaBtn.Text = "Delete";
            this.DeleteCinemaBtn.UseColumnTextForButtonValue = true;
            // 
            // CinemasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1775, 835);
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
            this.Name = "CinemasForm";
            this.Text = "Cinemas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewButtonColumn EditCinemaBtn;
        private System.Windows.Forms.DataGridViewButtonColumn CinemaScheduleBtn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCinemaBtn;
    }
}