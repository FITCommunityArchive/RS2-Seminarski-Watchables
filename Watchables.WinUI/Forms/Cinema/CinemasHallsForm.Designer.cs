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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinemasHallsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddHallBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.dgvHalls = new System.Windows.Forms.DataGridView();
            this.CinemaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).BeginInit();
            this.SuspendLayout();
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
            this.AddHallBtn.Location = new System.Drawing.Point(0, 344);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHalls.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHalls.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHalls.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvHalls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHalls.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvHalls.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHalls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHalls.ColumnHeadersHeight = 40;
            this.dgvHalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CinemaId,
            this.HallId,
            this.Hall,
            this.Number,
            this.NumberOfSeats,
            this.Edit,
            this.Delete});
            this.dgvHalls.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHalls.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHalls.GridColor = System.Drawing.Color.White;
            this.dgvHalls.Location = new System.Drawing.Point(9, 49);
            this.dgvHalls.Name = "dgvHalls";
            this.dgvHalls.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHalls.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHalls.RowHeadersVisible = false;
            this.dgvHalls.RowHeadersWidth = 51;
            this.dgvHalls.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHalls.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHalls.RowTemplate.Height = 45;
            this.dgvHalls.Size = new System.Drawing.Size(557, 294);
            this.dgvHalls.TabIndex = 14;
            this.dgvHalls.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHalls_CellContentClick_1);
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
            // Hall
            // 
            this.Hall.DataPropertyName = "HallName";
            this.Hall.FillWeight = 128.0945F;
            this.Hall.HeaderText = "Hall";
            this.Hall.MinimumWidth = 6;
            this.Hall.Name = "Hall";
            // 
            // Number
            // 
            this.Number.DataPropertyName = "HallNumber";
            this.Number.FillWeight = 128.0945F;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            // 
            // NumberOfSeats
            // 
            this.NumberOfSeats.DataPropertyName = "NumberOfSeats";
            this.NumberOfSeats.FillWeight = 128.0945F;
            this.NumberOfSeats.HeaderText = "Seats";
            this.NumberOfSeats.MinimumWidth = 6;
            this.NumberOfSeats.Name = "NumberOfSeats";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 61.8565F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 53.85996F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // CinemasHallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 383);
            this.Controls.Add(this.dgvHalls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddHallBtn);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CinemasHallsForm";
            this.Text = "CinemasHallsForm";
            this.Load += new System.EventHandler(this.CinemasHallsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddHallBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView dgvHalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn CinemaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfSeats;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}