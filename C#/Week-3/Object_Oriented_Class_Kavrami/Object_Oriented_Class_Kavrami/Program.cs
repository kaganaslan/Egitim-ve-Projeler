namespace Object_Oriented_Class_Kavrami
{

    class MyFirstClass
    {

       

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            OrnekModel model1 = new OrnekModel();
            //model1.a = 5;
            //model1.c = "Ahmet";
            //model1.b = 25;
            //Console.WriteLine(model1.OrnekMetot2());
            //model1.OrnekMetot();

            OrnekModel yenimodel = new OrnekModel();
            //yenimodel.b = 25;

            //yenimodel.a = 32500;
            //Console.WriteLine(yenimodel.a);

            OrnekModel r1 = new OrnekModel();
            //Console.WriteLine(r1.Yasi);
            //r1.Yasi = 92;
            //Console.WriteLine(r1.Yasi);

            Banka b1 = new Banka();
            Console.WriteLine(b1.Bakiye);
            b1.Bakiye = 25;
            Console.WriteLine(b1.Bakiye);
            b1.Bakiye = 51;
            Console.WriteLine(b1.Bakiye);

        }
    }


    public class OrnekModel
    {
          int a;
          int b;
          string c;
        int yas = 30;

        public void OrnekMetot()
        {
            Console.WriteLine( a + b * 5 );
        }

        public int OrnekMetot2()
        {
            return a + b;
        }

        public int Yasi
        {
            get
            {
                return yas;
            }
            
        }
    }

    public class Banka
    {
        int bakiye = 5000;

        public int Bakiye
        {
            get
            {
                if (bakiye > 2000)
                {
                    return bakiye*10/100;
                }
                return 0;
            }
            set
            {
                if (value < 50)
                {
                    bakiye = 2000;
                }
                else
                {
                    bakiye += value;
                }

            }
        }
    }

}

