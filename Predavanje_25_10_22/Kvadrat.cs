using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_25_10_22
{
    internal class Kvadrat
    {
        public int stranica;
        public int povrsina;
        

        public int Stranica
        {
            get { return stranica; }
        }

        public int Povrsina
        {
            get { return povrsina; }
        }
        private void IzracunajPovrsinu()
        {
            this.povrsina = this.stranica * this.stranica;
            
        }
        public Kvadrat(int stranica)
        {
            this.stranica = stranica;
            IzracunajPovrsinu();
        }
    }
}
