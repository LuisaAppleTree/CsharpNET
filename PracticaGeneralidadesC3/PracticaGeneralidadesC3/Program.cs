using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC3
{
    internal class Program
    {
        struct Punto
        {
            public int x; 
            public int y;
        }

        enum DiaSemana
        {
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado,
            Domingo
        }

        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        interface IAnimal
        {
            void Hablar();
        }

        class Perro : IAnimal
        {
            public void Hablar()
            {
                Console.WriteLine("Implementando método de interfaz, guau");
            }
        }

        public delegate int Operacion(int x, int y);

        static void Main(string[] args)
        {   
            //struct
            Punto punto1 = new Punto(){x = 10, y = 20};
            Punto punto2 = punto1;
            punto2.y = 30;

            Console.WriteLine("Punto1 x: " + punto1.x + " y: " + punto1.y);
            Console.WriteLine("Punto2 x: " + punto2.x + " y: " + punto2.y);

            //enum
            DiaSemana diaSemana = DiaSemana.Lunes;
            Console.WriteLine("Día de la semana: " + diaSemana);

            //valores nullables
            int? numero = null;
            if (numero.HasValue)
            {
                Console.WriteLine("El número tiene un valor: " + numero.Value);
            }
            else
            {
                Console.WriteLine("El número es Null");
            }

            //Clase
            Persona persona1 = new Persona() { Nombre = "Luisa", Edad = 25 };
            Persona persona2 = persona1;
            persona2.Edad = 28;
            Console.WriteLine("Persona1 nombre: " + persona1.Nombre + " edad: " + persona1.Edad);
            Console.WriteLine("Persona2 nombre: " + persona2.Nombre + " edad: " + persona2.Edad);

            //Interfaz
            IAnimal animal = new Perro();
            animal.Hablar();

            //Arreglos
            string[] nombres = { "Claudia", "Marlla", "Monica", "Jessica", "Paloma" };
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            //Delegates
            int Suma(int x, int y)
            {
                return x + y;
            }

            int Resta(int x, int y)
            {
                return x - y;
            }
            Operacion operacion1 = Suma;
            Operacion operacion2 = Resta;
            Console.WriteLine("Suma: " + operacion1(5, 2));
            Console.WriteLine("Resta: " + operacion2(10, 5));
            Console.ReadLine();
        }
    }
}
