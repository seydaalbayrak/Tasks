using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yenim
{
    public class cProje
    {
        public string projeAdi { get; set; }
        public DateTime bitisTarihi { get; set; }
        public int kurucuId { get; set; }
        public string projeAciklama { get; set; }
        public string notlar { get; set; }
        public int projeId { get; set; }
        public string tahminiSure { get; set; }
        public string baslangicTarihi { get; set; }

        cBaglanti baglanti = new cBaglanti();
        //Yeni bir proje eklerken kullanılan fonksiyon
        public void ProjeEkle()
        {
            SqlCommand ekle = new SqlCommand("exec AddProject @projeAdi,@bitisTarihi,@kurucuId,@projeAciklama,@notlar", baglanti.Baglanti());
            ekle.Parameters.AddWithValue("@projeAdi", projeAdi );
            ekle.Parameters.AddWithValue("@bitisTarihi",bitisTarihi );
            ekle.Parameters.AddWithValue("@kurucuId",kurucuId );
            ekle.Parameters.AddWithValue("@projeAciklama",projeAciklama );
            ekle.Parameters.AddWithValue("@notlar", notlar);
            ekle.ExecuteNonQuery();
            baglanti.Baglanti().Close();
        }
        //Proje adına göre proje bilgileri getiren fonksiyon
        public int ProjeGetir(string projeAdi)
        {
            SqlCommand getir = new SqlCommand("select ProjectId,StartDate,EstimatedFinish from Project where ProjectName=@projectName ", baglanti.Baglanti());
            getir.Parameters.AddWithValue("@projectName", projeAdi);
            SqlDataReader dr = getir.ExecuteReader();

            if (dr.Read())
            {
                projeId = Convert.ToInt32(dr["ProjectId"]);
                baslangicTarihi = dr["StartDate"].ToString();
                tahminiSure = dr["EstimatedFinish"].ToString();
                return 1;
                
            }
              baglanti.Baglanti().Close();
            throw new InvalidOperationException();

        }
        //Proje numarıan göre proje silen fonksiyon
        public void ProjeSil(int projeId)
        {
            SqlCommand sil = new SqlCommand("exec DeleteProject @projeNo", baglanti.Baglanti());
            sil.Parameters.AddWithValue("@projeNo", projeId);
           
            sil.ExecuteNonQuery();
            baglanti.Baglanti().Close();
        }


    }



}
