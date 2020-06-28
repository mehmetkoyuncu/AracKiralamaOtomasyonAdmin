using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
   public class EnumMarkaHelper
    {
        public static string MarkaEnumGetir(int MarkaID)
        {
            switch (MarkaID)
            {
                case 1:
                    return "Ford";
                case 2:
                    return "Fiat";
                case 3:
                    return "BMW";
                case 4:
                    return "Mercedes";
                case 5:
                    return "Opel";
                case 6:
                    return "Kia";
                case 7:
                    return "Volkswogen";
                case 8:
                    return "Dacia";
                default:
                    return string.Empty;



            }
        }
    }
}
