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
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }


        private void UyeOl_Click(object sender, EventArgs e)
        {
            //Üye olma sayfasına yönledirme
            UyeOl singUp = new UyeOl();
            singUp.Show();
            this.Hide();

          
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //Giriş için iligili alanların boş bırakılma kontrolü
            if (txtKullaniciAdi.Text =="")
            {
                lblKullaniciAdi.Visible = true;

            }
            else if (txtSifre.Text =="")
            {
                lblSifre.Visible = true;
            }
            else
            {
                lblSifre.Visible = false;
                lblKullaniciAdi.Visible = false;

                //Giriş Kontrolü sınıfından gelen değerlerle karşılaştırma
                cGirisKontrolu giris = new cGirisKontrolu();
                bool kontrol = giris.KullaniciDogrula(txtKullaniciAdi.Text, txtSifre.Text);
                if(kontrol== true)
                {
                    
                    Projeler pano = new Projeler();
                    pano.kullaniciAdi= txtKullaniciAdi.Text;
                    
                    pano.Show();
                    this.Hide();


                }
                else
                {
                    lblHata.Visible = true;
                }

               
                
            }
        }

        

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            //Kullanıcı Adı için karakter sınırlama
            string ad = txtKullaniciAdi.Text;
            int s = ad.Length;
            if(s==20)
            {
                lblMaksimum.Visible = true;
            }
            else
            {
                lblMaksimum.Visible = false;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            //Sifre için karakter sınırlama
            string sifre = txtSifre.Text;
            int a = sifre.Length;
            if (a == 20)
            {
                lblMaksimum.Visible = true;
            }
            else
            {
                lblMaksimum.Visible = false;
            }
        }

       
    }
}
