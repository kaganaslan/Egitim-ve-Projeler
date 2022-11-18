namespace _21_09_22_Donguler_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği iki sayı arasında bulunan 3 ile bölünebilen tam sayıların listesini, toplamını ve ortalamasını gösteren program.

            //Kullanıcının giriği 10 adet sayıdan kaç tanesinin 12 ile 35 arasında olduğunu gösteren program

            // Ekranda çarpım tablosunu gösteren program.


            #region Örnek 1

            //Console.Write("Lütfen küçük olan sayıyı giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen büyük olan sayıyı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int toplam = 0;
            //int ortalama = 0;
            //int sayac = 0;

            //for (int i = sayi1; i < sayi2; i++)
            //{
            //    if (i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //        sayac++;
            //        toplam += i;

            //    }
            //}
            //ortalama = toplam / sayac;
            //Console.WriteLine($"Girmiş olduğunuz sayı aralığında toplam {sayac} adet sayı vardır. Bu sayıların toplamı {toplam} adettir. Bu sayıların ortalaması: {ortalama}.");

            #endregion

            #region örnek 2

            //int kacAdetVarAcaba = 0;
            //int araligaUymayanlar = 0;


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. sayıyı giriniz: ");
            //    int veri = int.Parse(Console.ReadLine());

            //    if ((veri>12 && veri<35))
            //    {
            //        //kacAdetVarAcaba = kacAdetVarAcaba + 1;
            //        kacAdetVarAcaba++;
            //    }
            //    else
            //    {
            //        araligaUymayanlar++;
            //    }
            //}

            //Console.WriteLine($"Toplam {kacAdetVarAcaba} adet sayı 12 ile 35 arasındadır. {araligaUymayanlar} adet sayı aralığa uymamaktadır.");

            #endregion

            #region Örnek3 Çarpım Tablosu

            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {

                    Console.WriteLine($"{i} X {j} = {i * j }");
                    

                }
                Console.WriteLine();
                Console.WriteLine("*****************");

            }

            #endregion

        }
    }
}