using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    public class ИЛ_76 : Samolet
    {
        public double k, n;

        public ИЛ_76(double nm, double nk, double nn) : base(nm)
        {
            k = nk;
            n = nn;
        }

        public override double Calc()
        {
            double z3 = 12 - 0.005 * m - 0.001 * k - 0.002 * n;
            return z3;
        }

        public override string ToString()
        {
            return "ИЛ-76 m = " + m + "k = " + k + "n = " + n;
        }
    }
}
//BY TUSTUGASHEV Y.V.