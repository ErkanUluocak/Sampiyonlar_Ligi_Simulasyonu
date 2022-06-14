using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampiyonlar_Ligi_Simulasyonu
{
    public class Takim
    {
        public byte TakimID { get; set; }
        public string TakimAdi { get; set; }
        public string TakimUlke { get; set; }
        public int ToplamAtilanGol { get; set; }
        public int ToplamYenenGol { get; set; }
        public int TakimPuan { get; set; }


        public static Random rastgele = new Random();


        public int Averaj
        {
            get
            {
                return ToplamAtilanGol - ToplamYenenGol;
            }
        }

        public override string ToString()
        {
            return TakimAdi + "-" + TakimUlke;
        }

        public Mac MacYap(Takim karsitakim)
        {

            int atilanGol = rastgele.Next(0, 9);
            int yenenGol = rastgele.Next(0, 9);

            karsitakim.ToplamYenenGol += atilanGol;
            karsitakim.ToplamAtilanGol += yenenGol;

            ToplamAtilanGol += atilanGol;
            ToplamYenenGol += yenenGol;


            if (atilanGol > yenenGol)
            {
                this.TakimPuan += 3;

            }
            else if (atilanGol > yenenGol)
            {
                karsitakim.TakimPuan += 3;
            }
            else
            {
                this.TakimPuan += 1;
                karsitakim.TakimPuan += 1;
            }



            Mac mac = new Mac
            {
                Takim1 = this,
                Takim2 = karsitakim,
                Takim1AtilanGol = atilanGol,
                Takim2AtilanGol = yenenGol,
            };

            return mac;
        }
    }
}
