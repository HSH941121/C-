﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_02WIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 떠라ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("잘해보자");
            label1.Text = "잘해보자";
        }
    }
}