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

        private static Baglanti instance;

        public static Baglanti Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Baglanti();
                }

                return instance;
            }
        }

        private Baglanti() { }
        
        public SqlConnection conn = null;

        public void baglantı()
        {

            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-0T2QVEL\\SQLEXPRESS;Initial Catalog=FilmDiziSatinAlma;Integrated Security=True");
                
            }
            catch
            {
                throw;
            }



        }

        
    }


}




//Data Source=DESKTOP-LQ4CI0T;Initial Catalog=FilmDiziSatinAlma;Integrated Security=True