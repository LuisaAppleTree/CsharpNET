using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC15
{
    public class MiClase<T> where T : new()
    {
        private T miVariable;

        public void asignarValor(T valor)
        {
            miVariable = valor;
        }

        public T obtenerValor()
        {
            return miVariable;
        }
    }

    public class Persona
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Edad { get; set; }

        public Persona()
        {

        }

        public override string ToString()
        {
            return $"({Name},{Edad})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MiClase <Persona> instanciaPersona = new MiClase<Persona> ();
            Persona person = new Persona();
            person.Id = "09-C90";
            person.Name = "Tom Cruise";
            person.Edad = 54;
            instanciaPersona.asignarValor(person);
            Persona valorPersona = instanciaPersona.obtenerValor();
            Console.WriteLine("Valor: " + valorPersona.ToString());
            Console.ReadLine();
        }
    }
}
