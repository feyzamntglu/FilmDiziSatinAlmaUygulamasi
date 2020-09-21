using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması
{
  public class Dil
    {
        private int dil_id;
        private string dilAdi;

        public int Dil_id
        {
            get
            {
                return dil_id;
            }
            set
            {
                dil_id = value;
            }
        }

        public string DilAdi
        {
            get
            {
                return dilAdi;
            }
            set
            {
                dilAdi = value;
            }
        }
       
    }
}
