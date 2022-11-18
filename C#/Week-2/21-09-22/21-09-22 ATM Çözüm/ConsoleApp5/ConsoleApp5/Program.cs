namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("ATM");
            
            double bakiye = 5000;
            string userName = "barb";
            Console.WriteLine("Hoşgeldiniz " + userName);
            string pass = "1234";
            int passCounter = 3;
            Console.WriteLine("Lütfen Şifrenizi Giriniz:");
            sifreKontrol:
            string passValid = Console.ReadLine();
            if (passValid == pass)
            {
                Console.WriteLine("Giriş Başarılı <3");
                goto islemler;
            }
            else
            {
                Console.WriteLine("Yanlış Giriş yaptınız.");
                passCounter--;
                if (passCounter==0)
                {
                    Console.WriteLine("Programdan çıkış yapılıyor");
                    return;
                }
                else
                {
                    Console.WriteLine("Kalan Giriş Hakkınız " + passCounter);
                    goto sifreKontrol;
                }
                
            }

            // break continue return
            islemler:

            while (true)
            {
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
                
                Console.WriteLine("1- BAKİYE SORGULAMA\n2-PARA YATIRMA\n3-PARA ÇEKME\n4-ÇIKIŞ");
                string islemNo = Console.ReadLine();

                if (islemNo == "4")
                {
                    Console.WriteLine("See u.");
                    break;
                }
                else if (islemNo == "1") {
                    Console.WriteLine($"Bakiyeniz: {bakiye} TL'dir."); 
                }
                else if (islemNo == "2")
                {
                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                    double yatirilacak = double.Parse(Console.ReadLine());
                    bakiye += yatirilacak;
                }
                else if (islemNo == "3")
                {
                    Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
                    double cekilecek = double.Parse(Console.ReadLine());
                    bakiye -= cekilecek;
                }

            }

            Console.ReadKey();









           
        }
    }
}