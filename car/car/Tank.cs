using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Tank
    {
        public Point location;
        public Image imager = Image.FromFile(@"C:\Users\Lenovo\Downloads\right1.jpg");
        public Image imagel = Image.FromFile(@"C:\Users\Lenovo\Downloads\left1.jpg");
        public Image imaged = Image.FromFile(@"C:\Users\Lenovo\Downloads\down1.jpg");
        public Image imageu = Image.FromFile(@"C:\Users\Lenovo\Downloads\up1.jpg");
    }
}
