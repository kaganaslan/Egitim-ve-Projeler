namespace WinFormsApp1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        
        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void toplaBtn_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(birinciSayiTxtBox.Text);
            int sayi2 = int.Parse(ikinciSayiTxtBox.Text);
            int toplam = sayi1 + sayi2;
            label3.Text = $"{sayi1} ve {sayi2} toplamý: {toplam}";
        }
    }
}