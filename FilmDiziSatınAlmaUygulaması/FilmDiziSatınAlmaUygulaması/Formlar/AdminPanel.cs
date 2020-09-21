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

namespace FilmDiziSatınAlmaUygulaması.Formlar
{
    public partial class AdminPanel : MaterialForm
    {
        public AdminPanel()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red900, MaterialSkin.Primary.BlueGrey600, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.Show();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            AdminFilmListele liste = new AdminFilmListele();
            liste.Show();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            AdminFilmListele liste = new AdminFilmListele();
            liste.Show();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            AdminFilmListele liste = new AdminFilmListele();
            liste.Show();
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
