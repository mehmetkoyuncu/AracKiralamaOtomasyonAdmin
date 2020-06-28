using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKAracKira
{
   public class OnDenetleme
    {
        public string Mail { get; set; }
        public string Sifre { get; set; }

        public bool MailDenetle()
        {
            if(Mail=="")
            {
                return true;
            }
            return false;
        }
        public bool SifreDenetle()
        {
            if (Sifre == "")
            {
                return true;
            }
            return false;
        }
    }
}
