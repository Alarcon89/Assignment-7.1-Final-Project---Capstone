using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TravelCoffee
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            // Here I am calling the music to play in the background.
            // This had to be done by downloading the music and converting from mp3 to wav.
            PlayMusic(@"C:\Users\Jose\Documents\Audacity\Bah Dop Bop - Casa Rosa's Tulum Vibes.wav");
        }
        // This right here the music is going to play playing in the background.
        // Think of it as a calm sound when you go to a coffee shop. 
        private void PlayMusic(string filePath)
        {
            SoundPlayer player = new SoundPlayer(filePath);
            player.PlayLooping();
        }

        private void OpenForm2_Click(object sender, EventArgs e)
        {
            // by clicking the button it will open Form2
            // and whatever the user's name is typed will be passed onto Form2. 
            // Here I make a noise for the button
            System.Media.SystemSounds.Asterisk.Play();
            Form2 form2 = new Form2(txtName.Text);
            form2.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}
