using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start, end;
            int sum = 0;
            try
            {
                start = int.Parse(inputStart.Text);
                end = int.Parse(inputStop.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("값을 입력해주세요.");
                return;
            }
            if(end <= start)
            {
                MessageBox.Show("종료하는 값이 더 크거나 같습니다.");
                return;
            }

            for(int i = start; i <= end; i++)
            {
                
                if(i%3 == 0)
                {
                    sum += i;
                }
                result.Text = sum.ToString();
            }
            
        }

        private void inputStart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
