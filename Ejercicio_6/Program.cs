using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Introduce un número entero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine("El número es positivo");
            }
        }
    }
}
