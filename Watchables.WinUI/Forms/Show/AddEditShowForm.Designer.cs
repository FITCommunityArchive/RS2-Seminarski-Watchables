namespace Watchables.WinUI.Forms.Show
{
    partial class AddEditShowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditShowForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.PageTitle = new System.Windows.Forms.Label();
            this.Ongoing = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TrailerLink = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ImageLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cast = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowTitle = new System.Windows.Forms.TextBox();
            this.Trailer = new System.Windows.Forms.WebBrowser();
            this.Image = new System.Windows.Forms.WebBrowser();
            this.Seasons = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seasons)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.PageTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1670, 74);
            this.panel1.TabIndex = 20;
            // 
            // Reset
            // 
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.Dock = System.Windows.Forms.DockStyle.Right;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Image = ((System.Drawing.Image)(resources.GetObject("Reset.Image")));
            this.Reset.Location = new System.Drawing.Point(1554, 0);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(56, 74);
            this.Reset.TabIndex = 18;
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(1610, 0);
            this.Close.Name = "Close";
            this.Close.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Close.Size = new System.Drawing.Size(60, 74);
            this.Close.TabIndex = 17;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.Location = new System.Drawing.Point(42, 9);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(143, 74);
            this.PageTitle.TabIndex = 23;
            this.PageTitle.Text = "Title";
            // 
            // Ongoing
            // 
            this.Ongoing.AutoSize = true;
            this.Ongoing.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ongoing.Location = new System.Drawing.Point(326, 602);
            this.Ongoing.Name = "Ongoing";
            this.Ongoing.Size = new System.Drawing.Size(140, 34);
            this.Ongoing.TabIndex = 76;
            this.Ongoing.Text = "Ongoing";
            this.Ongoing.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(0, 1034);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(1670, 35);
            this.SaveBtn.TabIndex = 75;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1184, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 30);
            this.label9.TabIndex = 74;
            this.label9.Text = "Trailer ID";
            // 
            // TrailerLink
            // 
            this.TrailerLink.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrailerLink.Location = new System.Drawing.Point(1189, 396);
            this.TrailerLink.Name = "TrailerLink";
            this.TrailerLink.Size = new System.Drawing.Size(236, 36);
            this.TrailerLink.TabIndex = 73;
            this.TrailerLink.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TrailerLink_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(560, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 72;
            this.label8.Text = "Imgae link";
            // 
            // ImageLink
            // 
            this.ImageLink.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLink.Location = new System.Drawing.Point(562, 397);
            this.ImageLink.Name = "ImageLink";
            this.ImageLink.Size = new System.Drawing.Size(348, 36);
            this.ImageLink.TabIndex = 71;
            this.ImageLink.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImageLink_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 70;
            this.label3.Text = "Cast";
            // 
            // Cast
            // 
            this.Cast.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cast.Location = new System.Drawing.Point(562, 267);
            this.Cast.Name = "Cast";
            this.Cast.Size = new System.Drawing.Size(863, 83);
            this.Cast.TabIndex = 69;
            this.Cast.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 68;
            this.label2.Text = "Description";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(562, 125);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(863, 83);
            this.Description.TabIndex = 67;
            this.Description.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 873);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 30);
            this.label7.TabIndex = 66;
            this.label7.Text = "Price";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(288, 906);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(178, 36);
            this.Price.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 874);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 30);
            this.label6.TabIndex = 64;
            this.label6.Text = "Year";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(54, 907);
            this.Year.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(194, 36);
            this.Year.TabIndex = 63;
            this.Year.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 741);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 30);
            this.label5.TabIndex = 61;
            this.label5.Text = "Rating";
            // 
            // Rating
            // 
            this.Rating.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating.Location = new System.Drawing.Point(288, 774);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(178, 36);
            this.Rating.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 741);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 30);
            this.label4.TabIndex = 59;
            this.label4.Text = "Seasons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "Title";
            // 
            // ShowTitle
            // 
            this.ShowTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTitle.Location = new System.Drawing.Point(55, 635);
            this.ShowTitle.Name = "ShowTitle";
            this.ShowTitle.Size = new System.Drawing.Size(411, 36);
            this.ShowTitle.TabIndex = 57;
            // 
            // Trailer
            // 
            this.Trailer.Location = new System.Drawing.Point(562, 469);
            this.Trailer.MinimumSize = new System.Drawing.Size(20, 20);
            this.Trailer.Name = "Trailer";
            this.Trailer.ScrollBarsEnabled = false;
            this.Trailer.Size = new System.Drawing.Size(863, 485);
            this.Trailer.TabIndex = 56;
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(55, 98);
            this.Image.MinimumSize = new System.Drawing.Size(20, 20);
            this.Image.Name = "Image";
            this.Image.ScrollBarsEnabled = false;
            this.Image.Size = new System.Drawing.Size(411, 473);
            this.Image.TabIndex = 55;
            // 
            // Seasons
            // 
            this.Seasons.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seasons.Location = new System.Drawing.Point(58, 774);
            this.Seasons.Name = "Seasons";
            this.Seasons.Size = new System.Drawing.Size(190, 36);
            this.Seasons.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(926, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 30);
            this.label10.TabIndex = 79;
            this.label10.Text = "Genre";
            // 
            // Genre
            // 
            this.Genre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(931, 396);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(236, 36);
            this.Genre.TabIndex = 78;
            // 
            // AddEditShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 1069);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Seasons);
            this.Controls.Add(this.Ongoing);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TrailerLink);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ImageLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowTitle);
            this.Controls.Add(this.Trailer);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditShowForm";
            this.Text = "AddEditShowForm";
            this.Load += new System.EventHandler(this.AddEditShowForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Seasons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label PageTitle;
        private System.Windows.Forms.CheckBox Ongoing;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TrailerLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ImageLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Cast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShowTitle;
        private System.Windows.Forms.WebBrowser Trailer;
        private System.Windows.Forms.WebBrowser Image;
        private System.Windows.Forms.NumericUpDown Seasons;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Genre;
    }
}