using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    public class CU_34 : Samolet
    {
        public CU_34(double nm) : base(nm)
        {
        }
        public override double Calc()
        {
            double z2 = 15-0.001*m;
            return z2;
        }
        public override string ToString()
        {
            return "СУ-34 m = " + m;
        }
    }
}
//BY TUSTUGASHEV Y.V.