using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Painter2
{
    class Circle :Shape
    {
        
        public Circle(int x, int y) :base(x,y)
        {
           
        }

        public override void  Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black), X, Y, 100, 100);
        }
    }
}
