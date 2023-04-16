using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    static class Series
    {
        public static void S1(int n)
        {
            Console.Write("\nSerie 1: ");
            for(int i = 1, c = 1; i <= n; i++)
            {
                c *= i;
                Console.Write(" , "+c);
            }
        }

        public static void S2(int n)
        {
            double c = 0;
            Console.Write("\nSerie 2: ");
            for(int i = 1; i <= n; i++)
            {
                c = Math.Pow(2 , i);
                Console.Write(" , "+c);
            }
        }
    }
}
