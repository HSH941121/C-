
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormHash
{
    public partial class Form1 : Form
    {
        Hashtable myTable;

        public Form1()
        {
            InitializeComponent();
            myTable = new Hashtable();

            myTable["하선호"] = "010-0000-0000";
            myTable["홍길동"] = "010-1111-1111";
            
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            if (myTable.Contains(tbName.Text))
            {
                tbPhone.Text = "";
                tbPhone.Text = myTable[tbName.Text].ToString();
            }
            else
            {
                tbPhone.Text = "일치하는 사람이 없습니다.";
            }

            
        }
    }
}
