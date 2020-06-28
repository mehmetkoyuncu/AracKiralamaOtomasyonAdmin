using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enum
{
   public class VitesTiphelper
    {
        public static string VitesTipGetir(int VitesTipID)
        {
            switch(VitesTipID)
            {
                case 1:
                    return "Düz";
                case 2:
                    return "Yarı Otomatik";
                case 3:
                    return "Otomatik";
                default:
                    return null;
            }
        }
    }
}
