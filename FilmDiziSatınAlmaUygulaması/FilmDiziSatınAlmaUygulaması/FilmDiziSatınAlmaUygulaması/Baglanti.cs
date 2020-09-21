using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FilmDiziSatınAlmaUygulaması
{
    class Baglanti
    {
        public static SqlConnection conn = null;

        public void baglanti()
        {
            conn = new SqlConnection("Data Source=DESKTOP-LQ4CI0T;Initial Catalog=FilmDiziSatinAlma;Integrated Security=True");
            conn.Open();
        }

    }
}
//Data Source=DESKTOP-LQ4CI0T;Initial Catalog=FilmDiziSatinAlma;Integrated Security=True