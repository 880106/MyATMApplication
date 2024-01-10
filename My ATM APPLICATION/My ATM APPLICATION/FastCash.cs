using BusinessLogicLayer;
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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        BusinessLogicLayerClass bll = new BusinessLogicLayerClass();
        private void label3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Red;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            // Assuming the button amount is 100
            decimal withdrawalAmount = 100;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {
                MessageBox.Show(statusMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
               
            }
            else
            {
                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn100_MouseHover(object sender, EventArgs e)
        {
            btn100.BackColor = Color.Green;
        }

        private void btn100_MouseLeave(object sender, EventArgs e)
        {
            btn100.BackColor = Color.SlateGray;
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            // Assuming the button amount is 100
            decimal withdrawalAmount = 1000;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {
                MessageBox.Show(statusMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
               
            }
            else
            {
                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn1000_MouseHover(object sender, EventArgs e)
        {
            btn1000.BackColor = Color.Green;
        }

        private void btn1000_MouseLeave(object sender, EventArgs e)
        {
            btn1000.BackColor = Color.SlateGray;
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            // Assuming the button amount is 100
            decimal withdrawalAmount = 5000;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {
                MessageBox.Show(statusMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
              
            }
            else
            {
                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn5000_MouseHover(object sender, EventArgs e)
        {
            btn5000.BackColor = Color.Green;
        }

        private void btn5000_MouseLeave(object sender, EventArgs e)
        {
            btn5000.BackColor = Color.SlateGray;
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            // Assuming the button amount is 100
            decimal withdrawalAmount = 500;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {
                MessageBox.Show(statusMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                
            }
            else
            {
                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn500_MouseHover(object sender, EventArgs e)
        {
            btn500.BackColor = Color.Green;
        }

        private void btn500_MouseLeave(object sender, EventArgs e)
        {
            btn500.BackColor = Color.SlateGray;
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            // Assuming the button amount is 100
            decimal withdrawalAmount = 2000;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {

                MessageBox.Show(statusMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();

            }
            else
            {
                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn2000_MouseHover(object sender, EventArgs e)
        {
            btn2000.BackColor = Color.Green;
        }

        private void btn2000_MouseLeave(object sender, EventArgs e)
        {
            btn2000.BackColor = Color.SlateGray;
        }

        private void btn10000_MouseHover(object sender, EventArgs e)
        {
            btn10000.BackColor = Color.Green;
        }

        private void btn10000_MouseLeave(object sender, EventArgs e)
        {
            btn10000.BackColor = Color.SlateGray;
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            // Assuming the button amount is 100
            decimal withdrawalAmount = 10000;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {
                MessageBox.Show(statusMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
               
            }
            else
            {
                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refresh()
        {
            lblBalance.Text = Home.AccNumber;

            decimal balance = bll.GetBalance(int.Parse(lblBalance.Text));
            lblBalance.Text = $"{balance:C}";
        }

    }
}
