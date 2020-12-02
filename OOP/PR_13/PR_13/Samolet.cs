using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    abstract public class Samolet
    {
        public double m;

        public Samolet(double nm)
        {
            m = nm;
        }
        abstract public double Calc(); // абстрактная функция, которая будет описана в классе наследника
    }
}
//BY TUSTUGASHEV Y.V.