using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UCD1
{
    public partial class Form7 : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader mdr;
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;username=root;database=uvd;password=qwerty1234");
            connection.Open();
            String query = "insert into worker(name,phone,address,w_no,password) values('" + textBox1.Text + "','"
                + textBox2.Text+"','"+textBox4.Text +"','"+ textBox5.Text + "','"+ textBox6.Text+"')";
            cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Worker registered successfully!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form6().Visible = true;
            this.Dispose();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
