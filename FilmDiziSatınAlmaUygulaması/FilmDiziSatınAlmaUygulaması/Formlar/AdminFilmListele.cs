using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FilmDiziSatınAlmaUygulaması.Sınıflar;
using FilmDiziSatınAlmaUygulaması.Formlar;
using FilmDiziSatınAlmaUygulaması.Sınıflar.İşlem_Sınıfları;

namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    public partial class AdminFilmListele : MaterialForm
    {
        public AdminFilmListele()
        {
            InitializeComponent();
        }

        private void AdminFilmListele_Load(object sender, EventArgs e)
        {
            Baglanti.Instance.baglantı();
        }
        SelectClass select = new SelectClass();
        DeleteClass delete = new DeleteClass();

        private void cmb_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridFilm.DataSource = "";
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            if (cmb_film.Text == "İMDP Puanı Artan")
            {
                select.ListeleİmdbArtan(datagridFilm);
            }

            if (cmb_film.Text == "İMDP Puanı Azalan")
            {
                select.ListeleİmdbAzalan(datagridFilm);
            }

            else if (cmb_film.Text == "Kategori")
            {
                cmb_sec.Visible = true;
                Baglanti.Instance.conn.Open();
                SqlCommand komut = new SqlCommand("select kategoriAdi from Kategori", Baglanti.Instance.conn);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmb_sec.Items.Add(dr[0]);
                }

                Baglanti.Instance.conn.Close();


            }
            else if (cmb_film.Text == "Tüm Filmler")
            {

                select.ListeleTumFilm(datagridFilm);
            }
            else if (cmb_film.Text == "Oyuncu")
            {
                cmb_sec.Visible = true;
                Baglanti.Instance.conn.Open();
                SqlCommand sorgu = new SqlCommand("select oyuncuAdi from Oyuncu", Baglanti.Instance.conn);
                SqlDataReader read = sorgu.ExecuteReader();
                while (read.Read())
                {

                    cmb_sec.Items.Add(read["oyuncuAdi"]);

                }
            }
            else
            {
                cmb_sec.Visible = true;
                Baglanti.Instance.conn.Open();
                SqlCommand komut = new SqlCommand("select dilAdi from Dil", Baglanti.Instance.conn);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmb_sec.Items.Add(dr[0]);
                }

                Baglanti.Instance.conn.Close();

            }

        }

        private void cmb_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagridFilm.DataSource = "";
            if (cmb_film.Text == "Kategori")
            {
                select.ListeleKategori(datagridFilm, cmb_sec.SelectedIndex + 1);
            }
            else if (cmb_film.Text == "Dil")
            {
                select.ListeleDil(datagridFilm, cmb_sec.SelectedIndex + 1);

            }

            else if (cmb_film.Text == "Oyuncu")
            {

                select.OyuncuFilm(datagridFilm, cmb_sec.Text);

            }
        }

    

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in datagridFilm.SelectedRows) 
            {
                int film_id = Convert.ToInt32(drow.Cells[0].Value);
                delete.FilmSil(film_id);
            }
          
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi.");
            
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {

            if (cmb_film.Text == "İMDP Puanı Artan")
            {
                select.ListeleİmdbArtan(datagridFilm);
            }

            if (cmb_film.Text == "İMDP Puanı Azalan")
            {
                select.ListeleİmdbAzalan(datagridFilm);
            }

            else if (cmb_film.Text == "Kategori")
            {
                cmb_sec.Visible = true;
                Baglanti.Instance.conn.Open();
                SqlCommand komut = new SqlCommand("select kategoriAdi from Kategori", Baglanti.Instance.conn);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmb_sec.Items.Add(dr[0]);
                }

                Baglanti.Instance.conn.Close();


            }
            else if (cmb_film.Text == "Tüm Filmler")
            {

                select.ListeleTumFilm(datagridFilm);
            }
            else if (cmb_film.Text == "Oyuncu")
            {
                cmb_sec.Visible = true;
                Baglanti.Instance.conn.Open();
                SqlCommand sorgu = new SqlCommand("select oyuncuAdi from Oyuncu", Baglanti.Instance.conn);
                SqlDataReader read = sorgu.ExecuteReader();
                while (read.Read())
                {

                    cmb_sec.Items.Add(read["oyuncuAdi"]);

                }
            }
            else
            {
                cmb_sec.Visible = true;
                Baglanti.Instance.conn.Open();
                SqlCommand komut = new SqlCommand("select dilAdi from Dil", Baglanti.Instance.conn);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmb_sec.Items.Add(dr[0]);
                }

                Baglanti.Instance.conn.Close();

            }

        }
        

        private void cmb_sec_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            datagridFilm.DataSource = "";
            if (cmb_film.Text == "Kategori")
            {
                select.ListeleKategori(datagridFilm, cmb_sec.SelectedIndex + 1);
            }
            else if (cmb_film.Text == "Dil")
            {
                select.ListeleDil(datagridFilm, cmb_sec.SelectedIndex + 1);

            }

            else if (cmb_film.Text == "Oyuncu")
            {

                select.OyuncuFilm(datagridFilm, cmb_sec.Text);

            }
        }

        private void datagridFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridFilm_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = datagridFilm.SelectedCells[0].RowIndex;
            FilmGüncelle frm = new FilmGüncelle();
            frm.id = datagridFilm.Rows[secilen].Cells[0].Value.ToString();
            frm.ad = datagridFilm.Rows[secilen].Cells[1].Value.ToString();
            frm.icerik = datagridFilm.Rows[secilen].Cells[2].Value.ToString();
            frm.tarih = datagridFilm.Rows[secilen].Cells[3].Value.ToString();
            frm.imdb = datagridFilm.Rows[secilen].Cells[4].Value.ToString();
            frm.dil = datagridFilm.Rows[secilen].Cells[5].Value.ToString();
            frm.kategori = datagridFilm.Rows[secilen].Cells[6].Value.ToString();
            
            frm.Show();

        }
    }
    }


    


    

