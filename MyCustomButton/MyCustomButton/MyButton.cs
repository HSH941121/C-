using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MyCustomButton 
{
    class MyButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Pen thePen = new Pen(Color.Pink, 10);
            pevent.Graphics.DrawLine(thePen, 0, 2, Width, 2);
            pevent.Graphics.DrawLine(thePen, 2, 2,2,Height);
            pevent.Graphics.DrawLine(thePen, 2, Height, Width, Height);
            pevent.Graphics.DrawLine(thePen, Width, 2, Width, Height);
            //pevent.Graphics.FillEllipse(new SolidBrush(Color.Black), 10, 10, 10, 10);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);

            BackColor = Color.Red;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.Aqua;
        }
    }
}
