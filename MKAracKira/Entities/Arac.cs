using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Arac
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public bool DurumUygunmu { get; set; }
        public DateTime? AlinisTarihi { get; set; }
        public DateTime? VerilisTarihi { get; set; }
        public int? Fiyat { get; set; }
        public string Ozellik1 { get; set; }
        public string Ozellik2 { get; set; }
        public string Ozellik3 { get; set; }
        public string Ozellik4 { get; set; }
        public int? AracSinifID { get; set; }
        public int VitesTipID { get; set; }
        public int YakitTipID { get; set; }
        public int MarkaID { get; set; }
        public int? KullaniciID { get; set; }
        public string AracResim { get; set; }

      
     


    }
}
