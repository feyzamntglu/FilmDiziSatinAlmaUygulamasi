using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar
{
    class KategoriConverter
    {
        public static KategoriInterface CreateConverterClass(string secim)
        {
            KategoriInterface selectedStrategy = null;
            if (secim == "bilimKurgu")
            {
                selectedStrategy = new BilimKurguClass();
            }
            else if (secim == "romantik")
            {
                selectedStrategy = new RomantikClass();
            }
            return selectedStrategy;
        }
    }
}
