using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;

namespace My_ATM_APPLICATION
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        BusinessLogicLayerClass bll = new BusinessLogicLayerClass();
        private void ChangePin_Load(object sender, EventArgs e)
        {

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

        private void btnChange_Click(object sender, EventArgs e)
        {
            // Validate and parse the new PIN and confirmation
            if (!int.TryParse(txtNewPin.Text, out int newPin) || !int.TryParse(txtConfirmPin.Text, out int confirmPin))
            {
                MessageBox.Show("Invalid PIN input. Please enter valid PIN numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the new PIN matches the confirmation
            if (newPin != confirmPin)
            {
                MessageBox.Show("PINs do not match. Please enter matching PINs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return;
            }

            // Get the account number from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to update the PIN
            if (bll.UpdatePin(accNumber, newPin))
            {
                MessageBox.Show("PIN update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("PIN update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnChange.BackColor = Color.Green;
        }

        private void btnChange_MouseLeave(object sender, EventArgs e)
        {
            btnChange.BackColor = Color.SlateGray;
        }

        private void Clear()
        {
            txtNewPin.Clear();
            txtConfirmPin.Clear();
        }
    }
}
