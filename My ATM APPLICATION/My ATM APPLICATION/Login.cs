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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BusinessLogicLayerClass bll = new BusinessLogicLayerClass();
        // public string AccountNumber { get; set; }
        public static String AccNumber;
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            errorProviderAccNumber.Clear();
            errorProviderPin.Clear();

            
            if (!int.TryParse(txtAccNumber.Text, out int accNumber))
            {
                
                errorProviderAccNumber.SetError(txtAccNumber, "Invalid input. Please enter a valid number for Account Number.");
                return;
            }

           
            if (!int.TryParse(txtPin.Text, out int pin))
            {
                
                errorProviderPin.SetError(txtPin, "Invalid input. Please enter a valid number for PIN.");
                return;
            }

          

            if (bll.ValidateLogin(accNumber, pin))
            {
                AccNumber = txtAccNumber.Text;
                Home homeForm = new Home();
                //homeForm.AccountNumber = txtAccNumber.Text;
                homeForm.Show();
                this.Hide();
            }
            else
            {
             
                MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSignUp_MouseHover(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.Red;
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            lblSignUp.ForeColor = Color.Black;
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

       

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Green;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.SlateGray;
        }

        private void errorProviderAccNumber_RightToLeftChanged(object sender, EventArgs e)
        {

        }
    }
}
