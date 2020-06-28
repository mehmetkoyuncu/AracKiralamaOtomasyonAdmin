using BusinessLayer;
using Common;
using DataAccessLayer;
using Entities;
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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        int hak = 3;


        public bool OnDenetleme()
        {
            string KullaniciAdi = txtMail.Text.Trim();
            string Sifre = txtMail.Text.Trim();

            bool result = false;

            OnDenetleme denetle = new OnDenetleme();
            denetle.Mail = txtMail.Text;
            denetle.Sifre = txtSifre.Text;
            bool KullaniciAdiDenetle = denetle.MailDenetle();
            bool SifreDenetke = denetle.SifreDenetle();
            if (KullaniciAdiDenetle == true)
            {
                errorProvider1.SetError(txtMail, "Mail Alanı Boş Geçilemez");
                result = true;
              
            }
            if (SifreDenetke == true)
            {
                errorProvider1.SetError(txtSifre, "Sifre Alanı Boş Geçilemez");
                result = true;
            }
            return result;
        }


        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtMail.Text.Trim();
            string Sifre = txtSifre.Text.Trim();


            if (OnDenetleme() == true)
                return;
            errorProvider1.Clear();

            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            Kullanici kullanici= kullaniciIslemleri.KullaniciLogin(KullaniciAdi, Sifre);
           
            if (kullanici!=null)
            {
                if(kullanici.Adminmi==true)
                {
                    this.Hide();
                    AdminPage adminSayfasi = new AdminPage();
                    adminSayfasi.kullanici = kullanici;    
                    adminSayfasi.ShowDialog();
                    this.Close();
                }
           

            }
            else
            {
                if (hak == 0)
                {
                    Application.Exit();
                }


                hak--;
                MessageBox.Show("Kullanıcı Adı veya Şifre Başarısız !! \nKalan deneme hakkı = " + hak.ToString(), "Hatalı Giriş",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {


        }
    }
}
