using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using FilmDiziSatınAlmaUygulaması.Sınıflar;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar.İşlem_Sınıfları
{
   public class UpdateClass
    {
        public void MusteriPuan(int puan, string email)
        {

            try
            {

                Baglanti.Instance.conn.Open();

                SqlCommand komut = new SqlCommand(" update Musteri set musteriPuan ='" + puan + "' where musteriEmail = '" + email + "'", Baglanti.Instance.conn);


                komut.ExecuteNonQuery();


                Baglanti.Instance.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

                Baglanti.Instance.conn.Close();

            }
        }
        public void FilmGüncelle(Film k, int idD, int idK, int id)

        {

            try

            {

                Baglanti.Instance.conn.Open();

                SqlCommand komut = new SqlCommand("update Film set filmAdi = @p1, icerik = @p2,cikisYili=@p3,imdbPuani=@p4,dil_id=@p5,kategori_id=@p6 where film_id=@p7", Baglanti.Instance.conn);

                komut.Parameters.AddWithValue("@p1", k.filmAdi);

                komut.Parameters.AddWithValue("@p2", k.icerik);

                komut.Parameters.AddWithValue("@p3", k.tarih);

                komut.Parameters.AddWithValue("@p4", k.imdbPuani);

                komut.Parameters.AddWithValue("@p5", idD);

                komut.Parameters.AddWithValue("@p6", idK);

                komut.Parameters.AddWithValue("@p7", id);



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
