using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VaticanoGamin_
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            

            InitializeComponent();
            
            player.SoundLocation = "vaticanooyun.wav";
            player.Play();
        }
        
        
        private void MusicButton_Click(object sender, EventArgs e)
        {
            player.Play();

        }

        private void musicOffButton_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGameSelectionScreen selectionscreen=new NewGameSelectionScreen();
            selectionscreen.Show();

            //assassinImage.Visible = true;
            //tankimage.Visible = true;
            //WizardImage.Visible = true;
            //uzakimage.Visible = true;
            //howToPlayLabelText.Visible = false;
            //howtoplaylabel2.Visible = false;
            //denemedeneme.Visible = true;
            //denemeboxx.Visible = true;
        }

        private void HowToPlayButton_Click(object sender, EventArgs e)
        {
            howToPlayLabelText.Visible = true;
            howtoplaylabel2.Visible = true;
        }

        private void CreditButton_Click(object sender, EventArgs e)
        {
            Credit newcredit = new Credit();
            newcredit.Show();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exit exitexit = new exit();
            exitexit.Show();
      
            //player.Play();
        }
    }
}