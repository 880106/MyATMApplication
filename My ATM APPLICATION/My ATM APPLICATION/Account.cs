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
using DevExpress.Blazor.Reporting;

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

        private void btnSIGNUP_Click_1(object sender, EventArgs e)
        {
            ClearAllErrors();
            ErrorProviders();
            if (errorProviderAccNum.GetError(txtAccNum) == "" &&
               errorProviderName.GetError(txtName) == "" &&
               errorProviderSurname.GetError(txtSurname) == "" &&
               errorProviderAddress.GetError(txtAddress) == "" &&
               errorProviderPhone.GetError(txtPhone) == "" &&
               errorProviderPin.GetError(txtPin) == "" &&
               errorProviderBalance.GetError(txtBalance) == "" &&
               errorProviderEducation.GetError(cmbEducation) == "" &&
               errorProviderOccupation.GetError(txtOccupation) == "" &&
               errorProviderDOB.GetError(dtDOB) == "")
            {
                Accounts acc = new Accounts();
                acc.AccNumber = int.Parse(txtAccNum.Text);
                acc.Name = txtName.Text;
                acc.Surname = txtSurname.Text;
                acc.Address = txtAddress.Text;
                acc.Phone = txtPhone.Text;
                acc.Pin = int.Parse(txtPin.Text);
                acc.Balance = decimal.Parse(txtBalance.Text);
                acc.Education = cmbEducation.Text;
                acc.Occupation = txtOccupation.Text;
                acc.DOB = dtDOB.Value.ToString("dd/MM/yyyy");

                int x = bll.AddAccount(acc);

                if (x < 0)
                {
                    MessageBox.Show("Failed to add the account. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Account Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearControls();
                    Login accountAdded = new Login();
                    accountAdded.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please correct the errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearAllErrors()
        {
            errorProviderAccNum.Clear();
            errorProviderName.Clear();
            errorProviderSurname.Clear();
            errorProviderAddress.Clear();
            errorProviderPhone.Clear();
            errorProviderPin.Clear();
            errorProviderBalance.Clear();
            errorProviderEducation.Clear();
            errorProviderOccupation.Clear();
            errorProviderDOB.Clear();
        }

        private void ErrorProviders()
        {
            // Validate input and set error providers accordingly
            if (!int.TryParse(txtAccNum.Text, out int accNumber) || accNumber <= 0)
            {
                errorProviderAccNum.SetError(txtAccNum, "Invalid Account Number.");
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProviderName.SetError(txtName, "Name is required.");
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errorProviderSurname.SetError(txtSurname, "Surname is required.");
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProviderAddress.SetError(txtAddress, "Address is required.");
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProviderPhone.SetError(txtPhone, "Phone is required.");
            }

            if (!int.TryParse(txtPin.Text, out int pin) || pin <= 0)
            {
                errorProviderPin.SetError(txtPin, "Invalid Pin.");
            }

            if (!decimal.TryParse(txtBalance.Text, out decimal balance) || balance < 0)
            {
                errorProviderBalance.SetError(txtBalance, "Invalid Balance.");
            }

            if (string.IsNullOrWhiteSpace(cmbEducation.Text))
            {
                errorProviderEducation.SetError(cmbEducation, "Education is required.");
            }

            if (string.IsNullOrWhiteSpace(txtOccupation.Text))
            {
                errorProviderOccupation.SetError(txtOccupation, "Occupation is required.");
            }

            // Validate Date of Birth
            if (dtDOB.Value.Date > DateTime.Now.Date)
            {
                errorProviderDOB.SetError(dtDOB, "Invalid Date of Birth.");
            }
        }
        // clears the controls
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
            // moves to the the login form
            Login main = new Login();
            main.Show();
            this.Hide();

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            // moves to the the login form
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

    }
}
