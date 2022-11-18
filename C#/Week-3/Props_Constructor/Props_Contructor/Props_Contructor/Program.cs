namespace Props_Contructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass firstClass = new();

            //MyClass firstClass = new MyClass();

            //Console.WriteLine(firstClass.A );
            //firstClass.A = 100;
            //Console.WriteLine(firstClass.A);

            //Console.WriteLine("Şuan Manuel Şekilde Class İçerisindeki Fielda Erişim Sağladık");
            //Console.WriteLine("b'nin değeri: " + firstClass.BGet());
            //Console.WriteLine("Şuan Manuel Şekilde Class İçerisindeki Fiel'ın Değerini Değiştirdik");
            //firstClass.BSet(21256);
            //Console.WriteLine("b'nin yeni değeri: " + firstClass.BGet());
            //new SecondClass(5);
            //new SecondClass(10);
            //new SecondClass();
            //new SecondClass();
            //new SecondClass();

            SecondClass nesne = new SecondClass(20);
           
            SecondClass nesne3 = new SecondClass(40, "Ahmet");
        }
    }


    class MyClass
    {
        int a = 32;
        int b = 25;

        public int Yas { get; set; }
        public string Name { get; set; }

        //Property Kullanılarak Erişim ve Değişim Sağladık
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        //Manuel Şekilde Erişim ve Değişim Sağlama
        public int BGet()
        {
            return this.b;
        }

        public void BSet(int value)
        {
            this.b = value;
        }
    }

    class SecondClass
    {
        //public SecondClass()
        //{
        //    Console.WriteLine("1 tane Second Class Nesnesi Oluşturdum.");
        //}
        //int x = 32;
        public SecondClass()
        {
            Console.WriteLine("Parametresiz constructor");
        }

        public SecondClass(int x)
        {
            
            Console.WriteLine("Bir adet tek parametreli SecondClass nesnesi üretilmiştir x değeri" + x);
        }

        public SecondClass(int x, string y) : this(x)
        {
            x = 0;
            Console.WriteLine("Bir adet iki parametreli SecondClass nesnesi üretilmiştir. x değeri " + x);
        }

        
    }
}