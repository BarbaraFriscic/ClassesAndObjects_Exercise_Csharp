using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_25_10_22
{
    internal class Krug
    {
        public double polumjer;
        public double promjer;
        public double povrsina;

        public double Promjer
        {
            get { return promjer; }
            
        }
        public double Povrsina
        {
            get { return povrsina; }
            
        }
        public double Polumjer
        {
            get { return polumjer; }
            set { 
                
                polumjer = value;
                promjer = 2 * polumjer;
                povrsina = polumjer * polumjer * Math.PI;
            }
        }

        public Krug()
        {
            Polumjer = 1;
        }


    }
}
