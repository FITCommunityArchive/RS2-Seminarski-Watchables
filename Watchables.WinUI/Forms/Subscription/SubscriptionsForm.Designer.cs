namespace Watchables.WinUI.Forms.Subscription
{
    partial class SubscriptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscriptionsForm));
            this.dgvSubscriptions = new System.Windows.Forms.DataGridView();
            this.SubscriptionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSubscriptionButton = new System.Windows.Forms.Button();
            this.MoviesScr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowsScr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TicketsScr = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceScr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearSearch = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesScr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowsScr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsScr)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubscriptions
            // 
            this.dgvSubscriptions.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvSubscriptions.AllowUserToAddRows = false;
            this.dgvSubscriptions.AllowUserToDeleteRows = false;
            this.dgvSubscriptions.AllowUserToResizeColumns = false;
            this.dgvSubscriptions.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSubscriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSubscriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubscriptions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.dgvSubscriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubscriptions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSubscriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubscriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSubscriptions.ColumnHeadersHeight = 45;
            this.dgvSubscriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubscriptionId,
            this.Price,
            this.Movies,
            this.Shows,
            this.Tickets,
            this.Available,
            this.Edit,
            this.Delete});
            this.dgvSubscriptions.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubscriptions.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSubscriptions.GridColor = System.Drawing.Color.White;
            this.dgvSubscriptions.Location = new System.Drawing.Point(57, 146);
            this.dgvSubscriptions.Name = "dgvSubscriptions";
            this.dgvSubscriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubscriptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSubscriptions.RowHeadersVisible = false;
            this.dgvSubscriptions.RowHeadersWidth = 51;
            this.dgvSubscriptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubscriptions.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubscriptions.RowTemplate.Height = 45;
            this.dgvSubscriptions.Size = new System.Drawing.Size(1669, 618);
            this.dgvSubscriptions.TabIndex = 15;
            this.dgvSubscriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubscriptions_CellContentClick);
            // 
            // SubscriptionId
            // 
            this.SubscriptionId.DataPropertyName = "SubscriptionId";
            this.SubscriptionId.HeaderText = "SubscriptionId";
            this.SubscriptionId.MinimumWidth = 6;
            this.SubscriptionId.Name = "SubscriptionId";
            this.SubscriptionId.Visible = false;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Movies
            // 
            this.Movies.DataPropertyName = "numberOfMovies";
            this.Movies.HeaderText = "Movies";
            this.Movies.MinimumWidth = 6;
            this.Movies.Name = "Movies";
            // 
            // Shows
            // 
            this.Shows.DataPropertyName = "numberOfShows";
            this.Shows.HeaderText = "Shows";
            this.Shows.MinimumWidth = 6;
            this.Shows.Name = "Shows";
            // 
            // Tickets
            // 
            this.Tickets.DataPropertyName = "numberOfTickets";
            this.Tickets.HeaderText = "Tickets";
            this.Tickets.MinimumWidth = 6;
            this.Tickets.Name = "Tickets";
            // 
            // Available
            // 
            this.Available.DataPropertyName = "available";
            this.Available.HeaderText = "Available";
            this.Available.MinimumWidth = 6;
            this.Available.Name = "Available";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 46.29558F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 43.3924F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "List of all subscriptions";
            // 
            // AddSubscriptionButton
            // 
            this.AddSubscriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddSubscriptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSubscriptionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddSubscriptionButton.FlatAppearance.BorderSize = 0;
            this.AddSubscriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSubscriptionButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubscriptionButton.ForeColor = System.Drawing.Color.White;
            this.AddSubscriptionButton.Location = new System.Drawing.Point(0, 792);
            this.AddSubscriptionButton.Name = "AddSubscriptionButton";
            this.AddSubscriptionButton.Size = new System.Drawing.Size(1775, 43);
            this.AddSubscriptionButton.TabIndex = 16;
            this.AddSubscriptionButton.Text = "Add subscription";
            this.AddSubscriptionButton.UseVisualStyleBackColor = false;
            this.AddSubscriptionButton.Click += new System.EventHandler(this.AddSubscriptionButton_Click);
            // 
            // MoviesScr
            // 
            this.MoviesScr.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesScr.Location = new System.Drawing.Point(1134, 97);
            this.MoviesScr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MoviesScr.Name = "MoviesScr";
            this.MoviesScr.Size = new System.Drawing.Size(138, 28);
            this.MoviesScr.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1130, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Movies from:";
            // 
            // ShowsScr
            // 
            this.ShowsScr.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsScr.Location = new System.Drawing.Point(1299, 97);
            this.ShowsScr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ShowsScr.Name = "ShowsScr";
            this.ShowsScr.Size = new System.Drawing.Size(138, 28);
            this.ShowsScr.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1295, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Shows from:";
            // 
            // TicketsScr
            // 
            this.TicketsScr.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketsScr.Location = new System.Drawing.Point(1463, 98);
            this.TicketsScr.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TicketsScr.Name = "TicketsScr";
            this.TicketsScr.Size = new System.Drawing.Size(138, 28);
            this.TicketsScr.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1459, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tickets from:";
            // 
            // PriceScr
            // 
            this.PriceScr.BackColor = System.Drawing.Color.Snow;
            this.PriceScr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceScr.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceScr.Location = new System.Drawing.Point(960, 97);
            this.PriceScr.Name = "PriceScr";
            this.PriceScr.Size = new System.Drawing.Size(141, 28);
            this.PriceScr.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(956, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Price from:";
            // 
            // clearSearch
            // 
            this.clearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearch.FlatAppearance.BorderSize = 0;
            this.clearSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearch.Image = ((System.Drawing.Image)(resources.GetObject("clearSearch.Image")));
            this.clearSearch.Location = new System.Drawing.Point(1635, 95);
            this.clearSearch.Name = "clearSearch";
            this.clearSearch.Size = new System.Drawing.Size(31, 32);
            this.clearSearch.TabIndex = 44;
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
            this.searchBtn.Location = new System.Drawing.Point(1672, 93);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(48, 32);
            this.searchBtn.TabIndex = 43;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SubscriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 835);
            this.Controls.Add(this.clearSearch);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.PriceScr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TicketsScr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowsScr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoviesScr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddSubscriptionButton);
            this.Controls.Add(this.dgvSubscriptions);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubscriptionsForm";
            this.Text = "SubscriptionsForm";
            this.Load += new System.EventHandler(this.SubscriptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesScr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowsScr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsScr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubscriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSubscriptionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscriptionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shows;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.NumericUpDown MoviesScr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ShowsScr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TicketsScr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceScr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearSearch;
        private System.Windows.Forms.Button searchBtn;
    }
}