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
    public partial class ProjeEkleme : MetroForm
    {
        public ProjeEkleme()
        {
            InitializeComponent();
        }
        public int userId { get; set; }
        public string userName { get; set; }
        cProje proje = new cProje();
        Tasks task = new Tasks();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
          //Proje Adı dolu mu diye kontrol ediliyor  
          if(txtProjeAdi.Text=="")
           {
               lblProjeAdiHata.Visible = true;
           }
          else
          {
                //Proje Adı dolu ise yeni proje ekliyor ve task sayfasını açıyor
                proje.projeAdi = txtProjeAdi.Text;
                proje.bitisTarihi = date.Value;
                proje.kurucuId = userId;
                proje.notlar = txtNotlar.Text;
                proje.projeAciklama = txtAciklama.Text;
                proje.ProjeEkle();
                task.projectName = txtProjeAdi.Text;
                task.userName = userName;
                task.Show();
                this.Hide();

            }
           
        }

        private void txtProjeAdi_TextChanged(object sender, EventArgs e)
        {
            //Proje adı karakter sınırını kontrol ediyor
            string ad = txtProjeAdi.Text;
            int a = ad.Length;
            if(a==20)
            {
                lblMaksimumHata.Visible = true;
            }
            else
            {
                lblMaksimumHata.Visible = false;
            }
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            //Projeler sayfasına geri dönüyor
            Projeler projeler = new Projeler();
            projeler.kullaniciId = userId;
            projeler.kullaniciAdi = userName;
            projeler.Show();
            this.Hide();

        }
    }
}
