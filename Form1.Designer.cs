
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
            ((System.ComponentModel.ISupportInitialize)(this.stickman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 453);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox stickman;
        private System.Windows.Forms.PictureBox target;
    }
}

