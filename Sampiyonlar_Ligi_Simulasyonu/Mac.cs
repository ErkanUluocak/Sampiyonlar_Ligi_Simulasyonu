using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampiyonlar_Ligi_Simulasyonu
{
    public class Mac
    {
        public Takim Takim1 { get; set; }
        public Takim Takim2 { get; set; }

        public int Takim1AtilanGol { get; set; }
        public int Takim2AtilanGol { get; set; }
        public bool IsReverse { get; set; }
   

        public string GetMacAdi()
        {
            if (IsReverse)
            {
                return Takim2.TakimAdi + "-" + Takim1.TakimAdi;
            }
            else
            {
                return Takim1.TakimAdi + "-" + Takim2.TakimAdi;
            }
        }


        public string GetMacSonuc()
        {
            if (IsReverse)
            {
                return Takim2AtilanGol + "-" + Takim1AtilanGol;
            }
            else
            {
                return Takim1AtilanGol + "-" + Takim2AtilanGol;
            }
        }
    }
}
