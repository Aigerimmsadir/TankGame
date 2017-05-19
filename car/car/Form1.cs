using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public static Tank tank = new Tank();
    
        
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        static  int x=30, y=30;
        Point bull = new Point();
        Pen pen = new Pen(Color.Red);
        private Position carposition = Position.Down;

        enum Position
        {
            Left,Right,Up,Down
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state == States.Move)
            {
                if (carposition == Position.Right) x = x + 5;
                if (carposition == Position.Left) x = x - 5;
                if (carposition == Position.Up) y = y - 5;
                if (carposition == Position.Down) y = y + 5;
                Refresh();
                bull.X = x+20;
                bull.Y = y+15;
                
            }
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                state = States.Move;
                carposition = Position.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                state = States.Move;
                carposition = Position.Right;
            }
            if (e.KeyCode == Keys.Up)
            {
                state = States.Move;
                carposition = Position.Up;
            }
            if (e.KeyCode == Keys.Down)
            {
                carposition = Position.Down;
                state = States.Move;
            }
            if (e.KeyCode == Keys.Enter)
            {
                 state = States.Fire;
            }
        }

        enum States
        {
            Move,Fire,Crash
        }
        States state = States.Move;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(state == States.Fire)
            {
                if (carposition == Position.Right) bull.X = bull.X + 5;
                if (carposition == Position.Left) bull.X = bull.X - 5;
                if (carposition == Position.Up) bull.Y = bull.Y - 5;
                if (carposition == Position.Down) bull.Y = bull.Y + 5;
                Refresh();
            }

           for(int i = 0; i < wall.list.Count; i++) {
                if (wall.list[i].Contains(bull))
                {
                    wall.list.Remove(wall.list[i]);
                    state = States.Move;
                    break;
                }
            }

          
        }
        Pen wallbrushb = new Pen(Color.Black);
        Pen wallbrushw = new Pen(Color.White);
        Wall wall = new Wall();


        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        
         for(int i = 0; i < wall.list.Count; i++)
            {
                e.Graphics.FillRectangle(wallbrushb.Brush, wall.list[i]);
            }
            if (carposition == Position.Right) e.Graphics.DrawImage(tank.imager, x, y);
            if (carposition == Position.Left) e.Graphics.DrawImage(tank.imagel, x, y);
            if (carposition == Position.Up) e.Graphics.DrawImage(tank.imageu, x, y);
            if (carposition == Position.Down) e.Graphics.DrawImage(tank.imaged, x, y);
          
        
           if (state == States.Fire)
            {
                e.Graphics.FillEllipse(pen.Brush, bull.X,bull.Y,10,10);
            }
         /*  if (state == States.Crash)
            {
                e.Graphics.FillPath(wallbrushw.Brush, wall.gp);
            }*/
        }
    }
}
