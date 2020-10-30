using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Urok_08._10._20
{
    class Vnos
    {
        public string a;
        public double b;
        public int c;
        public double d;

        public Vnos(string n_a, double n_b, int n_c, double n_d)
        {
            a = n_a;
            b = n_b;
            c = n_c;
            d = n_d;

        }
        public override string ToString()
        {
            {
                return " `" + a.ToString() + " - " + b.ToString() + "/ " + c.ToString() + "/ " + d.ToString() +"`";

            }
        }
    }
}
//TUSTUGASHEV Y.V.