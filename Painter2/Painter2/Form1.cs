using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter2
{
    public partial class Form1 : Form
    {
        //아무것도 안하면 -1, 원을 그릴시 0;
        int mode = -1;
        Color myColor;
        List<Circle> myCircleList;
        List<Sqare> mySqareList;
        List<Shape> myShapeList;



        public Form1()
        {
            InitializeComponent();
            myShapeList = new List<Shape>();
        }
        #region 메뉴
        private void Form1_Load(object sender, EventArgs e)
        {
            mode = -1;
            myColor = Color.Black;
            myCircleList = new List<Circle>();
            mySqareList = new List<Sqare>();
            
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 0;
            circleToolStripMenuItem.Checked = true;
            sqeraToolStripMenuItem.Checked = false;
        }

        private void sqeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
            circleToolStripMenuItem.Checked = false;
            sqeraToolStripMenuItem.Checked = true;
        }
        #endregion
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(mode == 0)
            {
                Circle aCircle = new Circle(e.X,e.Y);
                myCircleList.Add(aCircle);

               // Graphics g = CreateGraphics();
               // g.DrawEllipse(new Pen(myColor), e.X - 50 ,e.Y - 50, 100, 100);
            }
            else if (mode == 1)
            {
                mySqareList.Add(new Sqare(e.X,e.Y));

                //Graphics g = CreateGraphics();
                //g.DrawRectangle(new Pen(myColor), e.X - 50, e.Y - 50, 100, 100);
            }
            Refresh();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog aDia = new ColorDialog();
            if(aDia.ShowDialog() == DialogResult.OK)
            {
                myColor = aDia.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i< myCircleList.Count; i++)
            {
                myCircleList[i].Draw(e.Graphics);
            }
            for (int i = 0; i < mySqareList.Count; i++)
            {
                mySqareList[i].Draw(e.Graphics);
            }
        }
    }
}
