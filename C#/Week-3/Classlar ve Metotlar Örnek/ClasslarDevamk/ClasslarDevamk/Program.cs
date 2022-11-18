using System.Diagnostics.Tracing;

namespace ClasslarDevamk
{
    internal class Program
    {

        public static string YasHesapla(string name, int yasA, int yasB)
        {
            //Console.WriteLine("Merhaba " + name);
            int seninYasin = yasA + yasB;
            //Console.WriteLine($"Senin yaşın {seninYasin}");
            return name;
        }

        static void Main(string[] args)
        {


            //Car model1 = new Car();
            Car model2 = new();

            model2.brand = "Merso";
            model2.karar = true;
            Console.WriteLine($"Arabanızın modeli {model2.brand}");
            Console.WriteLine();
            Console.WriteLine("Arabayı Çalıştırmak İster Misiniz?\nEvet ya da Hayır Yazınız ve Enter'a Basınız");
            Console.WriteLine();
            string cevap = Console.ReadLine();

            if (cevap == "Evet")
            {
                bool isArabaCalistimi = model2.isCarStarted();
                Console.WriteLine(model2.carStartMessage(isArabaCalistimi));
            }
            else
            {
                Console.WriteLine("Hoşçakalın");
            }
            Console.WriteLine("Lütfen İsim gir");
            
            string isimGir = Console.ReadLine();

            //YasHesapla("Barb", 29, 20);
            Console.WriteLine("Şuan Yaş Hesapla Adında ama yaş hesaplamayan enteresan bir fonksiyonu tetikledik.");
            Console.WriteLine(YasHesapla(isimGir, 29, 20));
            
            



            
          


        }
    }

    class Car
    {
       public string brand;
        string color;
        string model;
        string gearType;
        int enginePower;
        int horsePower;
        public bool karar; 

        public bool isCarStarted()
        {
            
            if (karar == true)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public string carStartMessage(bool evetHayir)
        {

            if(evetHayir == true)
            {
                return "Araba Çalıştı";
            }else
            {
                return "Marş basmıyo";
            }
        }

    }
}