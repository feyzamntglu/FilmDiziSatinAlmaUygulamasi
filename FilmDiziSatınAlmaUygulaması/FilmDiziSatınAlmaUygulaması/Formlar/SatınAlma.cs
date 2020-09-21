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
using FilmDiziSatınAlmaUygulaması.Sınıflar.İşlem_Sınıfları;

namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    public partial class SatınAlma : MaterialForm
    {
        public SatınAlma()
        {
            
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }
        int ucret;
        Musteri musteri = new Musteri();
        İnsertClass ekle = new İnsertClass();
        UpdateClass güncelle = new UpdateClass();
        public string filmAdı { get; set; }
        


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           int puan= PuanBulma(txt_email.Text);
            puan = puan + 10;

            if (puan == 100)
            {
                MessageBox.Show("Tebrikler! Müşteri FilmPuanı'nız 100'e Ulaştı.Filmi Ücretsiz Satın Alabileceksiniz.");
                ucret = 0;
            
            }
            else
            {
                ucret = 10;
            }
            int iDF = FilmIdBulma(txt_filmadi.Text);
            int iDM = MusteriIdBul(txt_email.Text);
            
            ekle.SatınAl(iDF,iDM,ucret);
            güncelle.MusteriPuan(puan,txt_email.Text);

            MessageBox.Show("Satın Alma İşleminiz Başarıyla Gerçekleştirildi");


        }
        private int FilmIdBulma(string filmAdi)
        {
            try
            {

                Baglanti.Instance.conn.Open();
                SqlCommand command = new SqlCommand("Select film_id from Film where filmAdi = '" + filmAdi + "'", Baglanti.Instance.conn);
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
        private int MusteriIdBul(string email)
        {
            try
            {


                Baglanti.Instance.conn.Open();
                SqlCommand command = new SqlCommand("Select musteri_id from Musteri where musteriEmail = '" + email + "'", Baglanti.Instance.conn);
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
        private int PuanBulma(string email)
        {
            try
            {

                Baglanti.Instance.conn.Open();
                SqlCommand command = new SqlCommand("Select musteriPuan from Musteri where musteriEmail = '" + email + "'", Baglanti.Instance.conn);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    int puan = dataReader.GetInt32(0);
                    Baglanti.Instance.conn.Close();
                    return puan;
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

        private void SatınAlma_Load(object sender, EventArgs e)
        {
            txt_filmadi.Text = filmAdı;
        }

        private void txt_ad_Click(object sender, EventArgs e)
        {

        }
    }
    


}
