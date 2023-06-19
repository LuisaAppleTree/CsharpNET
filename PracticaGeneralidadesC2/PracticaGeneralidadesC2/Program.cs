using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Reflection;

namespace PracticaGeneralidadesC2
{
    internal class Program
    {
        public class Persona
        {
            public string Name { get; set; }
            public string ApellidoMat { get; set; }
            public string ApellidoPat { get; set; }
            public int Edad { get; set; }
            public string Profesion { get; set; }
        }
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Name = "Luisa";
            persona.ApellidoPat = "Manzano";
            persona.ApellidoMat = "Mendez";
            persona.Edad = 25;
            persona.Profesion = "Programadora";

            Persona persona2 = persona;
            persona2.Name = "Maria";

            Console.WriteLine("Persona 1: " + persona.Name + persona.ApellidoPat + persona.ApellidoMat + persona.Edad + persona.Profesion);
            Console.WriteLine("Persona 2: " + persona2.Name + persona2.ApellidoPat + persona2.ApellidoMat + persona2.Edad + persona2.Profesion);

            int numero1 = 10;
            int numero2 = numero1;
            numero2 = 20;
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);

            //TimeSpan
            TimeSpan t1 = new TimeSpan(2, 0, 0);
            TimeSpan t2 = new TimeSpan(3, 0, 0);

            TimeSpan t3 = t1.Add(t2);
            Console.WriteLine(t3);

            TimeSpan t4 = t2.Subtract(t1);
            Console.WriteLine(t4);

            TimeSpan t5 = new TimeSpan(-3, 0, 0);
            TimeSpan t6 = t5.Duration();
            Console.WriteLine(t6);

            TimeSpan t7 = t1.Negate();
            Console.WriteLine(t7);

            int valor = t5.CompareTo(t2);
            Console.WriteLine(valor);

            double duracion = t1.TotalMilliseconds;
            Console.WriteLine(duracion);

            DateTime fechaInicio = new DateTime(2023, 05, 22, 14, 30, 00);
            DateTime fechaFin = new DateTime(2025, 07, 30, 04, 33, 00);
            TimeSpan diferencia = fechaFin - fechaInicio;
            Console.WriteLine(diferencia);

            //DataTable
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Edad", typeof(int));
            tabla.Columns.Add("Fecha de Nacimiento", typeof(DateTime));

            tabla.Rows.Add("Luisa", 25, new DateTime(1997, 07, 02));
            tabla.Rows.Add("Migue", 21, new DateTime(2002, 02, 09));
            tabla.Rows.Add("Artu", 28, new DateTime(1994, 07, 09));

            DataRow[] resultados = tabla.Select("Edad <> 25");

            foreach (DataRow fila in resultados)
            {
                string nombre = fila["Nombre"].ToString();
                int edad = (int)fila["Edad"];
                DateTime fechaNacimiento = (DateTime)fila["Fecha de Nacimiento"];
                Console.WriteLine(nombre + " " + edad + " " + fechaNacimiento);
            }
            DataTable dt = new DataTable("Clientes");
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Ciudad", typeof(string));
            dt.Columns.Add("Pais", typeof(string));

            dt.Rows.Add(1, "Roberto Martinez", "Monterrey", "Mexico");
            dt.Rows.Add(2, "Jacobo Wong", "Tepito", "Mexico");
            dt.Rows.Add(3, "Robert Pattison", "Guamuchil", "Mexico");
            dt.Rows.Add(4, "Ryan Gosling", "Zapopan", "Mexico");
            dt.Rows.Add(5, "Lee Pace", "Monterrey", "Mexico");

            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };
            DataRow[] rows = dt.Select("Ciudad = 'Monterrey'");
            foreach (DataRow row in rows)
            {
                Console.WriteLine(" ID: " + row["ID"] + " Nombre: " + row["Nombre"] + " Ciudad: " + row["Ciudad"] + " Pais: " + row["Pais"]);
            }

            DataTable dtClone = dt.Copy();
            dtClone.Rows.Add(6, "Carlo Magno", "Sicilia", "Italia");
            foreach (DataRow row in dtClone.Rows)
            {
                Console.WriteLine(" ID: " + row["ID"] + " Nombre: " + row["Nombre"] + " Ciudad: " + row["Ciudad"] + " Pais: " + row["Pais"]);
            }

            //NameSpace
            string fileName = "ejemplo.txt";
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("Esta es una línea de ejemplo.");
                sw.WriteLine("Esta es otra línea de ejemplo.");
            }

            using (StreamReader sr = File.OpenText(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            string newFile = "ejemplo_copia.txt";
            File.Copy("ejemplo.txt", "ejemplo_copia.txt", true);
            if (File.Exists(newFile))
            {
                Console.WriteLine("Archivo copiado con éxito.");
            }

            File.Delete(newFile);
            Console.WriteLine("El archivo fue eliminado.");

            //Math
            double numero01 = 825.47;
            double numero02 = 1027.33;
            Console.WriteLine(Math.Abs(numero01));
            Console.WriteLine(Math.Ceiling(numero01));
            Console.WriteLine(Math.Floor(numero01));
            Console.WriteLine(Math.Max(numero01, numero02));
            Console.WriteLine(Math.Min(numero01, numero02));

            int numero03 = 4;
            int numero04 = 5;
            Console.WriteLine(Math.Pow(numero04, numero03));
            Console.WriteLine(Math.Sqrt(numero03));

            double numero05 = -5893.0234585;
            Console.WriteLine(Math.Round(numero05, 3));

            //Convert
            int num = 1245;
            string convertToString = Convert.ToString(num);
            int num2 = 232;
            Console.WriteLine(convertToString + num2);

            DateTime fechaHoy = DateTime.Now;
            Console.WriteLine(Convert.ToString(fechaHoy) + " así es.");

            //Random
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 11);
            int numeroUsuario;

            do
            {
                Console.WriteLine("Adivina el número entre 1 y 10");
                numeroUsuario = int.Parse(Console.ReadLine());

                if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El número aleatorio es mayor");
                }
                else if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El número aleatorio es menor");
                }
            } while (numeroAleatorio != numeroUsuario);
            Console.WriteLine("El número era: " + numeroAleatorio);

            Random random2 = new Random();
            const string caracteres = "ABCDEFGHIJKLMNÑOPRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890";
            string password = "";
            for (int i = 0; i <= 8; i++)
            {
                password += caracteres[random.Next(caracteres.Length)];
            }
            Console.WriteLine("El password es: " + password);

            //Tuplas
            Tuple<string, int, double, string> people = new Tuple<string, int, double, string>("Luisa", 25, 1.65, "Manzano Mendez");
            Console.WriteLine("Nombre completo: " + people.Item1 + people.Item4);

            (string name, int age) people2 = ("Maria ", 25);
            Console.WriteLine("Tu nombre y edad: " + people2.name + people2.age + "años");

            (int, int, int, float) resultadosOperacion = operacionesBasicas(12, 5);
            Console.WriteLine("El resultado de la suma: " + resultadosOperacion.Item1);
            Console.WriteLine("El resultado de la resta: " + resultadosOperacion.Item2);
            Console.WriteLine("El resultado de la multiplicación: " + resultadosOperacion.Item3);
            Console.WriteLine("El resultado de la división: " + resultadosOperacion.Item4);

            List<int> listaNumeros = new List<int> { 45, 25, 32, 60, 80, 90, 54, 103 };
            (int, int, int) resultadosEstadistica = estadisticas(listaNumeros);
            Console.WriteLine("Número máximo en lista: " + resultadosEstadistica.Item1);
            Console.WriteLine("Número máximo en lista: " + resultadosEstadistica.Item2);
            Console.WriteLine("Número máximo en lista: " + resultadosEstadistica.Item3);

            string cadenaTexto = "Texto de ejemplo, generalidades lenguaje C#";
            (int, int, int) contarCaracteresZ = contarCaracteres(cadenaTexto);
            Console.WriteLine("Número de caracteres: " + contarCaracteresZ.Item1);
            Console.WriteLine("Número de digitos: " + contarCaracteresZ.Item2);
            Console.WriteLine("Número de espacios: " + contarCaracteresZ.Item3);
            Console.ReadLine();
        }

        public static (int, int, int, float) operacionesBasicas(int a, int b)
        {
            int suma = a + b;
            int resta = a - b;
            int mult = a * b;
            float division = (float)a / b;

            return (suma, resta, mult, division);
        }

        public static (int, int, int) estadisticas(List<int> numeros)
        {
            int maximo = numeros.Max();
            int minimo = numeros.Min();
            int sumaA = numeros.Sum();

            return (maximo, minimo, sumaA);
        }

        public static (int, int, int) contarCaracteres(string texto0)
        {
            int letras = 0;
            int digitos = 0;
            int espacios = 0;

            foreach (char c in texto0)
            {
                if (char.IsLetter(c))
                {
                    letras++;
                }
                else if (char.IsDigit(c))
                {
                    digitos++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    espacios++;
                }
            }
            return (letras, digitos, espacios);
        }

    }
}
