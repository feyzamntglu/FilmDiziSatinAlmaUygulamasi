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
using System.Media;

namespace FilmDiziSatınAlmaUygulaması
{
    public partial class GirisForm :MaterialForm
    {
        private System.Media.SoundPlayer sound;
        public GirisForm()
        {
            InitializeComponent();
            sound = new System.Media.SoundPlayer();
            sound.SoundLocation = "play.wav";
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green700, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        

        private void giris_btn_Click(object sender, EventArgs e)
        {
            sound.Play();
        }
    }
}
