using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if else
            Random random = new Random();   
            int edad = random.Next(1,101);
            Console.WriteLine("La edad es de: " + edad);
            if (edad < 15)
            {
                Console.WriteLine("Eres un niño");
            }
            else if (edad > 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else if (edad > 70)
            {
                Console.WriteLine("Ya estas ruco.");
            }

            //switch
            string diaSemana;
            int dia = 4;
            switch(dia)
            {
                case 1:
                    diaSemana = "Lunes";
                    break;
                case 2:
                    diaSemana = "Martes";
                    break;
                case 3:
                    diaSemana = "Miercoles";
                    break;
                case 4:
                    diaSemana = "Jueves";
                    break;
                case 5:
                    diaSemana = "Viernes";
                    break;
                default:
                    diaSemana = "Día no valido";
                    break;
            }
            Console.WriteLine("El día de la semana es: " + diaSemana);

            //while
            string entrada;
            bool esValido = true;

            while (!esValido)
            {
                Console.WriteLine("Ingresa un número entero");
                entrada = Console.ReadLine();
                esValido = int.TryParse(entrada, out int resultado);
                if (esValido)
                {
                    Console.WriteLine("El número ingresado es:" + resultado);
                }
                else
                {
                    Console.WriteLine("La entrada no es válida, intente de nuevo.");
                }
            }
            Console.WriteLine("Fin del ciclo.");

            int[] numeros = { 1, 2, 3, 4, 5, 6 };
            int i = 0;
            while (i < numeros.Length)
            {
                Console.WriteLine(numeros[i]);
                i++;
            }

            //for
            for(int j=1; j <= 100; j++)
            {
                if((j % 5) == 0)
                {
                    Console.WriteLine(j);
                }
            }

            //Do while
            string contraseña = "";
            do
            {
                Console.WriteLine("Escribe la contraseña");
                contraseña = Console.ReadLine();
                if (contraseña != "12345")
                {
                    Console.WriteLine("Contraseña incorrecta.");
                }
                else
                {
                    Console.WriteLine("Bienvenido");
                }

            } while (contraseña != "12345");

            int num;
            do
            {
                Console.WriteLine("Escribe un número del 1 al 10");
                num = int.Parse(Console.ReadLine());
                if(num < 1 || num > 10)
                {
                    Console.WriteLine("Número debe ser entre 1 y 10.");
                }
            }
            while (num < 1 || num > 10);
            Console.WriteLine("El número escrito fue: " + num);

            //forEach
            int[] numeros2 = { 1, 2, 3, 4, 5 };
            int suma = 0;

            foreach (int numero in numeros2)
            {
                var resultado = suma += numero;
                Console.WriteLine("suma: " + resultado);
            }

            List<string> colores = new List<string>() { "rosa", "amarillo", "lila" };
            foreach(string color in colores)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();
        }
    }
}
