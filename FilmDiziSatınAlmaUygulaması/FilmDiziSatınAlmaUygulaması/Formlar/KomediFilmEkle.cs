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

namespace FilmDiziSatınAlmaUygulaması
{
    public partial class FilmEkle : MaterialForm
    {
        public FilmEkle()
        {
            InitializeComponent();
            Baglanti.Instance.baglantı();
          
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable datatable = new DataTable();
        SqlCommand command = new SqlCommand();

        Film film = new Film();
        İnsertClass ekle = new İnsertClass();
       
        

        private int KategoriIdBulma(string filmAdı)
        {
            try
            {
                Baglanti.Instance.conn.Open();

                SqlCommand command = new SqlCommand("Select kategori_id from Film where filmAdi = '" + filmAdı + "'", Baglanti.Instance.conn);
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
               
                return -2;
            }
        }

        private int DilIdBulma(string filmAdı)
        {
            try
            {


                Baglanti.Instance.conn.Open();
                SqlCommand command = new SqlCommand("Select dil_id from Film where filmAdi = '" + filmAdı + "'", Baglanti.Instance.conn);
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

        private void FilmEkle_Load(object sender, EventArgs e)
        {
            KategoriYukle();
            DilYukle();
           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Kategori kt = new Kategori();
            KomediClass km = new KategoriAdapter(kt);
           // KomediClass k = new Kategori();

            km.AdFilmAdi = txt_filmAdı.Text;
            km.AdIcerik = txt_filmİcerik.Text;
            km.AdTarih = txt_tarih.Text;
            km.AdImdbPuani = Convert.ToSingle(txt_imdb.Text);
            km.AdDil = cmn_dil.Text;
            km.AdKategori = cmb_kategori.Text;
            int idK = (int) cmb_kategori.SelectedValue;
            int idD = (int)cmn_dil.SelectedValue;
            
            ekle.FilmEkle(km, idD, idK);
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi");
          

        }
        public void KategoriYukle()
        {
            DataTable dt = new DataTable();
            string sorgu = "select * from Kategori";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            adapter.Dispose();
            cmb_kategori.DataSource = dt;
            cmb_kategori.ValueMember = "kategori_id";
            cmb_kategori.DisplayMember = "kategoriAdi";
        }
        public void DilYukle()
        {
            DataTable dt = new DataTable();
            string sorgu = "select * from Dil";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            adapter.Dispose();
            cmn_dil.DataSource = dt;
            cmn_dil.ValueMember = "dil_id";
            cmn_dil.DisplayMember = "dilAdi";
        }

        private void txt_tarih_Click(object sender, EventArgs e)
        {

        }
    }
}
