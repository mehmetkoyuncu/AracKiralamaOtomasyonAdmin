using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
   public class YakittipiEnumHelper
    {
        public static string YakitTipiGetir(int yakitTipID)
        {
            switch (yakitTipID)
            {
                case 1:
                    return "Benzin ";
                case 2:
                    return "Dizel";
                case 3:
                    return "LPG";
                case 4:
                    return "Elektrik";
                default:
                    return null;
            }
        }
    }
}
