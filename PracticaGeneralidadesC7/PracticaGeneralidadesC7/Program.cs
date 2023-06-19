using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticaGeneralidadesC7.Inventario;

namespace PracticaGeneralidadesC7
{
    public class Inventario
    {
        public int[] productos = new int[10];
        public int this[int index]
        {
            get { return productos[index]; } 
            set { productos[index] = value;}
        }

        public class Matriz
        {
            private int[,] valores = new int[10, 10];
            public int this[int fila, int columna]
            {
                get { return valores[fila, columna]; }
                set { valores[fila, columna] = value; }
            }
        }

        public class ColorAnimal
        {
            public string[] gatos = new string[5];

            public string this[int color]
            {
                get { return gatos[color]; }
                set { gatos[color] = value; }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            inventario[0] = 5;
            inventario[1] = 15;

            int cantidadProducto = inventario[0];
            Console.WriteLine("La cantidad de producto es de: " + cantidadProducto);

            Matriz matriz = new Matriz();
            matriz[0, 0] = 1;
            matriz[1,0] = 7;
            var celda1 = matriz[0, 0];
            var celda2 = matriz[1, 0];
            Console.WriteLine("La cantidad en celda 1: " + celda1);
            Console.WriteLine("La cantidad en celda 2: " + celda2);

            ColorAnimal colorPelaje = new ColorAnimal();
            colorPelaje[0] = "café";
            colorPelaje[4] = "blanco";
            var gato1 = colorPelaje[0];
            var gato2 = colorPelaje[4];
            Console.WriteLine("El gato 1 es de color: " + gato1);
            Console.WriteLine("El gato 2 es de color: " + gato2);
            Console.ReadLine();
        }
    }
}
