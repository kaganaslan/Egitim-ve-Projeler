namespace Polimorphism_Devam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Polimorfizm Temeller
            //Console.WriteLine("s.a");
            //BenimSinifim b = new BenimSinifim();
            //SeninSinifin s = new BenimSinifim();
            //SeninSinifin a = new SeninSinifin();
            //int a = "s.a";
            //B b = new B();
            //A b = new B();
            //A a = new B();
            //B b2 = new B();
            //C c = new B();
            //Özet: Polimorfizm bir nesnenin kendi türünün dışında bir veya birden fazla türle işaretlenebilmesi ve ya referans edilebilmesidir. Ve bunun bize getirmiş olduğu farklı davranışları sergileyebilme özelliğidir.
            //C c = new C();
            //c.Z();
            //B b = new C();
            //b.Y();
            //A a = new C();
            //a.X();

            #endregion

            #region Polimorfizm Türleri

            #region Static Polimorfizm
            // Static ileride görüeceğimiz bir konu.
            // Polimorfizm çerçevesinde Static Polimorfizm altında değerlendirilecek.
            // Static polimorfizm derleme zamanında sergilenen bir polimorfizm türüdür. Hangi fonksiyonun çağırılacağına derleme zamanında karar verilmektedir.
            // C# da static polimorfizm denin akla glemesi gereken konu Metot Overloading'tir.
            // Nedir Metot Overloding?? Aynı isimde farklı imzalara sahip olan metotların tanımlanabilmesine metot overloading diyoruz. Başka bir söylem ile bir isme birden fazla metot yükleme. Doğal olarak bir metodun birden fazla formunun olması nedir polimorfizmdir. Hangi formun kullanılacağına derleme zamanında karar verilmesi ve biliniyor olması static polimorfizm özelliğidir.

            //Matematik m = new Matematik();
            //m.Topla(2, 4,4,6);

            #endregion

            #region Dinamik Polimorfizm
            // Dinamik polimorfizm çalışma zamanı(run time) esnasında sergilenen polimorfizm'dir. Yani hangi fonksiyonun çalışacağına run  time'da karar verir.
            // C#'da dinamik polimorfizm diyince akla gelen Metot Override işlemidir.

            //Bunun çok biçimlilikle ne alakası var?
            //Metot override; base classta virtual olarak işaretlenen metotların derived classs'ta override edilerek ezilmesi/ yani yeniden yazılması işlemidir. bu sebeple aynı isimde birden fazla forma sahip fonksiyonun olması polimorfiz^mken, bunlardan hangsinin kullanılacağının runtime çalışma zamanında belirlenmesi daha doğrusu bilinmesi dinamik polimorfizmdir.

            //Arac a = new Arac();
            //a.Calistir();

            //Taksi t = new Taksi();
            //t.Calistir();
            #endregion

            //int b = 100;
            //double a = b;
            //double a2 = Convert.ToDouble(b);

            //A a = new C();
            //C c = (C)a;
            //A a1 = new D();

            //D d = (D)a1;
            //D d = (D)a;
            //object x = "Mahmut";
            //int y = (int)x;

            C c = new C();

            // Tersine dönüşüm
            A a = c;
            A a2 = (A)c;
            //int x = 5;
            //double z = x;
            //double y = Convert.ToDouble(x);

            A a1 = new C();
            D d = (D)a1; // Runtime error
            D d1 = a1 as D; // Null

            //Generic List , Abstract Class, Interface


            #endregion






        }
    }

    //class BenimSinifim : SeninSinifin
    //{

    //}

    //class SeninSinifin
    //{
    //    public int BaseClassInt { get; set; }
    //}


    //class A
    //{
    //    public void X() { }
    //}

    //class B: A
    //{
    //    public void Y() { }
    //}

    //class C: B
    //{
    //    public void Z() { }

    //}

    //class Matematik
    //{
    //    public long Topla(int s1, int s2) => s1 + s2;
    //    public long Topla(int s1, int s2, int s3)=> s1 + s2 + s3;
    //    public long Topla(int s1, int s2, int s3, int s4) => s1 + s2 + s3 + s4;

    //}

    //class Arac
    //{
    //    public virtual void Calistir() => Console.WriteLine("Araç Çalıştı");
    //}

    //class Taksi : Arac
    //{
    //    public override void Calistir() => Console.WriteLine("Taksi Çalıştı");
    //}

    class A {
        public int X { get; set; }
    }
    class B: A {
        public int Y { get; set; }
    }
    class C: B {
        public int Z { get; set; }
    }
    class D : C {
        public int T { get; set; }
    }
}