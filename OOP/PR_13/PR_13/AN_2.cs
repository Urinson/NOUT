using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    public class AN_2 : Samolet
    {
        public double k;

        public AN_2(double nm, double nk) : base(nm)
        {
            k = nk;
        }
        public override double Calc()
        {
            double z = 5 - 0.09 * m - 0.01 * k;
            return z;
        }
        public override string ToString()
        {
            return "АН-2 m = " + m + "k = " + k;
        }
    }
}
//BY TUSTUGASHEV Y.V.