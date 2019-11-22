namespace Watchables.WinUI.Forms.Subscription
{
    partial class AddEditSubsciptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditSubsciptionForm));
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Movies = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Shows = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Tickets = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Avaiable = new System.Windows.Forms.CheckBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(0, 322);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(836, 39);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reloadBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(624, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 39);
            this.panel1.TabIndex = 10;
            // 
            // reloadBtn
            // 
            this.reloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.reloadBtn.FlatAppearance.BorderSize = 0;
            this.reloadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reloadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Image = ((System.Drawing.Image)(resources.GetObject("reloadBtn.Image")));
            this.reloadBtn.Location = new System.Drawing.Point(114, 0);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(43, 39);
            this.reloadBtn.TabIndex = 1;
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(157, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(43, 39);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(99, 34);
            this.Title.TabIndex = 11;
            this.Title.Text = "label5";
            // 
            // Movies
            // 
            this.Movies.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movies.Location = new System.Drawing.Point(514, 158);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(126, 36);
            this.Movies.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Movies";
            // 
            // Shows
            // 
            this.Shows.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shows.Location = new System.Drawing.Point(185, 158);
            this.Shows.Name = "Shows";
            this.Shows.Size = new System.Drawing.Size(126, 36);
            this.Shows.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Shows";
            // 
            // Tickets
            // 
            this.Tickets.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tickets.Location = new System.Drawing.Point(350, 159);
            this.Tickets.Name = "Tickets";
            this.Tickets.Size = new System.Drawing.Size(126, 36);
            this.Tickets.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tickets";
            // 
            // Avaiable
            // 
            this.Avaiable.AutoSize = true;
            this.Avaiable.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avaiable.Location = new System.Drawing.Point(668, 157);
            this.Avaiable.Name = "Avaiable";
            this.Avaiable.Size = new System.Drawing.Size(143, 34);
            this.Avaiable.TabIndex = 18;
            this.Avaiable.Text = "Avaiable";
            this.Avaiable.UseVisualStyleBackColor = true;
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(18, 158);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(126, 36);
            this.Price.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Price";
            // 
            // AddEditSubsciptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(836, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Avaiable);
            this.Controls.Add(this.Tickets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Shows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditSubsciptionForm";
            this.Text = "AddEditSubsciption";
            this.Load += new System.EventHandler(this.AddEditSubsciptionForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.NumericUpDown Movies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Shows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Tickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Avaiable;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label4;
    }
}