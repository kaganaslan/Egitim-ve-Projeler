namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Muhasebeci muhasebeObject = new Muhasebeci();
            //muhasebeObject.Adi = "Barbaros";
            //muhasebeObject.MedeniHal = false;
            //muhasebeObject.isMusavir = true;

            //Yazilimci yazilimciObject = new Yazilimci();
            //yazilimciObject.Soyadi = "Serkan";
            //yazilimciObject.lakaplar[0] = "asdsdsad";
            //yazilimciObject.lakaplar[1] = "asdsdsad";
            //yazilimciObject.lakaplar[2] = "asdsdsad";
            //yazilimciObject.lakaplar[3] = "asdsdsad";
            //yazilimciObject.lakaplar[4] = "asdsdsad";

            //Mudur mudurObj = new Mudur();
            //mudurObj.Cinsiyet = 'e';

            //new D();

            Kiralik kiralik = new Kiralik();
            Console.Write("Lütfen kiralayan kişi bilgisini giriniz: ");
            kiralik.kiralayanKisi = Console.ReadLine();
            Console.Write("Lütfen oda sayısı bilgisini giriniz: ");
            kiralik.odaSayisi = int.Parse(Console.ReadLine());
            Console.Write("Lütfen evin alan bilgisi m² cinsinden giriniz: ");
            kiralik.metreKare = int.Parse(Console.ReadLine());
            Console.Write("Lütfen ısınma türü bilgisini giriniz: ");
            kiralik.isinmaTuru = Console.ReadLine();
            Console.Write("Lütfen il bilgisini giriniz: ");
            kiralik.il = Console.ReadLine();
            Console.Write("Lütfen ilçe bilgisini giriniz: ");
            kiralik.ilce = Console.ReadLine();
            Console.Write("Lütfen semt bilgisini giriniz: ");
            kiralik.semt = Console.ReadLine();
            Console.Write("Lütfen semt bilgisini giriniz: ");
            kiralik.kiraBedeli = int.Parse(Console.ReadLine());
            Console.WriteLine("Bilgiler için teşekkür ederik.");
            kiralik.kiraOzellikGoster(kiralik.metreKare, kiralik.odaSayisi, kiralik.semt, kiralik.ilce, kiralik.il, kiralik.isinmaTuru,kiralik.kiraBedeli, kiralik.kiralayanKisi);


        }
    }

    class Mudur : Personel
    {
        
    }

    class Yazilimci : Personel
    {
        public string[] lakaplar = new string[5];
    }

    class Muhasebeci : Personel
    {
        public bool isMusavir { get; set; }
    }


    class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public char Cinsiyet { get; set; }
        public bool MedeniHal { get; set; }
    }


    class A
    {
        public A()
        {
            Console.WriteLine($"{nameof(A)} nesnesi oluşturuldu!");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine($"{nameof(B)} nesnesi oluşturuldu!");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine($"{nameof(C)} nesnesi oluşturuldu!");
        }
    }
    class D : C
    {
        public D()
        {
            Console.WriteLine($"{nameof(D)} nesnesi oluşturuldu!");
        }
    }


    //Türetilen class üzerinden base class constructor'ına erişme

    class MyClass
    {
        public MyClass(int a)
        {

        }
    }

    // Eğer ki base class'ın costructor'i sadece parametre alan constructor ise derived classlarda da base classa bir değer göndermek zorundayız.

    class MyClass2 : MyClass
    {
        public MyClass2() : base(5)
        {

        }

        public MyClass2(int abuzer) :base(abuzer)
        {

        }
    }

    //base keyword vs this keyword

    /*
     1- this bir sınıf içerisindeki constructorlar arasında geçiş yapmayı sağlar.
     2- base keywordu ise, bir sınıfın base class'ının constructorlarından hangisinin tetikleneceğini belirlememizi ve varsa parametrelerinin değerlerinin derived class'tan gönderilmesini sağlar!!!
     */


    class Buzdolabi
    {
        char EnerjiSinifi;
        public bool Rezistans;
        public int MyProperty { get; set; }
    }

    class CamasirMakinesi : Buzdolabi
    {
        int DeterjanBolmesi;

        //türettiğimiz ikinci class içerisinde oluşturduğumuz constructor'da this keywordu kullanarak hem mevcut class'ımızın özelliklerine, hem de kalıtım aldığımız class'ın özelliklerine/memberlarına erişim sağlayabiliyoruzzzzzzz.

        //türettiğimiz ikinci class içerisinde oluşturduğumuz constructor içerisinde kullandığımız base keywordu bize içerisinde bulunduğu class'ın özelliklerini/memberlarını vermiyor. Bize kalıtım alınan ana/base class'ın memberlarını getiriyorrr!!!!
        public CamasirMakinesi()
        {
            
        }

    }

    //Öğretmen ve Öğrenci olacak şekilde iki adet classa ihtiyacımız var. Öğretmen class'ının özellikleri ad, soyad, yasadiği sehir, yas, bitirdiği üniversite, meslekAlanı olacak. Öğrenci class'ında ad, soyad, yasadiği sehir ve yas bilgileri olacak. Konsolda öğretmen bilgilerini giriniz şeklinde yukarıdaki alanlar doldurultacak. Sonrasında öğrenci bilgileri giriniz şeklinde yukarıdaki bilgiler doldurultacak. ve finalde ekranda öğretmen bilgileri bla bla bla, öğrenci bilgileri bla bla bla şeklinde yazdırılacak! Bu projeyi OOP kapsamında yapınız.


    // Kullanıcıya kiralık ya da satılık olmak üzere hangi işlemi yapmak istediğini sorduran. her iki tür için de oda sayısı adresi, metrekaresi, ısınma tipi, ilçesi gibi özellikler olacak. yine her iki tip için de özellikgöster diye bir metot olacak ve bütün bu özellikleri konsola yazdırabilecek. bunun dışında satılık ev için fiyat ve satan kişinin adı olacak, kiralık ev için de kiralayan kişi ve kirabedeli olacak. seçimimiz kira ise kira bilgilerini kullanıcıdan alıp gösterecek, satılık ise satılık bilgilerini kullanıcıdan alıp gösterecek.

    class Emlak
    {
        public int odaSayisi;
        public int metreKare;
        public string isinmaTuru;
        public string ilce;
        public string il;
        public string semt;
        
    }

    class Kiralik : Emlak
    {
        public int kiraBedeli;
        public string kiralayanKisi;
        public void kiraOzellikGoster(int mkare, int odaS, string semts, string ilChe, string sehir, string isnmaTrue, int harcirah, string parayiveren)
        {
            Console.WriteLine($"Evin kira bedeli {harcirah}, alanı: {mkare} m², oda sayısı: {odaS}, bulunduğu adres: {semts} / {ilChe} / {sehir}.\nIsınma türü: {isnmaTrue}\nKiralayan Kişi: {parayiveren}");
        }

    }


    class Satilik : Emlak
    {
        public int satilmaBedeli;
        public string satanKisi;
        public void satiOzellikGoster(int mkare, int odaS, string semts, string ilChe, string sehir, string isnmaTrue, int satinAlmaBedeli, string satanInsan)
        {
            Console.WriteLine($"Evin satılma bedeli {satinAlmaBedeli}, alanı: {mkare} m², oda sayısı: {odaS}, bulunduğu adres: {semts} / {ilChe} / {sehir}.\nIsınma türü: {isnmaTrue}\nSatan Kişi: {satanInsan}");
        }

    }


}