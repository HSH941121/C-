using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFriendPhone
{
    public partial class Form1 : Form
    {
        Phone myPhone;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] FriendName = { "A", "B", "C" };
            string[] PhoneNo = {"010-0000-0000","010-1111-1111","010-2222-2222"};
            myPhone = new Phone(FriendName,PhoneNo);

            for(int i = 0; i<FriendName.Length; i++)
            {
                comboBox1.Items.Add(FriendName[i]);
            }
            comboBox1.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text = myPhone[comboBox1.Text];
        }
    }
}
