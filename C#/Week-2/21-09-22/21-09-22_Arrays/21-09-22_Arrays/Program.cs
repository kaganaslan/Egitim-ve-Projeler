namespace _21_09_22_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ARRAYS

            //int[] array1 = new int[5];

            //array1[0] = 85;
            //array1[1] = 54;
            //array1[2] = 23;
            //array1[3] = 72;
            //array1[4] = 61;

            //Gösterim için yöntem 1
            //foreach (var i in array1)
            //{
            //    Console.WriteLine(i);
            //}

            //Gösterim için yöntem 2
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    Console.WriteLine($"Arrayın {i}. indexi =  {array1[i]}");
            //}


            //string[] arrayMetin = new string[5];
            //arrayMetin[0] = "Barbaros";
            //arrayMetin[1] = "Kağan";
            //arrayMetin[2] = "Selin";
            //arrayMetin[3] = "Sedanur";
            //arrayMetin[4] = "Esma";

            //foreach (var x in arrayMetin)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine("***************");

            //for (int i = 0; i < arrayMetin.Length; i++)
            //{
            //    Console.WriteLine(arrayMetin[i]);
            //}


            

            //Random rastgele = new Random();

            //int rastgeleSayi1 = rastgele.Next(10, 100);

            //Console.WriteLine("Rastgelesayı: " + rastgeleSayi1);

            //int rastgeleSayi2 = rastgele.Next(50);
            //Console.WriteLine("Rastgele 2. Sayı: " + rastgeleSayi2);



            //Console.WriteLine("Random ile dizi elemanlarına değer atama");
            //Random rnd = new Random();
            //int[] dizi1 = new int[10];

            //for (int i = 0; i < dizi1.Length; i++)
            //{
            //    dizi1[i] = rnd.Next(1,64);
            //    //Console.WriteLine(dizi1[i]);
            //}

            //foreach (var item in dizi1)
            //{
            //    Console.WriteLine(item);
            //}


            //Rastgele üretilen 5 adet sayı alt alta gösterilsin büyükten küçüğe sıralansın.

            int[] dizi2 = new int[5];
            Random random = new Random();

            for (int i = 0; i < dizi2.Length; i++)
            {
                dizi2[i] = random.Next(0, 100);

            }

            Array.Sort(dizi2);
            Array.Reverse(dizi2);

            foreach (var item in dizi2)
            {
                Console.WriteLine(item);
            }



            







            #endregion
        }
    }
}