using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_25_10_22
{
    internal class Izvidjac
    {
        public string ime;
        public int brojCete;
        public double clanarina;
        public const string MOTO = "Hrabro ići gdje još niti jedan čovjek nije išao";

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public int BrojCete
        {
            get { return brojCete; }
            set { brojCete = value; }
        }
        public double Clanarina
        {
            get { return clanarina; }
            set { clanarina = value; }
        }

       public Izvidjac()
        {
            Ime = "NN";
            BrojCete = 0;
            Clanarina = 0;

        }
    }
}
