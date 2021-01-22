using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace yenim
{
    public class cGirisKontrolu
    {
        cBaglanti baglanti = new cBaglanti();
        //Giriş ekranında kullanıcı adı şifre kontrolü
        public bool KullaniciDogrula(string kullaniciAdi,string sifre)
        {

            SqlCommand komut = new SqlCommand("Select * From Users where UserName=@kullaniciAdi and Password = @sifre", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
    }
}
