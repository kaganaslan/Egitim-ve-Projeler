using System.Runtime.InteropServices;

namespace Metotlar
{


    internal class Program
    {
        public static int brbros = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Hesaplama Programamıza Hoşgeldiniz");
            Console.WriteLine();
            //Burası Geriye Değer Döndürmeyen ve Parametre Almayan metot tipi için hazırlandı.
            //AlanHesapla();

            //Bu kısım Geriye Değer Döndürmeyen Ama Parametre Alan metot tipi için hazırlandı.
            //Console.WriteLine("Please enter the short edge: ");
            //int shortEdge = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the long edge: ");
            //int longEdge = int.Parse(Console.ReadLine());
            //AlanHesapla(shortEdge, longEdge);

            //Bu kısım geriye değer döndüren ve parametre almayan için hazırlandı. 
            //int sonuc = AlanHesapla();
            //Console.WriteLine($"Alan = {sonuc} kadar alan.");

            //Bu kısım geriye değer döndüren ve parametre alan için hazırlandı.
            //Console.WriteLine("Please enter the short edge: ");
            //int shortEdge = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the long edge: ");
            //int longEdge = int.Parse(Console.ReadLine());
            //int result = AlanHesapla(shortEdge, longEdge);
            //Console.WriteLine($"Alan = {result}");

            //Ödev Konusu

            /*
            Uzak Dövüşçü, Assasin, Tank, Büyücü olmak üzere 4 adet karakter seçimi yapılacaktır.
            Uzak Dövüşçü Özellikleri = Vuruş 80, Can 270, Iskalama Yüzdesi 5
            Assasin Özellikleri = Vuruş 85, Can 250, Iskalama Yüzdesi 3
            Tank Özellikleri = Vuruş 60, Can 300, Iskalama Yüzdesi 2
            Büyücü Özellikleri = Vuruş 70, Can 260, Iskalama Yüzdesi 3

            Karşılama isim alma ekranı tasarlanacak. Oyuna Başla ve Çıkış Seçenekleri sunulacak. Fakat yanlış tuşlama yaparsa da hata alınmayacak şekilde ayarlayın.
            Size bu dört karakterden birini seçtirsin. Ve bilgisayara da random bir karakter ataması yapılsın. Savaş başlasın mı diye sorulsun. Ve bir siz bir bilgisayar saldıracak şekilde kodlamaya başlayın. Her atak sonrasında eğer ıskalama denk gelmemişse atak gücü kadar karşı tarafın canı azalsın. Ve her hamle sonunda ekranda karakterlerin yaptıkları eylemler ve canları yazacak şekilde olsun. 
            Bir tarafın canı sıfır olduğunda oyun biter ve kazandın ya da kaybettin diye bir uyarı gelir. Sonrasında da tekrar oynamak ister misin ya da çıkış gibi bir seçenek konarak oyun tamamlanır. 



             
             
             
             
             
             */


        }

        #region Geriye Değer Döndürmeyen ve Parametre Almayan Metotlar
        //Metot geri değer döndürmeyecekse void yaz bas geç.
        //private static void AlanHesapla()
        //{
        //    Console.WriteLine("Please enter the short edge: ");
        //    int shortEdge = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter the long edge: ");
        //    int longEdge = int.Parse(Console.ReadLine());
        //    int area = shortEdge * longEdge;
        //    Console.WriteLine($"Alanın {area} kadar.");
        //}
        #endregion


        #region Geriye Değer Döndürmeyen ve Parametre Alan Metotlar
        //private static void AlanHesapla(int se, int le)
        //{
        //    int area2 = se*le;
        //    Console.WriteLine($"Alan = {area2}");
        //}
        #endregion

        #region Geriye Değer Döndüren ve Parametre Almayan Metotlar

        //private static int AlanHesapla()
        //{
        //    Console.WriteLine("Please enter the short edge: ");
        //    int shortEdge = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter the long edge: ");
        //    int longEdge = int.Parse(Console.ReadLine());
        //    int area3 = shortEdge * longEdge;

        //    return area3;
        //}



        #endregion

        #region Geriye Değer Döndüren ve Parametre Alan Metotlar
        private static int AlanHesapla(int se, int le)
        {
            int area4 = se * le;
            return area4;
        }
        #endregion
    }
}