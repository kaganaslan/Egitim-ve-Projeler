using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyon
{
    public class Konut
    {
        public int OdaSayisi { get; set; }
        public int Alan { get; set; }
        public string Adres { get; set; }
        public string Isınma { get; set; }
        public string EvSahibi { get; set; }
        public int Ucret { get; set; }

        public Konut()
        {

        }

        //public Konut(int odas, int alan, string adres, string isinma, string sahip, string kiraci, int fiyat)
        //{
        //    Adres = adres;
        //    OdaSayisi = odas;
        //    Alan = alan;
        //    EvSahibi = sahip;
        //    Isınma = isinma;
        //    Ucret = fiyat;
        //}
    }

    public class Kira : Konut
    {
        public string Kiralayan { get; set; }

        public string KiraGoster(int odas, string adres, int fiyat, string kiralayan, string evsahibi)
        {
            return $"Ev adresi: {adres}\n oda sayısı: {odas}\nFiyatı: {fiyat}\nKiracı adı: {kiralayan}\nEv Sahibi: {evsahibi}";
            
        }

        public Kira()
        {

        }

        public Kira(int odas, int alan, string adres, string isinma, string sahip, string kiraci, int fiyat)
        {
            Adres = adres;
            OdaSayisi = odas;
            Alan = alan;
            EvSahibi = sahip;
            Isınma = isinma;
            Ucret = fiyat;
            Kiralayan = kiraci;
        }
    }

    public class Satilik : Konut
    {
        public string SatinAlan { get; set; }
        public string SatilikGoster(int odas, string adres, int fiyat, string satinalan, string satan)
        {
            return $"Ev adresi: {adres}\nOda sayısı: {odas}\nFiyatı: {fiyat}\nSatın Alan: {satinalan}\nSatan: {satan}";
        }

        public Satilik()
        {

        }

        public Satilik(int odas, int alan, string adres, string isinma, string sahip, string satinalan, int fiyat)
        {
            Adres = adres;
            OdaSayisi = odas;
            Alan = alan;
            EvSahibi = sahip;
            Isınma = isinma;
            Ucret = fiyat;
            SatinAlan = satinalan;

        }


    }

}
