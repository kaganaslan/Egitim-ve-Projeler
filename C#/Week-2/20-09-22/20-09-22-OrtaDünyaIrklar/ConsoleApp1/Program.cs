namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen boyunuzu giriniz: ");
            double boyUser = double.Parse(Console.ReadLine());
            Console.Write("Lütfen kilonuzu giriniz: ");
            double kiloUser = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen silah için şu rakamları giriniz:\n 1- Kılıç, 2- Ok, 3-Balta, 4- Mızrak, 5-Asa");
            int weaponUser = int.Parse(Console.ReadLine());

            int dwarfCounter = 0;
            int elfCounter = 0;
            int orkCounter = 0;
            int humanCounter = 0;
            int mageCounter = 0;

            if (boyUser > 150)
            {
                elfCounter++;
                humanCounter++;
                orkCounter++;
                mageCounter++;
                if (boyUser <160)
                {
                    dwarfCounter++;
                    
                }
            }else if (boyUser >= 170 )
            {
                orkCounter++;
                elfCounter++;
                mageCounter++;

            }else if(boyUser >= 175)
            {
                orkCounter++;
                mageCounter++;
            }else if(boyUser >= 180)
            {
                orkCounter++;
            }

            if (weaponUser == 1 )
            {
                dwarfCounter++;
                humanCounter++;
                mageCounter++;
            }else if(weaponUser == 2){
                elfCounter++;
                humanCounter++;

            }else if(weaponUser == 3)
            {
                orkCounter++;
                dwarfCounter++;
            }
            else if(weaponUser == 4)
            {
                elfCounter++;
                orkCounter++;
            }else if(weaponUser== 5)
            {
                mageCounter++;
                elfCounter++;
            }

            if(kiloUser >85)
            {
                dwarfCounter++;
                orkCounter++;
                humanCounter++;
                
            }else if (kiloUser < 85)
            {
                elfCounter++;
                mageCounter++;

            }else if(kiloUser> 85 && kiloUser<120)
            {
                humanCounter++;
            }

            if (humanCounter > orkCounter && humanCounter> elfCounter && humanCounter> dwarfCounter && humanCounter> mageCounter)
            {
                Console.WriteLine("You're a human");
            }else if(orkCounter > elfCounter && orkCounter>humanCounter && orkCounter> mageCounter && orkCounter>dwarfCounter)
            {
                Console.WriteLine("You're an ork");
            }else if(elfCounter>orkCounter && elfCounter > humanCounter && elfCounter>mageCounter && elfCounter> dwarfCounter)
            {
                Console.WriteLine("You're an elf");
            }else if(dwarfCounter>orkCounter && dwarfCounter>elfCounter && dwarfCounter>humanCounter && dwarfCounter>mageCounter)
                Console.WriteLine("You're a dwarf");
            else
            {
                Console.WriteLine("You're a mage!");
            }

            
        }
    }
}