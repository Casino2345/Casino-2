﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.Show();

            this.Hide();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Roulette_Click(object sender, EventArgs e)
        {
            Roulette m = new Roulette();
            m.Show();

            this.Hide();
        }
    }
}
