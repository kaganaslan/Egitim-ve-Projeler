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
    public partial class RangedMap : Form
    {
        Character Player = new Character();
        Character Enemy = new Character();
        Character Assassin = new Character("Assassin", 1, 800, 70, 20);
        Character Mage = new Character("Mage", 1, 870, 75, 25);
        Character Tank = new Character("Tank", 1, 1000, 80, 18);
        Character Ranged = new Character("Ranged", 1, 880, 75, 30);

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public RangedMap()
        {
            InitializeComponent();

            player.SoundLocation = "rangedmusic.wav";
            player.Play();

            Player = Ranged;
        tekrarrandom:
            Random newrandom = new Random();
            int characterselection;
            characterselection = newrandom.Next(0, 4);
            if (characterselection == 1)
            {
                rangetomage.Visible = true;
                Enemy = Mage;
            }
            else if (characterselection == 2)
            {
                rangetoassas.Visible = true;
                Enemy = Assassin;
            }
            else if (characterselection == 3)
            {
                rangedtotank.Visible = true;
                Enemy = Tank;
            }
            else
            {
                goto tekrarrandom;
            }

            denemetextbox2.Text = "  Can: " + Enemy.Hp;
            denemetextbox.Text = "  Can: " + Player.Hp;

            timer1.Interval = 1000;

        }

        private void BaslatButton_Click(object sender, EventArgs e)
        {
            Enemy.saldir(Enemy.Damage, Enemy.Miss);
            if (Enemy.Hp >= 0)
            {

                denemetextbox2.Text = "  Can: " + Enemy.Hp;
                progressBar2.Value = Enemy.Hp;
            }
            else
            {

                progressBar2.Value = 0;
                denemetextbox2.Text = "  Can: " + 0;
                if (progressBar2.Value == 0)
                {
                    MessageBox.Show("KAZANDIN!!!");
                    Close();

                }
            }

            Player.saldir(Player.Damage, Player.Miss);
            if (Player.Hp > 0)
            {
                progressBar1.Value = Player.Hp;
                denemetextbox.Text = "  Can: " + Player.Hp;
                progressBar1.Value = Player.Hp;
            }

            else
            {
                progressBar1.Value = 0;
                MessageBox.Show("KAYBETTIN!!!");
                Close();
            }
        }
    }
}
