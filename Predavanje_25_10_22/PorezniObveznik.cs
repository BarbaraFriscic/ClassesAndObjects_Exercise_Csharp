using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_25_10_22
{
    internal class PorezniObveznik : IComparable
    {
        

        public string oib;
        public int godisnjaPlaca;
        public double porez;

        public int CompareTo(object obj)
        {
            PorezniObveznik temp = (PorezniObveznik)obj;
            if (this.porez > temp.porez)
                return 1;
            else if (this.porez < temp.porez)
                return -1;
            else
                return 0;

        }

        public string Oib { 
            get { return oib; }
            set { oib = value; } 
        }
        public int GodisnjaPlaca {
            get { return godisnjaPlaca; }
            set { godisnjaPlaca = value; }
        }

        public double Porez { 
            get { return porez; }
        }

        public void IzracunPoreza(int godisnjaPlaca)
        {
            if (this.godisnjaPlaca >= 100000)
                this.porez = this.godisnjaPlaca * 0.18;
            else if (this.godisnjaPlaca < 100000)
                this.porez = this.godisnjaPlaca * 0.27;
            else
                this.porez = 0;       
        }

        public PorezniObveznik(string oib, int godisnjaPlaca) 
        {
            this.oib = oib;
            this.godisnjaPlaca = godisnjaPlaca;
            IzracunPoreza(godisnjaPlaca); 
        }
       



    }
}
