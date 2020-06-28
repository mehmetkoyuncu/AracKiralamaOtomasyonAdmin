using Common;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class SartliGetir
    {
        public List<Arac> AracGetir()
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "Select * From Arac";
            DataTable sonuc = provider.TabloGetir(sorgu);

            List<Arac> araclar = new List<Arac>();

            if (sonuc.Rows.Count > 0)
            {
                foreach (DataRow dr in sonuc.Rows)
                {
                    Arac arac = new Arac();
                    arac = new Arac();
                    arac.ID = (int)dr["ID"];
                    //  arac.AlinisTarihi = (DateTime)dr["AlinisTarihi"];//null
                    //    arac.VerilisTarihi = (DateTime)dr["VerilisTarihi"];//null
                    arac.AracResim = dr["AracResim"].ToString();
                    arac.AracSinifID = (dr.IsNull("AracSinifID") == true ? null : (int?)dr["AracSinifID"]);
                    arac.DurumUygunmu = (bool)dr["DurumUygunmu"];
                    arac.Fiyat = (int)dr["Fiyat"];
                    //    arac.KullaniciID = (int)dr["KullaniciID"];
                    arac.MarkaID = (int)dr["MarkaID"];
                    arac.Model = dr["Model"].ToString();
                    arac.Ozellik1 = dr["Ozellik1"].ToString();
                    arac.Ozellik2 = dr["Ozellik2"].ToString();
                    arac.Ozellik3 = dr["Ozellik3"].ToString();
                    arac.Ozellik4 = dr["Ozellik4"].ToString();

                    arac.VitesTipID = (int)dr["VitesTipID"];
                    arac.YakitTipID = (int)dr["YakitTipID"];

                    araclar.Add(arac);
                }

            }
            return araclar;
        }
    }
}
