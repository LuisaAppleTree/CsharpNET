using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int dividendo = 10;
                int divisor = 0;
                int resultado = dividendo / divisor;
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Se ha producido una escepción: " + ex.Message);
            }
            finally 
            {
                Console.WriteLine("Bloque finally siempre se ejecuta.");
            }

            int num = 1;
            try
            {
                if(num == 0)
                {
                    throw new Exception("El número no puede ser 0");
                }
                else
                {
                    Console.WriteLine("Número correcto");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Se ha producido una escepción: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
