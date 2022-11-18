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

namespace VaticanoGamin_
{
    public partial class Credit : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        
        public Credit()
        {
            player.SoundLocation = "credit.wav";
            player.Play();
            //pictureBox2.Parent = pictureBox1;

            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
        }
    }
}
