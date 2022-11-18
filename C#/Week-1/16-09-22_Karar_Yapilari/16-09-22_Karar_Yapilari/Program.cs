namespace _16_09_22_Karar_Yapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool isSeasonBahar = false;
            string name1 = "Barbaros";

            int age1 = 30;
            string[] dersler = { "html", "css", "javascript" };

            string[] dersler2 = { "c#", ".net", "react" };

            if(isSeasonBahar == true)
            {
                Console.WriteLine($"{name1} hocanın bu dönem verdiği dersler: {dersler[0]},{dersler[1]}, {dersler[2]}");
            }
            else
            {
                Console.WriteLine($"{name1} hocanın bu dönem verdiği dersler: {dersler2[0]},{dersler2[1]}, {dersler2[2]} olmak üzere 3 tanedir. Bu arada {name1} hoca {age1} yaşında karizmatik bir hocadır.");
            }

            int a = 20;
            int b = -20;
            
            int toplam = a + b;

            if (toplam > 0)
            {
                Console.WriteLine("Sayı Pozitif Bir Tam Sayıdır.");
            }
            else if (toplam <0)
            {
                Console.WriteLine("Sayı Negatif Bir Tam Sayıdır.");
            }
            else
            {
                Console.WriteLine("Sayı Sıfırdır.");
            }



            //ÖDEEEEEEVVVV
            //Kullanıcıdan 3 tane sayı girmesi istensin. Kullanıcıya girdiği sayılar gösterilsin. Ve Bunların üzerinde kullanıcıya hesap yaptırılması istensin. Örneğin girdiğiniz ("Girdiğiniz sayılar: birinci sayı: 5, ikinci sayı:2, üçüncü sayı: 4 şeklinde kullanıcıya gösterilsin. Sonra da kullanıcıya 5 tane matematiksel işlem sorusu sorulsun. Örneğin girdiğiniz sayılardan birinci ile ikincinin çarpımı nedir diye sorulsun. Gelen cevap doğru ise bildiniz, yanlış ise bilemediniz cevabı dönsün. Eğer ki en az 2 doğru cevap olursa oyunu kazandınız yazacak. 1 ve 0 doğru cevap olursa oyunu kaybettiniz yazacak."

        }
    }
}