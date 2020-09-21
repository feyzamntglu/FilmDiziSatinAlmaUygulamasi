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
using System.Diagnostics;

namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    public partial class FilmAyrıntı : MaterialForm
    {
        public FilmAyrıntı()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }
        public string ad, icerik, tarih, imdb, dil, kategori;
        public string resim;
        public string fragman;

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
            ProcessStartInfo adres = new ProcessStartInfo(fragman);
            Process.Start(adres);
        }

    

        private void FilmAyrıntı_Load(object sender, EventArgs e)
        {
            txt_ad.Text = ad;
            txt_icerik.Text = icerik;
            txt_tarih.Text = tarih;
            txt_imdb.Text = imdb;
            txt_dil.Text = dil;
            txt_kategori.Text = kategori;
            pictureBox1.ImageLocation = resim;

        }
        private void btn_satınal_Click(object sender, EventArgs e)
        {
            SatınAlma yeni = new SatınAlma();
            yeni.filmAdı = txt_ad.Text;
            yeni.Show();   
          
        }
        private int MusteriIdBul(string email)
        {
            try
            {

                Baglanti.Instance.conn.Open();
                SqlCommand command = new SqlCommand("Select musteriEmail from Musteri where musteriEmail = '" + email + "'", Baglanti.Instance.conn);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    Baglanti.Instance.conn.Close();
                    return id;
                }

                Baglanti.Instance.conn.Close();
                return -1;
            }
            catch (Exception)
            {
                Baglanti.Instance.conn.Close();
                return -2;
            }

        }

    }
}
