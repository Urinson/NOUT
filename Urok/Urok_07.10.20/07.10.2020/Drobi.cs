using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _07._10._2020
{
    class Drobi
    {
        public int a;
        public int b;

        public Drobi(int n_a, int n_b)
        {
            a = n_a;
                b = n_b;

        }
        //noviy metod
        /*public string ToStr()
        {
            return base.ToString();
            {
                return "`" + a.ToString() + "/" + b.ToString() + "`";
            }
        }*/
        public override string ToString()
        {
            //return base.ToString();
            {
                return " " + a.ToString() + "/" + b.ToString() + " )";

            }
        }
        public double Rezult ()
            {
                return a * 1.0 / b;
            }
        }

    }
//TUSTUGASHEV Y.V.