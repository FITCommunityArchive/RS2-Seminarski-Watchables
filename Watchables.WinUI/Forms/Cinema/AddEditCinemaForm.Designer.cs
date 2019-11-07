namespace Watchables.WinUI.Forms.Cinema
{
    partial class AddEditCinemaForm
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
            this.Cinema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ImageLink = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rating = new System.Windows.Forms.TextBox();
            this.StreetNumber = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StreetNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Cinema
            // 
            this.Cinema.Location = new System.Drawing.Point(89, 98);
            this.Cinema.Name = "Cinema";
            this.Cinema.Size = new System.Drawing.Size(156, 22);
            this.Cinema.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cinema";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(89, 178);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(104, 22);
            this.Address.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Location";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(89, 264);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(156, 22);
            this.Location.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone number";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(89, 347);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(156, 22);
            this.PhoneNumber.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rating";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(89, 545);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(399, 105);
            this.Description.TabIndex = 12;
            this.Description.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Image link";
            // 
            // ImageLink
            // 
            this.ImageLink.Location = new System.Drawing.Point(497, 98);
            this.ImageLink.Name = "ImageLink";
            this.ImageLink.Size = new System.Drawing.Size(156, 22);
            this.ImageLink.TabIndex = 14;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(615, 573);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Close
            // 
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.Location = new System.Drawing.Point(817, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 29);
            this.Close.TabIndex = 17;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 29);
            this.panel1.TabIndex = 18;
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(89, 431);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(104, 22);
            this.Rating.TabIndex = 19;
            // 
            // StreetNumber
            // 
            this.StreetNumber.Location = new System.Drawing.Point(293, 221);
            this.StreetNumber.Name = "StreetNumber";
            this.StreetNumber.Size = new System.Drawing.Size(44, 22);
            this.StreetNumber.TabIndex = 20;
            // 
            // AddEditCinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 723);
            this.Controls.Add(this.StreetNumber);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ImageLink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cinema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditCinemaForm";
            this.Text = "AddEditCinema";
            this.Load += new System.EventHandler(this.AddEditCinemaForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StreetNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cinema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ImageLink;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Rating;
        private System.Windows.Forms.NumericUpDown StreetNumber;
    }
}