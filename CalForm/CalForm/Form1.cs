using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalForm
{
    public partial class Form1 : Form
    {
        int tempnum;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "0")
            {
               tbDisplay.Text = "0";
            }
            else if((sender as Button).Text == "1")
            {
                tbDisplay.Text = "1";
            }
            else if ((sender as Button).Text == "2")
            {
                tbDisplay.Text = "2";
            }
            else if ((sender as Button).Text == "3")
            {
                tbDisplay.Text = "3";
            }
            else if ((sender as Button).Text == "4")
            {
                tbDisplay.Text = "4";
            }
            else if ((sender as Button).Text == "5")
            {
                tbDisplay.Text = "5";
            }
            else if ((sender as Button).Text == "6")
            {
                tbDisplay.Text = "6";
            }
            else if ((sender as Button).Text == "7")
            {
                tbDisplay.Text = "7";
            }
            else if ((sender as Button).Text == "8")
            {
                tbDisplay.Text = "8";
            }
            else if ((sender as Button).Text == "9")
            {
                tbDisplay.Text = "9";
            }

        }

        
        private void btPlus_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                tempnum = int.Parse(tbDisplay.Text);
                tbDisplay.Text = "";
            }
        }

        private void btEquel_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text != "")
            {
                tbDisplay.Text = (tempnum + int.Parse(tbDisplay.Text)).ToString();
            }
        }
    }
}
