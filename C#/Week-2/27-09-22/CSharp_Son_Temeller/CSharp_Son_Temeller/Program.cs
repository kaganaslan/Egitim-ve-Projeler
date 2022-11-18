using System.Collections;

namespace CSharp_Son_Temeller
{

    internal class Program
    {


        static void Main(string[] args)
        {
            #region Koleksiyonlar (Collections) Part-1  Array List Nedir
            //Dizilerde sınırlılıklar mevcuttur. En büyük sınırlılıklarımız dizi tanımlaması yapıldığı anda içeriğinde olacak eleman sayılarını belirtmemiz, belirtilen bu eleman sayısı kadar tanımlama yapıldığı andan itibaren bellekte alan tahsis edilmesi ve bu eleman sayısını ileride arttıramıyor olmamızdır. 

            //ArrayList Collection

            //int[] ages = new int[18];

            //ArrayList _ages = new ArrayList();
            //#endregion

            //#region Tanımlanan Bir ArrayList İçerisine Değer Atama
            //ages[3] = 5;

            //Add komutunun içerisine yani parantezin içerisine girilen değer ilgili koleksiyonda en uygun yere atılır. Yani aşağıdaki örnekte koleksiyonun ilk elemanı 568 oldu. Değer girildikçe yeni eleman olarak ekler.

           // _ages.Add(568);


            //for (int i = 0; i < ages.Length; i++)
            //{
            //    ages[i] = i*5;
            //    _ages.Add(i*5);
            //}
            #endregion

            #region Tanımlanmış Bir ArrayList'den Değer Okuma

            //Dizilerde değer okuma
            //Console.WriteLine(ages[3]);

            //ArrayList'te değer okuma
            /*Console.WriteLine(_ages[3])*/;

            #endregion

            #region ArrayList'ten gelen sınırlılıklar

            //ArrayList'ler dizilerdeki bir takım sınırlılıkları ortadan kaldırsa da nihayetinde bu da daha primitiv ilkel bir koleksiyon olduğu için beraberinde getirdiği sınırlılıklar bulunmaktadır. Bu konuda en çok dikkate almamız gereken sınırlılık Boxing - Unboxing meselesidir.

            //int sum = 0;

            // integer tipinde bir toplama işlemi yapmak istersek örneğin elimizdeki koleksiyon değerleri box edilmiş halde yani object tipinde döndüğü için bir integer ile bir object toplanamamaktadır. Asıl veri tipine dönüş sağlamak için casting operatörünü kullanıyoruz. Yani şu "()". Ve içerisine istediğimiz tipi yani box edilmiş tipi yazarak unboxing işlemini gerçekleştiriyoruz.
            //for (int i = 0; i < _ages.Count; i++)
            //{
            //    if (_ages[i] is int)
            //    {
            //        sum = sum + (int)_ages[i];
            //    }


            //}
            //Console.WriteLine(sum);


            #endregion

            #region ArrayList Collection Initializers

            //ArrayList arrayList1 = new ArrayList()
            //{
            //    "Kağan",
            //    33,
            //    true,
            //    'b'
            //};

            #endregion

            #region Math Sınıfı

            //Console.WriteLine(Math.Abs(-32));
            //Console.WriteLine(Math.Ceiling(72.5));
            //Console.WriteLine(Math.Floor(72.5));
            //Console.WriteLine(Math.Round(72.6));
            //Console.WriteLine(Math.Max(8,3));
            //Console.WriteLine(Math.Min(8,3));
            //Console.WriteLine(Math.Pow(8,3));
            //Console.WriteLine(Math.Sqrt(16));
            //Console.WriteLine(Math.Truncate(16.3335588578));
            //Console.WriteLine(Math.Log(100,10));
            //Console.WriteLine(Math.Log10(10));

            #endregion

            #region DateTime Sınıfı

            //DateTime tarih;
            //tarih = DateTime.Now.Date;
            //Console.WriteLine(tarih.ToString());

            //Console.WriteLine(tarih.ToString().Remove(10));
            //Console.WriteLine(tarih.ToString().Trim('0', ':'));

            //int gun = DateTime.Now.Day;
            //int ay = DateTime.Now.Month;
            //int yil = DateTime.Now.Year;
            //int saat = DateTime.Now.Hour;
            //int dakika = DateTime.Now.Minute;
            //int saniye = DateTime.Now.Second;
            //int salise = DateTime.Now.Millisecond;

            //Console.Write($"{gun}/{ay}/{yil} - {saat}:{dakika}:{saniye}:{salise}");


            //DateTime Gun = DateTime.Now.AddDays(5);

            //Console.WriteLine(Gun.ToString());


            //vs vs araştırın.
            #endregion

            #region Hatırlatma mahiyetinde örnekler

            //10 elemanlı bir dizi tanımlayın. elemanları kullanıcı girsin. Bu dizinin elemanlarındaki negatif, pozitif ve sıfır olan kaç adet eleman olduğunu gösteren program yazın.


            //Klavyeden girişi yapılan 5 adet sayının büyükten küçüğe sıralamasını çıktı veren programı yazınız.


            //Öğretmenin (kullanıcının) girdiği 10 adet öğrenci notlarının analiz edilmesi sonucunda kaç öğrencinin geçtiği kaç öğrencinin kaldığı bir program yazınız. Geçme notu 50.


            //200 elemanlı bir dizi oluşturunuz ve değerleri -100 ile +100 arasında random sayılar atayınız. Sonra ArrayList türünde negatif ve pozitif isimli koleksiyonlar oluşturarak negatifleri negatif adlı diziye, pozitifleri pozitif adlı diziye atayan ve bu dizileri gösteren programı oluşturunuz.


            //4. soru Cevap
            //int[] numbers = new int[200];
            //Random rnd = new Random();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = rnd.Next(-100,100);
            //}

            //ArrayList arrayPozitif = new ArrayList();
            //ArrayList arrayNegatif = new ArrayList();
            //int sifirCounter = 0;


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > 0)
            //    {
            //        arrayPozitif.Add(numbers[i]);
            //    }else if (numbers[i] < 0)
            //    {
            //        arrayNegatif.Add(numbers[i]);
            //    }
            //    else
            //    {
            //        sifirCounter++;
            //    }

            //}

            //Console.WriteLine("Pozitif Sayı Listesi");
            //foreach (var item in arrayPozitif)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Negatif Sayı Listesi");
            //foreach (var item in arrayNegatif)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(sifirCounter > 0 ? "Toplam" + sifirCounter + " adet 0 rakamı bulunmaktadır." : "See you");
            #endregion

            #region Metotlar

            //Metot nedir? 


            #endregion


        }

        
    }
}