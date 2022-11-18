namespace _15_09_22_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte minDeger = 8;

            int a;
            int b;

            string name = "barbaros";
            string barbarosunArkadasi1;

            int yasBarbaros;

            a = 5;

           
            b = a;
            Console.WriteLine("a'nın değeri: " +a);
            Console.WriteLine("b'nin değeri: " + b);
            barbarosunArkadasi1 = "Selim";
            yasBarbaros = 30;
            
            b = 30;
            Console.WriteLine("b'nin değeri: " + b);
            Console.WriteLine("a'nın değeri: " + a);

            a = 15;
            
            b = a;
            Console.WriteLine("b'nin değeri: " + b);

            Console.WriteLine("min değer: "+minDeger);
            Console.WriteLine("a'nın değeri: "+a);
            Console.WriteLine("b'nin değeri: " + b);
            Console.WriteLine("name: "+name);
            Console.WriteLine("barb ark: "+barbarosunArkadasi1);
            Console.WriteLine("barb yaş " +yasBarbaros);

            //diyez işareti yanına region eklenerek görüntülemeyi açıp kapatabileceğiniz bir alan oluşturmaya başlarsınız. Bitiş kısmı için de yine diyez işareti koyup endregion yazmanız gerekir.
            #region Quiz 1
            //todo Quick Challenge bu soruyu değiştirelim. değişken adlarını türkçe yazalım diye bir görev verdiğini düşünelim. Başına todo ekleyip boşluk verip normal bir yorum satırı yazar gibi devam eder.
            //todo  1- sayı tipinde bir değişken tanımlayın.
            // 2- sayı tipinde başka bir değişken tanımlayın
            // 3 - bunları isimlerini de göstererek konsola yazdırın.
            // 4- birinci sayıyı ikinci sayıya, ikinci sayıyı birinci sayının değerine eşitleyin ve konsolda bu şekilde yazdırın.
            Console.WriteLine("**************************************************");
            Console.WriteLine("Quiz");
            //1. aşama değişkenlerin tanımlanması
            int num1 = 80;
            //2. aşama değişkenlerin tanımlanması
            int num2 = 60;
            //3. aşama yazdırma
            Console.WriteLine($"Birinci sayı: {num1}, ikinci sayı: {num2}");

            //Logic
            int tempNum = num1;
            num1 = num2;
            num2 = tempNum;
            Console.WriteLine($"Birinci sayı: {num1}, ikinci sayı: {num2}");
            #endregion

            int sayi1 = 22;
            int sayi2 = sayi1 *2 ;
            int toplamDeger = sayi1 + sayi2;
            Console.WriteLine($"Birinci sayı {sayi1} ve ikinci sayı: {sayi2} ve ikisinin toplamı {toplamDeger}");


            #region Quiz 2

            //Ouiz 2
            //Kullanıcıların girdiği değerlerden oluşan ve bu değerleri saklayıp konsole yazdıran bir program olacak. Programın içeriğinde başlıklara aralıklara dikkat edilecek. Program ismi çalışan listesi olacak. Toplam 5 adet çalışanın ad, soyad, email, yaş, maaş verileri alınacak. Ve tüm veriler toplandıktan sonra konsolda alt alta örneğin (
            //1. çalışan
            // Ad: sadasd;
            // Soyad: asdsa;
            // Email: asdsa;
            //Yaş: sadasd;
            //Yıllık kazanç
            // şeklinde alt alt verileri gösterilecek. ve sonrasında da bir alt satırda da çalışanların maaş ortalaması gösterilecek.

           
            Console.WriteLine();
            Console.WriteLine("***-----------ÇALIŞANLAR FORMU-----------***");
            Console.WriteLine();

            #region 1. Kişi
            Console.WriteLine("Lütfen birinci kullanıcı için istenen değerleri giriniz :) ");
            Console.Write("İsim: ");
           
            string name1 = Console.ReadLine();
            Console.Write("Soyad: ");
            string surname1 = Console.ReadLine();
            Console.Write("Email: ");
            string eMail1 = Console.ReadLine();
            Console.Write("Yaş: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maaş: ");
            double salary1 = Convert.ToDouble(Console.ReadLine());
            double yillikKazanc = salary1 * 12;
            Console.WriteLine($"1. Kullanıcının Adı: {name1}, Soyadı: {surname1}, E-Mail: {eMail1} yaşı: {age1} ve Yıllık Kazancı {yillikKazanc}");
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");
            #endregion

            #region 2. Kişi
           
           
            Console.WriteLine("Lütfen ikinci kullanıcı için istenen değerleri giriniz :) ");
            Console.Write("İsim: ");
           
            string name2 = Console.ReadLine();
            Console.Write("Soyad: ");
            string surname2 = Console.ReadLine();
            Console.Write("Email: ");
            string eMail2 = Console.ReadLine();
            Console.Write("Yaş: ");
           
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maaş: ");
            double salary2 = Convert.ToDouble(Console.ReadLine());
            double yillikKazanc2 = salary2 * 12;
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");
            Console.WriteLine();
            Console.WriteLine($"2. Kullanıcının Adı: {name2}, Soyadı: {surname2}, Email: {eMail2} yaşı: {age2} ve Yıllık Kazancı {yillikKazanc2}");
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");
            #endregion

            #region 3. Kişi
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("Lütfen üçüncü kullanıcı için istenen değerleri giriniz :) ");
            Console.Write("İsim: ");

            string name3 = Console.ReadLine();
            Console.Write("Soyad: ");
            string surname3 = Console.ReadLine();
            Console.Write("Email: ");
            string eMail3 = Console.ReadLine();
            Console.Write("Yaş: ");

            int age3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maaş: ");
            double salary3 = Convert.ToDouble(Console.ReadLine());
            double yillikKazanc3 = salary3 * 12;
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");
            Console.WriteLine();
            Console.WriteLine($"3. Kullanıcının Adı: {name3}, Soyadı: {surname3}, Email: {eMail3} yaşı: {age3} ve Yıllık Kazancı {yillikKazanc3}");
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");
            #endregion

            #region 4. Kişi

            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("Lütfen dördüncü kullanıcı için istenen değerleri giriniz :) ");
            Console.Write("İsim: ");

            string name4 = Console.ReadLine();
            Console.Write("Soyad: ");
            string surname4 = Console.ReadLine();
            Console.Write("Email: ");
            string eMail4 = Console.ReadLine();
            Console.Write("Yaş: ");

            int age4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maaş: ");
            double salary4 = Convert.ToDouble(Console.ReadLine());
            double yillikKazanc4 = salary4 * 12;
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");
            Console.WriteLine();
            Console.WriteLine($"4. Kullanıcının Adı: {name4}, Soyadı: {surname4}, Email: {eMail4} yaşı: {age4} ve Yıllık Kazancı {yillikKazanc4}");
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");

            #endregion

            #region 5. Kişi
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("Lütfen beşinci kullanıcı için istenen değerleri giriniz :) ");
            Console.Write("İsim: ");

            string name5 = Console.ReadLine();
            Console.Write("Soyad: ");
            string surname5 = Console.ReadLine();
            Console.Write("Email: ");
            string eMail5 = Console.ReadLine();
            Console.Write("Yaş: ");

            int age5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maaş: ");
            double salary5 = Convert.ToDouble(Console.ReadLine());
            double yillikKazanc5 = salary5 * 12;
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");
            Console.WriteLine();
            Console.WriteLine($"5. Kullanıcının Adı: {name5}, Soyadı: {surname5}, Email: {eMail5} yaşı: {age5} ve Yıllık Kazancı {yillikKazanc5}");
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("*******************Girdiğiniz bilgiler için teşekkür ederiz****************");
            #endregion

            Console.WriteLine($"5 çalışanın maaş ortalaması: {(salary1+salary2+salary3+salary4+salary5)/5}");

            #endregion

            #region
            //ÖDEV

            //Kullanıcının gireceği 10 adet üründen oluşan ve finalde bu ürünleri alt alta sıralayan bir program yazılacak. Ürünlerin adı, kategorisi, rengi, fiyatı, adeti girilecek. 10 ürün de girildikten sonra önce alt alta örneğin şu şekilde
            // 1. Ürün
            // Adı(Markası): Apple;
            // Kategorisi: Elektronik;
            // Rengi: Altın;
            // Fiyatı: 25000;
            // Adeti: 8
            // 2. Ürün
            // Adı(Markası): Apple;
            // Kategorisi: Elektronik;
            // Rengi: Altın;
            // Fiyatı: 25000;
            // Adeti: 8
            // şeklinde bir çıktı alınacak.
            //En alt satırda toplam kazanç miktarı hesaplanacak satılan 10 ürün için. (ürünlerin adetleri ve fiyatları arasındaki ilişki kurularak)

            #endregion
        }
    }
}