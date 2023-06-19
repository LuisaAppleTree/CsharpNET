using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gestionContactos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa en C# que permita gestionar una lista de contactos utilizando un Dictionary. El programa debe tener las siguientes funcionalidades:
            //Permitir al usuario agregar un nuevo contacto. El usuario debe ingresar un nombre y un número de teléfono para el contacto.
            //Permitir al usuario buscar un contacto por nombre. El programa debe mostrar el número de teléfono del contacto encontrado.
            //Mostrar todos los contactos existentes en el Dictionary. El programa debe mostrar el nombre y el número de teléfono de cada contacto.
            //Permitir al usuario eliminar un contacto. El usuario debe ingresar el nombre del contacto a eliminar.
            //Salir del programa.
            //Puedes utilizar un menú con opciones numéricas para que el usuario seleccione la acción deseada.Utiliza un Dictionary para almacenar los contactos, donde la clave será el nombre del contacto(string) y el valor será el número de teléfono(string).

            Dictionary<string, string> AgendaContactos = new Dictionary<string, string>();
            Console.WriteLine("Escribe el número de opción de tú interes para ingresar a la Gestión de Contactos:");
            Console.WriteLine("1. Agregar contacto\r\n2. Buscar contacto\r\n3. Mostrar contactos\r\n4. Eliminar contacto\r\n5. Salir ");
            int menuOpcion = int.Parse(Console.ReadLine());

                while (menuOpcion != 5)
                {
                    Console.WriteLine("Escribe el número de opción de tú interes para ingresar a la Gestión de Contactos:");
                    Console.WriteLine("1. Agregar contacto\r\n2. Buscar contacto\r\n3. Mostrar contactos\r\n4. Eliminar contacto\r\n5. Salir ");
                    menuOpcion = int.Parse(Console.ReadLine());

                    switch (menuOpcion)
                    {
                        case 1:
                            AgregarContacto();
                            break;

                        case 2:
                            BuscarContacto();
                            break;

                        case 3:
                            MostrarContactos();
                            break;

                        case 4:
                            EliminarContacto();
                            break;

                        case 5:
                            Salir();
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            Console.ReadLine();
                            break;
                    }
                }


             void AgregarContacto()
            {
                Console.WriteLine("Por favor ingresa el nombre del contacto a agregar.");
                string llave = Console.ReadLine();
                Console.WriteLine("Añade el número telefónico de tu contacto: ");
                string valor = Console.ReadLine();
                AgendaContactos.Add(llave, valor);
                Console.WriteLine("Contacto agregado correctamente.");
                Console.ReadLine();
            }

             void BuscarContacto()
            {
                Console.WriteLine("Porfavor ingresa el nombre del contacto a buscar: ");
                string llave = Console.ReadLine();
                if (AgendaContactos.ContainsKey(llave))
                {
                    foreach (var item in AgendaContactos)
                    {
                        if (item.Key == llave)
                        {
                            Console.WriteLine("El nombre: " + item.Key + " el número de teléfono: " + item.Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El contacto no fue encontrado.");
                }
                Console.ReadLine();
            }

             void MostrarContactos()
            {
                Console.WriteLine("Contactos existentes: ");
                foreach (KeyValuePair<string, string> contacto in AgendaContactos)
                {
                    Console.WriteLine(contacto);
                }
                Console.ReadLine();
            }

             void EliminarContacto()
            {
                Console.WriteLine("Por favor ingresa el nombre del contacto a eliminar.");
                string llave = Console.ReadLine();
                if (AgendaContactos.ContainsKey(llave))
                {
                    AgendaContactos.Remove(llave);
                    Console.WriteLine("Contacto eliminado correctamente.");
                } else
                {
                    Console.WriteLine("El contacto no existe.");
                }
                Console.ReadLine();
            }

             void Salir()
            {
                Console.WriteLine("Saliendo de Gestión de Contactos.");
                Console.ReadLine();
            }

        }

    }
}
