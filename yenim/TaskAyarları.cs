using MetroFramework.Controls;
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
using System.Data.SqlClient;


namespace yenim
{
    public partial class TaskAyarları : MetroForm
    {
        public TaskAyarları()
        {
            InitializeComponent();

        }
        cKart kart = new cKart();
        cProje proje = new cProje();
        cKullanici kullanici = new cKullanici();
        cBaglanti baglanti = new cBaglanti();
        public int ProjeNo { get; set; }
        public string ProjeAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public int kullaniciNo { get; set; }
        public string KartAdi { get; set; }
       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Boş geçilemez alanların konrolü ve kart eklemenin yapıldığı kısım
            if(cboxKullanici.SelectedIndex==-1)
            {
                lblTeknikUzmanHata.Visible = true;
            }
            else if(txtKartAdi.Text=="")
            {
                lblKartAdiHata.Visible = true;
            }
            else
            {
                kart.ProjeNo = ProjeNo;
                kart.KartAdi = txtKartAdi.Text;
                kart.Aciklama = txtAciklama.Text;
                kart.Notlar = txtNotlar.Text;
                kullanici.KullaniciGetir(cboxKullanici.SelectedItem.ToString());
                kart.KartEkle(kullanici.userId);

                Tasks pano = new Tasks();
                pano.userId = kullaniciNo;
                pano.projectId = ProjeNo;
                pano.projectName = ProjeAdi;
                pano.userName = KullaniciAdi;

                pano.Show();
                this.Hide();
            }
            
          
        }
        //Eğer güncellenecekse ilgili alanların dolu gelmesi
        private void Pano_Load(object sender, EventArgs e)
        {
            lblProjeAdi.Text = ProjeAdi;
            kart.ProjeGetir(KartAdi);
            kullanici.KullaniciAdiGetir(kart.TaskKullanici);
            KullaniciListele();
            cboxKullanici.SelectedIndex = 0;
            if(kullanici.kullaniciAdi==null)
            {
                lblTeknik.Visible = false;
            }
            else
            {
                lblTeknik.Text = "Teknik Uzman Adı: " + kullanici.kullaniciAdi;
            }

            
            txtNotlar.Text = kart.Notlar;
            txtAciklama.Text = kart.Aciklama;
            txtKartAdi.Text = kart.KartAdi;
            if(kart.durumu==0)
            {
                lblStatu.Text = "To Do";
            }
            else if (kart.durumu==1)
            {
                lblStatu.Text = "In Progress";
            }
            else if(kart.durumu==2)
            {
                lblStatu.Text = "Revision";
            }
            else if(kart.durumu==3)
            {
                lblStatu.Text = "Check";
            }
            else if (kart.durumu==4)
            {
                lblStatu.Text = "Done";
            }
            else
            {
                lblStatu.Visible = false;
            }

            if (txtKartAdi.Text=="")
            {
                btnGuncelle.Visible = false;
                btnSil.Visible = false;
            }
            else if(txtKartAdi.Text !="")
            {
                btnEkle.Visible = false;
            }
           


        }
        //CheckBox'ın içinin doldurulması için kullanılan sql komutu
        public void KullaniciListele()
        {
            SqlCommand listele = new SqlCommand("select * from Users", baglanti.Baglanti());
            SqlDataReader dr;
            dr = listele.ExecuteReader();
            while (dr.Read())
            {
                cboxKullanici.Items.Add(dr["UserName"]);
            }
            
        }
        //Kart silme kısmı
        private void btnSil_Click(object sender, EventArgs e)
        {
            kart.ProjeGetir(KartAdi);
            kart.KartSil(kart.KartNo);
            Tasks task = new Tasks();
            task.projectId = ProjeNo;
            task.projectName = ProjeAdi;
            task.userId = kullaniciNo;
            task.userName = KullaniciAdi;
            task.Show();
            this.Hide();

        }
        //Kart güncellemenin yapıldığı kısım
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kullanici.KullaniciGetir(cboxKullanici.SelectedItem.ToString());
            Tasks task = new Tasks();
            kart.ProjeGetir(KartAdi);
            kart.Aciklama = txtAciklama.Text;
            kart.TaskKullanici = kullanici.userId;
            kart.KartAdi = txtKartAdi.Text;
            kart.Notlar = txtNotlar.Text;
            kart.KartGuncelle(kart.KartNo);
            task.projectId = ProjeNo;
            task.projectName = ProjeAdi;
            task.userId = kullaniciNo;
            task.userName = KullaniciAdi;
            task.Show();
            this.Hide();


        }
        //maksimum sınıra ulaşma durumunun kontrolü
        private void txtKartAdi_TextChanged(object sender, EventArgs e)
        {
            string ad=txtKartAdi.Text;
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
        //Projeler alanına geri dönmek için kullanılan kısım
        private void lblGeriDon_Click(object sender, EventArgs e)
        {
            Tasks pano = new Tasks();
            pano.userId = kullaniciNo;
            pano.projectId = ProjeNo;
            pano.projectName = ProjeAdi;
            pano.userName = KullaniciAdi;

            pano.Show();
            this.Hide();
        }

      
    }
}
