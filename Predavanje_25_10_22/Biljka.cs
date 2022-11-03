using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_25_10_22
{
    internal class Biljka
    {
        private string imeBiljke;
        private double vrijednost;
        private bool zalijevanje;

        public string ImeBiljke
        {
            get { return imeBiljke; }
            set { imeBiljke = value; }
        }

        public double Vrijednost
        {
            get { return vrijednost; }
            set { vrijednost = value; }
        }
        public bool Zalijevanje
        {
            get { return zalijevanje; }
            set { zalijevanje = value; }
        }
    }
}
