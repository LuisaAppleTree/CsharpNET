using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGeneralidadesC8
{
    internal class Program
    {
        //clase
        class Rectangulo
        {
            //propiedades
            private int ancho;
            private int alto;

            //constructor
            public Rectangulo(int ancho, int alto)
            {
                this.ancho = ancho;
                this.alto = alto;
            }

            //modificadores de acceso
            public int Ancho
            {
                get { return ancho; }
                set { ancho = value; }
            }

            public int Alto
            {
                get { return alto; }
                set { alto = value; }
            }

            public int CalcularArea()
            {
                return ancho * alto;
            }
        }

        //clase
        class Reloj
        {
            //propiedad
            private DateTime horaActual;

            //constructor
            public Reloj()
            {
                horaActual = DateTime.Now;
            }

            //modificador acceso
            public DateTime HoraActual
            {
                get { return horaActual; }
            }

            //método
            public void ActualizarHora()
            {
                horaActual = DateTime.Now;
            }
        }
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(18, 9);
            int area = rectangulo.CalcularArea();
            Console.WriteLine("El ancho del rectángulo es de: " + rectangulo.Ancho);
            Console.WriteLine("El alto del rectángulo es de: " + rectangulo.Alto);
            Console.WriteLine("El Área del rectángulo es de: " + area);

            Reloj reloj = new Reloj();
            Console.WriteLine("La hora actual es: " + reloj.HoraActual);
            Console.ReadLine();
            reloj.ActualizarHora();
            Console.WriteLine("La hora actual es: " + reloj.HoraActual);
            Console.ReadLine();
        }
    }
}
