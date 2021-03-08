using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DrowEx
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics mGraphic;
        //SolidBrush mBrush;
        //Pen mPen;

        List<Shape> mShpeList = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mGraphic = this.CreateGraphics();
            //mBrush = new SolidBrush(Color.HotPink);
            //mPen = new Pen(Color.Purple, 3);

            //mShpeList.Add(new Ellips(3, Color.Purple, 15, 200, new Point(85, 100)));
            //mShpeList.Add(new Ellips(3, Color.Red, 200, 200, new Point(100, 100)));
            //mShpeList.Add(new Ellips(3, Color.Purple, 15, 200, new Point(300, 100)));
            mShpeList.Add(new Quadrangle(3, Color.Red, 100, 100, 100, 100));
            mShpeList.Add(new Polygon(3, Color.Red));
            Refresh();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Shape a in mShpeList)
            {
                a.Draw(mGraphic);
            }
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog aDia = new ColorDialog();
            if(aDia.ShowDialog() == DialogResult.OK)
            {
                //mPen.Color = aDia.Color;
                //mBrush.Color = aDia.Color;
                Refresh();
            }
        }
    }
}
