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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String a = textBox1.Text;
            String b = textBox2.Text;
            String c = textBox3.Text;
            String d = textBox4.Text;
            String g = textBox5.Text;
            String f = textBox6.Text;
            MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=navy");

            string query = "insert into navy.soilder values('" + a + "','" + b + "','" + d + "','" + c + "','" + g  + "','" + f + "')";

            try
            {
                sqlp.Open();
                MySqlCommand cmd = new MySqlCommand(query, sqlp);
                cmd.ExecuteNonQuery();
                sqlp.Close();
                MessageBox.Show("Added soilder sucessfully");

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
                String str_query = "select * from navy.soilder";
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
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.Show();
            this.Hide();
        }

        
    }
}
