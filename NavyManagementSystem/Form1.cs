using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NavyManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "navy123") && (textBox1.Text == "navy"))
            {
                Form2 a = new Form2();
                a.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid User name or Password");
            }


        }
    }
}
