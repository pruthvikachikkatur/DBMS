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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String b = textBox2.Text;
            int a = int.Parse(textBox1.Text);
            String c = textBox3.Text;
            MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=navy");

            string query = "insert into navy.ammunition values(" + a + ",'" + b + "','" + c + "')";

            try
            {
                sqlp.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlp);
                cmd.ExecuteNonQuery();
                sqlp.Close();
                MessageBox.Show("Added Ammunation sucessfully");

            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=navy");
                String str_query = "select * from navy.ammunition";
                sql_con.Open();
                MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                DTA.Fill(d);
                sql_con.Close();

            }
            catch (Exception)
            {


            }

            dataGridView1.DataSource = d.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 a=new Form5();
            a.Show();
            this.Hide();
        }
    }
}
