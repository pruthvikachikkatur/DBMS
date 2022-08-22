using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace NavyManagementSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myconn = new MySqlConnection("server=localhost;User Id=root; password=root;database=navy");
            int i;


            i = 0;
            myconn.Open();
            MySqlCommand cmd = myconn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from navy.soilder where s_id ='" + textBox1.Text + "' and passwd='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Incorrect username or password");
            }
           
            myconn.Close();
            Form7 a = new Form7();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }
    }
}
