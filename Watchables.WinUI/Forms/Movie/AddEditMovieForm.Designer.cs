namespace Watchables.WinUI.Forms.Movie
{
    partial class AddEditMovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditMovieForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Trailer = new System.Windows.Forms.WebBrowser();
            this.MovieTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.DateTimePicker();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TrailerLink = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ImageLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cast = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Standalone = new System.Windows.Forms.CheckBox();
            this.Image = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1670, 74);
            this.panel1.TabIndex = 19;
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
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(42, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(143, 74);
            this.Title.TabIndex = 23;
            this.Title.Text = "Title";
            // 
            // Trailer
            // 
            this.Trailer.Location = new System.Drawing.Point(563, 470);
            this.Trailer.MinimumSize = new System.Drawing.Size(20, 20);
            this.Trailer.Name = "Trailer";
            this.Trailer.ScrollBarsEnabled = false;
            this.Trailer.Size = new System.Drawing.Size(863, 485);
            this.Trailer.TabIndex = 25;
            // 
            // MovieTitle
            // 
            this.MovieTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitle.Location = new System.Drawing.Point(56, 636);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(411, 36);
            this.MovieTitle.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 742);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 30);
            this.label4.TabIndex = 33;
            this.label4.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 742);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 30);
            this.label5.TabIndex = 35;
            this.label5.Text = "Rating";
            // 
            // Rating
            // 
            this.Rating.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rating.Location = new System.Drawing.Point(289, 775);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(178, 36);
            this.Rating.TabIndex = 34;
            // 
            // Duration
            // 
            this.Duration.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duration.Location = new System.Drawing.Point(55, 775);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(194, 36);
            this.Duration.TabIndex = 36;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(55, 908);
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
            this.Year.TabIndex = 37;
            this.Year.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 875);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 30);
            this.label6.TabIndex = 38;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 874);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 30);
            this.label7.TabIndex = 40;
            this.label7.Text = "Price";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(289, 907);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(178, 36);
            this.Price.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1185, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 30);
            this.label9.TabIndex = 52;
            this.label9.Text = "Trailer ID";
            // 
            // TrailerLink
            // 
            this.TrailerLink.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrailerLink.Location = new System.Drawing.Point(1190, 397);
            this.TrailerLink.Name = "TrailerLink";
            this.TrailerLink.Size = new System.Drawing.Size(236, 36);
            this.TrailerLink.TabIndex = 51;
            this.TrailerLink.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TrailerLink_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(561, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 30);
            this.label8.TabIndex = 50;
            this.label8.Text = "Imgae link";
            // 
            // ImageLink
            // 
            this.ImageLink.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLink.Location = new System.Drawing.Point(563, 398);
            this.ImageLink.Name = "ImageLink";
            this.ImageLink.Size = new System.Drawing.Size(609, 36);
            this.ImageLink.TabIndex = 49;
            this.ImageLink.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ImageLink_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cast";
            // 
            // Cast
            // 
            this.Cast.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cast.Location = new System.Drawing.Point(563, 268);
            this.Cast.Name = "Cast";
            this.Cast.Size = new System.Drawing.Size(863, 83);
            this.Cast.TabIndex = 47;
            this.Cast.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 30);
            this.label2.TabIndex = 46;
            this.label2.Text = "Description";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(563, 126);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(863, 83);
            this.Description.TabIndex = 45;
            this.Description.Text = "";
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
            this.SaveBtn.TabIndex = 53;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            // 
            // Standalone
            // 
            this.Standalone.AutoSize = true;
            this.Standalone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Standalone.Location = new System.Drawing.Point(302, 603);
            this.Standalone.Name = "Standalone";
            this.Standalone.Size = new System.Drawing.Size(171, 34);
            this.Standalone.TabIndex = 54;
            this.Standalone.Text = "Standalone";
            this.Standalone.UseVisualStyleBackColor = true;
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(56, 99);
            this.Image.MinimumSize = new System.Drawing.Size(20, 20);
            this.Image.Name = "Image";
            this.Image.ScrollBarsEnabled = false;
            this.Image.Size = new System.Drawing.Size(411, 473);
            this.Image.TabIndex = 24;
            // 
            // AddEditMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 1069);
            this.Controls.Add(this.Standalone);
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
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.Trailer);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditMovieForm";
            this.Text = "AddEditMovieForm";
            this.Load += new System.EventHandler(this.AddEditMovieForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.WebBrowser Trailer;
        private System.Windows.Forms.TextBox MovieTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.DateTimePicker Duration;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TrailerLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ImageLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Cast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox Standalone;
        private System.Windows.Forms.WebBrowser Image;
    }
}