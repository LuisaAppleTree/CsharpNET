using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadGenerics
{
    //clase tipo Generic
    class ListaGenerica<T>
    {
        //lista tipo generics para almacenar elementos
        private List<T> elementos;

        //constructor sin parámetros para inicializar lista
        public ListaGenerica()
        {
            elementos = new List<T>();
        }

        //Implementa un método público llamado Agregar que reciba un elemento de tipo T y lo agregue a la lista.
        public void Agregar(T elemento)
        {
            elementos.Add(elemento);
        }

        //Implementa un método público llamado Obtener que reciba un índice entero y devuelva el elemento de la lista en esa posición.
        public T Obtener(int indice)
        {
            return elementos[indice];
        }

        //Implementa un método público llamado Contar que devuelva la cantidad de elementos en la lista.
        public int Contar()
        {
            return elementos.Count;
        }

        //Implementa un método público llamado Vaciar que elimine todos los elementos de la lista.
        public void Vaciar()
        {
            elementos.Clear();
        }
    }

    //clase personalizada Persona
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Prueba la clase ListaGenerica<T> creando instancias con diferentes tipos de elementos (enteros, cadenas, objetos personalizados) y realiza operaciones de agregar, obtener, contar y vaciar.
            // Lista de enteros
            ListaGenerica<int> listaEnteros = new ListaGenerica<int>();
            listaEnteros.Agregar(10);
            listaEnteros.Agregar(20);
            listaEnteros.Agregar(30);
            Console.WriteLine("Elementos en la lista de enteros: " + listaEnteros.Contar());
            Console.WriteLine("Primer elemento: " + listaEnteros.Obtener(0));

            // Lista de cadenas
            ListaGenerica<string> listaCadenas = new ListaGenerica<string>();
            listaCadenas.Agregar("Hola");
            listaCadenas.Agregar("Mundo");
            Console.WriteLine("Elementos en la lista de cadenas: " + listaCadenas.Contar());
            Console.WriteLine("Segundo elemento: " + listaCadenas.Obtener(1));

            // Lista de objetos personalizados
            ListaGenerica<Persona> listaPersonas = new ListaGenerica<Persona>();
            listaPersonas.Agregar(new Persona("Juan", 25));
            listaPersonas.Agregar(new Persona("María", 30));
            Console.WriteLine("Elementos en la lista de personas: " + listaPersonas.Contar());
            Console.WriteLine("Edad de la primera persona: " + listaPersonas.Obtener(0).Edad);

            listaEnteros.Vaciar();
            listaCadenas.Vaciar();
            listaPersonas.Vaciar();
            Console.WriteLine("Elementos en la lista de enteros después de vaciar: " + listaEnteros.Contar());
            Console.WriteLine("Elementos en la lista de cadenas después de vaciar: " + listaCadenas.Contar());
            Console.WriteLine("Elementos en la lista de personas después de vaciar: " + listaPersonas.Contar());
            Console.ReadLine();
        }
    }
}
