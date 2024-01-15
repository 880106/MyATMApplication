using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                int accNumber = int.Parse(txtAccNum.Text);

                // Check if the account number already exists
                if (bll.IsAccountNumberUnique(accNumber))
                {
                    // Account number is unique, proceed to add the new account
                    Accounts acc = new Accounts();
                    acc.AccNumber = accNumber;
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
                        MessageBox.Show("Account Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearControls();
                        Login accountAdded = new Login();
                        accountAdded.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the account. Please check your input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Account with this number already exists. Please choose a different account number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            errorProviderPhone.Clear();

            const string phonePattern = @"^\d{3}\s?\d{3}\s?\d{4}$";
            const string errorMessage = "Invalid phone number. Please enter a number in the format 'XXX XXX XXXX'.";

            string phoneNumber = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(phoneNumber))
            {
                // Clear the error if the textbox is empty
                return;
            }

            if (IsValidPhoneNumber(phoneNumber, phonePattern))
            {
                errorProviderPhone.Clear(); // Clear the error if the phone number is valid
            }
            else
            {
                errorProviderPhone.SetError(txtPhone, errorMessage);
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber, string pattern)
        {
            return Regex.IsMatch(phoneNumber, pattern);
        }
        

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            errorProviderPin.Clear();

            const string pinPattern = @"^\d{5}$";
            const string errorMessage = "Invalid PIN. Please enter a 5-digit PIN.";

            if (string.IsNullOrWhiteSpace(txtPin.Text))
            {
                // Clear the error if the textbox is empty
                return;
            }

            if (IsValidPin(txtPin.Text, pinPattern))
            {
                errorProviderPin.Clear(); // Clear the error if the PIN is valid
            }
            else
            {
                errorProviderPin.SetError(txtPin, errorMessage);
            }
        }

        private bool IsValidPin(string pin, string pattern)
        {
            return Regex.IsMatch(pin, pattern);
        }

        private void txtAccNum_TextChanged(object sender, EventArgs e)
        {


            errorProviderAccNum.Clear();

            const string accPattern = @"^\d{10}$";
            const string errorMessage = "Invalid Account. Please enter a 10-digit Account Number.";
            const string errorMessage1 = "Invalid Account.Account with this number already exists. Please choose a different account number.";
            if (string.IsNullOrWhiteSpace(txtAccNum.Text))
            {
                // Clear the error if the textbox is empty
                return;
            }

            int accNumber;
            if (int.TryParse(txtAccNum.Text, out accNumber))
            {
                if (IsValidAccountNum(txtAccNum.Text, accPattern) && bll.IsAccountNumberUnique(accNumber))
                {
                    errorProviderAccNum.Clear(); // Clear the error if the Account Number is valid and unique
                }
                else
                {
                    errorProviderAccNum.SetError(txtAccNum, errorMessage1);
                }
            }
            else
            {
                errorProviderAccNum.SetError(txtAccNum, errorMessage);
            }
        }

        private bool IsValidAccountNum(string account, string pattern)
        {
            return Regex.IsMatch(account, pattern);
        }

    }
}
