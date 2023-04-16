using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Ingrese un numero: ");
            n= Convert.ToInt32(Console.ReadLine());
            Series.S1(n);
            Series.S2(n);

            Console.ReadKey();
        }
    }
}
