namespace DovuscuGame
{
    internal class Program
    {
        public static int heroSecim = 0;
        public static int pcSecim = 0;
       
        public static int[,] dovusculer =
        {
            //UzakDövüşü - Assasin - Tank - Büyücü
            {80,270,15 },
            {85,250,13 },
            {60,300,12 },
            {70,260,13 }
        };

        public static string DusmanSecim()
        {
            Random rnd = new Random();
            int pcCharChoose = rnd.Next(0, 4);
            pcSecim = pcCharChoose;
            string pcCharName = "";
         

            if (pcCharChoose == 0)
            {
                pcCharName = "Uzak Dövüşçü";
                return pcCharName;
            }else if(pcCharChoose == 1)
            {
                pcCharName = "Assasin";
                return pcCharName;
            }
            else if (pcCharChoose == 2)
            {
                pcCharName = "Tank";
                return pcCharName;
            }
            else
            {
                pcCharName = "Büyücü";
                return pcCharName;
            }
        }

        public static bool HeroIskala()
        {
            Random rnd = new Random();
            int iskala = rnd.Next(0, 100);
            
            if (iskala >= 0 && iskala<= dovusculer[heroSecim-1,2] )
            {
                return true;
            }
            else
            {
                return false;
            }

         
        }

        public static bool PcIskala()
        {
            Random rnd = new Random();
            int iskala = rnd.Next(0, 100);

            if (iskala >= 0 && iskala <= dovusculer[pcSecim, 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Oyuna Hoşgeldniz");
            Console.WriteLine("Lütfen Bir Seçim Yapınız ve Enter Tuşuna Basınız:\n1) Başla\n2) Bitir");
            Console.Write("Seçiminiz: ");
            string secimBaslangic = Console.ReadLine();
            if (secimBaslangic == "1")
            {
                while (true)
                {
                    Console.Write("Lütfen Kullanıcı Adınızı Giriniz:");
                    string userName = Console.ReadLine();
                    Console.WriteLine($"Hoşgeldiniz {userName}. Şimdi aşağıdaki yönergelere göre ilerleyiniz...");
                    Console.WriteLine();
                    Console.WriteLine($"Lütfen Bir Karakter Seçiniz\n1) Uzak Dövüşçü --------------------- Saldırı Gücü: {dovusculer[0,0]} / Can: {dovusculer[0,1]} / Iskalama Oranı: %{dovusculer[0,2]}\n2) Assasin --------------------- Saldırı Gücü: {dovusculer[1, 0]} / Can: {dovusculer[1, 1]} / Iskalama Oranı: %{dovusculer[1, 2]}\n3) Tank --------------------- Saldırı Gücü: {dovusculer[2, 0]} / Can: {dovusculer[2, 1]} / Iskalama Oranı: %{dovusculer[2, 2]}\n4) Büyücü --------------------- Saldırı Gücü: {dovusculer[3, 0]} / Can: {dovusculer[3, 1]} / Iskalama Oranı: %{dovusculer[3, 2]}");
                    Console.WriteLine();
                    Console.Write("Seçiminiz: ");
                    int charChoose = int.Parse(Console.ReadLine());
                    heroSecim = charChoose;
                    Console.WriteLine("Savaşa Hazırız. Bakalım Düşman Ne Seçmiş?");
                    Console.WriteLine();
                    Console.WriteLine($"Düşman {DusmanSecim()} karakterini seçti. ");
                    Console.ReadKey();
                    Console.WriteLine("Savaş Başlıyor");

                    for (int i = 0; 3 == 3; i++)
                    {
                        if (i%2 == 0)
                        {
                            Console.WriteLine("Saldırı Hakkı Sende");
                            if(HeroIskala() == false)
                            {
                                
                                Console.WriteLine($"Düşmanın Canı: {dovusculer[pcSecim,1]}");
                                Console.WriteLine("Saldırdın.");

                                Console.WriteLine($"Düşmanın Canı {dovusculer[pcSecim, 1] - dovusculer[heroSecim-1,0]}");
                                dovusculer[pcSecim, 1] = dovusculer[pcSecim, 1] - dovusculer[heroSecim - 1, 0];
                                Console.WriteLine("Saldırı Hakkı Karşı Tarafta");
                                Console.ReadKey();
                                if (dovusculer[pcSecim, 1] <=0 || dovusculer[heroSecim-1, 1] <= 0)
                                {
                                    return;
                                }
                                else
                                {

                                }

                            }
                            else
                            {
                                Console.WriteLine("Iskaladın. Saldırı hakkı karşı tarafta...");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Canın: {dovusculer[heroSecim-1, 1]}");
                            if (PcIskala() == false)
                            {
                                Console.WriteLine(" Pc Saldırdı.");

                                Console.WriteLine($"Kalan Canın {dovusculer[heroSecim - 1, 1] - dovusculer[pcSecim, 0]}");
                                dovusculer[heroSecim - 1, 1] = dovusculer[heroSecim - 1, 1] - dovusculer[pcSecim, 0];
                                Console.WriteLine("Saldırı Hakkı Sende");
                                Console.ReadKey();
                                if (dovusculer[pcSecim, 1] <= 0 || dovusculer[heroSecim - 1, 1] <= 0)
                                {
                                    return;
                                }
                                else
                                {

                                }
                            }
                            else
                            {
                                Console.WriteLine("Pc Iskaladı");
                                Console.ReadKey();
                            }
                        }
                    }

                }
            }
            else
            {
                return;
            }
        }
    }
}