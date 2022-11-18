namespace String_Array_Methods_Rest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Array Class Metotları Kalanlar

            #region BinarySearch
            /*
            string[] array1 = { "Kağan", "Seda", "Selin(Gone)", "Tek İsimli Seda", "Science", "Hoşgeldin Aslıhan", "Aydın" };
            Array.Sort(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(i + ") " + array1[i]);
            }
            Console.WriteLine("Lütfen Aranacak Metni Giriniz");
            string bugunNeAramakIstersiniz = Console.ReadLine();

            int indexDegeri = Array.BinarySearch(array1, bugunNeAramakIstersiniz);
            if (indexDegeri>= 0)
            {
                Console.WriteLine($"Aradığınız {bugunNeAramakIstersiniz} kelimesi dizinin içinde {indexDegeri}. eleman olarak tespit edildi.");
            }
            else
            {
                Console.WriteLine("Dizide böyle bir eleman yoh.");
            }*/
            #endregion
            #region Clear 
            // Bu metot esasen dizi içerisindeki elemanları siler olarak anlatılır. Fakat aslında içeriğindeki orjinal türlerin default değerlerini döndürür.

            //int[] sayiDizisi = { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
            //Console.WriteLine("Normal Çıktı");
            //for (int i = 0; i< sayiDizisi.Length; i++)
            //{
            //    Console.WriteLine(i +") " + sayiDizisi[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Clear Metodu Sonrası Çıktı");
            //Array.Clear(sayiDizisi, 2,5);

            //for (int i = 0; i < sayiDizisi.Length; i++)
            //{
            //    Console.WriteLine(i + ") " + sayiDizisi[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("String İçin Örnek");
            //string[] stringDizisi = { "Kağan", "Seda", "Selin(Gone)", "Tek İsimli Seda", "Science", "Hoşgeldin Aslıhan", "Aydın" };
            //Console.WriteLine("Normal Çıktı");
            //for (int i = 0; i < stringDizisi.Length; i++)
            //{
            //    Console.WriteLine(i + ") " + stringDizisi[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Clear Metodu Sonrası Çıktı");
            //Array.Clear(stringDizisi, 2, 5);

            //for (int i = 0; i < stringDizisi.Length; i++)
            //{
            //    Console.WriteLine(i + ") " + stringDizisi[i]);
            //}
            #endregion
            #region Clone ,Copy & CopyTo

            //Clone 
            //int[] rastgeleDizi = new int[10];
            //Random r = new Random();

            //for (int i = 0; i < rastgeleDizi.Length; i++)
            //{
            //    rastgeleDizi[i] = r.Next(112);
            //}
            //Console.WriteLine("Orijinal Dizimiz");
            //foreach (var item in rastgeleDizi)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] cloneArray = new int[10];

            //cloneArray = (int[])rastgeleDizi.Clone();
            //Console.WriteLine();
            //Console.WriteLine("Clone'lanan Kodumuz");

            //foreach (var item in cloneArray)
            //{
            //    Console.WriteLine(item);
            //}


            //Copy Metodu
            //int[] sayiArray = { 1, 2, 3, 4, 5, 6, 7 };

            //int[] copyArray = new int[sayiArray.Length];

            //Console.WriteLine("Mevcut kopyalanacak arrayimiz budur.");
            //for (int i = 0; i < sayiArray.Length; i++)
            //{
            //    Console.WriteLine(sayiArray[i]);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Şuan ikinci array içerisine ilk arrayi kopyalıyoruz.");
            //Array.Copy(sayiArray, copyArray, sayiArray.Length);

            //for (int i = 0; i < copyArray.Length; i++)
            //{
            //    Console.WriteLine(copyArray[i]);
            //}


            //CopyTo
            //string kopyalanacakDeger = "Selamun aleyküm. Sabri siz misiniz? Bak boğazıma, antibiyotik kullanıyorum.";

            //char[] kopyalayacakKarakterDizisi =new char[kopyalanacakDeger.Length];

            //Console.WriteLine("Orjinal Dizi");
            //Console.WriteLine(kopyalanacakDeger);

            //Parametreler şöyledir. Doğrudan kopyalaayacağınız değişken adını yazıp içerisine orjinal değeri kopyalayabilirsiniz. Yahut 4'lü parametre alır. Birincisi kopyalamak istediğin kaynak array'deki başlangıç istediğin index no, ikinci parametre hedef değişken ismi, üçüncü parametre hedef değişkenin kaçıncı indeksinden başlamak istediğin, dördüncü parametre ise kaç tane index kopyalamak istediğin yani uzunluk
            //kopyalanacakDeger.CopyTo(5, kopyalayacakKarakterDizisi,0,kopyalanacakDeger.Length-5);
            //Console.WriteLine();
            //Console.WriteLine("Kopyalama sonrası yeni dizimiz.");
            //foreach (var item in kopyalayacakKarakterDizisi)
            //{
            //    Console.Write(item);
            //}








            #endregion
            #region İki Boyutlu Diziler (Matris, Matrix.. vb) Böylece GetLenght Metodunu kullanmış olduk.
            //int[,] array2d = new int[2, 3];

            //array2d[0,0] = 1;
            //array2d[0,1] = 2;
            //array2d[0,2] = 3;
            //array2d[1, 0] = 4;
            //array2d[1, 1] = 5;
            //array2d[1,2] = 6;

            //int[,] dizi2d =
            //{
            //    {1,2,3 },
            //    {0,1,2 },
            //};

            //int[,,] dizi3d = {
            //{
            //        {1,2,3 },
            //        {1,2,3 }
            //},
            //{
            //    {2,5,8 },
            //    {1,2,3 },
            //},
            //{
            //    {2,5,8 },
            //    {1,2,3 },
            //},
            //};

            //for (int i = 0; i < array2d.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2d.GetLength(1); j++)
            //    {
            //        Console.Write(array2d[i,j] + "\t");
            //    } 
            //    Console.WriteLine();
            //}

            //Örnek Satır ve Sütun sayısı kullanıcı tarafından belirlenen dizi oluşturulacak. Değerleri random şekilde (0,100) içine atacağız

            //Console.Write("Lütfen Satır Değerini Giriniz: ");
            //int satir = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Sütun Değerini Giriniz: ");
            //int sutun = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("******************************");


            //int[,] rndDizi2d = new int[satir, sutun];
            //Random rnd = new Random();
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        rndDizi2d[i, j] = rnd.Next(35);
            //        Console.Write(rndDizi2d[i,j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            #endregion
            #region GetValue SetValue
            //string[] array1 = new string[5];


            //array1.SetValue("Barb", 1);
            //Console.WriteLine($"Bu dizinin 1. indeks değeri: {array1.GetValue(1)}");



            //int[,] array2 = new int[5, 5];
            //array2.SetValue(33, 0, 4);
            //Console.WriteLine("GetValue ile");
            //Console.WriteLine($"Bu dizinin 1. satırının 5.sütununun değeri: {array2.GetValue(0,4)}");
            //array2[0, 4] =33;
            //Console.WriteLine("Assign Ederek");
            //Console.WriteLine(array2[0,4]);

            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region CreateInstance
            Array array1 = Array.CreateInstance(typeof(int), 5);
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
            array1.SetValue(rnd.Next(50), i);
            Console.WriteLine(array1.GetValue(i));
            }
            #endregion


            //C# String Metotları
            //Length metodu uzunluğunu ölçer. Stringin. Boşluk da bir index değeri taşır.

            #region Compare
            //Console.WriteLine("Birinci metni gir: ");
            //string metin1 = Console.ReadLine();

            //Console.WriteLine("İkinci metni gir: ");
            //string metin2 = Console.ReadLine();

            //int donusDegeri = String.Compare(metin1, metin2);
            //Console.WriteLine(donusDegeri);
            #endregion

            #region Concat
            //Console.WriteLine("Birinci metni gir: ");
            //string metin1 = Console.ReadLine();

            //Console.WriteLine("İkinci metni gir: ");
            //string metin2 = Console.ReadLine();

            //string birlestirme = String.Concat(metin1, metin2);
            //Console.WriteLine(birlestirme);
            #endregion

            #region Copy
            //Console.WriteLine("Birinci metni gir: ");
            //string metin1 = Console.ReadLine();
            //string kopyayalananDeger = String.Copy(metin1);
            //Console.WriteLine(kopyayalananDeger);
            #endregion

            #region Contains
            //Console.WriteLine("Birinci metni gir: ");
            //string metin1 = Console.ReadLine();

            //Console.WriteLine("Aranan metni gir: ");
            //string arananMetin = Console.ReadLine();

            //if (metin1.Contains(arananMetin))
            //{
            //    Console.WriteLine($"Metninizde {arananMetin} bulunmaktadır.");
            //}
            //else
            //{
            //    Console.WriteLine($"Metninizde {arananMetin} ifadesi bulunmamaktadır.");
            //}
            
            #endregion

            // StartsWith, EndsWith, Trim, Substring, Split, Remove


            //Haftaya Dersler: String örnek. Metot, Windows Forms.


        }
    }
}