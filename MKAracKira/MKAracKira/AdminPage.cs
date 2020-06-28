using BusinessLayer;
using Entities;
using Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKAracKira
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        public Kullanici kullanici { get; set; }

        private void AdminPage_Load(object sender, EventArgs e)
        {

            lblAdSoyad.Text = kullanici.Adi +" " + kullanici.Soyadi;


            ArabaIslemleri arabaIslem = new ArabaIslemleri();
            List <Arac> aracListem= arabaIslem.AracGetir();


            lstArac.DataSource = aracListem;
            lstArac.DisplayMember = "Model";

            
            List<VitesTip> vitesList=arabaIslem.VitesTipleriGetir();
            cmbVitesTipi.DataSource = vitesList;
            cmbVitesTipi.DisplayMember = "VitesTipAdi";

            List<YakitTip> yakitList = arabaIslem.yakitTipGetir();
            cmbYakitTipi.DataSource = yakitList;
            cmbYakitTipi.DisplayMember = "YakitTipAdi";


            List<AracSinif> aracSinifList = arabaIslem.AracSinifGetir();
            cmbAracSinifi.DataSource = aracSinifList;
            cmbAracSinifi.DisplayMember = "AracSinifAdi";

            List<Marka> markaListe = arabaIslem.MarkaGetir();
            cmbMarka.DataSource = markaListe;
            cmbMarka.DisplayMember = "MarkaAdi";





        }

        private void lstArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arac arac = this.lstArac.SelectedItem as Arac;
            lblID.Text = arac.ID.ToString();
            lblFiyat.Text = arac.Fiyat.ToString()+" TL";
            lblMarka.Text = EnumMarkaHelper.MarkaEnumGetir(arac.MarkaID);
            lblModel.Text = arac.Model.ToString();
            lblEkOzellikler.Text = arac.Ozellik1 + " " + arac.Ozellik2 + " " + arac.Ozellik3 + " " + arac.Ozellik4;
            lblVitesTipi.Text = VitesTiphelper.VitesTipGetir(arac.VitesTipID);
            lblAracSinifi.Text = AracSinifEnum.AracSinifGetir(arac.AracSinifID);
            lblUygunlukDurumu.Text = UygunlukDurumHelper.UygunlukDurumuGetir(arac.DurumUygunmu);
            lblYakitTipi.Text = YakittipiEnumHelper.YakitTipiGetir(arac.YakitTipID);
            lblEkOzellikler.Text = arac.Ozellik1 + " " + arac.Ozellik2 + " " + arac.Ozellik3 + " " + arac.Ozellik4;
            pctUrunResim.ImageLocation = arac.AracResim;


            npmFiyat.Text = arac.Fiyat.ToString();
            cmbAracSinifi.SelectedItem = arac.AracSinifID;
            cmbMarka.SelectedItem = arac.MarkaID;
            cmbVitesTipi.SelectedItem = arac.VitesTipID;
            cmbYakitTipi.SelectedItem = arac.YakitTipID;
            txtEkOzellik1.Text = arac.Ozellik1;
            txtEkOzellik2.Text = arac.Ozellik2;
            txtEkOzellik3.Text = arac.Ozellik3;
            txtEkOzellik4.Text = arac.Ozellik4;
            txtModel.Text = arac.Model;
            txtResimText.Text = arac.AracResim;
            pctDuzenlenecek.ImageLocation = arac.AracResim;
            if(arac.DurumUygunmu==true)
            {
                rbUygun.Checked = true;
            }
            if(arac.DurumUygunmu==false)
            {
                rbUygunDegil.Checked = true;
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Marka marka = cmbMarka.SelectedItem as Marka;
            int MarkaID = marka.ID;
            AracSinif sinif = cmbAracSinifi.SelectedItem as AracSinif;
            int SinifID = sinif.ID;
            VitesTip vites = cmbVitesTipi.SelectedItem as VitesTip;
            int VitesTipID = vites.ID;
            YakitTip yakit = cmbYakitTipi.SelectedItem as YakitTip;
            int YakitTipID = yakit.ID;
            string ozellik1 = txtEkOzellik1.Text;
            string ozellik2 = txtEkOzellik2.Text;
            string ozellik3 = txtEkOzellik3.Text;
            string ozellik4 = txtEkOzellik4.Text;
            string Model = txtModel.Text;
            string AracResim = txtResimText.Text;
            

            int fiyat = Convert.ToInt32(npmFiyat.Text);
            bool UygunlukDurumu = false;
            if(rbUygun.Checked==true)
            {
                UygunlukDurumu = true;
            }
            else if (rbUygunDegil.Checked == true)
            {
                UygunlukDurumu = false;
            }

            Arac arac = new Arac();
            arac.AracSinifID =(int?)SinifID;
            arac.DurumUygunmu = UygunlukDurumu;
            arac.Fiyat = (int?)fiyat;
            arac.MarkaID = MarkaID;
            arac.Model = Model;
            arac.Ozellik1 = ozellik1;
            arac.Ozellik2 = ozellik2;
            arac.Ozellik3 = ozellik3;
            arac.Ozellik4 = ozellik4;
            arac.VitesTipID = VitesTipID;
            arac.YakitTipID = YakitTipID;
            arac.AracResim = AracResim;
            

            ArabaIslemleri araba = new ArabaIslemleri();
            int sonuc = araba.AracEkle(arac);
            if(sonuc>0)
            {
                MessageBox.Show("Bir kayıt eklendi");
            }
            else
            {
                MessageBox.Show("Ekleme Başarısız");
            }


            ArabaIslemleri arabaIslem = new ArabaIslemleri();
            List<Arac> aracListem = arabaIslem.AracGetir();


            lstArac.DataSource = aracListem;
            lstArac.DisplayMember = "Model";






        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {

           DialogResult result= openFileDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                pctDuzenlenecek.ImageLocation = openFileDialog1.FileName;
                txtResimText.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Görsel Seçilmedi..");
            }
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ArabaIslemleri aracIslem = new ArabaIslemleri();
            Arac arac = lstArac.SelectedItem as Arac;

            int id = arac.ID;
            arac.AracResim = txtResimText.Text;
            arac.AracSinifID = (int?)cmbAracSinifi.SelectedIndex;
            bool uygunMu = false;
            if (rbUygun.Checked == true)
            {
                uygunMu = true;
            }
            if (rbUygunDegil.Checked == true)
            {
                uygunMu = false;
            }
            arac.DurumUygunmu = uygunMu;
            arac.Fiyat = Convert.ToInt32(npmFiyat.Text);
            Marka marka = cmbMarka.SelectedItem as Marka;
            arac.MarkaID = marka.ID;
            arac.Model = txtModel.Text;
            arac.Ozellik1 = txtEkOzellik1.Text;
            arac.Ozellik1 = txtEkOzellik2.Text;
            arac.Ozellik1 = txtEkOzellik3.Text;
            arac.Ozellik1 = txtEkOzellik4.Text;
            VitesTip vites = cmbVitesTipi.SelectedItem as VitesTip;
            arac.VitesTipID = vites.ID;
            YakitTip yakit = cmbYakitTipi.SelectedItem as YakitTip;
            arac.YakitTipID = yakit.ID;
            AracSinif sinif = cmbAracSinifi.SelectedItem as AracSinif;
            arac.AracSinifID = sinif.ID;

            int GuncellenenVeri = aracIslem.AracGuncelle(arac);


            if (GuncellenenVeri > 0)
            {

                MessageBox.Show("Veri Güncelllendi");
                ArabaIslemleri arabaIslem = new ArabaIslemleri();
                List<Arac> aracListem = arabaIslem.AracGetir();


                lstArac.DataSource = aracListem;
                lstArac.DisplayMember = "Model";
            }
            else
            {
                MessageBox.Show("Veri Güncellenemedi");
            }
           
       
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Arac aa = lstArac.SelectedItem as Arac;
            int id = aa.ID;
          
            
            ArabaIslemleri islem = new ArabaIslemleri();
           int SilinenVeri= islem.Sil(id);
            if(SilinenVeri>0)
            {
                MessageBox.Show("Veri Silindi");
                ArabaIslemleri arabaIslem = new ArabaIslemleri();
                List<Arac> aracListem = arabaIslem.AracGetir();


                lstArac.DataSource = aracListem;
                lstArac.DisplayMember = "Model";
            }
            else
            {
                MessageBox.Show("Veri Silinemedi");
            }
           
        }
    }
}
