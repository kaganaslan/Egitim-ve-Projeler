namespace _16_09_22_Variables_Devam
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }

            public int Yas { get; set; }
        }
        
        static void Main(string[] args)
        {
            #region Reference vs Value Type Variables Part 1
            //string name = "Apple Watch";
            //string color = "black";
            //double price = 5024.56;
            //bool isWaterProof = true;
            //string type = "Deri";
            //string productID = "01";
            //char productCode = 'A';

            //bool isAdmin = false;

            //var name1 = 500;
            //string name2 = name1.ToString();
            //Console.WriteLine("name 1'in tipi: "+name1.GetType());
            //Console.WriteLine("name 2'nin tipi: " +name2.GetType());

            //const double pi = 3.14;
            //double sayi = 5;

            //sayi = 90;

            //pi = 5;


            //Referans tipli değişkenlerden 'object'

            //int a = 1589;

            // boxing işlemi. içerisine bir ilgili türden değişken alır onun değerini saklar ve onun türünü kendi içerisinde saklar. Fakat o türden bir değişkenmiş gibi davranmaz.

            //object o = 50.20;
            //Console.WriteLine(o);


            //object o1 = a;

            //unboxing işlemi. cast operatörü kullanılarak -yani () işareti- obje türü sarıp sarmalanmış olan değişken türünü dışarıya kendi türünden çıkartmak için yapılan işlemdir.

            //double y = (double)o;

            //Console.WriteLine(y);

            //Değer Tip ve Referans Tip Çalışma Mantığı 


            //Değer tipinde değişkenler tanımlanırken belleğin Stack Bölgesinde tanımlanırlar. Bir değişken tanımlanırken değerini başka bir değişken eşitlenerek alırsa buna Deep Copy işlemi denir. Yani sadece değerini kopyalar ve birbirlerine bağımlılıkları kalmaz. Dolayısıyla bu kopyalama sonrasında değişkenlerin değerleri değişse bile birbirlerini etkilemez. Ram'de kendi kapladığı alanlarda belirlenen kendi değerleri değişerek sürece devam ederler. Yani y x kopyalanarak üretildi. Fakat bu üretim sonrasında x'teki değişiklikler y'yi bağlamaz. y x'in ilk kopyalanma esnasındaki değerini taşır. Ta ki y'nin kendi değeri değiştirilene kadar.
            //int x = 5;
            //int y = x;
            //x = 15;

            //Console.WriteLine($"x'in değeri: {x}, y'nin değeri: {y}");

            //Referans tipli değişkenlerde ise durum farklıdır. Aşağıdaki örnekte b'nin değerleri için hiç bir zaman Heap'te alan oluşturulmadı. Stack'te a'nın tuttuğu adresi b'ye eşitledik. Bu sebeple artık b ve a aynı adrese sahip. Ve yine sebeple değerleri aynı değerleri gösterir. Bu kopyalama işlemine Shallow Copy denir. Bir gölge gibi davranır ve değişiklikleri birbirerini doğrudan etkiler.
            //int[] a = { 1, 2, 3, 4, 5 };
            //int[] b = a;

            //Console.WriteLine("A dizisinin değerleri");
            //Console.WriteLine($"A dizisi: ({a[0]},{a[1]},{a[2]},{a[3]},{a[4]}) ");
            //Console.WriteLine($"B dizisi: ({b[0]},{b[1]},{b[2]},{b[3]},{b[4]}) ");
            //Burada birinci değerleri iki değişkende de değiştiriyoruz. Böylece ikisinin de verdiği çıktığa bu değişiklikler birbirlerini etkileyecek şekilde bir görüntü veriyor.
            //a[0] = 8;
            //b[1] = 9;
            //burada a'nın sıfırıncı indeksindeki int değeri 8'e eşitledik. b'nin birinci indeksindeki değeri 9'a eşitledik.
            //Console.WriteLine("****************");
            //Console.WriteLine("Değişiklik sonrası");
            //Console.WriteLine($"A dizisi: ({a[0]},{a[1]},{a[2]},{a[3]},{a[4]}) ");
            //Console.WriteLine($"B dizisi: ({b[0]},{b[1]},{b[2]},{b[3]},{b[4]}) ");
            #endregion

            #region Reference Type Variables Sample


            Person person1 = new Person();

            person1.Name = "Selim";
            person1.Yas = 30;

            Console.WriteLine($"{person1.Name} kişisi {person1.Yas} yaşındadır.");

            Person person2 = new Person();
            person2.Name = "Ahmet";
            person2.Yas = 25;

            Console.WriteLine($"{person2.Name} kişisi {person2.Yas} yaşındadır.");

            person2 = person1;

            person2.Name = "Mahmut";

            Console.WriteLine($"{person1.Name} kişisi {person1.Yas} yaşındadır.");
            Console.WriteLine($"{person2.Name} kişisi {person2.Yas} yaşındadır.");


            #endregion

            //deneme







        }


    }
}