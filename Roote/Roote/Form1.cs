using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tb_A.Text);
            double b = double.Parse(tb_B.Text);
            double c = double.Parse(tb_C.Text);

            double det = b * b - 4.0 * a * c;
            double result1 = 0.0, result2 = 0.0;
            double im1, im2;
            if(det > 0)
            {
                result1 = (-b + Math.Sqrt(det)) / (2.0 * a);
                result2 = (-b - Math.Sqrt(det)) / (2.0 * a);
                tb_Roots1.Text = result1.ToString();
                tb_Roots2.Text = result2.ToString();
            }
            else if(det < 0)
            {
                
                result1 = -b / (2.0 * a);
                result2 = -b / (2.0 * a);
                im1 = Math.Sqrt(-det) / (2.0 * a);
                im2 = -Math.Sqrt(-det) / (2.0 * a);

                tb_Roots1.Text = String.Format("{0}+{1}i", result1, im1);
                tb_Roots2.Text = String.Format("{0}+{1}i", result2, im2);
            }
            else
            {
                result1 = result2 = -b / (2.0 * a);
                tb_Roots1.Text = result1.ToString();
                tb_Roots2.Text = result2.ToString();
            }

            
            
        }
    }
}
