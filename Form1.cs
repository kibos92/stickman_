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
            arrow.Visible = false;
            game_over.Visible = false;
        }
        private int time = 1;
        private int score_value = 0;
        private int life_value = 3;
        public void Projectile()
        {
        double speed = 1.4;
        double angle = 45;
        double gravity = 0.05;

        double[] position = { arrow.Location.X, arrow.Location.Y };

        double xvelocity = speed * Math.Cos((angle *Math.PI)/180);
        double yvelocity = speed * Math.Sin((angle * Math.PI) / 180);

        double x = position[0] + xvelocity * time * Math.Cos((angle * Math.PI) / 180);
        double y = position[1] - (yvelocity * time * Math.Sin((angle * Math.PI) / 180) - 0.5 * gravity * Math.Pow(time, 2));

        arrow.Location= new Point(Convert.ToInt32(x),Convert.ToInt32(y));

        time++;
        }

        private void Collisions()
        {
            if (arrow.Bounds.IntersectsWith(target.Bounds))
            {
                arrow.Visible = false;
                score_value++;
                score.Text = "Score: " + score_value.ToString();
                clock.Enabled = false;
            }
            else if (arrow.Bounds.IntersectsWith(left_wall.Bounds))
            {
                arrow.Visible = false;
                life_value--;
                life.Text = "Life: " + life_value.ToString();
                clock.Enabled = false;
                if (life_value <= 0)
                {
                    game_over.Visible = true;
                }
            }
            else if (arrow.Bounds.IntersectsWith(right_wall.Bounds))
            {
                arrow.Visible = false;
                life_value--;
                life.Text = "Life: " + life_value.ToString();
                clock.Enabled = false;
                if (life_value <= 0)
                {
                    game_over.Visible = true;
                }
            }
            else if (arrow.Bounds.IntersectsWith(up_wall.Bounds))
            {
                arrow.Visible = false;
                life_value--;
                life.Text = "Life: " + life_value.ToString();
                clock.Enabled = false;
                if (life_value <= 0)
                {
                    game_over.Visible = true;
                }
            }
            else if (arrow.Bounds.IntersectsWith(down_wall.Bounds))
            {
                arrow.Visible = false;
                life_value--;
                life.Text = "Life: " + life_value.ToString();
                clock.Enabled = false;
                if (life_value <= 0)
                {
                    game_over.Visible = true;
                }
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            Projectile();
            Collisions();
        }

        private void stickman_Click(object sender, EventArgs e)
        {
            clock.Enabled = true;
            arrow.Visible = true;
            arrow.Location = new Point (125, 316);
            time = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
