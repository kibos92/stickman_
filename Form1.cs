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
            clock.Enabled = false;
        }
        private int time = 1;
        private void Projectile()
        {
                int speed = 1;
                int angle = 30;

                double[] position = { arrow.Location.X, arrow.Location.Y };

                Console.WriteLine(arrow.Location);
                double xvelocity = speed * Math.Cos((angle *Math.PI)/180);
                double yvelocity = speed * Math.Sin((angle * Math.PI) / 180);

                position[0] += (xvelocity * time);
                position[1] += (yvelocity * time);

                arrow.Location= new Point(Convert.ToInt32(position[0]),Convert.ToInt32(position[1]));

                time++;
        }


        private void clock_Tick(object sender, EventArgs e)
        {
            Projectile();
        }

        private void stickman_Click(object sender, EventArgs e)
        {
            clock.Enabled = true;
        }
    }
}
