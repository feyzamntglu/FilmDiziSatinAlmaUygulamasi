using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using FilmDiziSatınAlmaUygulaması.Sınıflar;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar
{
   public class İnsertClass
    {
         public void FilmEkle(KomediClass k, int idD,int idK)
        { 
            
            try
            {
                Baglanti.Instance.conn.Open();
            // Baglanti b = new Baglanti();
               


                SqlCommand komut = new SqlCommand("INSERT INTO Film(filmAdi, icerik, cikisYili, imdbPuani,dil_id,kategori_id ) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.Instance.conn);
                komut.Parameters.AddWithValue("@p1", k.AdFilmAdi);
                komut.Parameters.AddWithValue("@p2", k.AdIcerik);
                komut.Parameters.AddWithValue("@p3", k.AdTarih);
                komut.Parameters.AddWithValue("@p4", k.AdImdbPuani);
                komut.Parameters.AddWithValue("@p5", idD);
                komut.Parameters.AddWithValue("@p6", idK);


                komut.ExecuteNonQuery();

                Baglanti.Instance.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

                Baglanti.Instance.conn.Close();

            }
        }
        public void SatınAl(int idf,int idm,int ucret)

        {

            try
            {
                Baglanti.Instance.conn.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO SatinAlma(ucret, film_id, musteri_id) VALUES (@p1,@p2,@p3)", Baglanti.Instance.conn);
                komut.Parameters.AddWithValue("@p1",ucret);
                komut.Parameters.AddWithValue("@p2",idf);
                komut.Parameters.AddWithValue("@p3",idm);
                

                komut.ExecuteNonQuery();


                Baglanti.Instance.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

                Baglanti.Instance.conn.Close();

            }
        }
       
        public void BilimKurguFilmEkle(BilimKurguClass b, int idD, int idK)
        {

            try
            {
                Baglanti.Instance.conn.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO Film(filmAdi, icerik, cikisYili, imdbPuani,dil_id,kategori_id ) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.Instance.conn);
                komut.Parameters.AddWithValue("@p1", b.AdFilmAdi);
                komut.Parameters.AddWithValue("@p2", b.AdIcerik);
                komut.Parameters.AddWithValue("@p3", b.AdTarih);
                komut.Parameters.AddWithValue("@p4", b.AdImdbPuani);
                komut.Parameters.AddWithValue("@p5", idD);
                komut.Parameters.AddWithValue("@p6", idK);


                komut.ExecuteNonQuery();


                Baglanti.Instance.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

                Baglanti.Instance.conn.Close();

            }
        }
        public void RomantikFilmEkle(RomantikClass r, int idD, int idK)
        {

            try
            {
                Baglanti.Instance.conn.Open();

                SqlCommand komut = new SqlCommand("INSERT INTO Film(filmAdi, icerik, cikisYili, imdbPuani,dil_id,kategori_id ) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.Instance.conn);
                komut.Parameters.AddWithValue("@p1", r.AdFilmAdi);
                komut.Parameters.AddWithValue("@p2", r.AdIcerik);
                komut.Parameters.AddWithValue("@p3", r.AdTarih);
                komut.Parameters.AddWithValue("@p4", r.AdImdbPuani);
                komut.Parameters.AddWithValue("@p5", idD);
                komut.Parameters.AddWithValue("@p6", idK);


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
