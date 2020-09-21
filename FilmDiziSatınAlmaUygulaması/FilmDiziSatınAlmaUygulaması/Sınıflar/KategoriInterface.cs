using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar
{
    interface KategoriInterface
    {
        int AdFilm_id { get; set; }
        string AdFilmAdi { get; set; }
        string AdIcerik { get; set; }
        string AdTarih { get; set; }
        float AdImdbPuani { get; set; }
        string AdDil { get; set; }
        string AdKategori { get; set; }
    }
}
