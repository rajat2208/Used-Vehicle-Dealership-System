﻿using System;
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
    public partial class Form5 : Form
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader mdr;
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=localhost;username=root;database=uvd;password=qwerty1234");
            connection.Open();
            String query = "select password from registered_user where c_no='" + textBox1.Text + "'";
            cmd = new MySqlCommand(query, connection);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                if (textBox2.Text == mdr.GetString("password"))
                {
                    // MessageBox.Show("Correct");
                    Form10 frm = new Form10();//change
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect password/ID");
                }
            }
            else
            {
                MessageBox.Show("Incorrect password/ID");

            }
            connection.Close();
        }
    }
}
