namespace My_ATM_APPLICATION
{
    partial class FastCash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastCash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn100 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn1000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn5000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn500 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn2000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn10000 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 127);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(643, 51);
            this.label8.TabIndex = 7;
            this.label8.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Your Transaction Please";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(318, 397);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(122, 22);
            this.lblBack.TabIndex = 26;
            this.lblBack.Text = "Back to Home";
            this.lblBack.Click += new System.EventHandler(this.label3_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Location = new System.Drawing.Point(-1, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 29);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "Fast Cash";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(467, 159);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(97, 29);
            this.lblBalance.TabIndex = 59;
            this.lblBalance.Text = "xxxxxxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 58;
            this.label2.Text = " Available balance:";
            // 
            // btn100
            // 
            this.btn100.ActiveBorderThickness = 1;
            this.btn100.ActiveCornerRadius = 20;
            this.btn100.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn100.ActiveForecolor = System.Drawing.Color.White;
            this.btn100.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn100.BackColor = System.Drawing.SystemColors.Control;
            this.btn100.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn100.BackgroundImage")));
            this.btn100.ButtonText = "R 100";
            this.btn100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn100.IdleBorderThickness = 1;
            this.btn100.IdleCornerRadius = 20;
            this.btn100.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btn100.IdleForecolor = System.Drawing.Color.Black;
            this.btn100.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn100.Location = new System.Drawing.Point(21, 191);
            this.btn100.Margin = new System.Windows.Forms.Padding(5);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(196, 45);
            this.btn100.TabIndex = 60;
            this.btn100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn100.Click += new System.EventHandler(this.btn100_Click_1);
            // 
            // btn1000
            // 
            this.btn1000.ActiveBorderThickness = 1;
            this.btn1000.ActiveCornerRadius = 20;
            this.btn1000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn1000.ActiveForecolor = System.Drawing.Color.White;
            this.btn1000.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn1000.BackColor = System.Drawing.SystemColors.Control;
            this.btn1000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1000.BackgroundImage")));
            this.btn1000.ButtonText = "R 1000";
            this.btn1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn1000.IdleBorderThickness = 1;
            this.btn1000.IdleCornerRadius = 20;
            this.btn1000.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btn1000.IdleForecolor = System.Drawing.Color.Black;
            this.btn1000.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn1000.Location = new System.Drawing.Point(21, 254);
            this.btn1000.Margin = new System.Windows.Forms.Padding(5);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(196, 45);
            this.btn1000.TabIndex = 61;
            this.btn1000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click_1);
            // 
            // btn5000
            // 
            this.btn5000.ActiveBorderThickness = 1;
            this.btn5000.ActiveCornerRadius = 20;
            this.btn5000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn5000.ActiveForecolor = System.Drawing.Color.White;
            this.btn5000.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn5000.BackColor = System.Drawing.SystemColors.Control;
            this.btn5000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5000.BackgroundImage")));
            this.btn5000.ButtonText = "R 5000";
            this.btn5000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5000.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn5000.IdleBorderThickness = 1;
            this.btn5000.IdleCornerRadius = 20;
            this.btn5000.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btn5000.IdleForecolor = System.Drawing.Color.Black;
            this.btn5000.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn5000.Location = new System.Drawing.Point(21, 318);
            this.btn5000.Margin = new System.Windows.Forms.Padding(5);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(196, 45);
            this.btn5000.TabIndex = 62;
            this.btn5000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn5000.Click += new System.EventHandler(this.btn5000_Click_1);
            // 
            // btn500
            // 
            this.btn500.ActiveBorderThickness = 1;
            this.btn500.ActiveCornerRadius = 20;
            this.btn500.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn500.ActiveForecolor = System.Drawing.Color.White;
            this.btn500.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn500.BackColor = System.Drawing.SystemColors.Control;
            this.btn500.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn500.BackgroundImage")));
            this.btn500.ButtonText = "R 500";
            this.btn500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn500.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn500.IdleBorderThickness = 1;
            this.btn500.IdleCornerRadius = 20;
            this.btn500.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btn500.IdleForecolor = System.Drawing.Color.Black;
            this.btn500.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn500.Location = new System.Drawing.Point(572, 191);
            this.btn500.Margin = new System.Windows.Forms.Padding(5);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(196, 45);
            this.btn500.TabIndex = 63;
            this.btn500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn500.Click += new System.EventHandler(this.btn500_Click_1);
            // 
            // btn2000
            // 
            this.btn2000.ActiveBorderThickness = 1;
            this.btn2000.ActiveCornerRadius = 20;
            this.btn2000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn2000.ActiveForecolor = System.Drawing.Color.White;
            this.btn2000.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn2000.BackColor = System.Drawing.SystemColors.Control;
            this.btn2000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2000.BackgroundImage")));
            this.btn2000.ButtonText = "R 2000";
            this.btn2000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2000.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn2000.IdleBorderThickness = 1;
            this.btn2000.IdleCornerRadius = 20;
            this.btn2000.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btn2000.IdleForecolor = System.Drawing.Color.Black;
            this.btn2000.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn2000.Location = new System.Drawing.Point(571, 254);
            this.btn2000.Margin = new System.Windows.Forms.Padding(5);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(196, 45);
            this.btn2000.TabIndex = 64;
            this.btn2000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2000.Click += new System.EventHandler(this.btn2000_Click_1);
            // 
            // btn10000
            // 
            this.btn10000.ActiveBorderThickness = 1;
            this.btn10000.ActiveCornerRadius = 20;
            this.btn10000.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn10000.ActiveForecolor = System.Drawing.Color.White;
            this.btn10000.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn10000.BackColor = System.Drawing.SystemColors.Control;
            this.btn10000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn10000.BackgroundImage")));
            this.btn10000.ButtonText = "R 10 000";
            this.btn10000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10000.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn10000.IdleBorderThickness = 1;
            this.btn10000.IdleCornerRadius = 20;
            this.btn10000.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btn10000.IdleForecolor = System.Drawing.Color.Black;
            this.btn10000.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn10000.Location = new System.Drawing.Point(571, 318);
            this.btn10000.Margin = new System.Windows.Forms.Padding(5);
            this.btn10000.Name = "btn10000";
            this.btn10000.Size = new System.Drawing.Size(196, 45);
            this.btn10000.TabIndex = 65;
            this.btn10000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn10000.Click += new System.EventHandler(this.btn10000_Click_1);
            // 
            // FastCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn10000);
            this.Controls.Add(this.btn2000);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btn5000);
            this.Controls.Add(this.btn1000);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastCash";
            this.Text = "FastCash";
            this.Load += new System.EventHandler(this.FastCash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn100;
        private Bunifu.Framework.UI.BunifuThinButton2 btn1000;
        private Bunifu.Framework.UI.BunifuThinButton2 btn5000;
        private Bunifu.Framework.UI.BunifuThinButton2 btn500;
        private Bunifu.Framework.UI.BunifuThinButton2 btn2000;
        private Bunifu.Framework.UI.BunifuThinButton2 btn10000;
    }
}