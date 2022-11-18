namespace _20_09_22_Donguler_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch Case vs If Else
            //Console.WriteLine();
            //string day = Console.ReadLine();
            //string day = "Monday";


            //Burası if else ile kullanım.
            //if (day == "Monday")
            //{
            //    Console.WriteLine($"Today is Monday");
            //}
            //else if(day == "Tuesday")
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //else if(day == "Wednesday")
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //else if(day == "Thursday")
            //{
            //    Console.WriteLine("Thursday");
            //}else
            //{
            //    Console.WriteLine("Saturday or Sunday");
            //}

            // Switch Case yapısı

            //switch (day)
            //{
            //    case "Monday":
            //        Console.WriteLine("Today is Monday");
            //        break;

            //    case "Tuesday":
            //        Console.WriteLine("Tuesday");
            //        break;

            //    case "Wednesday":
            //        Console.WriteLine("Today is Wednesday");
            //        break;
            //    case "Thursday":
            //        Console.WriteLine("Today is Thursday");
            //        break;
            //    case "Friday":
            //        Console.WriteLine("Today is Friday");
            //        break;

            //    case "Saturday":
            //        Console.WriteLine("Today is Saturday");
            //        break;

            //    default:
            //        Console.WriteLine("Switch Sunday olarak belirlendi");
            //        break;
            //}

            //int x = 0;

            //if (x>=0 && x<5)
            //{
            //    Console.WriteLine("Sayı ya 0 ya da 0'dan büyük, 5'ten küçük");
            //}else if(x>=5 && x<10)
            //{
            //    Console.WriteLine("0'dan büyük, 5'ten küçük");
            //}else if(x>=10 && x<30)
            //{
            //    Console.WriteLine("Sayı 10 ile 30 arasında");
            //}else
            //{
            //    Console.WriteLine("Sayı ya negatif ya da 30'dan büyük");
            //}

            //switch (x)
            //{
            //    case >= 5:
            //    case < 10:
            //        Console.WriteLine("Sayı ya 0 ya da 0'dan büyük, 5'ten küçük");
            //        break;
            //    //case > 0:
            //    //case < 5:
            //    //    Console.WriteLine("Sayı ya 0 ya da 0'dan büyük, 5'ten küçük");
            //    //    break;

            //    default:
            //        break;
            //}

            #endregion

            #region Döngüler 1 / For

            //int toplam = 0;



            //1'den 10'a kadar olan sayıların toplamını yazdıran program.
            //for (int x = 0; x < 10; x++)
            //{
            //    toplam = toplam + x;
            //}
            //Console.WriteLine(toplam);

            // Girilen metnin alt alta 10 defa yazdırılmasını sağlayan program..

            //Console.WriteLine("Lütfen adınızı giriniz");
            //string name = Console.ReadLine();
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i + "." + " " +name);
            //}

            //for döngüsü kullanarak kullanıcıdan alınan 10 adet sayıyı toplayarak ekranda gösteren uygulama.

            //int toplam = 0;
            //int sayi = 0;
            //int x = 0;
            //for (int i = 1; i <= 10 ; i++)
            //{
            //    Console.WriteLine($"Lütfen {i} numaralı sayıyı giriniz.");
            //    sayi = int.Parse(Console.ReadLine());
            //    toplam = toplam + sayi;
            //}
            //Console.WriteLine($"Girmiş olduğunuz sayıların toplamı {toplam}");
            //#endregion


            //Console.WriteLine("1. sayı {0}, toplam sayi {1}, falan filan sayı {2}", sayi, toplam, x);


            //char char1;

            //for (char char1 = 'a'; char1 <= 'z'; char1++)
            //{
            //    Console.WriteLine("Karakter: " + char1);
            //}

            //1-100 arası 3'e ve 5'e bölünebilen sayıları yazdıran program.

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%3 == 0 && i%5 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1-1000 arasında 3'e tam bölünemeyen sayılar.
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 3 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //1-1000 arasında 3'e tam bölünemeyen kaç tane sayı vardır?

            //int saydirici = 0;
            //int toplam = 0;

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 3 != 0)
            //    {
            //        Console.WriteLine(i);
            //        saydirici++;
            //        //toplam = toplam + i
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("Toplam " + saydirici + " adet sayı vardır. Ve bu sayıların toplamı: " + toplam);

            //1'den kullanıcının girdiği sayıya kadar olan sayıları listele, kaç adet olduğunu yazdır, toplamlarını yazdır, ortalamalarını yazdır.
            //Console.Write("Lütfen bir sayı giriniz: ");
            //int inputSayi = int.Parse(Console.ReadLine());
            //int toplam = 0;
            //int ortalama = 0;
            //int sayac = 0;

            //for (int alex = 1; alex <= inputSayi; alex++)
            //{
            //    Console.WriteLine(alex);
            //    sayac = sayac + 1;
            //    toplam = toplam + alex;

            //}
            //ortalama = toplam / sayac;


            //Console.WriteLine($"Girdiğiniz {inputSayi} sayısına kadar olan toplam sayı adedi {sayac}. Ve bu sayıların toplamı {toplam}. Ayrıca bu sayıların ortalaması {ortalama}");


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //for ile kullanım şekli
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //aynı sonucun while ile kullanım şekli.
            //int _i = 0;


            //while (_i<5)
            //{
                
            //    Console.WriteLine(_i);
            //    _i++;
            //}


            //int x = 0;
            //string cikis = "q";

            //while (true)
            //{
                
            //    Console.WriteLine("Lütfen bir sayı giriniz");
            //    int deger = int.Parse(Console.ReadLine());
            //    if (deger == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(deger);
            //}





           

            #endregion

        }
    }
}