using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Ornek_Sinema
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double hasilat;
        string salonNo;

        const double TAM = 60.0;
        const double INDIRIMLI = 45.0;


        public Sinema(string salon1, int sayiKoltuk)
        {
            toplamKoltukSayisi = sayiKoltuk;
            salonNo = salon1;
            bosKoltukSayisi = toplamKoltukSayisi;
            hasilat = 0;
        }


        public void BiletSat(bool indirimli)
        {
            bosKoltukSayisi--;
            if (indirimli == true)
            {
                hasilat += INDIRIMLI;
            }
            else
            {
                hasilat += TAM;
            }
        }

        public void BiletIptal(bool indirimli)
        {
            bosKoltukSayisi++;
            if (indirimli == true)
            {
                hasilat -= INDIRIMLI;
            }
            else
            {
                hasilat -= TAM;
            }
        }

        public int BosKoltukMetot()
        {
            return bosKoltukSayisi;
        }

        public double HasilatOgrenmeMetodu()
        {
            return hasilat;
        }
    }
}
