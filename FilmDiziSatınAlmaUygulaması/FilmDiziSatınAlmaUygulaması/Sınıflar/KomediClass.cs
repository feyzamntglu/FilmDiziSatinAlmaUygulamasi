using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar
{
   public class KomediClass : KategoriInterface
    {
        private int film_id;
        private string filmAdi;
        private string icerik;
        private string tarih;
        private float imdbPuani;
        private string dil;
        private string kategori;

        //Komedi classındaki nesneleri kategoriInterface clasındaki nesnelere adapte ediyor
        public static implicit operator KomediClass(KategoriAdapter v)
        {
            return new KomediClass { AdFilm_id = v.AdFilm_id, AdFilmAdi = v.AdFilmAdi, AdIcerik = v.AdIcerik, AdTarih = v.AdTarih, AdImdbPuani = v.AdImdbPuani, AdDil = v.AdDil, AdKategori = v.AdKategori };
        }
        public int AdFilm_id
        {
            get { return film_id; }
            set { film_id = value; }
        }
        public string AdFilmAdi
        {
            get { return filmAdi; }
            set { filmAdi = value; }
        }
        public string AdIcerik
        {
            get { return icerik; }
            set { icerik = value; }
        }
        public string AdTarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        public float AdImdbPuani
        {
            get { return imdbPuani; }
            set { imdbPuani = value; }
        }
        public string AdDil
        {
            get { return dil; }
            set { dil = value; }
        }
        public string AdKategori
        {
            get { return kategori; }
            set { kategori = value; }
        }
        
    }
}
