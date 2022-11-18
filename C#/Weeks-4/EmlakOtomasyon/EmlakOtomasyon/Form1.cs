namespace EmlakOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Kira kira = new();
        Satilik satilik = new();

        
        
        
        



        private void SatilikKaydet_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //constructorsýz nesnelere deðer atama

                //kira.Kiralayan = txtboxKiraci.Text;
                //kira.Ucret = int.Parse(textBoxUcret.Text);
                //kira.Adres = textBoxAdres.Text;
                //kira.OdaSayisi = int.Parse(textBoxOdaSayisi.Text);
                //kira.Alan = int.Parse(textBoxAlan.Text);
                //kira.EvSahibi = textBoxEvSahibi.Text;
                //kira.Isýnma = textBoxIsinmaTipi.Text;
                //richTextBox1.Text = kira.KiraGoster(kira.OdaSayisi, kira.Adres, kira.Ucret,kira.Kiralayan, kira.EvSahibi);

                //constructor ile nesne oluþturup deðerleri atama
                string a, c, f, g;
                int b, d, x;
                a = txtboxKiraci.Text;
                b = int.Parse(textBoxUcret.Text);
                c = textBoxAdres.Text;
                d = int.Parse(textBoxOdaSayisi.Text);
                x = int.Parse(textBoxAlan.Text);
                f = textBoxEvSahibi.Text;
                g = textBoxIsinmaTipi.Text;

                Kira kira2 = new(d, x,c, g, f, a, b);
                richTextBox1.Text = kira2.KiraGoster(d, c, b, a,f);
            }
            else
            {
                
                satilik.SatinAlan = textBoxSatinAlan.Text;
                satilik.Ucret = int.Parse(textBoxSUcret.Text);
                satilik.Adres = textBoxAAdress.Text;
                satilik.OdaSayisi = int.Parse(textBoxSOdaSay.Text);
                satilik.Alan = int.Parse(textBoxSAlan.Text);
                satilik.EvSahibi = textBoxSEvSahibi.Text;
                satilik.Isýnma = textBoxSIsinma.Text;
                richTextBox1.Text = satilik.SatilikGoster(satilik.OdaSayisi, satilik.Adres, satilik.Ucret, satilik.SatinAlan, satilik.EvSahibi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                panelKira.Visible = true;
                panelSatilik.Visible = false;
                richTextBox1.Text = "";
            }else
            {
                panelKira.Visible = false;
                panelSatilik.Visible = true;
                richTextBox1.Clear();
            }
        }
    }
}