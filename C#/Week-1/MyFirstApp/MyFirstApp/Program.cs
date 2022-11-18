namespace MyFirstApp
{
    internal class Program
    {
        // iki adet "/" işareti yanyana konarak kod bloklarımızda açıklama yapabiliriz.
        /*Açıklama yazıları tek satırdan oluşmuyorsa
        taksim yıldız yıldız taksim işaretleri arasına
        alt alta satırlar eklenerek açıklama satırları blokları oluşturulur.
        */

        // Comment blockları oluşturmak için kullanacağımız kısayol(shortcut) CTRL + K + C kombinasyonudur.
        
        // Kısayol Denemesi
        //Lorem ipsum dolor sit amet
        //Wissen Akademie ERP Sınıfı
        //Birinci Hafta VisualStudio Eğitimi

        static void Main(string[] args)
        {
            //İlk konsol metodumuz. Console.WriteLine. Konsola yazdırılan komutu bir satır boyunca tutar.
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("I'm Barb.");

            // Console.WriteLine'a göre farkı bir satır boyunca tutulmamasıdır. Kendinden sonra gelen kod bloğu hemen yanından devam eder.
            //Console.Write("I'm Barb.");

            // Kullanıcıdan gelen verileri okumak için kullanılan konsol metodudur.
            //Console.ReadLine();

            //Kod bitimine eklenerek konsolun kod tamamlanınca kapanmasını engeller.
            //Console.ReadKey();

            //Console.WriteLine("Lütfen İsminizi Giriniz: ");
            //Console.ReadLine();


            //int a = 5;
            //int b = 10;
            //string name = "barbaros";

            //Console.WriteLine("İsminiz: " + name + " " + "a değeri: " + a + " "+ "b değeri: " +b );

            //--------------------------------------------------------------------------------//

            //Kullanıcıya ismini girmesini söyleyen, girdiği ismi bize gösteren, soy adını isteyen, adresini isteyen, finalde hepsini bize gösteren bir program yazınız.

            //string name = "barbaros";
            Console.Write("Lütfen Adınızı Yazınız: ");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen 2. İsminizi Giriniz:");
            string secondName = Console.ReadLine();
            //string surname = "ciga";
            Console.Write("Lütfen Soyadınızı Yazınız: ");
            string surname = Console.ReadLine();
            //string email = "barbaros@gmail.com";
            Console.Write("Lütfen Email Adresinizi Yazınız: ");
            string email = Console.ReadLine();
            //string address = "maltepe";
            Console.Write("Lütfen Adresinizi Yazınız: ");
            string address = Console.ReadLine();
            Console.WriteLine("Adınız: " +name + " İkinci İsminiz" + secondName + " Soyadınız: " + surname + " " + "Email Adresiniz: " + email + " Adresiniz: " + address);
            
        }

        
    }
}

