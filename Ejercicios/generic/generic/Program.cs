using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class Program
    {
        class Pila<T>
        {
            private List<T> elementos;

            public Pila()
            {
                elementos = new List<T>();
            }

            public void Apilar(T elemento)
            {
                elementos.Add(elemento);
            }

            public T Desapilar()
            {
                if (elementos.Count == 0)
                {
                    throw new InvalidOperationException("La pila está vacía");
                }

                T elemento = elementos[elementos.Count - 1];
                elementos.RemoveAt(elementos.Count - 1);
                return elemento;
            }

            public bool EstaVacia()
            {
                return elementos.Count == 0;
            }
        }

       static void Main(string[] args)
       {

            // Uso de la clase genérica
            Pila<int> pilaEnteros = new Pila<int>();
            pilaEnteros.Apilar(1);
            pilaEnteros.Apilar(2);
            pilaEnteros.Apilar(3);

            while (!pilaEnteros.EstaVacia())
            {
                int elemento = pilaEnteros.Desapilar();
                Console.WriteLine(elemento); // Imprime los elementos 3, 2, 1 en ese orden
            }

            Pila<string> pilaCadenas = new Pila<string>();
            pilaCadenas.Apilar("Hola");
            pilaCadenas.Apilar("Mundo");

            while (!pilaCadenas.EstaVacia())
            {
                string elemento = pilaCadenas.Desapilar();
                Console.WriteLine(elemento); // Imprime los elementos "Mundo", "Hola" en ese orden
            }
            Console.ReadLine();
       }
    }
}
