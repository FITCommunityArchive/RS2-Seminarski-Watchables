namespace Watchables.WinUI.Forms
{
    partial class DashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTopMovies = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ravenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTopShows = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orders = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MoviesRavenue = new System.Windows.Forms.Label();
            this.ShowsRavenue = new System.Windows.Forms.Label();
            this.SubRavenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopShows)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users notification feed";
            // 
            // dgvNotifications
            // 
            this.dgvNotifications.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvNotifications.AllowUserToAddRows = false;
            this.dgvNotifications.AllowUserToDeleteRows = false;
            this.dgvNotifications.AllowUserToResizeColumns = false;
            this.dgvNotifications.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNotifications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotifications.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotifications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvNotifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvNotifications.ColumnHeadersHeight = 40;
            this.dgvNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Notification,
            this.Created});
            this.dgvNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotifications.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvNotifications.GridColor = System.Drawing.Color.White;
            this.dgvNotifications.Location = new System.Drawing.Point(37, 76);
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotifications.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.RowHeadersWidth = 51;
            this.dgvNotifications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNotifications.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNotifications.RowTemplate.Height = 45;
            this.dgvNotifications.Size = new System.Drawing.Size(1338, 305);
            this.dgvNotifications.TabIndex = 15;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.FillWeight = 42.33355F;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // Notification
            // 
            this.Notification.DataPropertyName = "Content";
            this.Notification.FillWeight = 192.8716F;
            this.Notification.HeaderText = "Notification";
            this.Notification.MinimumWidth = 6;
            this.Notification.Name = "Notification";
            // 
            // Created
            // 
            this.Created.DataPropertyName = "Created";
            this.Created.FillWeight = 64.79482F;
            this.Created.HeaderText = "Created";
            this.Created.MinimumWidth = 6;
            this.Created.Name = "Created";
            // 
            // dgvTopMovies
            // 
            this.dgvTopMovies.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvTopMovies.AllowUserToAddRows = false;
            this.dgvTopMovies.AllowUserToDeleteRows = false;
            this.dgvTopMovies.AllowUserToResizeColumns = false;
            this.dgvTopMovies.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTopMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTopMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopMovies.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvTopMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopMovies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvTopMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTopMovies.ColumnHeadersHeight = 40;
            this.dgvTopMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Ravenue});
            this.dgvTopMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopMovies.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTopMovies.GridColor = System.Drawing.Color.White;
            this.dgvTopMovies.Location = new System.Drawing.Point(37, 475);
            this.dgvTopMovies.Name = "dgvTopMovies";
            this.dgvTopMovies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvTopMovies.RowHeadersVisible = false;
            this.dgvTopMovies.RowHeadersWidth = 51;
            this.dgvTopMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTopMovies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTopMovies.RowTemplate.Height = 45;
            this.dgvTopMovies.Size = new System.Drawing.Size(657, 428);
            this.dgvTopMovies.TabIndex = 17;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 125.6732F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Ravenue
            // 
            this.Ravenue.DataPropertyName = "Ravenue";
            this.Ravenue.FillWeight = 74.32675F;
            this.Ravenue.HeaderText = "Ravenue";
            this.Ravenue.MinimumWidth = 6;
            this.Ravenue.Name = "Ravenue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "Top selling movies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(768, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 40);
            this.label6.TabIndex = 20;
            this.label6.Text = "Top selling shows";
            // 
            // dgvTopShows
            // 
            this.dgvTopShows.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvTopShows.AllowUserToAddRows = false;
            this.dgvTopShows.AllowUserToDeleteRows = false;
            this.dgvTopShows.AllowUserToResizeColumns = false;
            this.dgvTopShows.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTopShows.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvTopShows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopShows.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvTopShows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopShows.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvTopShows.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopShows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvTopShows.ColumnHeadersHeight = 40;
            this.dgvTopShows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTopShows.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopShows.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvTopShows.GridColor = System.Drawing.Color.White;
            this.dgvTopShows.Location = new System.Drawing.Point(775, 475);
            this.dgvTopShows.Name = "dgvTopShows";
            this.dgvTopShows.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopShows.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvTopShows.RowHeadersVisible = false;
            this.dgvTopShows.RowHeadersWidth = 51;
            this.dgvTopShows.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTopShows.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTopShows.RowTemplate.Height = 45;
            this.dgvTopShows.Size = new System.Drawing.Size(600, 428);
            this.dgvTopShows.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.FillWeight = 125.6732F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ravenue";
            this.dataGridViewTextBoxColumn2.FillWeight = 74.32675F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ravenue";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Orders
            // 
            this.Orders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Orders.AutoSize = true;
            this.Orders.BackColor = System.Drawing.Color.Snow;
            this.Orders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Orders.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Orders.Location = new System.Drawing.Point(81, 107);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(30);
            this.Orders.Size = new System.Drawing.Size(233, 120);
            this.Orders.TabIndex = 7;
            this.Orders.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SubRavenue);
            this.panel1.Controls.Add(this.ShowsRavenue);
            this.panel1.Controls.Add(this.MoviesRavenue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Orders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1424, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 900);
            this.panel1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Orders ravenue";
            // 
            // MoviesRavenue
            // 
            this.MoviesRavenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MoviesRavenue.AutoSize = true;
            this.MoviesRavenue.BackColor = System.Drawing.Color.Snow;
            this.MoviesRavenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoviesRavenue.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesRavenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.MoviesRavenue.Location = new System.Drawing.Point(81, 320);
            this.MoviesRavenue.Name = "MoviesRavenue";
            this.MoviesRavenue.Padding = new System.Windows.Forms.Padding(30);
            this.MoviesRavenue.Size = new System.Drawing.Size(233, 120);
            this.MoviesRavenue.TabIndex = 8;
            this.MoviesRavenue.Text = "label2";
            // 
            // ShowsRavenue
            // 
            this.ShowsRavenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowsRavenue.AutoSize = true;
            this.ShowsRavenue.BackColor = System.Drawing.Color.Snow;
            this.ShowsRavenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowsRavenue.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowsRavenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.ShowsRavenue.Location = new System.Drawing.Point(81, 543);
            this.ShowsRavenue.Name = "ShowsRavenue";
            this.ShowsRavenue.Padding = new System.Windows.Forms.Padding(30);
            this.ShowsRavenue.Size = new System.Drawing.Size(233, 120);
            this.ShowsRavenue.TabIndex = 9;
            this.ShowsRavenue.Text = "label2";
            // 
            // SubRavenue
            // 
            this.SubRavenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubRavenue.AutoSize = true;
            this.SubRavenue.BackColor = System.Drawing.Color.Snow;
            this.SubRavenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubRavenue.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubRavenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SubRavenue.Location = new System.Drawing.Point(81, 771);
            this.SubRavenue.Name = "SubRavenue";
            this.SubRavenue.Padding = new System.Windows.Forms.Padding(30);
            this.SubRavenue.Size = new System.Drawing.Size(233, 120);
            this.SubRavenue.TabIndex = 10;
            this.SubRavenue.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Movies ravenue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Shows ravenue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 723);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 34);
            this.label7.TabIndex = 13;
            this.label7.Text = "Monthly subs";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1794, 900);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTopShows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTopMovies);
            this.Controls.Add(this.dgvNotifications);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopShows)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNotifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridView dgvTopMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ravenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTopShows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label Orders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MoviesRavenue;
        private System.Windows.Forms.Label ShowsRavenue;
        private System.Windows.Forms.Label SubRavenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}