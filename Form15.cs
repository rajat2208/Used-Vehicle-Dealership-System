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

namespace UCD1
{
    public partial class Form15 : Form
    {
        String reg_no="";
        String c_no = "";
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader mdr;
        public Form15(String s1,String s2)
        {
            this.reg_no = s1;
            this.c_no = s2;
           
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            textBox2.Text = reg_no;
            textBox1.Text = c_no;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String order_no = reg_no + c_no;
            String model="";
            String amt = "";
            String query = "select model,amt from vehicle where reg_no='" + reg_no + "'";
            connection = new MySqlConnection("server=localhost;username=root;database=uvd;password=qwerty1234");
            connection.Open();
            
            cmd = new MySqlCommand(query, connection);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                model = mdr.GetString("model");
                amt = mdr.GetString("amt");
            }

            connection.Close();
            query = "insert into orders(reg_no,model,o_amount,o_date,cust_no) values('" +reg_no + "','"
                + model + "','" + amt + "','" + textBox3.Text + "','" + c_no + "')";
            connection.Open();
            cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
                MessageBox.Show("Order placed");
            connection.Close();
            //query = ""'
            
            new Form1().Visible = true;
            this.Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;username=root;database=uvd;password=qwerty1234");
            connection.Open();
            String query = "Select * from orders";
            cmd = new MySqlCommand(query, connection);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception e1)
            {

            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Visible = true;
            this.Visible = false;
        }
    }
}
