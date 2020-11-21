using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_10
{
    class Vnos
    {
        public int a;
        public int b;
        public int c;
        public int d;

        public Vnos(int m_a, int m_b, int m_c, int m_d)
        {
            a = m_a;
            b = m_b;
            c = m_c;
            d = m_d;

        }
        public override string ToString()
        {
            {
                return " `" + a.ToString() + " - " + b.ToString() + "/ " + c.ToString() + "/ " + d.ToString() + "`";

            }
        }
    }
}
//TUSTUGASHEV Y.V.