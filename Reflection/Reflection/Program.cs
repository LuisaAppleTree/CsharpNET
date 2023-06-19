using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: {Telefono}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Utilizando Reflection para crear una instancia de la clase Persona sin conocer el tipo en tiempo de compilación
            Type personaType = typeof(Persona);
            object personaInstance = Activator.CreateInstance(personaType);

            // Utilizando Reflection para obtener los nombres de las propiedades de la clase Persona
            PropertyInfo[] propiedades = personaType.GetProperties();

            // Solicitando los valores de las propiedades al usuario
            foreach (PropertyInfo propiedad in propiedades)
            {
                Console.Write($"Ingrese el valor para {propiedad.Name}: ");
                string valor = Console.ReadLine();

                // Estableciendo el valor de la propiedad utilizando Reflection
                propiedad.SetValue(personaInstance, Convert.ChangeType(valor, propiedad.PropertyType));
            }

            // Llamando al método MostrarInformacion() de la instancia creada utilizando Reflection
            MethodInfo mostrarInformacionMethod = personaType.GetMethod("MostrarInformacion");
            mostrarInformacionMethod.Invoke(personaInstance, null);

            Console.ReadLine();
        }
    }
}
