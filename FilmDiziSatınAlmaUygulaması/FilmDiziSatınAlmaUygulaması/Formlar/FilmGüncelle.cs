using FilmDiziSatınAlmaUygulaması.Sınıflar;
using FilmDiziSatınAlmaUygulaması.Sınıflar.İşlem_Sınıfları;
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

namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    public partial class FilmGüncelle : MaterialForm
    {
        public FilmGüncelle()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }
        public string  id,ad, icerik, tarih, imdb, dil, kategori;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable datatable = new DataTable();
        SqlCommand command = new SqlCommand();

        private void film_id_Click(object sender, EventArgs e)
        {

        }

        private void cmb_kategorisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmn_dili_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButtonGüncelle_Click(object sender, EventArgs e)
        {
            Film komedi = new Film();
            UpdateClass update = new UpdateClass();

            komedi.filmAdi = txt_filmAd.Text;
            komedi.icerik = txt_filmİcer.Text;
            komedi.tarih = txt_cikiisYili.Text;
            komedi.imdbPuani = Convert.ToSingle(txt_imdbPuani.Text);
            
            int idK = (int)cmb_kategorisi.SelectedValue;
            int idD = (int)cmn_dili.SelectedValue;

            update.FilmGüncelle(komedi, idD, idK, Convert.ToInt32(film_id.Text));

            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirildi");
        }

        private void FilmGüncelle_Load(object sender, EventArgs e)
        {
            film_id.Text = id;
            txt_filmAd.Text = ad;
            txt_filmİcer.Text = icerik;
            txt_cikiisYili.Text = tarih;
            txt_imdbPuani.Text = imdb;
            cmn_dili.Text = dil;
            cmb_kategorisi.Text = kategori;
            KategoriYukle();
            DilYukle();

        }
        public void KategoriYukle()
        {
            DataTable dt = new DataTable();
            string sorgu = "select * from Kategori";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            adapter.Dispose();
            cmb_kategorisi.DataSource = dt;
            cmb_kategorisi.ValueMember = "kategori_id";
            cmb_kategorisi.DisplayMember = "kategoriAdi";
        }
        public void DilYukle()
        {
            DataTable dt = new DataTable();
            string sorgu = "select * from Dil";
            command = new SqlCommand(sorgu, Baglanti.Instance.conn);

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            adapter.Dispose();
            cmn_dili.DataSource = dt;
            cmn_dili.ValueMember = "dil_id";
            cmn_dili.DisplayMember = "dilAdi";
        }
    }
}
