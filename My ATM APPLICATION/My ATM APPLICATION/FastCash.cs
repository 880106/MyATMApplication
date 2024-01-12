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

        private void btn100_Click_1(object sender, EventArgs e)
        {
            // Assuming the button amount is 100
            decimal withdrawalAmount = 100;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {
                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh(); 
            }
        }

        private void btn1000_Click_1(object sender, EventArgs e)
        {
            // Assuming the button amount is 1000
            decimal withdrawalAmount = 1000;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {
                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        private void btn5000_Click_1(object sender, EventArgs e)
        {
            // Assuming the button amount is 5000
            decimal withdrawalAmount = 5000;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {

                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        private void btn500_Click_1(object sender, EventArgs e)
        {
            // Assuming the button amount is 100
            decimal withdrawalAmount = 500;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {

                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

       
 
        private void btn2000_Click_1(object sender, EventArgs e)
        {
            // Assuming the button amount is 2000
            decimal withdrawalAmount = 2000;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {

                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        private void btn10000_Click_1(object sender, EventArgs e)
        {

            // Assuming the button amount is 10 000
            decimal withdrawalAmount = 10000;

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the balance
            string statusMessage;
            if (bll.withDrawal(accNumber, withdrawalAmount, out statusMessage))
            {

                MessageBox.Show(statusMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Transaction Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
             
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
