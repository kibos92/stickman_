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
            pictureBox1.Hide();
        }
        private int time = 1;
        private int score_value = 0;
        private int life_value = 3;
        private double speed = 1.4;
        private double angleValue = 45;
        private double gravity = 0.05;
        public void Projectile()
        {

        double[] position = { arrow.Location.X, arrow.Location.Y };

        double xvelocity = speed * Math.Cos((angleValue *Math.PI)/180);
        double yvelocity = speed * Math.Sin((angleValue * Math.PI) / 180);

        double x = position[0] + xvelocity * time * Math.Cos((angleValue * Math.PI) / 180);
        double y = position[1] - (yvelocity * time * Math.Sin((angleValue * Math.PI) / 180) - 0.5 * gravity * Math.Pow(time, 2));

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
                pictureBox1.Show();
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

        private void Handling(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                angleValue += 5;
                angle.Text = "angle: " + angleValue.ToString();
            }
            if (e.KeyCode == Keys.Down)
            {
                angleValue -= 5;
                angle.Text = "angle: " + angleValue.ToString();
            }
            if (e.KeyCode == Keys.Right)
            {
                speed += 0.1;
                power.Text = "power: " + speed.ToString();
            }
            if (e.KeyCode == Keys.Left)
            {
                speed -= 0.1;
                power.Text = "power: " + speed.ToString();
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

        private void target_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
