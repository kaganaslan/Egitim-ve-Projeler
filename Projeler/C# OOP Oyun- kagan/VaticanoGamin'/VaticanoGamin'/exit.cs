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
    public partial class exit : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public exit()
        {
            InitializeComponent();
            player.SoundLocation = "exit.wav";
            player.Play();
        }
    }
}
