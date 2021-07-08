
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
            ((System.ComponentModel.ISupportInitialize)(this.stickman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // stickman
            // 
            this.stickman.BackColor = System.Drawing.Color.Transparent;
            this.stickman.Image = ((System.Drawing.Image)(resources.GetObject("stickman.Image")));
            this.stickman.Location = new System.Drawing.Point(28, 402);
            this.stickman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stickman.Name = "stickman";
            this.stickman.Size = new System.Drawing.Size(133, 123);
            this.stickman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stickman.TabIndex = 0;
            this.stickman.TabStop = false;
            this.stickman.Click += new System.EventHandler(this.stickman_Click);
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.Color.Transparent;
            this.target.Image = ((System.Drawing.Image)(resources.GetObject("target.Image")));
            this.target.Location = new System.Drawing.Point(1143, 433);
            this.target.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(100, 92);
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
            this.score.Location = new System.Drawing.Point(13, 14);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(128, 38);
            this.score.TabIndex = 2;
            this.score.Text = "Score: ";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.BackColor = System.Drawing.Color.Transparent;
            this.life.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.life.ForeColor = System.Drawing.Color.DarkRed;
            this.life.Location = new System.Drawing.Point(20, 57);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(93, 38);
            this.life.TabIndex = 3;
            this.life.Text = "Life: ";
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Transparent;
            this.arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arrow.Image = ((System.Drawing.Image)(resources.GetObject("arrow.Image")));
            this.arrow.Location = new System.Drawing.Point(167, 402);
            this.arrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(113, 43);
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
            this.game_over.Location = new System.Drawing.Point(533, 246);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(196, 38);
            this.game_over.TabIndex = 5;
            this.game_over.Text = "Game Over";
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.BackColor = System.Drawing.Color.Transparent;
            this.angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angle.ForeColor = System.Drawing.Color.DarkRed;
            this.angle.Location = new System.Drawing.Point(24, 373);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(58, 17);
            this.angle.TabIndex = 6;
            this.angle.Text = "angle: ";
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.BackColor = System.Drawing.Color.Transparent;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.power.ForeColor = System.Drawing.Color.DarkRed;
            this.power.Location = new System.Drawing.Point(24, 341);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(61, 17);
            this.power.TabIndex = 7;
            this.power.Text = "power: ";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 25;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1309, 558);
            this.Controls.Add(this.power);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.life);
            this.Controls.Add(this.score);
            this.Controls.Add(this.target);
            this.Controls.Add(this.stickman);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1327, 605);
            this.MinimumSize = new System.Drawing.Size(1327, 605);
            this.Name = "Form1";
            this.Text = "Stickman with Bow";
            ((System.ComponentModel.ISupportInitialize)(this.stickman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
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
        private System.Windows.Forms.Timer clock;
    }
}

