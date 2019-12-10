namespace Watchables.WinUI.Forms.Cinema
{
    partial class AddEditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reloadBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(489, -1);
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
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(0, 323);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(689, 39);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(99, 34);
            this.Title.TabIndex = 12;
            this.Title.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(33, 149);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(395, 36);
            this.ProductName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Price";
            // 
            // ProductPrice
            // 
            this.ProductPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.Location = new System.Drawing.Point(475, 149);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(171, 36);
            this.ProductPrice.TabIndex = 15;
            // 
            // AddEditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(689, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditProductForm";
            this.Text = "AddEditProductForm";
            this.Load += new System.EventHandler(this.AddEditProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private new System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductPrice;
    }
}