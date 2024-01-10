namespace My_ATM_APPLICATION
{
    partial class miniStatement
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
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMiniStatement = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiniStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 99);
            this.panel1.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(643, 51);
            this.label8.TabIndex = 7;
            this.label8.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "MINI STATEMENT";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(319, 397);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(122, 22);
            this.lblBack.TabIndex = 51;
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
            this.panel2.TabIndex = 50;
            // 
            // dgvMiniStatement
            // 
            this.dgvMiniStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiniStatement.Location = new System.Drawing.Point(4, 134);
            this.dgvMiniStatement.Name = "dgvMiniStatement";
            this.dgvMiniStatement.RowHeadersWidth = 51;
            this.dgvMiniStatement.RowTemplate.Height = 24;
            this.dgvMiniStatement.Size = new System.Drawing.Size(784, 260);
            this.dgvMiniStatement.TabIndex = 54;
            this.dgvMiniStatement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // miniStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMiniStatement);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "miniStatement";
            this.Text = "miniStatement";
            this.Load += new System.EventHandler(this.miniStatement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiniStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMiniStatement;
    }
}