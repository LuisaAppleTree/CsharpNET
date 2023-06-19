using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListBox_Practica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Poblaciones> listPob = new List<Poblaciones>();
            listPob.Add(new Poblaciones() { Poblacion1 = "Guamuchil", Temperatura1 = 37, Poblacion2 = "Culiacan", Temperatura2 = 40, DiferenciaTemp=3});
            listPob.Add(new Poblaciones() { Poblacion1 = "Merida", Temperatura1 = 30, Poblacion2 = "Tulum", Temperatura2 = 32, DiferenciaTemp=2});
            listPob.Add(new Poblaciones() { Poblacion1 = "Guadalajara", Temperatura1 = 28, Poblacion2 = "Jocotepec", Temperatura2 = 23, DiferenciaTemp=5 });
            listPob.Add(new Poblaciones() { Poblacion1 = "Ensenada", Temperatura1 = 29, Poblacion2 = "Mazamitla", Temperatura2 = 18, DiferenciaTemp=11});
            listaPoblaciones.ItemsSource = listPob;
            Console.ReadLine();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                 (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " °C " +
                 (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " °C ");
            }
            catch
            {
                if (e != null)
                {
                    MessageBox.Show("Lo sentimos, debes seleccionar algo.");
                }
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                MessageBox.Show("Seleccionaste la ciudad: " + (listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + 
                    " y la ciudad de: " + (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2
                    + " ambas ciudades de México.");
            }
            catch
            {
                if(e != null)
                {
                    MessageBox.Show("Selecciona una ciudad.");
                }
            }
        }
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int DiferenciaTemp { get; set; }
    }
}
