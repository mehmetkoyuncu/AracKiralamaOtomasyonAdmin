using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kullanici
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public int? ArabaID { get; set; }
        public bool? Adminmi { get; set; }
    
    }
}
