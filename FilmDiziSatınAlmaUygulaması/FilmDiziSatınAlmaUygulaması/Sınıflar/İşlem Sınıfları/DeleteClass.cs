using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar.İşlem_Sınıfları
{
   public class DeleteClass
    {
        public void FilmSil(int film_id)
        {
            try
            {
                Baglanti.Instance.conn.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Film where film_id=@p1", Baglanti.Instance.conn);

                komut.Parameters.AddWithValue("@p1", film_id);

                komut.ExecuteNonQuery();

                Baglanti.Instance.conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Baglanti.Instance.conn.Close();
            }

        }
    }
}

