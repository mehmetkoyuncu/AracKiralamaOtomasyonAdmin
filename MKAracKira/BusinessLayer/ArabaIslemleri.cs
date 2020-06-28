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
   public class ArabaIslemleri
    {
        public List<Arac> AracGetir()
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "Select * From Arac";
            DataTable sonuc = provider.TabloGetir(sorgu);

            List<Arac> araclar = new List<Arac>();

            if(sonuc.Rows.Count>0)
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

        public List<VitesTip> VitesTipleriGetir()
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "Select * From VitesTip";
            DataTable sonuc = provider.TabloGetir(sorgu);

            List <VitesTip> vitesTipListe= new List<VitesTip>();

            if (sonuc.Rows.Count>0)
            {
                foreach (DataRow dr in sonuc.Rows)
                {
                    VitesTip vites = new VitesTip();
                    vites.ID = (int)dr["ID"];
                    vites.VitesTipAdi =dr["VitesTip"].ToString();
                 

                    vitesTipListe.Add(vites);
                }
            }

            return vitesTipListe; 

        }

        public List<YakitTip> yakitTipGetir()
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "Select * From YakitTipi";
            DataTable sonuc = provider.TabloGetir(sorgu);

            List<YakitTip> yakitTipList = new List<YakitTip>();

            if(sonuc.Rows.Count>0)
            {
                foreach (DataRow dr in sonuc.Rows)
                {
                    YakitTip yakit = new YakitTip();
                    yakit.ID = (int)dr["ID"];
                    yakit.YakitTipAdi = dr["YakitTipi"].ToString();
                    yakitTipList.Add(yakit);
                }
            }
            return yakitTipList;
                
        }



        public List<AracSinif> AracSinifGetir()
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "Select * From AracSinif";
            DataTable sonuc = provider.TabloGetir(sorgu);

            List<AracSinif> aracSinifList = new List<AracSinif>();

            if (sonuc.Rows.Count > 0)
            {
                foreach (DataRow dr in sonuc.Rows)
                {
                    AracSinif sinif = new AracSinif();
                    sinif.ID = (int)dr["ID"];
                    sinif.AracSinifAdi = dr["AracSinif"].ToString();
                    aracSinifList.Add(sinif);
                }
            }
            return aracSinifList;

        }

        public List<Marka> MarkaGetir()
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "Select * From Marka";
            DataTable sonuc = provider.TabloGetir(sorgu);

            List<Marka> markaList = new List<Marka>();

            if (sonuc.Rows.Count > 0)
            {
                foreach (DataRow dr in sonuc.Rows)
                {
                    Marka marka = new Marka();
                    marka.ID = (int)dr["ID"];
                    marka.MarkaAdi = dr["Marka"].ToString();
                    markaList.Add(marka);
                }
            }
            return markaList;

        }


        public int AracEkle(Arac arac)
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "INSERT INTO Arac (Model,DurumUygunmu,Fiyat,Ozellik1,Ozellik2,Ozellik3,Ozellik4,AracSinifID," +
                "VitesTipID,YakitTipID,MarkaID,AracResim) VALUES(@Model,@DurumUygunmu,@Fiyat,@Ozellik1,@Ozellik2,@Ozellik3,@Ozellik4," +
                "@AracSinifID,@VitesTipID,@YakitTipID,@MarkaID,@AracResim)";
          
            provider.komut.Parameters.AddWithValue("@Model", arac.Model);
            provider.komut.Parameters.AddWithValue("DurumUygunmu", arac.DurumUygunmu); 
            provider.komut.Parameters.AddWithValue("Fiyat", arac.Fiyat);
            provider.komut.Parameters.AddWithValue("Ozellik1", arac.Ozellik1);
            provider.komut.Parameters.AddWithValue("Ozellik2", arac.Ozellik2);
            provider.komut.Parameters.AddWithValue("Ozellik3", arac.Ozellik3);
            provider.komut.Parameters.AddWithValue("Ozellik4", arac.Ozellik4);
            provider.komut.Parameters.AddWithValue("AracSinifID", arac.AracSinifID);
            provider.komut.Parameters.AddWithValue("VitesTipID", arac.VitesTipID);
            provider.komut.Parameters.AddWithValue("YakitTipID", arac.YakitTipID);
            provider.komut.Parameters.AddWithValue("MarkaID", arac.MarkaID);
            provider.komut.Parameters.AddWithValue("AracResim", arac.AracResim);
            int sonuc = provider.SorguyuCalistir(sorgu);
            return sonuc;



        }

        public int AracGuncelle(Arac arac)
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "UPDATE Arac SET Model=@Model,DurumUygunmu=@DurumUygunmu,Fiyat=@Fiyat,Ozellik1=@Ozellik1," +
                "Ozellik2=@Ozellik2,Ozellik3=@Ozellik3,Ozellik4=@Ozellik4,AracSinifID=@AracSinifID,VitesTipID=@VitesTipID," +
                "YakitTipID=@YakitTipID,MarkaID=@MarkaID,AracResim=@AracResim WHERE ID=@id";

            provider.komut.Parameters.AddWithValue("id", arac.ID);
            provider.komut.Parameters.AddWithValue("@Model", arac.Model);
            provider.komut.Parameters.AddWithValue("DurumUygunmu", arac.DurumUygunmu);
            provider.komut.Parameters.AddWithValue("Fiyat", arac.Fiyat);
            provider.komut.Parameters.AddWithValue("Ozellik1", arac.Ozellik1);
            provider.komut.Parameters.AddWithValue("Ozellik2", arac.Ozellik2);
            provider.komut.Parameters.AddWithValue("Ozellik3", arac.Ozellik3);
            provider.komut.Parameters.AddWithValue("Ozellik4", arac.Ozellik4);
            provider.komut.Parameters.AddWithValue("AracSinifID", arac.AracSinifID);
            provider.komut.Parameters.AddWithValue("VitesTipID", arac.VitesTipID);
            provider.komut.Parameters.AddWithValue("YakitTipID", arac.YakitTipID);
            provider.komut.Parameters.AddWithValue("MarkaID", arac.MarkaID);
            provider.komut.Parameters.AddWithValue("AracResim", arac.AracResim);
            int sonuc = provider.SorguyuCalistir(sorgu);
            return sonuc;



        }

        public int Sil(int id)
        {
            DataProvider provider = new DataProvider(ConstrName.ConnectionString);
            string sorgu = "DELETE FROM Arac WHERE ID=@iD";

            provider.komut.Parameters.AddWithValue("iD", id);
         
            int sonuc = provider.SorguyuCalistir(sorgu);
            return sonuc;



        }




    }
}
