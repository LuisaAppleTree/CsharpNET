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

namespace ComboBox_CheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Capitales> listaCapitales = new List<Capitales>();
            listaCapitales.Add(new Capitales { NombreCapital = "Washington" });
            listaCapitales.Add(new Capitales { NombreCapital = "CDMX" });
            listaCapitales.Add(new Capitales { NombreCapital = "Tokyo" });
            listaCapitales.Add(new Capitales { NombreCapital = "Beijin" });
            listaCapitales.Add(new Capitales { NombreCapital = "Caracas" });
            CapitalesMundo.ItemsSource = listaCapitales;
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            Washington.IsChecked = true;
            CDMX.IsChecked = true;
            Tokyo.IsChecked = true;
            Beijin.IsChecked = true;
            Caracas.IsChecked = true;
        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            Washington.IsChecked = false;
            CDMX.IsChecked = false;
            Tokyo.IsChecked = false;
            Beijin.IsChecked = false;
            Caracas.IsChecked = false;
        }

        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if(Washington.IsChecked == true && CDMX.IsChecked == true && Tokyo.IsChecked == true && Beijin.IsChecked == true && Caracas.IsChecked == true)
            {
                TodasC.IsChecked = true;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }

        private void Individual_NoChecked(object sender, RoutedEventArgs e)
        {
            if (Washington.IsChecked == false && CDMX.IsChecked == false && Tokyo.IsChecked == false && Beijin.IsChecked == false && Caracas.IsChecked == false)
            {
                TodasC.IsChecked = false;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }

}
