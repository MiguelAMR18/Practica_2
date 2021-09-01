using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int perimetro_a = 10;
            int perimetro_b = 10;
            int perimetro_c = 7;
            int peri = perimetro_a + perimetro_b + perimetro_c;

            Console.WriteLine("El perimetro del triangulo es: " + peri);
            Console.WriteLine("preciona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
