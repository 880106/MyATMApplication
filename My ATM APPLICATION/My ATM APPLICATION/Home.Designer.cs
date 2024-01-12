namespace My_ATM_APPLICATION
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeposit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnFastCash = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChangePin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnWithDraw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMiniStatement = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBalance = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 127);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 51);
            this.label8.TabIndex = 7;
            this.label8.Text = "Select Transaction";
            // 
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNumber.Location = new System.Drawing.Point(280, 167);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(238, 32);
            this.lblAccNumber.TabIndex = 2;
            this.lblAccNumber.Text = "Account Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Location = new System.Drawing.Point(1, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 29);
            this.panel2.TabIndex = 6;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(334, 397);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(65, 22);
            this.lblLogout.TabIndex = 17;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            this.lblLogout.MouseHover += new System.EventHandler(this.lblLogout_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 54;
            this.label5.Text = "Home";
            // 
            // btnDeposit
            // 
            this.btnDeposit.ActiveBorderThickness = 1;
            this.btnDeposit.ActiveCornerRadius = 20;
            this.btnDeposit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeposit.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeposit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeposit.BackgroundImage")));
            this.btnDeposit.ButtonText = "Deposit";
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.IdleBorderThickness = 1;
            this.btnDeposit.IdleCornerRadius = 20;
            this.btnDeposit.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnDeposit.IdleForecolor = System.Drawing.Color.Black;
            this.btnDeposit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.Location = new System.Drawing.Point(68, 204);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(196, 45);
            this.btnDeposit.TabIndex = 55;
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click_1);
            // 
            // btnFastCash
            // 
            this.btnFastCash.ActiveBorderThickness = 1;
            this.btnFastCash.ActiveCornerRadius = 20;
            this.btnFastCash.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFastCash.ActiveForecolor = System.Drawing.Color.White;
            this.btnFastCash.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFastCash.BackColor = System.Drawing.SystemColors.Control;
            this.btnFastCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFastCash.BackgroundImage")));
            this.btnFastCash.ButtonText = "FastCash";
            this.btnFastCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFastCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastCash.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFastCash.IdleBorderThickness = 1;
            this.btnFastCash.IdleCornerRadius = 20;
            this.btnFastCash.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnFastCash.IdleForecolor = System.Drawing.Color.Black;
            this.btnFastCash.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnFastCash.Location = new System.Drawing.Point(68, 273);
            this.btnFastCash.Margin = new System.Windows.Forms.Padding(5);
            this.btnFastCash.Name = "btnFastCash";
            this.btnFastCash.Size = new System.Drawing.Size(196, 45);
            this.btnFastCash.TabIndex = 56;
            this.btnFastCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFastCash.Click += new System.EventHandler(this.btnFastCash_Click_1);
            // 
            // btnChangePin
            // 
            this.btnChangePin.ActiveBorderThickness = 1;
            this.btnChangePin.ActiveCornerRadius = 20;
            this.btnChangePin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChangePin.ActiveForecolor = System.Drawing.Color.White;
            this.btnChangePin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnChangePin.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangePin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePin.BackgroundImage")));
            this.btnChangePin.ButtonText = "Change Pin";
            this.btnChangePin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnChangePin.IdleBorderThickness = 1;
            this.btnChangePin.IdleCornerRadius = 20;
            this.btnChangePin.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnChangePin.IdleForecolor = System.Drawing.Color.Black;
            this.btnChangePin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnChangePin.Location = new System.Drawing.Point(68, 339);
            this.btnChangePin.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(196, 45);
            this.btnChangePin.TabIndex = 57;
            this.btnChangePin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePin_Click_1);
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.ActiveBorderThickness = 1;
            this.btnWithDraw.ActiveCornerRadius = 20;
            this.btnWithDraw.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnWithDraw.ActiveForecolor = System.Drawing.Color.White;
            this.btnWithDraw.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnWithDraw.BackColor = System.Drawing.SystemColors.Control;
            this.btnWithDraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWithDraw.BackgroundImage")));
            this.btnWithDraw.ButtonText = "With Draw";
            this.btnWithDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithDraw.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnWithDraw.IdleBorderThickness = 1;
            this.btnWithDraw.IdleCornerRadius = 20;
            this.btnWithDraw.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnWithDraw.IdleForecolor = System.Drawing.Color.Black;
            this.btnWithDraw.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnWithDraw.Location = new System.Drawing.Point(518, 204);
            this.btnWithDraw.Margin = new System.Windows.Forms.Padding(5);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(196, 45);
            this.btnWithDraw.TabIndex = 58;
            this.btnWithDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click_1);
            // 
            // btnMiniStatement
            // 
            this.btnMiniStatement.ActiveBorderThickness = 1;
            this.btnMiniStatement.ActiveCornerRadius = 20;
            this.btnMiniStatement.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMiniStatement.ActiveForecolor = System.Drawing.Color.White;
            this.btnMiniStatement.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMiniStatement.BackColor = System.Drawing.SystemColors.Control;
            this.btnMiniStatement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMiniStatement.BackgroundImage")));
            this.btnMiniStatement.ButtonText = "Mini Statement";
            this.btnMiniStatement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiniStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniStatement.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMiniStatement.IdleBorderThickness = 1;
            this.btnMiniStatement.IdleCornerRadius = 20;
            this.btnMiniStatement.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnMiniStatement.IdleForecolor = System.Drawing.Color.Black;
            this.btnMiniStatement.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnMiniStatement.Location = new System.Drawing.Point(518, 273);
            this.btnMiniStatement.Margin = new System.Windows.Forms.Padding(5);
            this.btnMiniStatement.Name = "btnMiniStatement";
            this.btnMiniStatement.Size = new System.Drawing.Size(196, 45);
            this.btnMiniStatement.TabIndex = 59;
            this.btnMiniStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMiniStatement.Click += new System.EventHandler(this.btnMiniStatement_Click_1);
            // 
            // btnBalance
            // 
            this.btnBalance.ActiveBorderThickness = 1;
            this.btnBalance.ActiveCornerRadius = 20;
            this.btnBalance.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBalance.ActiveForecolor = System.Drawing.Color.White;
            this.btnBalance.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBalance.BackColor = System.Drawing.SystemColors.Control;
            this.btnBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBalance.BackgroundImage")));
            this.btnBalance.ButtonText = "Balance";
            this.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBalance.IdleBorderThickness = 1;
            this.btnBalance.IdleCornerRadius = 20;
            this.btnBalance.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnBalance.IdleForecolor = System.Drawing.Color.Black;
            this.btnBalance.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBalance.Location = new System.Drawing.Point(518, 339);
            this.btnBalance.Margin = new System.Windows.Forms.Padding(5);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(196, 45);
            this.btnBalance.TabIndex = 60;
            this.btnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnMiniStatement);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.btnChangePin);
            this.Controls.Add(this.btnFastCash);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAccNumber);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeposit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFastCash;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChangePin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnWithDraw;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMiniStatement;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBalance;
    }
}