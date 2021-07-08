
namespace stickman_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stickman = new System.Windows.Forms.PictureBox();
            this.target = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            this.arrow = new System.Windows.Forms.PictureBox();
            this.game_over = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.left_wall = new System.Windows.Forms.PictureBox();
            this.down_wall = new System.Windows.Forms.PictureBox();
            this.right_wall = new System.Windows.Forms.PictureBox();
            this.up_wall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stickman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_wall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_wall)).BeginInit();
            this.SuspendLayout();
            // 
            // stickman
            // 
            this.stickman.BackColor = System.Drawing.Color.Transparent;
            this.stickman.Image = ((System.Drawing.Image)(resources.GetObject("stickman.Image")));
            this.stickman.Location = new System.Drawing.Point(21, 316);
            this.stickman.Margin = new System.Windows.Forms.Padding(2);
            this.stickman.Name = "stickman";
            this.stickman.Size = new System.Drawing.Size(100, 100);
            this.stickman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stickman.TabIndex = 0;
            this.stickman.TabStop = false;
            this.stickman.Click += new System.EventHandler(this.stickman_Click);
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.Color.Transparent;
            this.target.Image = ((System.Drawing.Image)(resources.GetObject("target.Image")));
            this.target.Location = new System.Drawing.Point(836, 366);
            this.target.Margin = new System.Windows.Forms.Padding(2);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(75, 75);
            this.target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.target.TabIndex = 1;
            this.target.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.ForeColor = System.Drawing.Color.DarkRed;
            this.score.Location = new System.Drawing.Point(10, 11);
            this.score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(123, 31);
            this.score.TabIndex = 2;
            this.score.Text = "Score: 0";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.BackColor = System.Drawing.Color.Transparent;
            this.life.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.life.ForeColor = System.Drawing.Color.DarkRed;
            this.life.Location = new System.Drawing.Point(15, 46);
            this.life.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(95, 31);
            this.life.TabIndex = 3;
            this.life.Text = "Life: 3";
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Transparent;
            this.arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arrow.Image = ((System.Drawing.Image)(resources.GetObject("arrow.Image")));
            this.arrow.Location = new System.Drawing.Point(125, 316);
            this.arrow.Margin = new System.Windows.Forms.Padding(2);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(85, 19);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow.TabIndex = 4;
            this.arrow.TabStop = false;
            // 
            // game_over
            // 
            this.game_over.AutoSize = true;
            this.game_over.BackColor = System.Drawing.Color.Transparent;
            this.game_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.game_over.ForeColor = System.Drawing.Color.DarkRed;
            this.game_over.Location = new System.Drawing.Point(400, 200);
            this.game_over.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(162, 31);
            this.game_over.TabIndex = 5;
            this.game_over.Text = "Game Over";
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.BackColor = System.Drawing.Color.Transparent;
            this.angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angle.ForeColor = System.Drawing.Color.DarkRed;
            this.angle.Location = new System.Drawing.Point(18, 288);
            this.angle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(60, 13);
            this.angle.TabIndex = 6;
            this.angle.Text = "angle: 45";
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.BackColor = System.Drawing.Color.Transparent;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.power.ForeColor = System.Drawing.Color.DarkRed;
            this.power.Location = new System.Drawing.Point(18, 265);
            this.power.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(67, 13);
            this.power.TabIndex = 7;
            this.power.Text = "power: 1.4";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 25;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // left_wall
            // 
            this.left_wall.BackColor = System.Drawing.Color.Transparent;
            this.left_wall.Location = new System.Drawing.Point(0, 0);
            this.left_wall.Name = "left_wall";
            this.left_wall.Size = new System.Drawing.Size(10, 456);
            this.left_wall.TabIndex = 8;
            this.left_wall.TabStop = false;
            // 
            // down_wall
            // 
            this.down_wall.BackColor = System.Drawing.Color.Transparent;
            this.down_wall.Location = new System.Drawing.Point(0, 446);
            this.down_wall.Name = "down_wall";
            this.down_wall.Size = new System.Drawing.Size(984, 10);
            this.down_wall.TabIndex = 9;
            this.down_wall.TabStop = false;
            // 
            // right_wall
            // 
            this.right_wall.BackColor = System.Drawing.Color.Transparent;
            this.right_wall.Location = new System.Drawing.Point(974, 0);
            this.right_wall.Name = "right_wall";
            this.right_wall.Size = new System.Drawing.Size(10, 456);
            this.right_wall.TabIndex = 10;
            this.right_wall.TabStop = false;
            // 
            // up_wall
            // 
            this.up_wall.BackColor = System.Drawing.Color.Transparent;
            this.up_wall.Location = new System.Drawing.Point(0, -2);
            this.up_wall.Name = "up_wall";
            this.up_wall.Size = new System.Drawing.Size(984, 10);
            this.up_wall.TabIndex = 11;
            this.up_wall.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 460);
            this.Controls.Add(this.up_wall);
            this.Controls.Add(this.right_wall);
            this.Controls.Add(this.down_wall);
            this.Controls.Add(this.left_wall);
            this.Controls.Add(this.power);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.life);
            this.Controls.Add(this.score);
            this.Controls.Add(this.target);
            this.Controls.Add(this.stickman);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 499);
            this.MinimumSize = new System.Drawing.Size(999, 499);
            this.Name = "Form1";
            this.Text = "Stickman with Bow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stickman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_wall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up_wall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox stickman;
        private System.Windows.Forms.PictureBox target;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.PictureBox arrow;
        private System.Windows.Forms.Label game_over;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.Label power;
        private System.Windows.Forms.PictureBox left_wall;
        private System.Windows.Forms.PictureBox down_wall;
        private System.Windows.Forms.PictureBox right_wall;
        private System.Windows.Forms.PictureBox up_wall;
        public System.Windows.Forms.Timer clock;
    }
}

