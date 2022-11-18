namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                            double cSharpDogru1 = double.Parse(cSharpDogru.Text);
                           double cSharpYanlis1 = double.Parse(cSharpYanlis.Text);
                            double cSharpNet1 = cSharpDogru1 - (cSharpYanlis1 / 4);
                           double reactDogru1 = double.Parse(reactDogru.Text);
                           double reactYanlis1 = double.Parse(reactYanlis.Text);
                            double reactNet1 = reactDogru1 - (reactYanlis1 / 4);
                           double jsDogru1 = double.Parse(jsDogru.Text);
                           double jsYanlis1 = double.Parse(jsYanlis.Text);
                            double jsNet1 = jsDogru1 - (jsYanlis1 / 4);
                           double java1Dogru = double.Parse(javaDogru.Text);
                           double javaYanlis1 = double.Parse(javaYanlis.Text);
                            double javaNet1 = java1Dogru - javaYanlis1 / 4;
                           double htmlDogru1 = double.Parse(htmlDogru.Text);
                           double htmlYanlis1 = double.Parse(htmlYanlis.Text);
                           double htmlNet1 = htmlDogru1 - (htmlYanlis1 / 4);

                            cNet.Text = cSharpNet1.ToString();
                            reactNt.Text = reactNet1.ToString();
                            jsNet.Text = jsNet1.ToString();
                            javaNet.Text = javaNet1.ToString();
                            htmlNet.Text = htmlNet1.ToString();
            }
            catch (Exception)
            {

                
            }   

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayiKontrol = int.Parse(txtTekCift.Text);
            if (sayiKontrol % 2 == 0)
            {
                MessageBox.Show("Girilen sayý çift.");
            }else
            {
                MessageBox.Show("Girilen sayý tek.");
            }
        }
    }
}