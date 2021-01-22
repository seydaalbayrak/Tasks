using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yenim
{
    public class cKart
    {
      
        public int KartNo { get; set; }
        public int ProjeNo { get; set; }
        public string KartAdi { get; set; }
        public string Aciklama { get; set; }
        public string Notlar { get; set; }
        public int TaskKullanici { get; set; }
        public int durumu { get; set; }
         

        cBaglanti baglanti = new cBaglanti();
        //Database'e yeni bir kart eklemek için kullanılan fonsyon
        public void KartEkle(int kullaniciNo)
        {
            SqlCommand ekle = new SqlCommand("exec AddProjectTasks @kullaniciNo,@projeNo,@kartAdi,@aciklama,@notlar", baglanti.Baglanti());
            ekle.Parameters.AddWithValue("@kullaniciNo", kullaniciNo);
            ekle.Parameters.AddWithValue("@projeNo", ProjeNo);
            ekle.Parameters.AddWithValue("@kartAdi", KartAdi);
            ekle.Parameters.AddWithValue("@aciklama", Aciklama);
            ekle.Parameters.AddWithValue("@notlar", Notlar);
            ekle.ExecuteNonQuery();
            baglanti.Baglanti().Close();
        }
        //Databse'den kart silmek için kullanılan fonskiyon
        public void KartSil(int kartNo)
        {
            SqlCommand sil = new SqlCommand("exec DeleteProjectTasks @kartNo", baglanti.Baglanti());
            sil.Parameters.AddWithValue("@kartNo", KartNo);
           
            sil.ExecuteNonQuery();
            baglanti.Baglanti().Close();
        }
        //Database'de bulunan kartları listelemek için kullanılan fonksiyon
        public void ProjeGetir(string TaskAdi)
        {
            SqlCommand getir = new SqlCommand("select UserId,TaskId,TaskName,TaskDescription,Notes,Status from ProjectTasks where TaskName=@projectName ", baglanti.Baglanti());
            getir.Parameters.AddWithValue("@projectName", TaskAdi);
            SqlDataReader dr = getir.ExecuteReader();

            if (dr.Read())
            {
                TaskKullanici = Convert.ToInt32(dr["UserId"]);
                KartNo = Convert.ToInt32(dr["TaskId"]);
                KartAdi = dr["TaskName"].ToString();
                Aciklama = dr["TaskDescription"].ToString();
                Notlar = dr["Notes"].ToString();
                durumu =Convert.ToInt32(dr["Status"]);
                

            }
            baglanti.Baglanti().Close();
            
            
        }
        //Database'de bulunan kartları güncellemek için kullanılan fonksiyon
        public void KartGuncelle(int KartNo)
        {
            SqlCommand ekle = new SqlCommand("exec UpdateTasks @TaskId,@UserId,@TaskName,@TaskDescription,@Notes", baglanti.Baglanti());

            ekle.Parameters.AddWithValue("@UserId",TaskKullanici);
            ekle.Parameters.AddWithValue("@TaskId", KartNo);
            ekle.Parameters.AddWithValue("@TaskName", KartAdi);
            ekle.Parameters.AddWithValue("@TaskDescription", Aciklama);
            ekle.Parameters.AddWithValue("@Notes", Notlar);
            ekle.ExecuteNonQuery();
            baglanti.Baglanti().Close();
        }
        //Database'de bulunan kartın durumunu güncellemek için kullanılan fonksiyon
        public void KartDurumuGuncelle(int KartNo, int durumu)
        {
            SqlCommand guncelle = new SqlCommand("exec UpdateTaskStatus @TaskId,@Status", baglanti.Baglanti());

            guncelle.Parameters.AddWithValue("@Status", durumu);
            guncelle.Parameters.AddWithValue("@TaskId", KartNo);
           
            guncelle.ExecuteNonQuery();
            baglanti.Baglanti().Close();
        }


    }


}
