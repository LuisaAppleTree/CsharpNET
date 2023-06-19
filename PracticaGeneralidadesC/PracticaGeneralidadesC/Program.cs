using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Int
            int numero1 = 10;
            int numero2 = 20;

            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int division = numero1 / numero2;
            int multiplicacion = numero1 * numero2;
            int residuo = numero1 % numero2;
            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(division);
            Console.WriteLine(multiplicacion);
            Console.WriteLine(residuo);

            Int16 numeroShort = Int16.MaxValue;
            Int32 numeroInt = Int32.MaxValue;
            Int64 numeroLong = Int64.MaxValue;
            Console.WriteLine("valor máximo short: " + numeroShort);
            Console.WriteLine("valor máximo int: " + numeroInt);
            Console.WriteLine("valor máximo long: " + numeroLong);

            string resultado = suma.ToString();
            Console.WriteLine(resultado);

            decimal valorMinimo = Decimal.MinValue;
            decimal valorMaximo = Decimal.MaxValue;
            Console.WriteLine(valorMinimo);
            Console.WriteLine(valorMaximo);

            //Date Time
            DateTime fechaActual = DateTime.Now;
            Console.WriteLine(fechaActual.ToString());
            int dia = fechaActual.Day;
            int mes = fechaActual.Month;
            int año = fechaActual.Year;
            Console.WriteLine("Día " + dia);
            Console.WriteLine("Mes " + mes);
            Console.WriteLine("Año " + año);
            DateTime fechaFutura = fechaActual.AddDays(15);
            DateTime fechaPasada = fechaActual.AddMonths(-1);
            Console.WriteLine("Fecha futura: 15 días más: " + fechaFutura);
            Console.WriteLine("Fecha pasada: 1 mes antes: " + fechaPasada);

            bool esMayor = fechaFutura > fechaPasada;
            bool esIgual = fechaActual == fechaFutura;
            Console.WriteLine(esMayor);
            Console.WriteLine(esIgual);

            string fechaFormateada = fechaActual.ToString("dd/MMMM/yyyy");
            Console.WriteLine("La fecha actual es: " + fechaFormateada);

            //String
            string saludo = "Hola ";
            string nombre = "Luisa";
            string mensaje = saludo + nombre;
            Console.WriteLine(mensaje + "!!");

            int longitud = mensaje.Length;
            Console.WriteLine(longitud);

            string subCadena = mensaje.Substring(0, 5);
            Console.WriteLine(subCadena);

            string mensajeModificado = mensaje.Replace("Hola ", "Adios ");
            Console.WriteLine(mensajeModificado + ":)");

            //Clase Uri
            Uri adress = new Uri("https://okhosting.com/");
            string adress2 = "https://okhosting.com/";
            bool sonIguales = adress2.Equals(adress.OriginalString);
            Console.WriteLine("Las URL son iguales? " + sonIguales);

            Console.WriteLine(adress.Scheme);
            Console.WriteLine(adress.Host);
            Console.WriteLine(adress.Port);
            Console.WriteLine(adress.AbsolutePath);

            bool isWellFormed = Uri.IsWellFormedUriString(adress.OriginalString, UriKind.Absolute);
            if (isWellFormed)
            {
                Console.WriteLine("La URL esta bien formada");
            }
            Console.WriteLine(adress.ToString());

            Uri correo = new Uri("mailto:luisamanzano2@gmail.com");
            bool correoBienFormado = Uri.IsWellFormedUriString(correo.OriginalString, UriKind.Absolute);
            if (correoBienFormado)
            {
                Console.WriteLine("El correo esta bien formado.");
            }

            //Clase ValueType
            int numero01 = 5;
            double numero02 = 5;
            int numero03 = 5;
            bool numIgual = numero01.Equals(numero03);
            Console.WriteLine("Los números son iguales? " + numIgual);

            Console.WriteLine(numero01.GetType().Name);
            Console.WriteLine(numero01.GetHashCode().ToString());
            Console.WriteLine(numero01.ToString() + numero02.ToString());
            Console.WriteLine(numero01 + numero02);
            Console.ReadLine();
        }
    }
}
