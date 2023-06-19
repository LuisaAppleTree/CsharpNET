using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC12
{
    internal class Program
    {
        public delegate int Operacion(int x, int y);

        static void Main(string[] args)
        {
            Operacion suma = (x, y) => x + y;
            Operacion resta = (x, y) => x - y;

            int resultadoSuma = suma(2, 3);
            int resultadoResta = resta(3, 2);

            Console.WriteLine($"Resultado de la suma: {resultadoSuma}");
            Console.WriteLine($"Resultado de la resta: {resultadoResta}");
            Console.ReadLine();
        }
    }
}
