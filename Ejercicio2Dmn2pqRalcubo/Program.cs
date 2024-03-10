using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Dmn2pqRalcubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0,
                m = 5,
                n = 5,
                p = 5,
                q = 5,
                r = 5,
                D = 0;

            while (i < 6)

            {
                D = (m * n / (2 * p * q) * r ^ 3);

                Console.WriteLine($" el 40% de la ecuacion es: + { D * 0.4}");

                i++;
            }
                Console.ReadKey();
                   

        }
    }
}
