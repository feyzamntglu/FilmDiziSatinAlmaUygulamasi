using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDiziSatınAlmaUygulaması
{
   public  class Musteri
    {
        private int musteri_id;
        private string musteriAdi;
        private string musteriSoyadi;
        private string musteriKartNo;
        private string musteriEmail;
        private int musteriPuan;

        public int Musteri_id
        {
            get
            {
                return musteri_id;
            }
            set
            {
                musteri_id = value;
            }

        }
        public string MusteriAdi
        {
            get
            {
                return musteriAdi;
            }
            set
            {
                musteriAdi = value;
            }
        }
        public string MusteriSoyadi
        {
            get
            {
                return musteriSoyadi;
            }
            set
            {
                musteriSoyadi = value;
            }
        }
        public string MusteriKartNo
        {
            get
            {
                return musteriKartNo;
            }
            set
            {
                musteriKartNo = value;
            }
        }
        public string MusteriEmail
        {
            get
            {
                return musteriEmail;
            }
            set
            {
                musteriEmail = value;
            }
        }
        public int MusteriPuan
        {
            get
            {
                return musteriPuan;
            }
            set
            {
                musteriPuan = value;
            }

        }
    }
}
