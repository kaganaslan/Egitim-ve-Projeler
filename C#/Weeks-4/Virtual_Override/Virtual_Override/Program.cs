namespace Virtual_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir sınıfta sanal yapı oluşturabilmek için ilgili member'ın (prop ya da metot) imzasını virtual keywordu ile işaretlemek yeterlidir. 
            // public virtual ya da virtual public şeklinde oluşturacağızzzzzzzz.

            //MyClass m1 = new MyClass();
            //Obje objeobje = new Obje();
            //objeobje.Message();
            //Oje ojeNesne = new Oje();
            //ojeNesne.Message();

            //Top topNesne = new Top();
            //topNesne.Message();
            //Memeli memeliObject = new Memeli();
            //Maymun maymunObject = new Maymun();
            //Angus angusObject = new Angus();

            //maymunObject.Mesaj();
            //angusObject.Mesaj();
            //memeliObject.Mesaj();

            //A nesne1 = new A();
            //B nesne2 = new B();
            //C nesne3 = new C();
            //D nesne4 = new D();
            //E nesne5 = new E();

            //nesne1.SayClass();
            //nesne2.SayClass();
            //nesne3.SayClass();
            //nesne4.SayClass();
            //nesne5.SayClass();


            Ucgen u = new Ucgen(3,4);
            Console.WriteLine(u.AlanHesap());

            Dortgen d1 = new Dortgen(4,5);
            Console.WriteLine(d1.AlanHesap());
            

            
        }
    }


    class MyClass
    {
        public void MyNormalMethod()
        {

        }

        public virtual void MyVirtualMethod()
        {
            
        }

        public string MyNormalProp { get; set; }

        virtual public string MyVirtualProp { get; set; }
    }

    // Sanal Yapılar Nasıl Ezilir??????? override keywordu ile.
    //Base class'ta ya da atalarda virtual ile işaretlenerek sanallaştırılmış herhabgi bir member torunlarda illa ki override ile ezilmek zorunda değildir! Ama bir torun class base classtaki herhangi bir memberı ezecekse(override edecekse) o memberın kesinlikle ve kesinlikle ve kesinlikle virtual ile işaretlenmiş olması laaaazım.

    class MyClass2 : MyClass
    {
        public override void MyVirtualMethod()
        {
            
        }
    }

    #region Ornek3
    // Protected ile işaretlenen herhabgi bir member sadece ilgili classta veyahut o classtan kalıtım almış olan sınıfların içerisinden erişilebilir. FAKAT nesne üzerinden erişilemez.
    class Sekil
    {
       public int _kenar1;
       public int _kenar2;

        public Sekil(int kenar1, int kenar2)
        {
            _kenar1 = kenar1;
            _kenar2 = kenar2;
        }

        virtual public int AlanHesap()
        {
            return 0;
        }
    }

    class Ucgen : Sekil
    {
        public Ucgen(int kenar1, int kenar2) : base(kenar1, kenar2)
        {

        }

        public override int AlanHesap()
        {
            return _kenar1 * _kenar2 / 2; 
        }
    }
    class Dortgen : Sekil
    {
        public Dortgen(int kenar1, int kenar2): base(kenar1, kenar2)
        {

        }

        public override int AlanHesap()
        {
            return _kenar1 * _kenar2;
        }
    }
    class Dikdortgen : Sekil
    {
        public Dikdortgen(int kenar1, int kenar2): base (kenar1, kenar2)
        {

        }
    }


    #endregion



    class Obje
    {
        public virtual void Message()
        {
            Console.WriteLine("Ben bir objeyim");
        }
    }

    class Oje : Obje
    {

        public override void Message()
        {
            Console.WriteLine("Ben bir ojeyim");
        }
    }

    class Top: Obje
    {
        public override void Message()
        {
            Console.WriteLine("Ben bir topum");
        }
    }


    class Memeli
    {
        public virtual void Mesaj()
        {
            Console.WriteLine("I am a mammal.");
        }
    }

    class Maymun : Memeli
    {
        public override void Mesaj()
        {
            Console.WriteLine("I am a mon k ");
        }
    }

    class Angus : Memeli
    {
        public override void Mesaj()
        {
            Console.WriteLine("I am a un cause ");
        }
    }


    class A
    {
        public virtual void SayClass()
        {
            Console.WriteLine("Ben A nesnesiyim.");
        }
    }

    class B : A
    {
       
    }

    class C : B
    {
        public override void SayClass()
        {
            Console.WriteLine("Ben C nesnesiyim.");
        }
    }

    class D: C
    {

    }

    class E: D
    {
        public override void SayClass()
        {
            Console.WriteLine("Ben E nesnesiyim.");
        }
    }



}