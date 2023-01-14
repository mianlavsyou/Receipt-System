using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace receipt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "*************************************************************\n";
            txtResult.Text += "********************  Fee Receipt System    *****************\n";
            txtResult.Text += "*************************************************************\n";
            txtResult.Text +=  "Date :" + DateTime.Now + "\n\n";
            

            txtResult.Text +=  "First Name:" + txtFirstName.Text + "\n\n";
            txtResult.Text +=  "Midddle Name:" + txtMiddleName.Text + "\n\n";
            txtResult.Text +=  "Last Name:" + txtLastName.Text + "\n\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Print";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            txtResult.SelectAll();
            txtResult.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
