using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC13
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>()
            {
                 new Persona {Nombre = "Roberto", Edad = 30 },
                 new Persona {Nombre = "Jacobo", Edad = 78 },
                 new Persona {Nombre = "Luisa", Edad = 25 },
                 new Persona {Nombre = "Brad", Edad = 45 }
            };

            var personasMayores40 = personas.Where(p => p.Edad > 40);
            foreach (var persona in personasMayores40)
            {
                Console.WriteLine(persona.Nombre + " tiene: " + persona.Edad + " años");
            }

            var nombresPersonas = personas.Select(p => p.Nombre).ToList();
            foreach(string nombre in nombresPersonas)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadLine();
        }
    }
}
