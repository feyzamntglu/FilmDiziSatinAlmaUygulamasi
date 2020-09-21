using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması
{
   public  class Kategori : Film
    {
        public int Film_id
        {
            get { return film_id; }
            set { film_id = value; }
        }
        public string FilmAdi
        {
            get { return filmAdi; }
            set { filmAdi = value; }
        }
        public string Icerik
        {
            get { return icerik; }
            set { icerik = value; }
        }
        public string Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        public float ImdbPuani
        {
            get { return imdbPuani; }
            set { imdbPuani = value; }
        }
        public string Dil
        {
            get { return dil; }
            set { dil = value; }
        }
        internal string KKategori
        {
            get { return kategori; }
            set { kategori = value; }
        }
    }
}
