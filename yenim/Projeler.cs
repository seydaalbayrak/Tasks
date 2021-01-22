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
    public partial class Projeler : MetroForm
    {
        public Projeler()
        {
            InitializeComponent();
           
        }
        private void Panolar_Load(object sender, EventArgs e)
        {   //Kullanıcıya göre projelerin oluşturulması         
            kullanici.KullaniciGetir(kullaniciAdi);
            kullaniciId = kullanici.userId;
            ProjeOluştur(kullanici.userId);
        }


    
        public string kullaniciAdi { get; set; }
        public int kullaniciId { get; set; }
        public int projectId { get; set; }
        cKullanici kullanici = new cKullanici();
        cBaglanti baglanti = new cBaglanti();
        cProje cProje = new cProje();




       
        //Projelerin oluşturulduğu blok
        public void ProjeOluştur(int userId)
        {
            
            using (SqlCommand m = new SqlCommand("exec ListProjectsFromUserId @UserId", baglanti.Baglanti()))
            {
                
                m.Parameters.AddWithValue("@userId",userId);
                SqlDataReader oku = m.ExecuteReader();
                while(oku.Read())
                {
                    Button btn = new Button();
                    btn.ForeColor = Color.DodgerBlue;
                    btn.Text = String.Concat(oku["ProjectName"]);                   
                    btn.Size = new System.Drawing.Size(120, 90);                     
                    btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                    btn.BackColor = Color.FloralWhite;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += new EventHandler(btn_Click);
                    flowLayoutPanel1.Controls.Add(btn);
                }

            }
        }
        //Yeni bir proje eklenen blok
        private void btnProjeEkle_Click(object sender, EventArgs e)
        {

            ProjeEkleme proje = new ProjeEkleme();
            proje.userId = Convert.ToInt32(kullanici.userId);
            proje.userName = kullaniciAdi;
            proje.ShowDialog();
            this.Hide();
        }
        //Task sayfasına yönlendiren blok
        void btn_Click(object sender, EventArgs e)
        {
            
            Tasks task = new Tasks();  
            task.userName = kullaniciAdi;
            task.projectName = ((Button)sender).Text;
            task.userId = kullaniciId;
            task.Show();
            this.Hide();
            
        }
        //Giriş yap ekranına dönülen yer
        private void lblCikisYap_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
