namespace _22_09_22__Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Soru1
            //// 15 elemanlı bir diziye -52'den 112'ye kadar random sayılar atan ve bu dizinin elemanlarından pozitif , negatif ve nötr sayılarından kaç tane atandığını gösteren program

            //int[] sayilar = new int[15] ;
            //int artiSayilar = 0;
            //int eksiSayilar = 0;
            //int sifirSayilar = 0;
            ////diziye değer atama
            
            //Random random = new Random();

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = random.Next(-52,112);

            //}
            //foreach (var x in sayilar)
            //{
                
            //    Console.Write(x + " ");
            //    if (x>0)
            //    {
            //        artiSayilar++;
            //    }else if (x < 0)
            //    {
            //        eksiSayilar++;
            //    }else
            //    {
            //        sifirSayilar++;
            //    }
            //}
            //Console.WriteLine();
            //Console.Write($"Bu dizideki pozitif sayı adedi {artiSayilar}, negatif sayı adedi: {eksiSayilar} ve bu dizideki nötr(sıfır) sayı adedi: {sifirSayilar}");
            #endregion

            #region Soru 2
            // 5 elemanlı bir dizide (dizinin elemanlarını istediğiniz gibi atayabilirsiniz) Kullanıcının girmiş olduğu sayının dizide olup olmadığını bulan varsa kaç adet bulunduğunu ekrana yansıtan dizi 

            //int[] dizi2 = new int[5];
            //Random rastgele = new Random();
            
            
            //for (int i = 0; i < dizi2.Length; i++)
            //{
            //    dizi2[i] = rastgele.Next(33);
            //}

            //Console.WriteLine("Programı durdurmak için Rakamla -1 yazınız");

            //Console.WriteLine("Dizimizin değerleri: ");
            //foreach (var item in dizi2)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();


            //while (true)
            //{

            //    int sayac = 0;
            //    Console.WriteLine("Lütfen Bir Sayı Giriniz. Bakalımm girdiğiniz sayı dizimizde yer alıyor mu?????");
            //    string mesaj1 = "";
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (input == -1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        for (int i = 0; i < dizi2.Length; i++)
            //        {
            //            if (input == dizi2[i])
            //            {
            //                sayac++;

            //            }
            //            else
            //            {
            //                //sayac = 0; Hatayı veren yer

            //            }
                        
            //        }
            //        if (sayac <= 0)
            //        {
            //            Console.WriteLine($"Dizide {input} sayısı bulunmamaktadır.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Toplam {sayac} adet {input} sayısı bulunmaktadır.");
            //        }



            //    }

            //}

            #endregion

            #region Soru3
            //İsimleri Kullanıcıdan alınacak olan 10 kişilik bir sınıf dizisi oluşturulacak. Önce bu dizinin orijinal sırası isimler yan yana gözükecek şekilde gösterilecek, sonra ters sırayla gösterilecek, sonra da sıralı bir array olarak gösterilecek.

            //string[] sinifArray = new string[10];

            //for (int i = 0; i < sinifArray.Length; i++)
            //{
            //    Console.Write($"{i+1}. kişinin ismini giriniz: ");
            //    sinifArray[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("**********************************");
            //Console.WriteLine("Sınıf Listemizin Normal Sıralaması");
            //for (int i = 0; i < sinifArray.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}) {sinifArray[i]}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("**********************************");
            //Console.WriteLine("Sınıf Listemizin Tersten Sıralaması");

            //Array.Reverse(sinifArray);
            //for (int i = 0; i < sinifArray.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}) {sinifArray[i]}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("**********************************");
            //Console.WriteLine("Sınıf Listemizin  Sıralı Sıralaması");

            //Array.Sort(sinifArray);
            //for (int i = 0; i < sinifArray.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}) {sinifArray[i]}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("**********************************");
            //Console.WriteLine("Sınıf Listemizin Tersten Sıralı Sıralaması");



            //Array.Reverse(sinifArray);
            //for (int i = 0; i < sinifArray.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}) {sinifArray[i]}");
            //}


            #endregion


            #region Soru4
            //5 adet personelin numara, isim, telefon ve email bilgilerinin ayrı ayrı dizilerde tutulduğu ve aranan kişi no'ya göre ilgili kişinin tüm bilgilerini ekrana döken bir program.


            string[] personelNo = { "01", "02", "03", "04", "05" };
            string[] personelName = { "Barbaros", "Kağan", "Selin", "Sedanur", "Science" };
            string[] personelTelefon = { "0537654874156", "05372236156", "0549654874123", "05714658477", "05341287854" };
            string[] personelEMail = { "bciga@gmail.com", "kaslan@gmail.com", "sbayatli@gmail.com", "sedanur@rize.com", "science@fiction.com" };

            Console.WriteLine("Bir Personel No Giriniz..\n 01-Barbaros, 02-Kağan, 03-Selin, 04-Seda, 05-Science");
            string search = Console.ReadLine();
            Console.WriteLine();
            int prsNo = Array.IndexOf(personelNo, search);
            Console.WriteLine("***************************");
            Console.WriteLine($"Aradığınız personelin bilgileri: \n***************************\n1) Personel No: {personelNo[prsNo]}\n2) Personel Adı: {personelName[prsNo]}\n3) Personel Telefon: {personelTelefon[prsNo]}\n4) Personel E-Mail: {personelEMail[prsNo]}");






            #endregion
        }
    }
}