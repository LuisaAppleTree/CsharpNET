using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC6
{
    internal class Program
    {
        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

        }

        static void Main(string[] args)
        {
            List<Persona> person = new List<Persona>()
            {
                new Persona() {Nombre = "Roberto",Edad = 31},
                new Persona() {Nombre = "Jacobo",Edad = 50},
                new Persona() {Nombre = "Palazuelos",Edad = 78}
            };
            Console.WriteLine("Lista de personas sin ordenar: ");
            foreach(Persona persona in person)
            {
                Console.WriteLine("Nombre: " + persona.Nombre + " Edad: " + persona.Edad);
            }
            //ordenar por nombre
            person.Sort((p1, p2) => p1.Nombre.CompareTo(p2.Nombre));
            Console.WriteLine("Lista de personas ordenadas por nombre: ");
            foreach (Persona persona in person){
                Console.WriteLine($"{persona.Nombre}, Edad: + {persona.Edad}");
            }
            Console.ReadLine();
        }
    }
}
