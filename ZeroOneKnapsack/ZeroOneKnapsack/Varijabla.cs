using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroOneKnapsack
{
    public class Varijabla
    {
        public string Naziv { get; set; }
        public int NetoVrijednost { get; set; }
        public int TezinskaVrijednost { get; set; }
        public double Prosjek { get { return (double)NetoVrijednost / TezinskaVrijednost; } }
    }
}
