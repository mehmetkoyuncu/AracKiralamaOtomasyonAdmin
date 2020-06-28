using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
   public class AracSinifEnum
    {
        public static string AracSinifGetir(int? AracSinifİD)
        {
            switch (AracSinifİD)
            {
                case 1:
                    return "Ekonomi";
                case 2:
                    return "Üst";
                case 3:
                    return "Minibüs";
                default:
                    return null;
                
            }
        }
    }
}
