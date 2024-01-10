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
    public partial class miniStatement : Form
    {
        public miniStatement()
        {
            InitializeComponent();
        }
        private BusinessLogicLayerClass bll = new BusinessLogicLayerClass();

        private void lblBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void miniStatement_Load(object sender, EventArgs e)
        {
            // Get the AccNumber from the Home form
            int accNumber = int.Parse(Home.AccNumber);

            // Call your business logic layer to get transactions
            DataTable transactionTable = bll.GetTransactionsByAccNumber1(accNumber);

            // Set the DataGridView's DataSource to the transactions DataTable
            dgvMiniStatement.DataSource = transactionTable;
        }

        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Red;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
