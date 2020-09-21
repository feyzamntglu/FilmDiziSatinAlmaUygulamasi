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
    public partial class Kategori : MaterialForm
    {
        public Kategori()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red900, MaterialSkin.Primary.BlueGrey600, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void Kategori_Load(object sender, EventArgs e)
        {

        }

        private void btn_bilimKurgu_Click(object sender, EventArgs e)
        {
            BilimKurguFilmEkle bilimKurgu = new BilimKurguFilmEkle();
            bilimKurgu.Show();
            this.Hide();
        }

        private void btn_komedi_Click(object sender, EventArgs e)
        {
            FilmEkle komedi = new FilmEkle();
            komedi.Show();
            this.Hide();
        }

        private void btn_romantik_Click(object sender, EventArgs e)
        {
            RomantikFilmEkle romantik = new RomantikFilmEkle();
            romantik.Show();
            this.Hide();
        }
    }
}
