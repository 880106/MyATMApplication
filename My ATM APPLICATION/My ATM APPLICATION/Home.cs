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

        private void btnDeposit_Click_1(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void btnFastCash_Click_1(object sender, EventArgs e)
        {
            FastCash fast = new FastCash();
            fast.Show();
            this.Hide();
        }

        private void btnChangePin_Click_1(object sender, EventArgs e)
        {
            ChangePin change = new ChangePin();
            change.Show();
            this.Hide();
        }

        private void btnWithDraw_Click_1(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void btnMiniStatement_Click_1(object sender, EventArgs e)
        {
            miniStatement mini = new miniStatement();
            mini.Show();
            this.Hide();
        }

        private void btnBalance_Click_1(object sender, EventArgs e)
        {
            Balance balance = new Balance(lblAccNumber.Text);
            balance.Show();
            this.Hide();
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
