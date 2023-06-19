using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC9
{
    public static class Extensiones
    {
        public static bool EsPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }

    public static class Utilidades
    {
        public static int Suma(int a, int b)
        {
            return a + b;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            var num = Extensiones.EsPar(5);
            Console.WriteLine("El número es par?: " + num);

            int sumar = Utilidades.Suma(3, 5);
            Console.WriteLine("La suma de a y b: " + sumar);
            Console.ReadLine();
        }
    }
}
