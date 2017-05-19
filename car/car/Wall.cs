using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Wall
    {
        public GraphicsPath gp = new GraphicsPath();
        public List<Rectangle> list = new List<Rectangle>();
        Rectangle r = new Rectangle(500, 200, 10, 200);
        Rectangle r2 = new Rectangle(500, 400, 200, 15);
        Rectangle r3 = new Rectangle(200, 20, 200, 15);
        public Wall()
        {
            gp.AddRectangle(r);
            gp.AddRectangle(r2);
            gp.AddRectangle(r3);
            list.Add(r);
            list.Add(r2);
            list.Add(r3);
        }
    }
}
