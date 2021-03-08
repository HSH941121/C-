using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyCustomButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen aPen = new Pen(Color.Purple, 3);
            //g.DrawLine(aPen, 0, 0, Width, Height);

            /*
            Random rand = new Random();
            PointF[] pnts = new PointF[30];
            for(int i = 0; i<30; i++)
            {
                pnts[i] = new PointF((float)rand.NextDouble() * Width,(float)rand.NextDouble() * Height);
            }

            g.DrawLines(aPen, pnts);
            */

            g.DrawPie(aPen, new Rectangle(10, 10, 100, 100), 45, 90);

            g.DrawLine(aPen, 100, 500, Width, 500);
            g.DrawLine(aPen, 200, 1000, 200, 0);
            // 중심좌표 x:200  y:500
            int size = 100;
            PointF[] sinPnts = new PointF[size];
            for(int i = 0; i<size; i++)
            {
                float x = (float)(Math.PI * 2.0 / size * i);
                sinPnts[i] = new PointF(x*100 + 200, (float)Math.Sin(x)*100 + 500);
            }

            g.DrawLines(aPen, sinPnts);
            
        }
    }
}
