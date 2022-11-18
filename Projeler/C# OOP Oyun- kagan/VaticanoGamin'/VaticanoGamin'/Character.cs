using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaticanoGamin_
{
    public class Character
    {
        public string Name { get; set; }
        public int  CharNum { get; set; }
        public int  Hp { get; set; }
        public int  Damage { get; set; }
        public int  Miss { get; set; }

        public Character()
        {

        }

        public Character(string n, int characternumber, int health, int dmg , int mss)
        {
            Name = n;
            CharNum = characternumber;
            Hp = health;
            Damage = dmg;
            Miss = mss;
        }

        public void saldir(int saldir, int ismiss)
        {
            
            Random rnd = new Random();
            int iskarandom = rnd.Next(0, 100);
            if (iskarandom > ismiss)
           
            {
                Hp -= saldir;
            }
            else
            {
                
            }
        }

    }

    
}
