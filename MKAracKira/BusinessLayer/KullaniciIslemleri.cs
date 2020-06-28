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
   public class KullaniciIslemleri
    {

        public Kullanici KullaniciLogin(string KullaniciAdi,string Sifre)
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "Select * from Kullanici AS k where k.Mail=@mail and k.Sifre=@sifre";
            provider.komut.Parameters.AddWithValue("mail", KullaniciAdi);
            provider.komut.Parameters.AddWithValue("sifre", Sifre);
            DataTable sonuc = provider.TabloGetir(sorgu);
            Kullanici kullanici=null;

            if(sonuc.Rows.Count>0)
            {
                DataRow dr = sonuc.Rows[0];
                kullanici = new Kullanici();
                kullanici.ID = (int)dr["ID"];
                kullanici.Adi = dr["Adi"].ToString();
                kullanici.Soyadi = dr["Soyadi"].ToString();
                kullanici.Mail = dr["Mail"].ToString();
                kullanici.Sifre = dr["Sifre"].ToString();
                kullanici.Adminmi = (dr.IsNull("Adminmi") == true ? null : (bool?)dr["Adminmi"]);
                kullanici.ArabaID = (dr.IsNull("ArabaID") == true ? null : (int?)dr["ArabaID"]);
            


            }
            return kullanici;
        }

       
    }
}
