using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace yenim
{
    public class cKullanici
    {
        public int userId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        cBaglanti baglanti = new cBaglanti();

        //Yeni bir kullanıcı eklerken kullanılan fonksiyon
        public void KullaniciEkle()
        {
            SqlCommand ekle = new SqlCommand("exec AddUser @kullaniciAdi, @sifre, @ad, @soyad", baglanti.Baglanti());
            ekle.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            ekle.Parameters.AddWithValue("@sifre", sifre);
            ekle.Parameters.AddWithValue("@ad", ad);
            ekle.Parameters.AddWithValue("@soyad", soyad);
            ekle.ExecuteNonQuery();
            baglanti.Baglanti().Close();
           
        }
        //Kullanıcı adına göre kullanıcı numarası getiren fonksiyon
        public int KullaniciGetir(string kullaniciAd)
        {
            SqlCommand getir = new SqlCommand("select UserId from Users where UserName=@kullaniciAdi ", baglanti.Baglanti());
            getir.Parameters.AddWithValue("@kullaniciAdi",kullaniciAd);
            SqlDataReader dr = getir.ExecuteReader();

            if(dr.Read())
            {
                userId=Convert.ToInt32(dr["UserId"]);
                return 1;
          
            }
            baglanti.Baglanti().Close();
            throw new InvalidOperationException();
            
            
        }

        //Kullanıcı numarasına göre kullanıcı adı getiren fonksiyon
        public void KullaniciAdiGetir(int userId)
        {
            SqlCommand getir = new SqlCommand("select UserName from Users where UserId=@userId ", baglanti.Baglanti());
            getir.Parameters.AddWithValue("@userId", userId);
            SqlDataReader dr = getir.ExecuteReader();

            if (dr.Read())
            {
                kullaniciAdi = dr["UserName"].ToString();
              
            }

            baglanti.Baglanti().Close();
           

        }

    }
}
