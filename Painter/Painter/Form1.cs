using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Painter
{
    public partial class Form1 : Form
    {
        Color myColor;
        Font myFont;

        public Form1()
        {
            InitializeComponent();

            myColor = Color.Black;
            myFont = new Font("궁서",10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Rect rect1 = new Rect(50, 50, 100, 100);
            rect1.Draw(e.Graphics,myColor,myFont);

            Rect rect2 = new Rect(100, 100, 100, 100);
            rect2.Draw(e.Graphics,myColor,myFont);

            Rect rect3 = new Rect(150, 150, 100, 100);
           rect3.Draw(e.Graphics,myColor,myFont);


            /*
            int gap = 5;
            Trace.WriteLine("그리는중");
            Graphics g = e.Graphics;
            
            Pen aPen = new Pen(Color.Crimson,2);
            g.DrawRectangle(aPen, gap, gap, Width-gap*2, Height-gap*2);
            */

            //Trace.WriteLine(string.Format("{0} {1}", Width, Height));
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog aDia = new ColorDialog();
            if(aDia.ShowDialog() == DialogResult.OK)
            {
                myColor = aDia.Color;
                Invalidate();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog aDia = new FontDialog();
            if(aDia.ShowDialog() == DialogResult.OK)
            {
                myFont = aDia.Font;
                Invalidate();
            }
        }
    }
}
