﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
                frm.Show();
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Visible = true;
            this.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form10().Visible = true;
            this.Visible = false;
        }
    }
}
