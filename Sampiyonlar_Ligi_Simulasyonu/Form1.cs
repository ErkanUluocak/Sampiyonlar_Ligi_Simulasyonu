using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sampiyonlar_Ligi_Simulasyonu
{
    public partial class Form1 : Form
    {


        
        List<Takim> torba1;
        List<Takim> torba2;
        List<Takim> torba3;
        List<Takim> torba4;


        List<List<Takim>> gruplar = new List<List<Takim>>();

        List<Mac> maclar = new List<Mac>();

        string[] grupAdlari = { "A", "B", "C", "D", "E", "F", "G", "H" };


        List<ListBox> grupListBoxlari
        {
            get
            {
                return new List<ListBox>() { lstAGrubu,lstBGrubu,lstCGrubu,lstDGrubu
                ,lstEGrubu,lstFGrubu,lstGGrubu,lstHGrubu};
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        public void TorbalarıDoldur()
        {
            TorbalariYenile();
            lstTorba1.Items.Clear();
            lstTorba2.Items.Clear();
            lstTorba3.Items.Clear();
            lstTorba4.Items.Clear();

            lstAGrubu.Items.Clear();
            lstBGrubu.Items.Clear();
            lstCGrubu.Items.Clear();
            lstDGrubu.Items.Clear();
            lstEGrubu.Items.Clear();
            lstFGrubu.Items.Clear();
            lstGGrubu.Items.Clear();
            lstHGrubu.Items.Clear();

            foreach (var takim in torba1)
            {
                lstTorba1.Items.Add(takim.TakimAdi);
            }

            foreach (var takim in torba2)
            {
                lstTorba2.Items.Add(takim.TakimAdi);
            }

            foreach (var takim in torba3)
            {
                lstTorba3.Items.Add(takim.TakimAdi);
            }

            foreach (var takim in torba4)
            {
                lstTorba4.Items.Add(takim.TakimAdi);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            TorbalarıDoldur();
        }


   
        
        public void Karistir(List<Takim> ts)
        {
            Random random = new Random();
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = random.Next(i, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
        }

        public void TorbalariYenile()
        {
            torba1 = new List<Takim>
        {
            new Takim { TakimID = 1,TakimAdi = "Bayern Munich",TakimUlke="Almanya",},
            new Takim {TakimID = 2,TakimAdi = "Sevilla",TakimUlke="İspanya" },
            new Takim { TakimID = 3,TakimAdi = "Real Madrid",TakimUlke="İspanya" },
            new Takim { TakimID = 4,TakimAdi = "Liverpool",TakimUlke="İngiltere" },
            new Takim { TakimID = 5,TakimAdi = "Juventus",TakimUlke="İtalya" },
            new Takim { TakimID = 6,TakimAdi = "Paris Saint-Germain",TakimUlke="Fransa" },
            new Takim { TakimID = 7,TakimAdi = "Zenit",TakimUlke="Rusya" },
            new Takim { TakimID = 8,TakimAdi = "Porto",TakimUlke="Portekiz" },
        };
            torba2 = new List<Takim>
        {
            new Takim { TakimID = 9,TakimAdi = "Barcelona",TakimUlke="İspanya" },
            new Takim { TakimID = 10,TakimAdi = "Atlético Madrid",TakimUlke="İspanya" },
            new Takim { TakimID = 11,TakimAdi = "Manchester City",TakimUlke="İngiltere" },
            new Takim { TakimID = 12,TakimAdi = "Manchester United",TakimUlke="İngiltere" },
            new Takim { TakimID = 13,TakimAdi = "Borussia Dortmund",TakimUlke="Almanya" },
            new Takim { TakimID = 14,TakimAdi = "Shakhtar Donetsk",TakimUlke="Ukrayna" },
            new Takim { TakimID = 15,TakimAdi = "Chelsea",TakimUlke="İngiltere" },
            new Takim { TakimID = 16,TakimAdi = "Ajax",TakimUlke="Hollanda" },
        };
            torba3 = new List<Takim>
        {
            new Takim { TakimID = 17,TakimAdi = "Dynamo Kiev",TakimUlke="Ukrayna" },
            new Takim { TakimID = 18,TakimAdi = "Red Bull Salzburg",TakimUlke="Almanya" },
            new Takim { TakimID = 19,TakimAdi = "RB Leipzig",TakimUlke="Almanya" },
            new Takim { TakimID = 20,TakimAdi = "Internazionale",TakimUlke="İtalya" },
            new Takim { TakimID = 21,TakimAdi = "Olympiacos",TakimUlke="Yunanistan" },
            new Takim { TakimID = 22,TakimAdi = "Lazio",TakimUlke="İtalya" },
            new Takim { TakimID = 23,TakimAdi = "Krasnodar",TakimUlke="Rusya" },
            new Takim { TakimID = 24,TakimAdi = "Atalanta",TakimUlke="İtalya" },
        };
            torba4 = new List<Takim>
        {
            new Takim { TakimID = 25,TakimAdi = "Lokomotiv Moskova",TakimUlke="Rusya" },
            new Takim { TakimID = 26,TakimAdi = "Marseille",TakimUlke="Fransa" },
            new Takim { TakimID = 27,TakimAdi = "Club Brugge",TakimUlke="Belçika" },
            new Takim { TakimID = 28,TakimAdi = "Bor. Mönchengladbach",TakimUlke="Almanya" },
            new Takim { TakimID = 29,TakimAdi = "Galatasaray",TakimUlke="Türkiye" },
            new Takim { TakimID = 30,TakimAdi = "Midtjylland",TakimUlke="Danimarka" },
            new Takim { TakimID = 31,TakimAdi = "Rennes",TakimUlke="Fransa" },
            new Takim { TakimID = 32,TakimAdi = "Ferencváros",TakimUlke="Macaristan" },
        };
        }

        public void GruplariOlustur()
        {
            gruplar.Clear();

            Karistir(torba1);
            Karistir(torba2);
            Karistir(torba3);
            Karistir(torba4);


            for (int i = 0; i < 8; i++)
            {
                List<Takim> grup = new List<Takim>();
                grup.Add(KuraCek(torba1, grup));
                grup.Add(KuraCek(torba2, grup));
                grup.Add(KuraCek(torba3, grup));
                grup.Add(KuraCek(torba4, grup));
                gruplar.Add(grup);
            }


            for (int grupindex = 0; grupindex < gruplar.Count; grupindex++)
            {
                for (int takimindex = 0; takimindex < gruplar[grupindex].Count; takimindex++)
                {
                    grupListBoxlari[grupindex].Items.Add(gruplar[grupindex][takimindex].TakimAdi);
                }
            }
        }

        public Takim KuraCek(List<Takim> torba, List<Takim> grup)
        {
            
            int secilenTakimIndex = 0;
            for (int i = 0; i < torba.Count; i++)
            {
                if (grup.FirstOrDefault(t => t.TakimUlke == torba[i].TakimUlke) == null)
                {
                    secilenTakimIndex = i;
                    break;
                }
            }
            Takim takim = torba[secilenTakimIndex];
            torba.RemoveAt(secilenTakimIndex);
            return takim;
        }

        private void btnGruplariOlustur_Click(object sender, EventArgs e)
        {
            TorbalarıDoldur();
            GruplariOlustur();
            btnMacYaptir.Show();
            lstMacSonuclari.Items.Clear();
            lstPuanSiralamasi.Items.Clear();
            lstSon16Takimlar.Items.Clear();
            btnMacYaptir.Enabled = true;

        }


        public void GrupKarsilastir(List<Takim> grup, Takim secilenTakim)
        {
            for (int i = 0; i < grup.Count; i++)
            {
                Takim takim = grup[i];
                if (takim.TakimID != secilenTakim.TakimID)
                {
                    Mac ilkMac = secilenTakim.MacYap(takim);                
                    maclar.Add(ilkMac);                   
                }
            }
        }

        public void ButunGruplariKarsilastir()
        {
            maclar.Clear();
            for (int i = 0; i < gruplar.Count; i++)
            {
                List<Takim> secilenGrup = gruplar[i];
                for (int j = 0; j < secilenGrup.Count; j++)     
                {
                    Takim secilenTakim = secilenGrup[j];
                    GrupKarsilastir(secilenGrup, secilenTakim);
                }
            }

            lstMacSonuclari.Items.Clear();


            for (int i = 0; i < maclar.Count; i++)
            {
                if (i % 12 == 0)
                {
                    lstMacSonuclari.Items.Add("");
                    lstMacSonuclari.Items.Add($"--------- {grupAdlari[i / 12]} Grubu Maç Sonuçları ---------");
                    lstMacSonuclari.Items.Add("");

                }
                lstMacSonuclari.Items.Add(maclar[i].GetMacAdi() + " " + maclar[i].GetMacSonuc());
            }


        }


        private void Son16Hesapla()
        {
            lstSon16Takimlar.Items.Clear();

            for (int i = 0; i < gruplar.Count; i++)
            {
                List<Takim> secilenGrup = gruplar[i];

                secilenGrup = TakimlariSirala(secilenGrup);


                for (int j = 0; j < 2; j++)
                {
                    Takim secilenTakim = secilenGrup[j];
                    lstSon16Takimlar.Items.Add(secilenTakim.TakimAdi);
                }
            }
        }

        private void btnMacYaptir_Click(object sender, EventArgs e)
        {
            ButunGruplariKarsilastir();

            lstPuanSiralamasi.Items.Clear();
            btnMacYaptir.Enabled = false;



            for (int i = 0; i < gruplar.Count; i++)
            {
                List<Takim> secilenGrup = gruplar[i];

                lstPuanSiralamasi.Items.Add("");
                lstPuanSiralamasi.Items.Add($"--------- {grupAdlari[i]} Grubu Puan Sıralaması ---------");
                lstPuanSiralamasi.Items.Add("");

                secilenGrup = TakimlariSirala(secilenGrup);

                for (int j = 0; j < secilenGrup.Count; j++)
                {

                    Takim secilenTakim = secilenGrup[j];
                    lstPuanSiralamasi.Items.Add((j + 1) + "- " + secilenTakim.TakimAdi + " Puan: \n" + secilenTakim.TakimPuan + " Attığı Gol : " + secilenTakim.ToplamAtilanGol + " Yediği Gol : " + secilenTakim.ToplamYenenGol + " Averaj : " + secilenTakim.Averaj);
                }
            }

            Son16Hesapla();
        }

        private static List<Takim> TakimlariSirala(List<Takim> secilenGrup)
        {
            secilenGrup = secilenGrup.OrderByDescending(t => t.TakimPuan).ThenByDescending(t => t.Averaj).ThenByDescending(t => t.ToplamAtilanGol).ToList();
            return secilenGrup;
        }
    }
}


