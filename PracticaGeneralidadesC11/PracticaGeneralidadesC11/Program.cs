using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC11
{
    internal class Program
    {

        static void Main(string[] args)
        {   
            //Where
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = numeros.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Números pares: ");
            foreach(int num in numerosPares)
            {
                Console.WriteLine(num);
            }

            //From
            int[] numeros2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double promedio = (from num2 in numeros2 select num2).Average();
            Console.WriteLine($"El promedio de los números es {promedio}");
            Console.ReadLine();
        }
    }
}
