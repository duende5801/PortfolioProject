namespace DAbdallah_Project2
{
    partial class Title_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title_Screen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Play_Game = new System.Windows.Forms.Button();
            this.Music = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(961, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Play_Game
            // 
            this.Play_Game.BackColor = System.Drawing.Color.Gold;
            this.Play_Game.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Game.Location = new System.Drawing.Point(436, 82);
            this.Play_Game.Name = "Play_Game";
            this.Play_Game.Size = new System.Drawing.Size(125, 69);
            this.Play_Game.TabIndex = 2;
            this.Play_Game.Text = "Play Game";
            this.Play_Game.UseVisualStyleBackColor = false;
            this.Play_Game.Click += new System.EventHandler(this.Play_Game_Click);
            // 
            // Music
            // 
            this.Music.BackColor = System.Drawing.Color.Gold;
            this.Music.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music.Location = new System.Drawing.Point(436, 389);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(125, 69);
            this.Music.TabIndex = 3;
            this.Music.Text = "Play Music";
            this.Music.UseVisualStyleBackColor = false;
            this.Music.Click += new System.EventHandler(this.Music_Click);
            // 
            // Title_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 597);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.Play_Game);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.Name = "Title_Screen";
            this.Text = "Title Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Play_Game;
        private System.Windows.Forms.Button Music;
    }
}

