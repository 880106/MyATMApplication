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
    public partial class Balance : Form
    {
        private readonly string accountNumber;
        public Balance(string accountNumber)
        {
            InitializeComponent();
            this.accountNumber = accountNumber;
        }
        public string AccountNumber { get; set; }

        BusinessLogicLayerClass dal = new BusinessLogicLayerClass();
        private void Balance_Load(object sender, EventArgs e)
        {
            //  lblAccNumber.Text = accountNumber;
            lblAccNumber.Text = Home.AccNumber;

            decimal balance = dal.GetBalance(int.Parse(lblAccNumber.Text));
            lblBalance.Text = $"{balance:C}";
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

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
