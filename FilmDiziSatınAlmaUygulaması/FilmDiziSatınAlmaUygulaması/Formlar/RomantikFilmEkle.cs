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
using MaterialSkin.Controls;

namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    public partial class RomantikFilmEkle : MaterialForm
    {
        public RomantikFilmEkle()
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
      

        private void RomantikFilmEkle_Load(object sender, EventArgs e)
        {
            KategoriYukle();
            DilYukle();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
            KategoriInterface yeniRomantikFilm = KategoriConverter.CreateConverterClass("romantik");

            yeniRomantikFilm.AdFilmAdi = txt_filmAdı.Text;
            yeniRomantikFilm.AdIcerik = txt_filmİcerik.Text;
            yeniRomantikFilm.AdTarih = txt_tarih.Text;
            yeniRomantikFilm.AdImdbPuani = Convert.ToSingle(txt_imdb.Text);
            yeniRomantikFilm.AdDil = cmn_dil.Text;
            yeniRomantikFilm.AdKategori = cmb_kategori.Text;
            int idK = (int)cmb_kategori.SelectedValue;
            int idD = (int)cmn_dil.SelectedValue;

            ekle.RomantikFilmEkle((RomantikClass)yeniRomantikFilm, idD, idK);
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
    }
}
