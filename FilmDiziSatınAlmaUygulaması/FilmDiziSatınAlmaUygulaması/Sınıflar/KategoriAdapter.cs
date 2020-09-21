using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar
{
   public class KategoriAdapter : KategoriInterface
    {
        private Kategori _adapter;

        public KategoriAdapter(Kategori adapter)
        {
            _adapter = adapter;
        }

        public void kategoriAdapter(Kategori ad)
        {
            this._adapter = ad;
        }

        public int AdFilm_id
        {
            get { return _adapter.Film_id; }
            set { _adapter.Film_id = value; }
        }
        public string AdFilmAdi
        {
            get { return _adapter.FilmAdi; }
            set { _adapter.FilmAdi = value; ; }
        }
        public string AdIcerik
        {
            get { return _adapter.Icerik; }
            set { _adapter.Icerik = value; ; }
        }
        public string AdTarih
        {
            get { return _adapter.Tarih; }
            set { _adapter.Tarih = value; ; }
        }
        public float AdImdbPuani
        {
            get { return _adapter.ImdbPuani; }
            set { _adapter.ImdbPuani = value; }
        }
        public string AdDil
        {
            get { return _adapter.Dil; }
            set { _adapter.Dil = value; ; }
        }
        public string AdKategori
        {
            get { return _adapter.KKategori; }
            set { _adapter.KKategori = value; ; }
        }
    }
}
