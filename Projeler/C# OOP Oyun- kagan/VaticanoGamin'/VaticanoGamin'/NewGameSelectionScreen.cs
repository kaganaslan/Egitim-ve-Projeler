using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaticanoGamin_
{
    public partial class NewGameSelectionScreen : Form
    {
        public NewGameSelectionScreen()
        {
            InitializeComponent();
        }

        private void NewGameSelectionScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RangedMap rangemap = new RangedMap();
            rangemap.Show();
            Close();
        }

        private void AssassinsSelected_Click(object sender, EventArgs e)
        {
            AssassinsMap assassinsselected = new AssassinsMap();
            assassinsselected.Show();
            Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MageMap mageselected=new MageMap();
            mageselected.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TankMap tankmapss = new TankMap();
            tankmapss.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
