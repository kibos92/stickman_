using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stickman_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int time = 0;
        private void Projectile()
        {
            while (time <= 10)
            { 
                int speed = 1;
                int angle = 30;

                double[] position = { arrow.Location.X, arrow.Location.Y };
                double xvelocity = speed * Math.Cos(angle);
                double yvelocity = speed * Math.Sin(angle);

                position[0] *= (xvelocity * time);
                position[1] *= (yvelocity * time);

                arrow.Location= new Point(Convert.ToInt32(position[0]),Convert.ToInt32(position[1]));

                time++;
            }
        }


        private void clock_Tick(object sender, EventArgs e)
        {
            Projectile();
        }

        private void stickman_Click(object sender, EventArgs e)
        {
            
        }
    }
}
