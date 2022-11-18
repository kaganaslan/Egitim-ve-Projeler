using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game
{
    public class Character
    {
        public string Name { get; set; }
        public int CharNum { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }

        public int Accuracy { get; set; }


        public Character()
        {

        }

        public Character(string n, int charN, int hp, int ap, int accr)
        {
            Name = n;
            CharNum = charN;
            Hp = hp;
            Damage = ap;
            Accuracy = accr;
        }

        public void hasarAl(int dam, int acc)
        {
            Random rnd = new Random();
            int iskaRnd = rnd.Next(0,100);
            if (iskaRnd > acc)
            {
                Hp -= dam;
            }
        }

    }

}
