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
            //declaramos variables
            int n1;
            //pedimos el numero en pantalla
            Console.WriteLine("Introduce un número entero: ");
            //ingresar el número con el teclado
            n1 = Convert.ToInt32(Console.ReadLine());
            //esta es la variante si que se ejecuta si se cumple una condición
            if (n1 > 0)
            {
                Console.WriteLine("El número es positivo");
            }
        }
    }
}
