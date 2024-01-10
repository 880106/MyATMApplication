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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.btnFastCash = new System.Windows.Forms.Button();
            this.btnMiniStatement = new System.Windows.Forms.Button();
            this.btnChangePin = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNumber.Location = new System.Drawing.Point(263, 147);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(238, 32);
            this.lblAccNumber.TabIndex = 2;
            this.lblAccNumber.Text = "Account Number";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.SlateGray;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeposit.Location = new System.Drawing.Point(81, 191);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(164, 40);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            this.btnDeposit.MouseLeave += new System.EventHandler(this.btnDeposit_MouseLeave);
            this.btnDeposit.MouseHover += new System.EventHandler(this.btnDeposit_MouseHover);
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.BackColor = System.Drawing.Color.SlateGray;
            this.btnWithDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithDraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWithDraw.Location = new System.Drawing.Point(518, 191);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(164, 40);
            this.btnWithDraw.TabIndex = 12;
            this.btnWithDraw.Text = "WITHDRAW";
            this.btnWithDraw.UseVisualStyleBackColor = false;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            this.btnWithDraw.MouseLeave += new System.EventHandler(this.btnWithDraw_MouseLeave);
            this.btnWithDraw.MouseHover += new System.EventHandler(this.btnWithDraw_MouseHover);
            // 
            // btnFastCash
            // 
            this.btnFastCash.BackColor = System.Drawing.Color.SlateGray;
            this.btnFastCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastCash.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFastCash.Location = new System.Drawing.Point(81, 254);
            this.btnFastCash.Name = "btnFastCash";
            this.btnFastCash.Size = new System.Drawing.Size(164, 40);
            this.btnFastCash.TabIndex = 13;
            this.btnFastCash.Text = "FAST CASH";
            this.btnFastCash.UseVisualStyleBackColor = false;
            this.btnFastCash.Click += new System.EventHandler(this.btnFastCash_Click);
            this.btnFastCash.MouseLeave += new System.EventHandler(this.btnFastCash_MouseLeave);
            this.btnFastCash.MouseHover += new System.EventHandler(this.btnFastCash_MouseHover);
            // 
            // btnMiniStatement
            // 
            this.btnMiniStatement.BackColor = System.Drawing.Color.SlateGray;
            this.btnMiniStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniStatement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMiniStatement.Location = new System.Drawing.Point(518, 254);
            this.btnMiniStatement.Name = "btnMiniStatement";
            this.btnMiniStatement.Size = new System.Drawing.Size(164, 40);
            this.btnMiniStatement.TabIndex = 14;
            this.btnMiniStatement.Text = "MINI STATEMENT";
            this.btnMiniStatement.UseVisualStyleBackColor = false;
            this.btnMiniStatement.Click += new System.EventHandler(this.btnMiniStatement_Click);
            this.btnMiniStatement.MouseLeave += new System.EventHandler(this.btnMiniStatement_MouseLeave);
            this.btnMiniStatement.MouseHover += new System.EventHandler(this.btnMiniStatement_MouseHover);
            // 
            // btnChangePin
            // 
            this.btnChangePin.BackColor = System.Drawing.Color.SlateGray;
            this.btnChangePin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangePin.Location = new System.Drawing.Point(81, 318);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(164, 40);
            this.btnChangePin.TabIndex = 15;
            this.btnChangePin.Text = "CHANGE PIN";
            this.btnChangePin.UseVisualStyleBackColor = false;
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePin_Click);
            this.btnChangePin.MouseLeave += new System.EventHandler(this.btnChangePin_MouseLeave);
            this.btnChangePin.MouseHover += new System.EventHandler(this.btnChangePin_MouseHover);
            // 
            // btnBalance
            // 
            this.btnBalance.BackColor = System.Drawing.Color.SlateGray;
            this.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBalance.Location = new System.Drawing.Point(518, 318);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(164, 40);
            this.btnBalance.TabIndex = 16;
            this.btnBalance.Text = "BALANCE";
            this.btnBalance.UseVisualStyleBackColor = false;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            this.btnBalance.MouseLeave += new System.EventHandler(this.btnBalance_MouseLeave);
            this.btnBalance.MouseHover += new System.EventHandler(this.btnBalance_MouseHover);
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
            this.label5.Location = new System.Drawing.Point(333, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 54;
            this.label5.Text = "Home";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(162, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 51);
            this.label8.TabIndex = 7;
            this.label8.Text = "Select Transaction";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAccNumber);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnChangePin);
            this.Controls.Add(this.btnMiniStatement);
            this.Controls.Add(this.btnFastCash);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.btnDeposit);
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
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Button btnFastCash;
        private System.Windows.Forms.Button btnMiniStatement;
        private System.Windows.Forms.Button btnChangePin;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}