using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC16
{
    public class MiClase<T> where T : ICaminar
    {
        private T miVariable;

        public void AsignarValor(T valor)
        {
            miVariable = valor;
        }

        public T ObtenerValor()
        {
            return miVariable;
        }
    }

    public class Persona:ICaminar
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        //constructores
        //vacío
        public Persona(string id, string nombre, int edad)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
        }

        //con parámetros
        public Persona()
        {

        }

        public override string ToString()
        {
            return $"({Nombre},{Edad})";
        }

        public void Caminar()
        {
            Console.WriteLine($"({Nombre} esta caminando.");
        }
    }

    public interface ICaminar
    {
        void Caminar();
    }

    public class Empleado : Persona
    {
        //constructor
        public Empleado()
        {

        }
    }

    public class Estudiante
    {
        public Estudiante()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MiClase<Empleado> miClase = new MiClase<Empleado>();
        }
    }
}
