using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace yenim
{
    public class cBaglanti
    {
        //Database bağlantısı yapılan blok
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-BKRH9DR;Initial Catalog=ProjeTakipUygulaması;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

        
    }
}
