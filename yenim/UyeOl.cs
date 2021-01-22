using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yenim
{
    public partial class UyeOl : MetroForm
    {
        public UyeOl()
        {
            InitializeComponent();
        }

     
        Login login = new Login();
        private void GiriseDon_Click(object sender, EventArgs e)
        {
            //Giriş Yap Ekranına Döndürür
            login.Show();
            this.Hide();
        }
        cKullanici kullanici = new cKullanici();

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            //Üye olmak için Boş bırakılmama kontrolü yapılıyor
            if (txtKullaniciAdi.Text == "")
            {
                lblKullaniciAdi.Visible = true;

            }
            else if(txtAd.Text=="")
            {
                lblAd.Visible = true;
            }
            else if (txtSoyad.Text == "")
            {
                lblSoyad.Visible = true;
            }
            else if (txtSifre.Text == "")
            {
                lblSifre.Visible = true;
            }
            else
            {
                //Üye olunduktan sonra kişiye özel proje sayfası açılıyor
                lblSifre.Visible = false;
                lblKullaniciAdi.Visible = false;
                lblAd.Visible = false;
                lblSoyad.Visible = false;
                kullanici.kullaniciAdi = txtKullaniciAdi.Text;               
                kullanici.sifre = txtSifre.Text;                
                kullanici.ad = txtAd.Text;               
                kullanici.soyad = txtSoyad.Text;                
                kullanici.KullaniciEkle();
                MessageBox.Show("Bilgileriniz başarıyla kaydedildi.");
                login.Show();
                this.Hide();

            }
        }


        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            //Kullanıcı Adı karakter sınırı kontrol ediliyor
            kullanici.kullaniciAdi = txtKullaniciAdi.Text;
            int k = kullanici.kullaniciAdi.Length;
            if(k==20)
            {
                lblMaksimum.Visible = true;
            }
            else if(k<20)
            {
                lblMaksimum.Visible = false;
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            // Ad karakter sınırı kontrol ediliyor
            kullanici.ad = txtAd.Text;
            int a = kullanici.ad.Length;
            if (a == 20)
            {
                lblMaksimum.Visible = true;
            }
            else if(a<20 )
            {
                lblMaksimum.Visible = false;
            }
          
            
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            //Soyad karakter sınırı kontrol ediliyor 
            kullanici.soyad = txtSoyad.Text;
            int so = kullanici.soyad.Length;
            if (so == 20)
            {
                lblMaksimum.Visible = true;
            }
            else if (so < 20)
            {
                lblMaksimum.Visible = false;
            }

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            //Şifre karakter sınırı kontrol ediliyor
            kullanici.sifre = txtSifre.Text;
            int s = kullanici.sifre.Length;
            if (s == 20)
            {
                lblMaksimum.Visible = true;
            }
            else if (s < 20)
            {
                lblMaksimum.Visible = false;
            }
        }

      
    }
}
