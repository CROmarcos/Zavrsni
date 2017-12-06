using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroOneKnapsack
{
    class Ranac
    {
        public int Kapacitet { get; set; }
        public int Iznos { get; private set; }
        public List<Varijabla> ListaUnosa;
        public List<string> ListaOdabranih;

        public Ranac()
        {
            ListaUnosa = new List<Varijabla>();
            ListaOdabranih = new List<string>();
            Iznos = 0;
        }

        public void Sortiraj()
        {
            ListaUnosa.Sort((x, y) => y.Prosjek.CompareTo(x.Prosjek));
        }

        public void DodajVarijable()
        {
            foreach (var item in ListaUnosa)
            {
                if (Kapacitet - item.TezinskaVrijednost >= 0)
                {
                    ListaOdabranih.Add(item.Naziv);
                    Iznos += item.NetoVrijednost;
                    Kapacitet -= item.TezinskaVrijednost;
                }
            }
        }

        public string IspisiIznos()
        {
            return Iznos.ToString();
        }

        public string IspisiVarijable()
        {
            string varijable = "";
            foreach (var item in ListaOdabranih)
            {
                varijable += item + " ";
            }
            return varijable;
        }
    }
}
