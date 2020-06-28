using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
   public class UygunlukDurumHelper
    {
        public static string UygunlukDurumuGetir(bool durum)
        {
            switch(durum)
            {
                case true:
                    return "Uygun";
                case false:
                    return "Uygun Değil";
                default:
                    return null;
            }
        }
    }
}
