namespace My_ATM_APPLICATION
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.errorProviderPin = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAccNumber = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPin = new Bunifu.UI.WinForms.BunifuTextBox();
            this.errorProviderAccNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAccNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 127);
            this.panel1.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(763, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 29);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Account number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pin Code:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.Location = new System.Drawing.Point(498, 400);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(78, 22);
            this.lblSignUp.TabIndex = 11;
            this.lblSignUp.Text = "SIGNUP";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            this.lblSignUp.MouseLeave += new System.EventHandler(this.lblSignUp_MouseLeave);
            this.lblSignUp.MouseHover += new System.EventHandler(this.lblSignUp_MouseHover);
            // 
            // errorProviderPin
            // 
            this.errorProviderPin.ContainerControl = this;
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.AcceptsReturn = false;
            this.txtAccNumber.AcceptsTab = false;
            this.txtAccNumber.AnimationSpeed = 200;
            this.txtAccNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAccNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAccNumber.AutoSizeHeight = true;
            this.txtAccNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtAccNumber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAccNumber.BackgroundImage")));
            this.txtAccNumber.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAccNumber.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAccNumber.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAccNumber.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAccNumber.BorderRadius = 1;
            this.txtAccNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAccNumber.BorderThickness = 1;
            this.txtAccNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAccNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccNumber.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtAccNumber.DefaultText = "";
            this.txtAccNumber.FillColor = System.Drawing.Color.White;
            this.txtAccNumber.HideSelection = true;
            this.txtAccNumber.IconLeft = null;
            this.txtAccNumber.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccNumber.IconPadding = 10;
            this.txtAccNumber.IconRight = null;
            this.txtAccNumber.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccNumber.Lines = new string[0];
            this.txtAccNumber.Location = new System.Drawing.Point(423, 227);
            this.txtAccNumber.MaxLength = 10;
            this.txtAccNumber.MinimumSize = new System.Drawing.Size(4, 4);
            this.txtAccNumber.Modified = false;
            this.txtAccNumber.Multiline = false;
            this.txtAccNumber.Name = "txtAccNumber";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAccNumber.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAccNumber.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAccNumber.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAccNumber.OnIdleState = stateProperties8;
            this.txtAccNumber.Padding = new System.Windows.Forms.Padding(3);
            this.txtAccNumber.PasswordChar = '\0';
            this.txtAccNumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAccNumber.PlaceholderText = "";
            this.txtAccNumber.ReadOnly = false;
            this.txtAccNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccNumber.SelectedText = "";
            this.txtAccNumber.SelectionLength = 0;
            this.txtAccNumber.SelectionStart = 0;
            this.txtAccNumber.ShortcutsEnabled = true;
            this.txtAccNumber.Size = new System.Drawing.Size(241, 34);
            this.txtAccNumber.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAccNumber.TabIndex = 59;
            this.txtAccNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAccNumber.TextMarginBottom = 0;
            this.txtAccNumber.TextMarginLeft = 3;
            this.txtAccNumber.TextMarginTop = 1;
            this.txtAccNumber.TextPlaceholder = "";
            this.txtAccNumber.UseSystemPasswordChar = false;
            this.txtAccNumber.WordWrap = true;
            this.txtAccNumber.TextChanged += new System.EventHandler(this.txtAccNumber_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnLogin.IdleForecolor = System.Drawing.Color.Black;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(447, 350);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(196, 45);
            this.btnLogin.TabIndex = 61;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtPin
            // 
            this.txtPin.AcceptsReturn = false;
            this.txtPin.AcceptsTab = false;
            this.txtPin.AnimationSpeed = 200;
            this.txtPin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPin.AutoSizeHeight = true;
            this.txtPin.BackColor = System.Drawing.Color.Transparent;
            this.txtPin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPin.BackgroundImage")));
            this.txtPin.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPin.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPin.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPin.BorderRadius = 1;
            this.txtPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPin.BorderThickness = 1;
            this.txtPin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPin.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPin.DefaultText = "";
            this.txtPin.FillColor = System.Drawing.Color.White;
            this.txtPin.HideSelection = true;
            this.txtPin.IconLeft = null;
            this.txtPin.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPin.IconPadding = 10;
            this.txtPin.IconRight = null;
            this.txtPin.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPin.Lines = new string[0];
            this.txtPin.Location = new System.Drawing.Point(423, 283);
            this.txtPin.MaxLength = 5;
            this.txtPin.MinimumSize = new System.Drawing.Size(4, 4);
            this.txtPin.Modified = false;
            this.txtPin.Multiline = false;
            this.txtPin.Name = "txtPin";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPin.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPin.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPin.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPin.OnIdleState = stateProperties4;
            this.txtPin.Padding = new System.Windows.Forms.Padding(3);
            this.txtPin.PasswordChar = '●';
            this.txtPin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPin.PlaceholderText = "";
            this.txtPin.ReadOnly = false;
            this.txtPin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPin.SelectedText = "";
            this.txtPin.SelectionLength = 0;
            this.txtPin.SelectionStart = 0;
            this.txtPin.ShortcutsEnabled = true;
            this.txtPin.Size = new System.Drawing.Size(241, 34);
            this.txtPin.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPin.TabIndex = 62;
            this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPin.TextMarginBottom = 0;
            this.txtPin.TextMarginLeft = 3;
            this.txtPin.TextMarginTop = 1;
            this.txtPin.TextPlaceholder = "";
            this.txtPin.UseSystemPasswordChar = true;
            this.txtPin.WordWrap = true;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            // 
            // errorProviderAccNumber
            // 
            this.errorProviderAccNumber.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtAccNumber);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAccNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.ErrorProvider errorProviderPin;
        private Bunifu.UI.WinForms.BunifuTextBox txtAccNumber;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.UI.WinForms.BunifuTextBox txtPin;
        private System.Windows.Forms.ErrorProvider errorProviderAccNumber;
    }
}