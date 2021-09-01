using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int Edad; 
            string Nombre;
            string Edada;

            Console.WriteLine("Escribe tu Nombre:  ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Que edad tienes: ");
            Edada = Console.ReadLine();
            Edad = Convert.ToInt32(Edada); 
            Console.WriteLine("Te llamas " + Nombre + " y tienes: " + Edad + " años");
            Console.WriteLine("preciona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
