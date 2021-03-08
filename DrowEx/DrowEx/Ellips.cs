using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DrowEx
{
    class Ellips:Shape
    {
        Point mCenter;
        int mLong;
        int mShort;

        public Ellips(int w, Color c, int l, int s, Point p) :base(w,c)
        {
            mLong = l;
            mShort = s;
            mCenter = p;

        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(mColor, mWidth), mCenter.X, mCenter.Y, mLong, mShort);
        }
    }
}
