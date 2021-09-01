using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string Nombre, Ciudad;
            Console.WriteLine("Escribe tu Nombre:  ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe una Ciudad: ");
            Ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + Nombre + " Bienbenido a " + Ciudad);
            Console.WriteLine("preciona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
