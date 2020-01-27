using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAbdallah_Project2
{
    public partial class Title_Screen : Form
    {
        bool firstClick = true;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        Form GameScreen = new Game_Screen();
        public Title_Screen()
        {
            InitializeComponent();
            player.SoundLocation = "CoffinNails.wav";
        }

        private void Play_Game_Click(object sender, EventArgs e)
        {
            GameScreen.Show();
            this.Hide();
            MessageBox.Show("Pick 1 case to keep.", "Game Start");
        }

        private void Music_Click(object sender, EventArgs e)
        {
            if (firstClick)
            {
                player.PlayLooping();
                firstClick = false;
            }
            else
            {
                player.Stop();
                firstClick = true;
            }
        }
    }
}
