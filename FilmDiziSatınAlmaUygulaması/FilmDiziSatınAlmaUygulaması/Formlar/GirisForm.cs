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
using System.Data.SqlClient;
using FilmDiziSatınAlmaUygulaması.Sınıflar;
using FilmDiziSatınAlmaUygulaması.Formlar;

namespace FilmDiziSatınAlmaUygulaması
{
    public partial class GirisForm :MaterialForm
    {
        

        private void GirisForm_Load(object sender, EventArgs e)
        {
            Baglanti.Instance.baglantı();
        }

       

        public GirisForm()
        {
            InitializeComponent();
          
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Red800, MaterialSkin.Primary.Red900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
    }



        private void giris_btn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select GirisTuru from Hesap where kullaniciAdi = @kullaniciAdi and sifre = @sifre", Baglanti.Instance.conn);
            cmd.Parameters.AddWithValue("@kullaniciAdi", kullanıcı_txt.Text);
            cmd.Parameters.AddWithValue("@sifre", parola_txt.Text);
            Baglanti.Instance.conn.Open();
            SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    if (rd["GirisTuru"].ToString() == "True")
                    {

                        //  MessageBox.Show("admin");
                        AdminPanel admin = new AdminPanel();
                        admin.Show();
                        this.Hide();

                    }
                    else
                    {

                        // MessageBox.Show("Kullanici");
                        FilmListele kullanıcı = new FilmListele();
                        kullanıcı.Show();
                        this.Hide();


                    }
                }
            }
            else
            {
                rd.Close();
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı");
            }
            Baglanti.Instance.conn.Close();


        }


    }

        
    
}
