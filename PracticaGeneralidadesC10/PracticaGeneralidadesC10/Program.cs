using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticaGeneralidadesC10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Manzana");
            stack.Push("Naranja");
            stack.Push("Plátano");
            Console.WriteLine("El último elemento del stack es: " + stack.Pop());
            Console.WriteLine("El nuevo último elemento del stack es: " + stack.Peek());
            Console.WriteLine("El número de elementos en el stack: " + stack.Count);
            Console.ReadLine();
        }
    }
}
