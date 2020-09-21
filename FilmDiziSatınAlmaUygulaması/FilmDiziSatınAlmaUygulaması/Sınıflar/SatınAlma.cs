using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması.Sınıflar
{
   public class SatınAlma
    {
        private int satinalma_id;
        private int ucret;

        public int Satinalma_id
        {
            get
            {
                return satinalma_id;
            }
            set
            {
                satinalma_id = value;
            }
        }
        public int Ucret
        {
            get
            {
                return ucret;
            }
            set
            {
                ucret = value;
            }
        }
    }
}
