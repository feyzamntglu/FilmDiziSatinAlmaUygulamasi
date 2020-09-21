using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması
{
    class Oyuncu
    {
        private int oyuncu_id;
        private string oyuncuAdı;
        private string oyuncuSoyadı;

        public int Oyuncu_id
        {
            get
            {
                return oyuncu_id;
            }
            set
            {
                oyuncu_id = value;
            }
        }

        public string OyuncuAdı
        {
            get
            {
                return oyuncuAdı;
            }
            set
            {
                oyuncuAdı = value;
            }
        }

        public string OyuncuSoyadı
        {
            get
            {
                return oyuncuSoyadı;
            }
            set
            {
                oyuncuSoyadı = value;
            }
        }
    }
}
