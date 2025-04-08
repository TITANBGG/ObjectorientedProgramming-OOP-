using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 //using System;


namespace HaliYikamaTakipSistemi
{
   

    public class Hali
    {
        public double Metrekare { get; set; }
        public DateTime AlinmaTarihi { get; set; }
        public DateTime TahminiTeslimTarihi { get; set; }
        public bool TeslimEdildi { get; set; }

        public double Ucret => Metrekare * 20;

        public string Durum => TeslimEdildi ? "Teslim Edildi" : "Yıkamada";

        public override string ToString()
        {
            return $"{Metrekare} m² - {Durum} - {Ucret} TL";
        }
    }

}
