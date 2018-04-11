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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Visible = true;
                    this.Dispose();
            //this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form13().Visible = true;
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form10().Visible = true;
            //this.Dispose();
        }
    }
}
