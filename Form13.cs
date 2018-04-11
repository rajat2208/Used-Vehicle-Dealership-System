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
  
    public partial class Form13 : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader mdr;
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;username=root;database=uvd;password=qwerty1234");
            connection.Open();
            String query = "delete from worker where w_no='" +textBox1.Text + "'";
            cmd = new MySqlCommand(query, connection);
            if(cmd.ExecuteNonQuery()>0)
             MessageBox.Show("Worker deleted successfully!");
            else
             MessageBox.Show("Invalid Input!!!");
            connection.Close();
            
            this.Close();
            new Form6().Visible = true;

        }
    }
}
