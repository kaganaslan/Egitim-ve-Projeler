namespace Karar_Odev_Cozum
{
    internal class Program
    {
    
    
    static void Main(string[] args)
        {
            #region Ödev Geçen Hafta
            //Console.WriteLine("************Wissen Akademie ERP Eğitimi Ara Sınavına Hoşgeldiniz************\nLütfen Talimatları İzleyiniz...");
            //Console.WriteLine();
            //Console.WriteLine("************************************************************");
            //Console.WriteLine("Oyun Kuralları Şöyledir. 3 Adet Sayı Belirleyeceksiniz ve bu\nsayılardan sınava gireceksiniz. Sınavdan 3 ve üzeri doğru\nyapan kazanır. Aksi halde :))) ");

            //Console.WriteLine();
            //Console.WriteLine("************************************************************");
            //Console.WriteLine("Oyun Başlıyor...");
            //Console.WriteLine("************************************************************");
            //Console.WriteLine();

            //Console.Write("Lütfen Birinci Sayıyı Giriniz: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Cevabınız kaydedildi. Teşekkür ederiz.");
            //Console.WriteLine("************************************************************");
            //Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Cevabınız kaydedildi. Teşekkür ederiz.");
            //Console.WriteLine("************************************************************");
            //Console.Write("Lütfen Üçüncü Sayıyı Giriniz: ");
            //double sayi3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Cevabınız kaydedildi. Teşekkür ederiz.");
            //Console.WriteLine("");
            //Console.WriteLine($"Girmiş olduğunuz sayılar şöyledir.. Birinci sayı:{sayi1}, ikinci sayı: {sayi2}, üçüncü sayı: {sayi3}");
            //Console.WriteLine();
            //Console.WriteLine("Şimdi sınava geçelim...");
            //Console.WriteLine("************************************************************");

            //int dogruCevap = 0;
            //Console.Write($"Soru 1:  {sayi1} + {sayi2} kaçtır? ");
            //double islem1 = sayi1 + sayi2;
            //double answer1Input = Convert.ToDouble(Console.ReadLine());

            //if (islem1 == answer1Input)
            //{
            //    Console.WriteLine("Cevabınız için teşekkürler. Bildiniz.");
            //    dogruCevap++;

            //}
            //else
            //{
            //    Console.WriteLine($"Cevabınız yanlış. Doğru cevap {islem1}");
            //}
            //Console.WriteLine();

            //// soru 2

            //Console.Write($"Soru 2:  {sayi2} * {sayi3} kaçtır? ");
            //double islem2 = sayi2 * sayi3;
            //double answer2Input = Convert.ToDouble(Console.ReadLine());

            //if (islem2 == answer2Input)
            //{
            //    Console.WriteLine("Cevabınız için teşekkürler. Bildiniz.");
            //    dogruCevap++;
            //}
            //else
            //{
            //    Console.WriteLine($"Cevabınız yanlış. Doğru cevap {islem2}");
            //}
            //Console.WriteLine();

            //// soru 3

            //Console.Write($"Soru 3:  {sayi1} - {sayi3} kaçtır? ");
            //double islem3 = sayi1 - sayi3;
            //double answer3Input = Convert.ToDouble(Console.ReadLine());

            //if (islem3 == answer3Input)
            //{
            //    Console.WriteLine("Cevabınız için teşekkürler. Bildiniz.");
            //    dogruCevap++;
            //}
            //else
            //{
            //    Console.WriteLine($"Cevabınız yanlış. Doğru cevap {islem3}");
            //}
            //Console.WriteLine();

            //// soru 4

            //Console.Write($"Soru 4:  {sayi2} - {sayi3} kaçtır? ");
            //double islem4 = sayi2 - sayi3;
            //double answer4Input = Convert.ToDouble(Console.ReadLine());

            //if (islem4 == answer4Input)
            //{
            //    Console.WriteLine("Cevabınız için teşekkürler. Bildiniz.");
            //    dogruCevap++;
            //}
            //else
            //{
            //    Console.WriteLine($"Cevabınız yanlış. Doğru cevap {islem4}");
            //}
            //Console.WriteLine();

            //// soru 4

            //Console.Write($"Soru 5:  {sayi2} / {sayi1} kaçtır? ");
            //double islem5 = sayi2 / sayi1;
            //double answer5Input = Convert.ToDouble(Console.ReadLine());

            //if (islem5 == answer5Input)
            //{
            //    Console.WriteLine("Cevabınız için teşekkürler. Bildiniz.");
            //    dogruCevap++;
            //}
            //else
            //{
            //    Console.WriteLine($"Cevabınız yanlış. Doğru cevap {islem5}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Sınav sonucunuz hazırlanıyor...");

            //if (dogruCevap >= 3)
            //{
            //    Console.WriteLine($"Toplam {dogruCevap} adet doğruyla oyunu kazandınız.");
            //}
            //else
            //{
            //    Console.WriteLine($"Toplam {5 - dogruCevap} yanlışla oyunu kaybettin. Öldün çık.");
            //}


            //Console.ReadKey();

            #endregion

            #region Ürün If Else Örneği
            //Bir mağazadan alınan iki ürünün tutarlarının toplamı 250 TL'den fazla ise, 2. ürüne %35'lik bir indirim uygulanıyor. Ek olarak tutar toplamı 300 liranın üzerindeyse her alışverişte alınan 25 TL'lik kargo bedeli alınmamaktadır.
            //Bu duruma göre iki ürünün fiyatlarının kullanıcı tarafından girilmesini sağlayan ve ödenecek toplam tutarı hespalayıp ekrana ayrı ayrı her ürünün fiyatlarıyla birlikte
            //1) Genel Tutar,
            //2) indirimli tutar,
            //3) kargo bedeli,
            //4)Ödenecek son toplam yazdıran programı yazınız.



            // Çözüm

            //double indirimliTutar = 0;
            //double kargoUcret = 25;
            //Console.Write("Lütfen 1. Ürünün Fiyatını Giriniz: ");
            //double product1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Ürünün Fiyatını Giriniz: ");
            //double product2 = double.Parse(Console.ReadLine());
            //double genelTutar = product1 + product2;

            //if (genelTutar > 250)
            //{
            //    indirimliTutar = genelTutar - (product2 * 0.35);
            //    if (indirimliTutar >=300)
            //    {
            //        kargoUcret = 0;
            //    }
            //}
            //else
            //{
            //    indirimliTutar = genelTutar;
            //}
            //double toplamOdenecekTutar = indirimliTutar + kargoUcret;

            //Console.WriteLine("***************************************");
            //Console.WriteLine($"Birinci ürünün fiyatı: {product1}");
            //Console.WriteLine($"İkinci ürünün fiyatı: {product2}");
            //Console.WriteLine($"Genel tutar: {genelTutar}");
            //Console.WriteLine($"İndirimli tutar: {indirimliTutar}");
            //Console.WriteLine($"Kargo Bedeli: {kargoUcret}");
            //Console.WriteLine($"Toplam ödenecek miktar: {toplamOdenecekTutar}");
            //Console.WriteLine("***************************************");
            //Console.ReadKey();


            //Ternary Operator

            int sayi1 = 10;
            int sayi2 = 10;
            int toplam = sayi1 + sayi2;

            Console.WriteLine("Uzun bloklu yazım");
            if(toplam > 20)
            {
                Console.WriteLine("Sayı 20'den büyük");
            }
            else if(toplam == 20)
            {
                Console.WriteLine("Sayı 20'ye eşit");
            }
            else
            {
                Console.WriteLine("Sayı 20'den küçük");
            }

            Console.WriteLine("Ternary Operator ile Yazım");
            Console.WriteLine(toplam > 20 ? "Sayı 20'den büyük" : (toplam == 20 ? "Sayı 20'ye eşit" : "Sayı 20'den küçük"));









            #endregion




        }



    }
}