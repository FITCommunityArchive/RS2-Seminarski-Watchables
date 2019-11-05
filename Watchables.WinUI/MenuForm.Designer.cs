namespace Watchables.WinUI
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            this.ShowDashboardBtn = new System.Windows.Forms.Button();
            this.ShowCinemasBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowDashboardBtn
            // 
            this.ShowDashboardBtn.BackColor = System.Drawing.Color.White;
            this.ShowDashboardBtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDashboardBtn.Location = new System.Drawing.Point(-9, 96);
            this.ShowDashboardBtn.Name = "ShowDashboardBtn";
            this.ShowDashboardBtn.Size = new System.Drawing.Size(407, 72);
            this.ShowDashboardBtn.TabIndex = 0;
            this.ShowDashboardBtn.Text = "Dashboard";
            this.ShowDashboardBtn.UseVisualStyleBackColor = false;
            this.ShowDashboardBtn.Click += new System.EventHandler(this.ShowDashboardBtn_Click);
            // 
            // ShowCinemasBtn
            // 
            this.ShowCinemasBtn.BackColor = System.Drawing.Color.White;
            this.ShowCinemasBtn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCinemasBtn.Location = new System.Drawing.Point(-9, 174);
            this.ShowCinemasBtn.Name = "ShowCinemasBtn";
            this.ShowCinemasBtn.Size = new System.Drawing.Size(407, 69);
            this.ShowCinemasBtn.TabIndex = 1;
            this.ShowCinemasBtn.Text = "Cinemas";
            this.ShowCinemasBtn.UseVisualStyleBackColor = false;
            this.ShowCinemasBtn.Click += new System.EventHandler(this.ShowCinemasBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ShowCinemasBtn);
            this.panel1.Controls.Add(this.ShowDashboardBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 558);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Watchables";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuForm";
            this.Text = "Watchables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button ShowDashboardBtn;
        private System.Windows.Forms.Button ShowCinemasBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label1;
    }
}



