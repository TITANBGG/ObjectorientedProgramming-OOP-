using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace HaliYikamaTakipSistemi
{
     

namespace HaliYikamaTakipSistemi
    {
        public class Musteri
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Telefon { get; set; }
            public string Adres { get; set; }

            public List<Hali> Halilar { get; set; } = new List<Hali>();

            public override string ToString()
            {
                return $"{Ad} {Soyad} - {Telefon}";
            }
        }
    }

}
