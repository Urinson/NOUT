using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_06._10._20
{
    //необходимо создать класс треугольник принимающий величины трех сторон. реализовать методы вывода площади периметра и ответа на вопрос о существовании треугольника

    class Treugolnik
    {
        public double a, b, c;

        public Treugolnik(double n_a, double n_b, double n_c)
        {
            a = n_a;
            b = n_b;
            c = n_c;
        }
        public bool Exists()

        {
            bool t = true;
            if ((a + b) < c || (b + c) < a || (c + a) < b)
                    {
                t = false;
            }
            return t;
        }
         public double Perimetr()
        {
            return a + b + c;

        }
        public double Plo()
        {
            double p = Perimetr() / 2;
            double s;
            if (Exists() == false)
            {
                s = 0;
            }
            else
            {
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return s;
        }
    }
}
