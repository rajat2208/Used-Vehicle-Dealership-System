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
    public partial class Form10 : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader mdr;
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form11().Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form12().Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form9().Visible = true;
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form1().Visible = true;
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;username=root;database=uvd;password=qwerty1234");
            connection.Open();
            String query = "Select * from vehicle";
            cmd = new MySqlCommand(query, connection);
            try {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            
            }
            catch(Exception e1)
            {

            }
            connection.Close();
            
            
            
        }
    }
}
