using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> miQueue = new Queue<string>();
            miQueue.Enqueue("Piña");
            miQueue.Enqueue("Fresa");
            miQueue.Enqueue("Mora");
            miQueue.Enqueue("Pitaya");
            Console.WriteLine("Total de frutas en cola: " + miQueue.Count());
            Console.WriteLine("Primer fruta en cola original: " + miQueue.Peek());
            miQueue.Dequeue();
            Console.WriteLine("Nueva primera fruta en la cola: " + miQueue.Peek());

            foreach(var fruta in miQueue)
            {
                Console.WriteLine(fruta);
            }

            bool contieneFruta = miQueue.Contains("Pitaya");
            if (contieneFruta)
            {
                Console.WriteLine("La fruta está en la lista.");
            }
            else
            {
                Console.WriteLine("No esta la fruta.");
            }

            //SortedSet
            SortedSet<string> colores = new SortedSet<string>();
            colores.Add("Azul");
            colores.Add("Rosa");
            colores.Add("Verde");
            colores.Add("Azul");
            colores.Add("Lila");
            foreach(var color in colores)
            {
                Console.WriteLine(color);
            }

            var primerColor = colores.Min();
            Console.WriteLine("Primer color: " + primerColor);

            var ultimoColor = colores.Max();
            Console.WriteLine("Primer color: " + ultimoColor);

            colores.Remove("Verde");
            Console.WriteLine("Ahora hay " + colores.Count + " colores.");
            Console.ReadLine();
        }
    }
}
