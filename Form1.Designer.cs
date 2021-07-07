
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stickman = new System.Windows.Forms.PictureBox();
            this.target = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.Label();
            this.arrow = new System.Windows.Forms.PictureBox();
            this.game_over = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stickman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // stickman
            // 
            this.stickman.BackColor = System.Drawing.Color.Transparent;
            this.stickman.Image = ((System.Drawing.Image)(resources.GetObject("stickman.Image")));
            this.stickman.Location = new System.Drawing.Point(44, 341);
            this.stickman.Name = "stickman";
            this.stickman.Size = new System.Drawing.Size(70, 70);
            this.stickman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stickman.TabIndex = 0;
            this.stickman.TabStop = false;
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.Color.Transparent;
            this.target.Image = ((System.Drawing.Image)(resources.GetObject("target.Image")));
            this.target.Location = new System.Drawing.Point(864, 361);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(50, 50);
            this.target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.target.TabIndex = 1;
            this.target.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score.ForeColor = System.Drawing.Color.Red;
            this.score.Location = new System.Drawing.Point(13, 13);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(131, 39);
            this.score.TabIndex = 2;
            this.score.Text = "Score: ";
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.BackColor = System.Drawing.Color.Transparent;
            this.life.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.life.ForeColor = System.Drawing.Color.Red;
            this.life.Location = new System.Drawing.Point(20, 56);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(96, 39);
            this.life.TabIndex = 3;
            this.life.Text = "Life: ";
            // 
            // arrow
            // 
            this.arrow.BackColor = System.Drawing.Color.Transparent;
            this.arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.arrow.Image = ((System.Drawing.Image)(resources.GetObject("arrow.Image")));
            this.arrow.Location = new System.Drawing.Point(121, 341);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(70, 35);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow.TabIndex = 4;
            this.arrow.TabStop = false;
            // 
            // game_over
            // 
            this.game_over.AutoSize = true;
            this.game_over.BackColor = System.Drawing.Color.Transparent;
            this.game_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.game_over.ForeColor = System.Drawing.Color.Red;
            this.game_over.Location = new System.Drawing.Point(400, 200);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(210, 39);
            this.game_over.TabIndex = 5;
            this.game_over.Text = "Game Over ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.life);
            this.Controls.Add(this.score);
            this.Controls.Add(this.target);
            this.Controls.Add(this.stickman);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
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
    }
}

