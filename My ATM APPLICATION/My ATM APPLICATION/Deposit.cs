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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        BusinessLogicLayerClass bll = new BusinessLogicLayerClass();

        private void btnChange_Click(object sender, EventArgs e)
        {

            // Validate and parse the deposit amount
            if (!decimal.TryParse(txtAmount.Text, out decimal depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Invalid deposit amount. Please enter a valid positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Calling business logic layer to update the balance
            if (bll.DepositAmount(accNumber, depositAmount))
            {
                MessageBox.Show("Deposit failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Deposit successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
                Balance bal = new Balance(accNumber.ToString());
                bal.Show();
                this.Hide();

            }
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Red;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }
       
    }
}
