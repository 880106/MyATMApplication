using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace My_ATM_APPLICATION
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        BusinessLogicLayerClass bll = new BusinessLogicLayerClass();
        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void btnSIGNUP_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();

            if (int.TryParse(txtAccNum.Text, out int accNumber) &&
                int.TryParse(txtPin.Text, out int pin) &&
                decimal.TryParse(txtBalance.Text, out decimal balance))
            {
                acc.AccNumber = accNumber;
                acc.Name = txtName.Text;
                acc.Surname = txtSurname.Text;
                acc.Address = txtAddress.Text;
                acc.Phone = txtPhone.Text;
                acc.Pin = pin;
                acc.Balance = balance;
                acc.Education = cmbEducation.Text;
                acc.Occupation = txtOccupation.Text;
                acc.DOB = dtDOB.Value.ToString("dd/MM/yyyy");

                int x = bll.AddAccount(acc);

                if (x < 0)
                {
                    MessageBox.Show($"Account Added. Education: {acc.Education}");
                    clearControls();
                    Login accountAdded = new Login();
                    accountAdded.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to add the account. Please check your input.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values for Account Number, Pin, and Balance.");
            }

        }

        public void clearControls()
        {
            txtAccNum.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtPin.Clear();
            txtBalance.Clear();
            cmbEducation.SelectedIndex = -1; 
            txtOccupation.Clear(); 
            txtAccNum.Focus();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Login main = new Login();
            main.Show();
            this.Hide();

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
           
            Login main = new Login();
            main.Show();
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

      

        private void btnSIGNUP_MouseHover(object sender, EventArgs e)
        {
            btnSIGNUP.BackColor = Color.Green;
        }

        private void btnSIGNUP_MouseLeave(object sender, EventArgs e)
        {
            btnSIGNUP.BackColor = Color.SlateGray;
        }
    }
}
