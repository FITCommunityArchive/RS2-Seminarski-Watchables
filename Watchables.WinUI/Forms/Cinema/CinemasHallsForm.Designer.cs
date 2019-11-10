namespace Watchables.WinUI.Forms.Cinema
{
    partial class CinemasHallsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemasHallsForm));
            this.Title = new System.Windows.Forms.Label();
            this.dgvHalls = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CinemaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddHallBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 7);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(99, 34);
            this.Title.TabIndex = 1;
            this.Title.Text = "label1";
            // 
            // dgvHalls
            // 
            this.dgvHalls.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvHalls.AllowUserToAddRows = false;
            this.dgvHalls.AllowUserToDeleteRows = false;
            this.dgvHalls.AllowUserToResizeColumns = false;
            this.dgvHalls.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHalls.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHalls.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvHalls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHalls.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvHalls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHalls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHalls.ColumnHeadersHeight = 35;
            this.dgvHalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CinemaId,
            this.HallId,
            this.HallName,
            this.HallNumber,
            this.Seats,
            this.Edit,
            this.Delete});
            this.dgvHalls.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHalls.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHalls.DoubleBuffered = true;
            this.dgvHalls.EnableHeadersVisualStyles = false;
            this.dgvHalls.GridColor = System.Drawing.Color.White;
            this.dgvHalls.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.dgvHalls.HeaderForeColor = System.Drawing.Color.White;
            this.dgvHalls.Location = new System.Drawing.Point(0, 61);
            this.dgvHalls.Name = "dgvHalls";
            this.dgvHalls.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHalls.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHalls.RowHeadersVisible = false;
            this.dgvHalls.RowHeadersWidth = 51;
            this.dgvHalls.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHalls.RowTemplate.Height = 35;
            this.dgvHalls.Size = new System.Drawing.Size(581, 290);
            this.dgvHalls.TabIndex = 2;
            this.dgvHalls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHalls_CellContentClick);
            // 
            // CinemaId
            // 
            this.CinemaId.DataPropertyName = "CinemaId";
            this.CinemaId.HeaderText = "CinemaId";
            this.CinemaId.MinimumWidth = 6;
            this.CinemaId.Name = "CinemaId";
            this.CinemaId.Visible = false;
            // 
            // HallId
            // 
            this.HallId.DataPropertyName = "HallId";
            this.HallId.HeaderText = "HallId";
            this.HallId.MinimumWidth = 6;
            this.HallId.Name = "HallId";
            this.HallId.Visible = false;
            // 
            // HallName
            // 
            this.HallName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.HallName.DataPropertyName = "HallName";
            this.HallName.HeaderText = "Name";
            this.HallName.MinimumWidth = 6;
            this.HallName.Name = "HallName";
            this.HallName.Width = 114;
            // 
            // HallNumber
            // 
            this.HallNumber.DataPropertyName = "HallNumber";
            this.HallNumber.FillWeight = 138.4047F;
            this.HallNumber.HeaderText = "Number";
            this.HallNumber.MinimumWidth = 6;
            this.HallNumber.Name = "HallNumber";
            // 
            // Seats
            // 
            this.Seats.DataPropertyName = "NumberOfSeats";
            this.Seats.FillWeight = 124.7002F;
            this.Seats.HeaderText = "Seats";
            this.Seats.MinimumWidth = 6;
            this.Seats.Name = "Seats";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 69.0993F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 67.79577F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AddHallBtn
            // 
            this.AddHallBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddHallBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddHallBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddHallBtn.FlatAppearance.BorderSize = 0;
            this.AddHallBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddHallBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(9)))), ((int)(((byte)(66)))));
            this.AddHallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHallBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHallBtn.ForeColor = System.Drawing.Color.White;
            this.AddHallBtn.Location = new System.Drawing.Point(0, 357);
            this.AddHallBtn.Name = "AddHallBtn";
            this.AddHallBtn.Size = new System.Drawing.Size(581, 39);
            this.AddHallBtn.TabIndex = 3;
            this.AddHallBtn.Text = "Add hall";
            this.AddHallBtn.UseVisualStyleBackColor = false;
            this.AddHallBtn.Click += new System.EventHandler(this.AddHallBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(455, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 36);
            this.panel1.TabIndex = 4;
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
            // CinemasHallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddHallBtn);
            this.Controls.Add(this.dgvHalls);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CinemasHallsForm";
            this.Text = "CinemasHallsForm";
            this.Load += new System.EventHandler(this.CinemasHallsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvHalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinemaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seats;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Button AddHallBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
    }
}