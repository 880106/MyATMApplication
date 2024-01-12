namespace My_ATM_APPLICATION
{
    partial class ChangePin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChange = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtConfirmPin = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtNewPin = new Bunifu.UI.WinForms.BunifuTextBox();
            this.errorProviderNewPin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPin)).BeginInit();
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
            this.panel1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(643, 51);
            this.label8.TabIndex = 6;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Confirm Pin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "New Pin:";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(340, 397);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(122, 22);
            this.lblBack.TabIndex = 33;
            this.lblBack.Text = "Back to Home";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Location = new System.Drawing.Point(-1, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 29);
            this.panel2.TabIndex = 32;
            // 
            // btnChange
            // 
            this.btnChange.ActiveBorderThickness = 1;
            this.btnChange.ActiveCornerRadius = 20;
            this.btnChange.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChange.ActiveForecolor = System.Drawing.Color.White;
            this.btnChange.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnChange.BackColor = System.Drawing.SystemColors.Control;
            this.btnChange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChange.BackgroundImage")));
            this.btnChange.ButtonText = "Change";
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnChange.IdleBorderThickness = 1;
            this.btnChange.IdleCornerRadius = 20;
            this.btnChange.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnChange.IdleForecolor = System.Drawing.Color.Black;
            this.btnChange.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnChange.Location = new System.Drawing.Point(302, 323);
            this.btnChange.Margin = new System.Windows.Forms.Padding(5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(196, 45);
            this.btnChange.TabIndex = 41;
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // txtConfirmPin
            // 
            this.txtConfirmPin.AcceptsReturn = false;
            this.txtConfirmPin.AcceptsTab = false;
            this.txtConfirmPin.AnimationSpeed = 200;
            this.txtConfirmPin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConfirmPin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConfirmPin.AutoSizeHeight = true;
            this.txtConfirmPin.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtConfirmPin.BackgroundImage")));
            this.txtConfirmPin.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtConfirmPin.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtConfirmPin.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtConfirmPin.BorderRadius = 1;
            this.txtConfirmPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtConfirmPin.BorderThickness = 1;
            this.txtConfirmPin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirmPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPin.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtConfirmPin.DefaultText = "";
            this.txtConfirmPin.FillColor = System.Drawing.Color.White;
            this.txtConfirmPin.HideSelection = true;
            this.txtConfirmPin.IconLeft = null;
            this.txtConfirmPin.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPin.IconPadding = 10;
            this.txtConfirmPin.IconRight = null;
            this.txtConfirmPin.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPin.Lines = new string[0];
            this.txtConfirmPin.Location = new System.Drawing.Point(281, 254);
            this.txtConfirmPin.MaxLength = 32767;
            this.txtConfirmPin.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtConfirmPin.Modified = false;
            this.txtConfirmPin.Multiline = false;
            this.txtConfirmPin.Name = "txtConfirmPin";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPin.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPin.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPin.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtConfirmPin.OnIdleState = stateProperties4;
            this.txtConfirmPin.Padding = new System.Windows.Forms.Padding(3);
            this.txtConfirmPin.PasswordChar = '\0';
            this.txtConfirmPin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtConfirmPin.PlaceholderText = "";
            this.txtConfirmPin.ReadOnly = false;
            this.txtConfirmPin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPin.SelectedText = "";
            this.txtConfirmPin.SelectionLength = 0;
            this.txtConfirmPin.SelectionStart = 0;
            this.txtConfirmPin.ShortcutsEnabled = true;
            this.txtConfirmPin.Size = new System.Drawing.Size(241, 34);
            this.txtConfirmPin.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtConfirmPin.TabIndex = 43;
            this.txtConfirmPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPin.TextMarginBottom = 0;
            this.txtConfirmPin.TextMarginLeft = 3;
            this.txtConfirmPin.TextMarginTop = 1;
            this.txtConfirmPin.TextPlaceholder = "";
            this.txtConfirmPin.UseSystemPasswordChar = false;
            this.txtConfirmPin.WordWrap = true;
            // 
            // txtNewPin
            // 
            this.txtNewPin.AcceptsReturn = false;
            this.txtNewPin.AcceptsTab = false;
            this.txtNewPin.AnimationSpeed = 200;
            this.txtNewPin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNewPin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNewPin.AutoSizeHeight = true;
            this.txtNewPin.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNewPin.BackgroundImage")));
            this.txtNewPin.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNewPin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNewPin.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNewPin.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNewPin.BorderRadius = 1;
            this.txtNewPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtNewPin.BorderThickness = 1;
            this.txtNewPin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPin.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtNewPin.DefaultText = "";
            this.txtNewPin.FillColor = System.Drawing.Color.White;
            this.txtNewPin.HideSelection = true;
            this.txtNewPin.IconLeft = null;
            this.txtNewPin.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPin.IconPadding = 10;
            this.txtNewPin.IconRight = null;
            this.txtNewPin.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPin.Lines = new string[0];
            this.txtNewPin.Location = new System.Drawing.Point(281, 182);
            this.txtNewPin.MaxLength = 32767;
            this.txtNewPin.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNewPin.Modified = false;
            this.txtNewPin.Multiline = false;
            this.txtNewPin.Name = "txtNewPin";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPin.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNewPin.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPin.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNewPin.OnIdleState = stateProperties8;
            this.txtNewPin.Padding = new System.Windows.Forms.Padding(3);
            this.txtNewPin.PasswordChar = '\0';
            this.txtNewPin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNewPin.PlaceholderText = "";
            this.txtNewPin.ReadOnly = false;
            this.txtNewPin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPin.SelectedText = "";
            this.txtNewPin.SelectionLength = 0;
            this.txtNewPin.SelectionStart = 0;
            this.txtNewPin.ShortcutsEnabled = true;
            this.txtNewPin.Size = new System.Drawing.Size(241, 34);
            this.txtNewPin.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNewPin.TabIndex = 42;
            this.txtNewPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPin.TextMarginBottom = 0;
            this.txtNewPin.TextMarginLeft = 3;
            this.txtNewPin.TextMarginTop = 1;
            this.txtNewPin.TextPlaceholder = "";
            this.txtNewPin.UseSystemPasswordChar = false;
            this.txtNewPin.WordWrap = true;
            // 
            // errorProviderNewPin
            // 
            this.errorProviderNewPin.ContainerControl = this;
            // 
            // errorProviderConfirmPin
            // 
            this.errorProviderConfirmPin.ContainerControl = this;
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConfirmPin);
            this.Controls.Add(this.txtNewPin);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.Text = "ChangePin";
            this.Load += new System.EventHandler(this.ChangePin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChange;
        private Bunifu.UI.WinForms.BunifuTextBox txtConfirmPin;
        private Bunifu.UI.WinForms.BunifuTextBox txtNewPin;
        private System.Windows.Forms.ErrorProvider errorProviderNewPin;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPin;
    }
}