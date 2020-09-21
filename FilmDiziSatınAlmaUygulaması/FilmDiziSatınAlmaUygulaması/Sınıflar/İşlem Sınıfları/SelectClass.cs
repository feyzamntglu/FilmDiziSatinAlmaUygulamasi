using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using FilmDiziSatınAlmaUygulaması.Sınıflar;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar
{
    public class SelectClass
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable datatable = new DataTable();
        SqlCommand command = new SqlCommand();

        public void ListeleTumFilm(DataGridView dataGrid)
        {

            string sorgu = "select f.film_id,f.filmAdi,f.icerik,f.cikisYili,f.imdbPuani,f.filmAfis,f.fragman,d.dilAdi,k.kategoriAdi from Film f join Dil d on f.dil_id=d.dil_id join Kategori k on k.kategori_id=f.kategori_id ";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            dataGrid.DataSource = datatable;
        }

        public void ListeleİmdbArtan(DataGridView dataGrid)
        {

            string sorgu = "select f.film_id,f.filmAdi,f.icerik,f.cikisYili,f.imdbPuani,f.filmAfis,f.fragman,d.dilAdi,k.kategoriAdi from Film f join Dil d on f.dil_id=d.dil_id join Kategori k on k.kategori_id=f.kategori_id  order by imdbPuani";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            dataGrid.DataSource = datatable;
        }
        public void ListeleİmdbAzalan(DataGridView dataGrid)
        {

            string sorgu = "select f.film_id,f.filmAdi,f.icerik,f.cikisYili,f.imdbPuani,f.filmAfis,f.fragman,d.dilAdi,k.kategoriAdi from Film f join Dil d on f.dil_id=d.dil_id join Kategori k on k.kategori_id=f.kategori_id  order by imdbPuani desc";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            dataGrid.DataSource = datatable;
        }

        public void ListeleOyuncu(DataGridView dataGrid,string text)
        {
            string sorgu = "select * from Oyuncu natural join Film where oyuncuAdı like'%" + text + "%'";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            dataGrid.DataSource = datatable;
        }

        public void ListeleDil(DataGridView dataGrid,int index)
        {
            string sorgu = "select * From Film where dil_id=@p1 ";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);
            command.Parameters.AddWithValue("@p1", index);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            dataGrid.DataSource = datatable;

            Baglanti.Instance.conn.Close();
        }

        public void ListeleKategori(DataGridView dataGrid,int index)
        {
            string sorgu = "select f.film_id,f.filmAdi,f.icerik,f.cikisYili,f.imdbPuani,f.filmAfis,f.fragman,d.dilAdi,k.kategoriAdi from Film f join Dil d on f.dil_id=d.dil_id join Kategori k on k.kategori_id=f.kategori_id where k.kategori_id =@p1";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);
            command.Parameters.AddWithValue("@p1", index);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            dataGrid.DataSource = datatable;

            Baglanti.Instance.conn.Close();

        }
        public void OyuncuFilm(DataGridView dataGrid, string isim)
        {
            datatable.Clear();
            Baglanti.Instance.baglantı();
            string sorgu = "SELECT filmAdi,oyuncuAdi FROM Film,Oyuncu WHERE Film.oyuncu_idS= Oyuncu.oyuncu_id AND Oyuncu.oyuncuAdi='" + isim + "'";

            command = new SqlCommand(sorgu, Baglanti.Instance.conn);


            adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            dataGrid.DataSource = datatable;


            Baglanti.Instance.conn.Close();
        }

    }
}
