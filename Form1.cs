﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kfc
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
            GeneralTable generalTable = new GeneralTable();
            generalTable.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CookTable cookTable = new CookTable();
            cookTable.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buy buyTable = new Buy();
            buyTable.Show();
        }
    }
}
