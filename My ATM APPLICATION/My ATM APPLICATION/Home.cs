using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_ATM_APPLICATION
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
       // public string AccountNumber { get; set; }
        public static String AccNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            lblAccNumber.Text = "Account Number: " + Login.AccNumber;
            AccNumber= Login.AccNumber;
             
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void btnDeposit_MouseHover(object sender, EventArgs e)
        {
            btnDeposit.BackColor = Color.Green;
        }
        private void btnDeposit_MouseLeave(object sender, EventArgs e)
        {
            btnDeposit.BackColor = Color.SlateGray;
        }
        private void btnFastCash_Click(object sender, EventArgs e)
        {
            FastCash fast = new FastCash();
            fast.Show();
            this.Hide();
        }
        private void btnFastCash_MouseHover(object sender, EventArgs e)
        {
            btnFastCash.BackColor = Color.Green;
        }

        private void btnFastCash_MouseLeave(object sender, EventArgs e)
        {
            btnFastCash.BackColor = Color.SlateGray;
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            ChangePin change = new ChangePin();
            change.Show();
            this.Hide();
        }
        private void btnChangePin_MouseHover(object sender, EventArgs e)
        {
            btnChangePin.BackColor = Color.Green;
        }

        private void btnChangePin_MouseLeave(object sender, EventArgs e)
        {
            btnChangePin.BackColor = Color.SlateGray;
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }
        private void btnWithDraw_MouseHover(object sender, EventArgs e)
        {
            btnWithDraw.BackColor = Color.Green;
        }

        private void btnWithDraw_MouseLeave(object sender, EventArgs e)
        {
            btnWithDraw.BackColor = Color.SlateGray;
        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
            miniStatement mini = new miniStatement();
            mini.Show();
            this.Hide();
        }
        private void btnMiniStatement_MouseHover(object sender, EventArgs e)
        {
            btnMiniStatement.BackColor = Color.Green;
        }

        private void btnMiniStatement_MouseLeave(object sender, EventArgs e)
        {
            btnMiniStatement.BackColor = Color.SlateGray;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance(lblAccNumber.Text);
            balance.Show();
            this.Hide();
        }
        private void btnBalance_MouseHover(object sender, EventArgs e)
        {
            btnBalance.BackColor = Color.Green;
        }

        private void btnBalance_MouseLeave(object sender, EventArgs e)
        {
            btnBalance.BackColor = Color.SlateGray;
        }
        private void lblLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lblLogout_MouseHover(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.Red;
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.Black;
        }

        
    }
}
