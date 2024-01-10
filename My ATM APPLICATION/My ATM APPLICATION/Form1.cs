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
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();

        }

        int starting = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;

            progressBar1.Value = starting;
            Percentage.Text = " " + starting;

            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login loginform = new Login();
                loginform.Show();
                this.Hide();

            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
